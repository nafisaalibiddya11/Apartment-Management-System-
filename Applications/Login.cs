using ApartmentManagement.Data;
using ApartmentManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement.Applications
{
    public partial class Login : Form
    {
        private DataSet Ds { get; set; }
        public Login()
        {
            InitializeComponent();
           // pnlLogin.BackColor = Color.FromArgb(150, 0, 0, 0);
           // lbl1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from users where id = '" + this.txtuserid.Text + "' AND password = '" + this.txtpassword.Text + "' ;";
                Ds = DataAccess.GetDataSet(sql);
                User user = new User(Ds, this);
                if (user.Designation.Equals("admin"))
                {
                    this.Visible = false;
                    AdminProfile ap = new AdminProfile(user);
                    ap.Visible = true;
                }
                else if (user.Designation.Equals("manager"))
                {
                    this.Visible = false;
                    ManagerProfile mp = new ManagerProfile(user);
                    mp.Visible = true;
                }
                else if (user.Designation.Equals("seller"))
                {
                    this.Visible = false;
                    SellerProfile Sp = new SellerProfile(user);
                    Sp.Visible = true;
                }
                else if (user.Designation.Equals("buyer"))
                {
                    this.Visible = false;
                    BuyerProfile Bp = new BuyerProfile(user);
                    Bp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("User ID and passWord dosen't match!");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            SignUp sg = new SignUp(this);
            sg.Visible = true;
        }
    }
}
