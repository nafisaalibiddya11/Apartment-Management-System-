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
    public partial class SellerProfile : Form
    {
        private DataSet Ds { get; set; }
        private User user;

        public SellerProfile(User user)
        {
            InitializeComponent();
            this.user = user;
            this.txtname.Text = user.Name;
            this.txtpass.Text = user.Password;
            this.txtemail.Text = user.Email;
            this.txtaddress.Text = user.Address;
            this.txtcontact.Text = user.Contactno;

            this.PopulateGridViewAll();
            this.PopulateGridViewRequested();
            this.PopulateGridViewConfirmed();

            this.label1.Text = this.label1.Text + user.ID;
        }

        public void PopulateGridViewAll()
        {
            this.Ds = UserAdvertisementRepository.GetAllAddDataSet(user.ID);
            this.dgvalladd.AutoGenerateColumns = false;
            this.dgvalladd.DataSource = this.Ds.Tables[0];
        }
        public void UpdatePopulateGridViewAll(string text)
        {
            this.Ds = UserAdvertisementRepository.GetAllAddDataSetChanged(user.ID, text);
            this.dgvalladd.AutoGenerateColumns = false;
            this.dgvalladd.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewRequested()
        {
            this.Ds = UserAdvertisementRepository.GetRequestAddDataSet(user.ID);
            this.dgvrequestedadd.AutoGenerateColumns = false;
            this.dgvrequestedadd.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewRequested(string text)
        {
            this.Ds = UserAdvertisementRepository.GetRequestAddDataSetChanged(user.ID, text);
            this.dgvrequestedadd.AutoGenerateColumns = false;
            this.dgvrequestedadd.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewConfirmed()
        {
            this.Ds = UserAdvertisementRepository.GetConfirmAddDataSet(user.ID);
            this.dgvconfirmedadd.AutoGenerateColumns = false;
            this.dgvconfirmedadd.DataSource = this.Ds.Tables[0];
        }
        private void UpdatePopulateGridViewConfirmed(string text)
        {
            this.Ds = UserAdvertisementRepository.GetConfirmAddDataSetChanged(user.ID, text);
            this.dgvconfirmedadd.AutoGenerateColumns = false;
            this.dgvconfirmedadd.DataSource = this.Ds.Tables[0];
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
        private void txtalladdsearch_TextChanged(object sender, EventArgs e)
        {
            UpdatePopulateGridViewAll(this.txtalladdsearch.Text);
        }
        private void txtrequestedaddsearch_TextChanged(object sender, EventArgs e)
        {
            UpdatePopulateGridViewRequested(this.txtrequestedaddsearch.Text);
        }
        private void txtconfirmedaddsearch_TextChanged(object sender, EventArgs e)
        {
            UpdatePopulateGridViewConfirmed(this.txtconfirmedaddsearch.Text);
        }
        private void btnremoveadvertisements_Click(object sender, EventArgs e)
        {
            string addid = this.dgvalladd.CurrentRow.Cells["alladdid"].Value.ToString();
            if (AdvertisementRepository.DeleteAddvertisement(addid) == 1)
            {
                PopulateGridViewAll();
                MessageBox.Show("Deleted!");
            }
        }
        private void btnremovebuyerrequest_Click(object sender, EventArgs e)
        {
            string addid = this.dgvrequestedadd.CurrentRow.Cells["reqaddid"].Value.ToString();
            if (AdvertisementRepository.DeleteAddvertisementRequest(addid) == 1)
            {
                PopulateGridViewRequested();
                PopulateGridViewAll();
                PopulateGridViewConfirmed();
                MessageBox.Show("Rejected!");
            }
        }
        private void btnconfirmbuyerrequest_Click(object sender, EventArgs e)
        {
            string addid = this.dgvrequestedadd.CurrentRow.Cells["reqaddid"].Value.ToString();
            if (AdvertisementRepository.ConfirmAddvertisementRequest(addid) == 1)
            {
                PopulateGridViewRequested();
                PopulateGridViewAll();
                PopulateGridViewConfirmed();
                MessageBox.Show("Confirmed!");
            }
        }
        private void btnaddvertisement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Advertisement add = new Advertisement(this.user);
            add.Visible = true;
        }
        private void btnaddadvertisement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddAdvertisement aad = new AddAdvertisement(user, this);
            aad.Visible = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.user.LG.Visible = true;
        }

        private void SellerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
