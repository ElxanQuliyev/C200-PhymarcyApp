using PhyrmacyApp_C200.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
namespace PhyrmacyApp_C200
{
    public partial class WorkerDashboard : Form
    {
        PharmcyDB db = new PharmcyDB();
        Worker activeWorker;
        int marginX = 10;
        int marginY = 20;
        int LocX = 10;
        int LocY = 20;
        public WorkerDashboard(Worker wr)
        {
            activeWorker = wr;

            InitializeComponent();
        }

        private void CmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMedicine();
            dtgMenu();
        }
        private void FillMedicine()
        {
            cmbMedicine.Items.AddRange(db.Medicines.Select(md=>md.Name).ToArray());
        }

        private void WorkerDashboard_Load(object sender, EventArgs e)
        {
            FillMedicine();
            FillTag();
            dtgMenu();
        }

        private void CmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTag();
            dtgMenu();
        }
        private void FillTag()
        {
            cmbTags.Items.AddRange(db.Tags.Select(ft => ft.Name).ToArray());
        }

        private void DtgMedicineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgMenu()
        {
            dtgMedicineList.DataSource = db.Medicines.Where(md=>md.Name.Contains(cmbMedicine.Text)).Select(md => new
            {
                md.Id,
                md.Name,
                md.Price,
                md.,
                md.Barcode,
                md.ProductionDate,
                md.ExperienceDate,
                resipet = md.WithResiept == true ? "Resiept" : "Reseieptsiz",

            }).ToList();
            dtgMedicineList.Columns[0].Visible = false;
        }

       
        private void CmbMedicine_KeyUp(object sender, KeyEventArgs e)
        {
            dtgMenu();

        }

        private void CmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            dtgMenu();
        }
        private void BuyFilterCombo(string buyname)
        {
            if (buyname == "buy")
            {
                btnOrderMedicine.Visible = true;
                btnMedicineBuy.Visible = true;
                lblMedicineBuyName.Visible = true;
                lblMedicineCount.Visible = true;
                txtMedicineBuyName.Visible = true;
                nmBuyCount.Visible = true;
                grpMedicineBuy.Visible = true;

            }
            else
            {
                btnMedicineBuy.Visible = true;
                lblMedicineBuyName.Visible = false;
                lblMedicineCount.Visible = false;
                txtMedicineBuyName.Visible = false;
                nmBuyCount.Visible = false;
                grpMedicineBuy.Visible = false;
                btnOrderMedicine.Visible = false;

            }
        }
        public bool AddTag(string medname)
        {
            if (medname != "")
            {
                foreach (System.Windows.Forms.Button item in grpMedicineBuy.Controls)
                {
                    if (item.Text == medname)
                    {
                        return false;

                    }
                }
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = medname;

                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.Location = new System.Drawing.Point(25, 45);
                btn.Tag = (int)nmBuyCount.Value;
                btn.Width = 100;
                if (LocX + btn.Width > grpMedicineBuy.Width)
                {
                    LocX = marginX;
                    LocY += btn.Height + marginY;
                }

                btn.Location = new System.Drawing.Point(LocX, LocY);
                btn.Click += new System.EventHandler(this.btnTagDelete);
                LocX += btn.Width;
                grpMedicineBuy.Controls.Add(btn);

            }

            return true;


        }
        private void btnTagDelete(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            grpMedicineBuy.Controls.Remove(btn);
            if (grpMedicineBuy.Controls.Count == 0)
            {
                LocX = 0;
            }
            int internalLocX = 10;
            int internalLocY = 20;
            int internalMarginX = 10;
            int internalMarginY = 20;
            int length = grpMedicineBuy.Controls.Count;
            foreach (System.Windows.Forms.Button button in grpMedicineBuy.Controls)
            {
                if (internalLocX + btn.Width >= grpMedicineBuy.Width)
                {
                    internalLocX = internalMarginX;
                    internalLocY += internalMarginY + btn.Height;

                }
                button.Location = new System.Drawing.Point(internalLocX, internalLocY);
                internalLocX += btn.Width + internalMarginX;
            }
            foreach (System.Windows.Forms.Button button in grpMedicineBuy.Controls)
            {
                if (grpMedicineBuy.Controls.GetChildIndex(button) == (length - 1))
                {
                    LocX = button.Location.X + btn.Width + marginX;
                    LocY = button.Location.Y;
                }
            }
        }
        private void DtgMedicineList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int medicineId = (int)dtgMedicineList.Rows[e.RowIndex].Cells[0].Value;
            Medicine selectedMedicine = db.Medicines.FirstOrDefault(md => md.Id == medicineId);
            txtMedicineBuyName.Text = selectedMedicine.Name;
            BuyFilterCombo("buy");
        }

        private void BtnMedicineBuy_Click(object sender, EventArgs e)
        {
            AddTag(txtMedicineBuyName.Text);
        }

        private void NmBuyCount_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnOrderMedicine_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (System.Windows.Forms.Button tagItem in grpMedicineBuy.Controls)
            {
                Medicine selectedTag = db.Medicines.FirstOrDefault(tg => tg.Name == tagItem.Text);

                if (selectedTag != null)
                {
                    int count = (int)tagItem.Tag;
                    db.Orders.Add(new Order
                    {
                        Worker_Id=activeWorker.Id,
                        Medicine_Id = selectedTag.Id,
                        PurchaseDate = DateTime.Now,
                        Amount = count,
                        Price = selectedTag.Price * (int)tagItem.Tag,
                    });
                    db.SaveChanges();
                    selectedTag.Count -= count;
                    db.SaveChanges();
                    result += string.Format("\n Medicine: {0}  Count:{1} Price:{2} Azn", tagItem.Text, count, count * selectedTag.Price);
                }

            }
            MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgMenu();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var xlApp = new Microsoft.Office.Interop.Excel.Application();
            var xlWorkBook = xlApp.Workbooks.Add();
            var xlSheet = xlWorkBook.Worksheets[1];

            for (var i = 0; i < dtgMedicineList.ColumnCount; i++)
            {
                xlSheet.Cells[1, i + 1] = dtgMedicineList.Columns[i].HeaderText;
            }
            for (var i = 0; i < dtgMedicineList.RowCount; i++)
            {
                for (var j = 0; j < dtgMedicineList.ColumnCount; j++)
                {
                    xlSheet.Cells[i + 2, j + 1] = dtgMedicineList.Rows[i].Cells[j].Value.ToString();
                }
            }
            MessageBox.Show(DateTime.Now.ToString());
            xlWorkBook.SaveAs(@"C:\Users\User\Desktop\MedOrder-"+DateTime.Now.ToString("yyyy MMMM ss"));
            xlWorkBook.Close();
            xlApp.Quit();
            MessageBox.Show("Excel yaradildi");
        }

        private void NmBuyCount_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void NmBuyCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                
                AddTag(txtMedicineBuyName.Text);
            }
        }
    }
}
