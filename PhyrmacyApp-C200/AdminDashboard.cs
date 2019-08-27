using PhyrmacyApp_C200.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhyrmacyApp_C200
{
    public partial class AdminDashboard : Form
    {
        PharmcyDB db = new PharmcyDB();
        int marginX = 10;
        int marginY = 20;
        int LocX = 10;
        int LocY = 20;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        #region Firm Combobox Fill
        private void FillComboFirms()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(fr => fr.Name).ToArray());
        }
        private void FillComboTags() {
            cmbTags.Items.AddRange(db.Tags.Select(tg => tg.Name).ToArray());
        }
        #endregion

        #region Admin Load Event
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FillComboFirms();
            FillComboTags();
            FillMedicineList();
        }
        public void FillMedicineList()
        {
            dtgView.DataSource = db.Medicines.Select(md => new
            {
                md.Name,
                md.Price,
                md.ProductionDate,
                md.ExperienceDate,
                md.Count,
                md.Barcode,
                WithReceipt=md.WithResiept==false ? "Resptsiz":"Reseptli",
            }).ToList();
            for (var i = 0; i < dtgView.RowCount; i++)
            {
                DateTime valDate = (DateTime)dtgView.Rows[i].Cells[3].Value;
                if (valDate<= DateTime.Now)
                {
                    dtgView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgView.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }
        #endregion
        private int addFirms(string firmname)
        {
            Firm selectedFirm = db.Firms.FirstOrDefault(fr => fr.Name == firmname);

            if (selectedFirm != null)
            {
                return selectedFirm.Id;
            }
           
               Firm newFirm= db.Firms.Add(new Firm
                {
                    Name = firmname
                });
                db.SaveChanges();
            
                return newFirm.Id;
        }
            
           
        private void Button1_Click(object sender, EventArgs e)
        {
            string medicinename = txtmedicinename.Text;
            string firmName = cmbFirms.Text;
            string tagname = cmbTags.Text;
            float? price = (float)nmPrice.Value;
            int? count = (int)nmCount.Value;
            string barcode = txtBarcode.Text;
            bool withReceipt = chkWithReceipt.Checked;
            DateTime productionDate = dtProductionDate.Value;
            DateTime endlineDate = dtEndlineDate.Value;
            string description = rcDescription.Text;
            bool allEmpty = Extensions.IsEmpty(new string[]
            {
                medicinename,firmName,tagname,barcode,description
            }, string.Empty);
            if (allEmpty)
            {
                if (count!=null && price!=null)
                {

                int firmId = addFirms(firmName);
                      Medicine addMedicine = null;
              
                     addMedicine = db.Medicines.Add(new Medicine
                    {
                        Name = medicinename,
                        Price = price,
                        Count = count,
                        ProductionDate = productionDate,
                        ExperienceDate = endlineDate,
                        Barcode = barcode,
                        Description = description,
                        WithResiept = withReceipt,

                    });
                    db.SaveChanges();

                    AddAllTag(addMedicine.Id);
                    FillMedicineList();
                    MessageBox.Show("Medicine Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    lblError.Text = "Price and Count not null";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Text = "Please all the Fill";
                lblError.Visible = true;
            }
        }

        private void CmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tagName = cmbTags.Text;
            AddTag(tagName);
        }
        public bool AddTag(string tg)
        {
            if (tg != "")
            {
                foreach (Button item in tagGroups.Controls)
                    {
                        if (item.Text == tg)
                        {
                        return false;

                    }
                }
                Button btn = new Button();
                btn.Text = tg;
                
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.Location = new Point(25, 45);


                btn.Width = 100;
                if (LocX + btn.Width > tagGroups.Width)
                {
                    LocX = marginX;
                    LocY += btn.Height + marginY;
                }

                btn.Location = new Point(LocX, LocY);
                btn.Click += new System.EventHandler(this.btnTagDelete);
                LocX += btn.Width;
                tagGroups.Controls.Add(btn);

            }
          
            return true;


        }
        private void btnTagDelete(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            tagGroups.Controls.Remove(btn);
            if (tagGroups.Controls.Count == 0)
            {
                LocX = 0;
            }
            int internalLocX = 10;
            int internalLocY = 20;
            int internalMarginX = 10;
            int internalMarginY = 20;
            int length = tagGroups.Controls.Count;
            foreach (Button button in tagGroups.Controls)
            {
                if (internalLocX + btn.Width >= tagGroups.Width)
                {
                    internalLocX = internalMarginX;
                    internalLocY += internalMarginY+btn.Height;

                }
                button.Location = new Point(internalLocX, internalLocY);
                internalLocX += btn.Width + internalMarginX;
            }
            foreach (Button button in tagGroups.Controls)
            {
                if (tagGroups.Controls.GetChildIndex(button) == (length - 1))
                {
                    LocX = button.Location.X + btn.Width + marginX;
                    LocY = button.Location.Y ;
                }
            }
        }
        public void AddAllTag(int medicineId)
        {

            foreach (Button tagItem in tagGroups.Controls)
            {
                Tag selectedTag = db.Tags.FirstOrDefault(tg => tg.Name == tagItem.Text);
                int TagId = 0;
                Tag addTag = null;
                if (selectedTag == null)
                {
                    Task tagTask = Task.Factory.StartNew(() =>
                    {
                        addTag = db.Tags.Add(new Tag
                        {
                            Name = tagItem.Text
                        });
                        db.SaveChanges();
                    });
                    tagTask.Wait();
                    if (tagTask.IsCompleted)
                    {
                        TagId = addTag.Id;
                    }

                }
                else {
                    TagId = selectedTag.Id; 
                }
                db.Medicine_to_Tag.Add(new Medicine_to_Tag
                {
                    Medicine_id = medicineId,
                    Tag_id = TagId
                });
                db.SaveChanges();


            }
        }
        private void CmbTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tagName = cmbTags.Text;
            if (e.KeyChar == 13)
            {
                AddTag(tagName);
            }
        }

        private void DtgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TagGroups_Enter(object sender, EventArgs e)
        {

        }


        //public bool CheckTags(string tag)
        //{
        //    foreach (Button btnTag in tagGroups.Controls)
        //    {
        //        if (btnTag.Text == tag)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
