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
    public partial class BuyerSignUp : Form
    {
        private Login lg;
        public BuyerSignUp(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
            this.pnlBuyerSignup.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void Buyer_Sign_up_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnBuyerBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.lg.Visible = true;
        }
        private void btnBuyerSignup_Click(object sender, EventArgs e)
        {
            if (this.cbxAgreement.Checked)
            {
                if (this.txtBuyerSignupPassword.Text.Equals(this.txtBuyerSignupConfirmPassword.Text))
                {
                    User u = new User(this.txtBuyerSignupName.Text, "buyer", this.txtBuyerSignupEmail.Text, this.txtBuyerAddress.Text, this.txtBuyerSignupPhone.Text, this.txtBuyerSignupPassword.Text);
                    if (UserRepository.AddInfromation(u) == 1)
                    {
                        MessageBox.Show("Signed in successfully!\nYour ID is " + u.ID + ".\nPlease remember for future work.");
                        MessageBox.Show("Your ID is " + u.ID + ".\nPlease Reconfirm that you have rememberd.");
                        this.Visible = false;
                        lg.Visible = true;
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

        private void BuyerSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
