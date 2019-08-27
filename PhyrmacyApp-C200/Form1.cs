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
    public partial class Form1 : Form
    {
        PharmcyDB db = new PharmcyDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Our Aptek";
            Setting selectedSetting = db.Settings.First();
            this.Icon = new Icon("../../Uploads/" + selectedSetting.Logo);
            this.Text = selectedSetting.Name;
            lblWelcome.Text = selectedSetting.Header;
                
 }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            if (email != null && password != null)
            {
                Admin selectAdmin = db.Admins.FirstOrDefault(ad => ad.AdminEmail == email);
                if (selectAdmin != null)
                {
                    if (selectAdmin.AdminPassword == password)
                    {
                        AdminDashboard adm = new AdminDashboard();
                        adm.ShowDialog();
                    }
                  
                }
                else
                {
                    Worker selectWorker = db.Workers.FirstOrDefault(wr => wr.Username == email);
                    if(selectWorker!=null)
                    {
                        if (selectWorker.Password == password)
                        {
                            WorkerDashboard wrd = new WorkerDashboard(selectWorker);
                            wrd.ShowDialog();
                        }
                        else
                        {
                            lblError.Text = "Password is not Correct";
                            lblError.Visible = true;
                        }
                        
                    }
                    else
                    {
                        lblError.Text = "Email is not Correct";
                        lblError.Visible = true;
                    }
                }
            }
            else
            {
                lblError.Text = "Please all the fill!";
                lblError.Visible = true;
            }
        }
    }
}
