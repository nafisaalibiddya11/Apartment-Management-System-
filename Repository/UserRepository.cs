using ApartmentManagement.Data;
using ApartmentManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement.Repository
{
    class UserRepository
    {
        private static DataSet Ds { get; set; }

        public static int GetTotalUsers()
        {
            try
            {
                string sql = "SELECT id FROM users ORDER BY substring(id,3,7);";
                Ds = DataAccess.GetDataSet(sql);
                int i = Ds.Tables[0].Rows.Count - 1;
                string str = Ds.Tables[0].Rows[i][0].ToString();
                str = str.Remove(0, 2);
                str = str.Remove(6, 2);
                return Convert.ToInt32(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public static DataSet GetManagerDataSet(string sql = "select * from users where designation = 'manager';")
        {
            try
            {
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetManagerDataSetChanged(string text)
        {
            try
            {
                string sql = "select * from users where (name like '" + text + "%' AND designation = 'manager') OR (id like '" + text + "%' AND designation = 'manager') OR (contactno like '" + text + "%' AND designation = 'manager');";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetBuyersDataSet(string sql = "select * from users where designation = 'buyer';")
        {
            try
            {
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetBuyersDataSetChanged(string text)
        {
            try
            {
                string sql = "select * from users where (name like '" + text + "%' AND designation = 'buyer') OR (id like '" + text + "%' AND designation = 'buyer') OR (contactno like '" + text + "%' AND designation = 'buyer');";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetSellersDataSet(string sql = "select * from users where designation = 'seller';")
        {
            try
            {
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetSellersDataSetChanged(string text)
        {
            try
            {
                string sql = "select * from users where (name like '" + text + "%' AND designation = 'seller') OR (id like '" + text + "%' AND designation = 'seller') OR (contactno like '" + text + "%' AND designation = 'seller');";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int UpdatePassword(string id, string password)
        {
            try
            {
                string sql = @"update users set password = '" + password + "' where id = '" + id + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int UpdateInfromation(string id, string name, string email, string address, string contactno)
        {
            try
            {
                string sql = @"update users set name = '" + name + "',email = '" + email + "', address = '" + address + "', contactno = " + contactno + " where id = '" + id + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int DeleteInfromation(string id)
        {
            try
            {
                string sql = "delete from users where id = '" + id + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int AddInfromation(User user)
        {
            try
            {
                string sql = "insert into users values ('" + user.ID + "','" + user.Name + "','" + user.Designation + "','" + user.Email + "','" + user.Address + "','" + user.Contactno + "','" + user.Password + "');";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }

        public static DataSet GetUserInformation(string id)
        {
            try
            {
                string sql = "select * from users where id = '" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
