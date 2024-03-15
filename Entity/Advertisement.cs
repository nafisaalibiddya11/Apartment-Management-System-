using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentManagement.Repository;

namespace ApartmentManagement.Entity
{
    public class Advertisement
    {
        private string id;
        private string description;
        private bool rentalDescription;
        private string location;
        private bool verification=false;
        private double price;
        private string uid;
        private bool status;
        private string rid;
        private string image;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public bool RentalDescription
        {
            get { return this.rentalDescription; }
            set { this.rentalDescription = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        public bool Verification
        {
            get { return this.verification; }
            set { this.verification = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string UID
        {
            get { return this.uid; }
            set { this.uid = value; }
        }
        public bool Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string RID
        {
            get { return this.rid; }
            set { this.rid = value; }
        }
        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public Advertisement(string description, bool rentaldescription, string location, double price, string uid, bool status,string image)
        {
            int tempid = (AdvertisementRepository.GetAllAddvertisement() + 1);
            this.ID = "AD-" + tempid.ToString().PadLeft(5, '0') + "-1";
            this.Description = description;
            this.RentalDescription = rentaldescription;
            this.Location = location;
            this.Price = price;
            this.UID = uid;
            this.Status = false;
            this.Image = image;
        }
        public Advertisement(DataSet advertisement)
        {
            try
            {
                this.ID = advertisement.Tables[0].Rows[0][0].ToString();
                this.Description = advertisement.Tables[0].Rows[0][1].ToString();
                this.RentalDescription = Convert.ToBoolean(advertisement.Tables[0].Rows[0][2]);
                this.Location = advertisement.Tables[0].Rows[0][3].ToString();
                this.Verification = Convert.ToBoolean(advertisement.Tables[0].Rows[0][4]);
                this.Price = Convert.ToDouble(advertisement.Tables[0].Rows[0][6]);
                this.UID = advertisement.Tables[0].Rows[0][7].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Coudn't get Advertisement Information");
                MessageBox.Show(ex.Message);
            }
        }
        public Advertisement(bool check)
        {
            if (check)
            {

            }
        }

    }
}
