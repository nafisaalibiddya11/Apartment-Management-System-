using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmentManagement.Applications;
using ApartmentManagement.Repository;

namespace ApartmentManagement.Entity
{
    public class User
    {
        private string id;
        private string name;
        private string designation;
        private string email;
        private string address;
        private string contactno;
        private string password;

        public Login LG { get; set; }

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Contactno
        {
            get { return this.contactno; }
            set { this.contactno = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public User(string name, string designation, string email, string address, string contactno, string password)
        {
            this.Name = name;
            this.Designation = designation;
            if (Designation.ToLower().Equals("admin"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "A-" + tempid.ToString().PadLeft(6, '0') + "-1";
            }
            else if (Designation.ToLower().Equals("manager"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "M-" + tempid.ToString().PadLeft(6, '0') + "-2";
            }
            else if (Designation.ToLower().Equals("buyer"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "B-" + tempid.ToString().PadLeft(6, '0') + "-3";
            }
            else if (Designation.ToLower().Equals("seller"))
            {
                int tempid = UserRepository.GetTotalUsers() + 1;
                this.ID = "S-" + tempid.ToString().PadLeft(6, '0') + "-4";
            }
            this.Email = email;
            this.Address = address;
            this.Contactno = contactno;
            this.Password = password;
        }
        public User(DataSet user,Login lg)
        {
            try
            {
                this.ID = user.Tables[0].Rows[0][0].ToString();
                this.Name = user.Tables[0].Rows[0][1].ToString();
                this.Designation = user.Tables[0].Rows[0][2].ToString();
                this.Email = user.Tables[0].Rows[0][3].ToString();
                this.Address = user.Tables[0].Rows[0][4].ToString();
                this.Contactno = user.Tables[0].Rows[0][5].ToString();
                this.Password = user.Tables[0].Rows[0][6].ToString();
                this.LG = lg;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Coudn't get User Information");
                MessageBox.Show(ex.Message);
            }
        }

    }
}
