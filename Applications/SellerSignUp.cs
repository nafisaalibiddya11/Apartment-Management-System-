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
    public partial class SellerSignUp : Form
    {
        private Login l { get; set; }

        public SellerSignUp(Login SL)
        {
            InitializeComponent();
            this.l = SL;
            this.pnlSellerSignup.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void Seller_Sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnSellerBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.l.Visible = true;
        }
        private void btnSellerSignup_Click(object sender, EventArgs e)
        {
            if (this.cbxAgreement.Checked)
            {
                if (this.txtSellerSignupPassword.Text.Equals(this.txtSellerSignupConfirmPassword.Text))
                {
                    User u = new User(this.txtSellerSignupName.Text, "seller", this.txtSellerSignupEmail.Text, this.txtSellerAddress.Text, this.txtSellerSignupPhone.Text, this.txtSellerSignupPassword.Text);
                    if (UserRepository.AddInfromation(u) == 1)
                    {
                        MessageBox.Show("Signed in successfully!\nYour ID is " + u.ID + ".\nPlease remember for future work.");
                        MessageBox.Show("Your ID is " + u.ID + ".\nPlease Reconfirm that you have rememberd.");
                        this.Visible = false;
                        l.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Your Email or Contact may already exist!");
                    }
                }
                else
                    MessageBox.Show("Password Dosen't Match!");
            }
            else
                MessageBox.Show("Please check the agreement box to continue!");
        }

        private void SellerSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
