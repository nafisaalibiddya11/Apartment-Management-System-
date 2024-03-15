using ApartmentManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManagement.Repository
{
    class UserAdvertisementRepository
    {
        private DataSet Ds { get; set; }

        public static DataSet GetAllAddDataSet(string id)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.uid='" + id + "';";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetAllAddDataSet2()
        {
            try
            {
                string sql = "select * from Addvertisement,users where Addvertisement.uid = users.id AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetAllAddDataSet3(int index)
        {
            try
            {
                string sql = "select * from Addvertisement, users where Addvertisement.uid = users.id AND status=0;";
                switch (index.ToString())
                {
                    case "0":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=20000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "1":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=40000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "2":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=60000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "3":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=80000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "4":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=100000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "5":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=4000000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "6":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=7000000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "7":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price <=10000000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                    case "8":
                        sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.price >=10000000 AND Addvertisement.status = 0 AND rid IS null;";
                        return DataAccess.GetDataSet(sql);
                }
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetAllAddDataSet4(string text)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.status = 0 AND Addvertisement.Location LIKE '%" + text + "%' AND rid IS null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetAllAddDataSetChanged(string id, string text)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.uid='" + id + "' And Addvertisement.status = 0 AND ((addid like '%" + text + "%' ) OR (rid like '%" + text + "%' )) ;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetRequestAddDataSet(string id)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.rid And Addvertisement.uid='" + id + "' AND status = 0 And Addvertisement.rid IS Not null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetRequestAddDataSetChanged(string id, string text)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.uid='" + id + "'And Addvertisement.status = 0 AND ((addid like '%" + text + "%' and rid IS Not null) OR (rid like '%" + text + "%' AND rid IS Not null)) ;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetConfirmAddDataSet(string id)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.rid And Addvertisement.uid='" + id + "'AND status = 1 And Addvertisement.rid IS Not null;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetConfirmAddDataSetChanged(string id, string text)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.uid='" + id + "'And Addvertisement.status = 1 AND ((addid like '%" + text + "%' ) OR (rid like '%" + text + "%' )) ;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataSet GetRequestedAddDataSet(string id)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.rid='" + id + "'AND status = 0;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetRequestedAddDataSetChanged(string id, string text)
        {
            try
            {
                string sql = "select* from users,Addvertisement where users.id = Addvertisement.uid And Addvertisement.rid = '" + id + "'AND status = 0 And (name like '%" + text + "%' OR id like '%" + text + "%' OR addid like '%" + text + "%' OR contactno like '%" + text + "%');";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static DataSet GetConfirmedAddDataSet(string id)
        {
            try
            {
                string sql = "select * from users,Addvertisement where users.id=Addvertisement.uid And Addvertisement.rid='" + id + "'AND status = 1;";
                return DataAccess.GetDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataSet GetConfirmedAddDataSetChanged(string id, string text)
        {
            try
            {
                string sql = "select* from users,Addvertisement where users.id = Addvertisement.uid And Addvertisement.rid = '" + id + "'AND status = 1 And (name like '%" + text + "%' OR id like '%" + text + "%' OR addid like '%" + text + "%' OR contactno like '%" + text + "%');";
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
