using ApartmentManagement.Entity;
using ApartmentManagement.Repository;
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
    public partial class AddManager : Form
    {
        request SET { get; set; }
        AdminProfile AP { get; set; }

        public AddManager(AdminProfile ap,request set)
        {
            InitializeComponent();
            this.AP = ap;
            this.SET = set;
        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AP.Visible = true;
        }
        private void btnManagerAddSignup_Click(object sender, EventArgs e)
        {
            if (this.txtManagerAddPassword.Text.Equals(this.txtManagerAddConfirmPassword.Text))
            {
                User u = new User(this.txtManagerAddName.Text, "seller", this.txtManagerAddEmail.Text, this.txtManagerAddAddress.Text, this.txtManagerAddPhone.Text, this.txtManagerAddPassword.Text);
                if (UserRepository.AddInfromation(u) == 1)
                {
                    MessageBox.Show("Signed in successfully!\nYour ID is "+u.ID+".\nPlease remember for future work.");
                    MessageBox.Show("Your ID is " + u.ID + ".\nPlease Reconfirm that you have rememberd.");
                    this.Visible = false;
                    SET();
                    AP.Visible = true;
                }
                else
                {
                    MessageBox.Show("Email or Contact may already exist!");
                }
            }
            else
                MessageBox.Show("Password Dosen't Match!");
        }

        private void AddManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
