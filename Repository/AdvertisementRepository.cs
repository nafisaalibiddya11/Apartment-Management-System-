using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ApartmentManagement.Data;
using ApartmentManagement.Entity;
using System.Windows.Forms;

namespace ApartmentManagement.Repository
{
    class AdvertisementRepository
    {
        private static DataSet Ds { get; set; }

        public static int GetAllAddvertisement()
        {
            try
            {
                string sql = "select * from Addvertisement ORDER BY substring(addid,2,8);";
                Ds = DataAccess.GetDataSet(sql);
                int i = Ds.Tables[0].Rows.Count - 1;
                string str = Ds.Tables[0].Rows[i][0].ToString();
                str = str.Remove(0, 3);
                str = str.Remove(5, 2);
                return Convert.ToInt32(str);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        

        public static DataSet GetVerifiedAddDataSet()
        {
            try
            {
                string sql = "select * from addvertisement where verification = 1 AND status = 0 AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetNotVerifiedAddDataSet()
        {
            try
            {
                string sql = "select * from addvertisement where verification = 0 AND status = 0 AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetForSaleAddDataSet()
        {
            try
            {
                string sql = "select * from addvertisement where rentaldescription = 1 AND status = 0 AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetForRentAddDataSet()
        {
            try
            {
                string sql = "select * from addvertisement where rentaldescription = 0 AND status = 0 AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int AddvertisementVerification(string addid)
        {
            try
            {
                string sql = "update addvertisement set verification = 1  where addid = '" + addid + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int AddvertisementRequest(string userid,string addid)
        {
            try
            {
                string sql = "update addvertisement set rid ='" + userid + "'  where addid = '" + addid + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int ConfirmAddvertisementRequest(string addid)
        {
            try
            {
                string sql = "update addvertisement set status = 1 where addid = '" + addid + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int DeleteAddvertisementRequest(string addid)
        {
            try
            {
                string sql = "update addvertisement set rid = null where addid = '" + addid + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int AddAddvertisement(Advertisement add)
        {
            try
            {
                byte rent;
                if (add.RentalDescription)
                    rent = 1;
                else
                    rent = 0;
                string sql = "insert into Addvertisement (addid,description,rentaldescription,location,price,uid,status,image,verification) Values ('" + add.ID + "','" + add.Description + "'," + rent + ",'" + add.Location + "','" + add.Price + "','" + add.UID + "',0,'"+add.Image+"',0);";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }
        public static int DeleteAddvertisement(string addid)
        {
            try
            {
                string sql = "delete from addvertisement where addid = '" + addid + "';";
                return DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
                return 0;
            }
        }

    }
}
