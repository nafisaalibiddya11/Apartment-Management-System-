using ApartmentManagement.Data;
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
    public partial class BuyerProfile : Form
    {
        private DataSet Ds { get; set; }
        private User user;

        public BuyerProfile(User user)
        {
            InitializeComponent();
            this.user = user;
            this.txtname.Text = user.Name;
            this.txtpass.Text = user.Password;
            this.txtemail.Text = user.Email;
            this.txtaddress.Text = user.Address;
            this.txtcontact.Text = user.Contactno;

            this.PopulateGridViewreq();
            this.PopulateGridViewconfirm();

            this.label1.Text = this.label1.Text + user.ID;
        }

        private void PopulateGridViewreq()
        {
            this.Ds = UserAdvertisementRepository.GetRequestedAddDataSet(user.ID);
            this.dgvbuyerreq.AutoGenerateColumns = false;
            this.dgvbuyerreq.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewreq(string text)
        {
            this.Ds = UserAdvertisementRepository.GetRequestedAddDataSetChanged(user.ID, text);
            this.dgvbuyerreq.AutoGenerateColumns = false;
            this.dgvbuyerreq.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewconfirm()
        {
            this.Ds = UserAdvertisementRepository.GetConfirmedAddDataSet(user.ID);
            this.dgvbuyercofirmed.AutoGenerateColumns = false;
            this.dgvbuyercofirmed.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewconfirm(string text)
        {
            this.Ds = UserAdvertisementRepository.GetConfirmedAddDataSetChanged(user.ID, text);
            this.dgvbuyercofirmed.AutoGenerateColumns = false;
            this.dgvbuyercofirmed.DataSource = this.Ds.Tables[0];
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
                string sql = @"update users set password = '" + this.txtpass.Text + "' where id = '" + this.user.ID + "';";
                try
                {
                    if (DataAccess.ExecuteQuery(sql) == 1)
                    {
                        this.txtpass.UseSystemPasswordChar = true;
                        this.btnchangepassword.Text = "Edit Password";
                        this.txtpass.Enabled = false;
                    }
                    MessageBox.Show("Updated!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }
        private void txtrequestedsearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePopulateGridViewreq(this.txtrequestedsearch.Text);
        }
        private void txtconfirmedsearch_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePopulateGridViewconfirm(this.txtconfirmedsearch.Text);
        }
        private void btnremoverequest_Click(object sender, EventArgs e)
        {
            string addid = this.dgvbuyerreq.CurrentRow.Cells["addid"].Value.ToString();
            if (AdvertisementRepository.DeleteAddvertisementRequest(addid) == 1)
            {
                this.PopulateGridViewreq();
                this.PopulateGridViewconfirm();
                MessageBox.Show("Deleted!");
            }
        }
        private void btnShowAddvertisement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Advertisement add = new Advertisement(this.user);
            add.Visible = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.user.LG.Visible = true;
        }

        private void BuyerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
