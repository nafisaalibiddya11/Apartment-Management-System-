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
using ApartmentManagement.Repository;
using ApartmentManagement.Data;

namespace ApartmentManagement.Applications
{
    public partial class AddAdvertisement : Form
    {
        private Entity.User USER { get; set; }
        private SellerProfile SP { get; set; }
        private Advertisement AD { get; set; }
        private bool SaveFlag = false;
        private bool RentalFlag;
        private bool Flag = false;

        public AddAdvertisement(Entity.User user,SellerProfile sp)
        {
            InitializeComponent();
            USER = user;
            this.SP = sp;
            Flag = true;
            this.panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }
        public AddAdvertisement(Entity.User user,Advertisement ad)
        {
            InitializeComponent();
            USER = user;
            this.AD = ad;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                SaveFlag = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveFlag)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var bytes = ms.GetBuffer();
                var image = Convert.ToBase64String(bytes, 0, bytes.Length).ToString();
                if (rbtnSale.Checked)
                {
                    this.RentalFlag = true;
                }
                else if (rbtnRent.Checked)
                    this.RentalFlag = false;
                Entity.Advertisement add = new Entity.Advertisement(this.txtDescription.Text, RentalFlag, this.txtLocation.Text, Convert.ToDouble(this.txtPrice.Text), USER.ID, false,image);
                if(AdvertisementRepository.AddAddvertisement(add)==1)
                {
                    this.Visible = false;
                    if (Flag)
                    {
                        SP.PopulateGridViewAll();
                        this.SP.Visible = true;
                    }
                    else
                    {
                        AD.PopulateGridView();
                        this.AD.Visible = true;
                    }
                }                
            }
            else
                MessageBox.Show("Please Enter A beautiful Picture of Your Addvertisement Apartment.\nSo that every one can see what it reallly looks like!");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Flag)
            {
                this.Visible = false;
                SP.Visible = true;
            }
            else
            {
                this.Visible = false;
                AD.Visible = true;
            }
            
        }

        private void AddAdvertisement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
