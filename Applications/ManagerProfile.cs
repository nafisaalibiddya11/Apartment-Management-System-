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
    public partial class ManagerProfile : Form
    {
        private DataSet Ds { get; set; }
        private User user;

        public ManagerProfile(User user)
        {
            InitializeComponent();
            this.PopulateGridViewBuyer();
            this.PopulateGridViewSeller();
            this.user = user;
            this.txtname.Text = user.Name;
            this.txtpass.Text = user.Password;
            this.txtemail.Text = user.Email;
            this.txtaddress.Text = user.Address;
            this.txtcontact.Text = user.Contactno;

            this.label1.Text = this.label1.Text + user.ID;
        }

        private void PopulateGridViewBuyer()
        {
            this.Ds = UserRepository.GetBuyersDataSet();
            this.dgvbuyer.AutoGenerateColumns = false;
            this.dgvbuyer.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewBuyer(string text)
        {
            this.Ds = UserRepository.GetBuyersDataSetChanged(text);
            this.dgvbuyer.AutoGenerateColumns = false;
            this.dgvbuyer.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewSeller()
        {
            this.Ds = UserRepository.GetSellersDataSet();
            this.dgvseller.AutoGenerateColumns = false;
            this.dgvseller.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewSeller(string text)
        {
            this.Ds = UserRepository.GetSellersDataSetChanged(text);
            this.dgvseller.AutoGenerateColumns = false;
            this.dgvseller.DataSource = this.Ds.Tables[0];
        }
        private void btnremovebuyer_Click(object sender, EventArgs e)
        {
            string id = this.dgvbuyer.CurrentRow.Cells["buyerid"].Value.ToString();
            if(UserRepository.DeleteInfromation(id)==1)
            {
                MessageBox.Show("Deletion Done.");
                this.PopulateGridViewBuyer();
            }
        }
        private void btnremoveseller_Click(object sender, EventArgs e)
        {
            string id = this.dgvseller.CurrentRow.Cells["sellerid"].Value.ToString();
            if(UserRepository.DeleteInfromation(id)==1)
            {
                MessageBox.Show("Deletion Done.");
                this.PopulateGridViewSeller();
            }
        }
        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            if (this.btnchangepassword.Text.Equals("Edit Password"))
            {
                this.btnchangepassword.Text = "Update Password";
                this.txtpass.UseSystemPasswordChar = false;
                this.txtpass.Enabled = true;
            }
            else if (this.btnchangepassword.Text.Equals("Update Password"))
            {
                if (UserRepository.UpdatePassword(this.user.ID, this.txtpass.Text) == 1)
                {
                    this.txtpass.UseSystemPasswordChar = true;
                    this.btnchangepassword.Text = "Edit Password";
                    this.txtpass.Enabled = false;
                    MessageBox.Show("Updated!");
                }
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (this.btnupdate.Text.Equals("Edit Information"))
            {
                this.btnupdate.Text = "Update Information";
                this.txtemail.Enabled = true;
                this.txtcontact.Enabled = true;
                this.txtaddress.Enabled = true;
            }
            else if (this.btnupdate.Text.Equals("Update Information"))
            {
                if (UserRepository.UpdateInfromation(this.user.ID, this.txtname.Text, this.txtemail.Text, this.txtaddress.Text, this.txtcontact.Text) == 1)
                {
                    this.txtemail.Enabled = false;
                    this.txtcontact.Enabled = false;
                    this.txtaddress.Enabled = false;
                    this.btnupdate.Text = "Edit Information";
                    MessageBox.Show("Updated!");
                }
            }
        }
        private void txtbuyersearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePopulateGridViewBuyer(this.txtbuyersearch.Text);
        }
        private void txtsellersearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePopulateGridViewSeller(this.txtsellersearch.Text);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.user.LG.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Advertisement add = new Advertisement(this.user);
            add.Visible = true;
        }

        private void ManagerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
