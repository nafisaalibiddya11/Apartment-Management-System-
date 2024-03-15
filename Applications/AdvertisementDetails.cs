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
using System.IO;

namespace ApartmentManagement.Applications
{
    public partial class AdvertisementDetails : Form
    {
        DataSet Ds { get; set; }
        request R { get; set; }

        public AdvertisementDetails(Entity.Advertisement add,request r,string designation)
        { 
            InitializeComponent();
            this.R = r;
            if (designation.Equals("buyer"))
            {
                btnRequest.Visible = true;
            }
            if (add.RentalDescription)//if rental flag true
            {
                this.lblRentalDescription1.Text = "For Rent";
                this.btnRequest.Text = this.btnRequest.Text + " Rent";
            }
            else
            {
                this.lblRentalDescription1.Text = "For sale";
                this.btnRequest.Text = this.btnRequest.Text + " Sale";
            }
            if (add.Verification)//if Verification true
            {
                this.lblVerify.Text = "Verified";
            }
            else
            {
                this.lblVerify.Text = "Not Verified";
            }
            this.lblDescription.Text = add.Description;
            this.lblLocation.Text = add.Location;
            this.lblPrice.Text = add.Price.ToString();
            Ds = UserRepository.GetUserInformation(add.UID);
            this.lbluserid.Text = Ds.Tables[0].Rows[0][1].ToString();

            var image = add.Image;
            var bytes = Convert.FromBase64String(image);
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);

            this.panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            R();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AdvertisementDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
