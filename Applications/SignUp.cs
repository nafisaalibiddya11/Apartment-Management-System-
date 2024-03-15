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
    public partial class SignUp : Form
    {
        private Login lg { get; set; }
        public SignUp(Login lg)
        {
            InitializeComponent();
            this.lg = lg;
            this.btnBuyer.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.btnSeller.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.btnBack.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BuyerSignUp bg = new BuyerSignUp(lg);
            bg.Visible = true;
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SellerSignUp Sg = new SellerSignUp(lg);
            Sg.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lg.Visible = true;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSellerBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.lg.Visible = true;
        }
    }
}
