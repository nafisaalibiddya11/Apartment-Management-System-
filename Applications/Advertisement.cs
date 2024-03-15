using ApartmentManagement.Data;
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
    public delegate void request();
    public partial class Advertisement : Form
    {
        private Entity.User user;
        private DataSet Ds { get; set; }

        public Advertisement(Entity.User user)
        {
            InitializeComponent();
            this.PopulateGridView();
            this.user = user;
            if (user.Designation.Equals("manager") || user.Designation.Equals("admin"))
            {
                this.btnverification.Visible = true;
                this.btndelete.Visible = true;
                this.btnrequest.Visible = false;
            }
            else if (user.Designation.Equals("seller"))
            {
                this.btnaddaddvertisement.Visible = true;
                this.btnrequest.Visible = false;
            }
        }

        public void PopulateGridView()
        {
            this.Ds = UserAdvertisementRepository.GetAllAddDataSet2();
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewSortByPrice(int index)
        {
            this.Ds = UserAdvertisementRepository.GetAllAddDataSet3(index);
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void PopulateGridViewSortText(string text)
        {
            this.Ds = UserAdvertisementRepository.GetAllAddDataSet4(text);
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateGridViewSortByPrice(cmb1.SelectedIndex);
        }
        private void btnverification_Click(object sender, EventArgs e)
        {
            string addid = this.dgvmain.CurrentRow.Cells["addid"].Value.ToString();
            if(AdvertisementRepository.AddvertisementVerification(addid)==1)
            {
                MessageBox.Show("Verified!");
                this.PopulateGridView();
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string addid = this.dgvmain.CurrentRow.Cells["addid"].Value.ToString();
            if(AdvertisementRepository.DeleteAddvertisement(addid)==1)
            {
                MessageBox.Show("Deleted!");
                this.PopulateGridView();
            }
        }
        private void btnrequest_Click(object sender, EventArgs e)
        {
            this.Request();
        }
        private void txtlocationsearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridViewSortText(this.txtlocationsearch.Text);
        }
        private void btnaddaddvertisement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddAdvertisement aad = new AddAdvertisement(user, this);
            aad.Visible = true;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            if (user.Designation.Equals("admin"))
            {
                this.Visible = false;
                AdminProfile ap = new AdminProfile(user);
                ap.Visible = true;
            }
            else if(user.Designation.Equals("manager"))
            {
                this.Visible = false;
                ManagerProfile mp = new ManagerProfile(user);
                mp.Visible = true;
            }
            else if(user.Designation.Equals("seller"))
            {
                this.Visible = false;
                SellerProfile sp = new SellerProfile(user);
                sp.Visible = true;
            }
            else if(user.Designation.Equals("buyer"))
            {
                this.Visible = false;
                BuyerProfile bp = new BuyerProfile(user);
                bp.Visible = true;
            }

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.user.LG.Visible = true;
        }
        private void dgvmain_DoubleClick(object sender, EventArgs e)
        {
            Entity.Advertisement add = new Entity.Advertisement(true);
            add.ID = this.dgvmain.CurrentRow.Cells["addid"].Value.ToString();
            add.Description = this.dgvmain.CurrentRow.Cells["description"].Value.ToString();
            add.RentalDescription = Convert.ToBoolean(this.dgvmain.CurrentRow.Cells["rentaldescription"].Value);
            add.Location = this.dgvmain.CurrentRow.Cells["location"].Value.ToString();
            add.Verification = Convert.ToBoolean(this.dgvmain.CurrentRow.Cells["verification"].Value);
            add.Price = Convert.ToDouble(this.dgvmain.CurrentRow.Cells["price"].Value);
            add.UID = this.dgvmain.CurrentRow.Cells["uid"].Value.ToString();
            add.Image = this.dgvmain.CurrentRow.Cells["image"].Value.ToString();
            request r = this.Request;
            AdvertisementDetails ad = new AdvertisementDetails(add,r,user.Designation);
            ad.Visible = true;
        }
        private void Request()
        {
            string addid = this.dgvmain.CurrentRow.Cells["addid"].Value.ToString();
            if(AdvertisementRepository.AddvertisementRequest(user.ID,addid)==1)
            {
                MessageBox.Show("Booking Reqested Done.\nPlease wait for confirmation!");
                this.PopulateGridView();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ds = AdvertisementRepository.GetVerifiedAddDataSet();
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ds = AdvertisementRepository.GetNotVerifiedAddDataSet();
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Ds = AdvertisementRepository.GetForSaleAddDataSet();
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Ds = AdvertisementRepository.GetForRentAddDataSet();
            this.dgvmain.AutoGenerateColumns = false;
            this.dgvmain.DataSource = this.Ds.Tables[0];
        }

        private void Advertisement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
