using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_ByG
{
    class Retrival
    {
        public void ShowUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UserNameGV, DataGridViewColumn PasswordGV, DataGridViewColumn PhoneGV , DataGridViewColumn EmailGV, DataGridViewColumn StatusGV,string data =null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                     cmd = new SqlCommand("st_getUsersData", MainClass.con);

                }
                else
                {
                     cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data",data);
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UserNameGV.DataPropertyName = dt.Columns["Username"].ToString();
                PasswordGV.DataPropertyName = dt.Columns["password"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["phone"].ToString();
                EmailGV.DataPropertyName = dt.Columns["email"].ToString();
                StatusGV.DataPropertyName = dt.Columns["status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {

            }
        }
        public void ShowCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn StatusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["category"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;

             }
            catch (Exception)
            {
                MainClass.ShowMSG("unable to category data", "Error", "Error");

            }
        }

        public void getCategoriesList(string proc,ComboBox cb,string displaymember,string valuemember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc,MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);
                cb.DisplayMember = displaymember;
                cb.ValueMember = valuemember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

                throw ;
            }
        }

        public void ShowProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV,DataGridViewColumn priceGV,DataGridViewColumn barGV,DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["product"].ToString();
                barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMSG("unable to category data", "Error", "Error");

            }
        }

        public static int USER_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_name=null,pass_word=null;
        private static bool checklogin;
        public static bool getUserDetail(string username,string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_GetUsersDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checklogin = true;
                    while (dr.Read())
                    {
                        
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["password"].ToString();
                    }
                    
                }
                else
                {
                    checklogin = false;
                    if (user_name!= null && pass_word!=null)
                    {
                        if (user_name!=username && pass_word==password)
                        {
                            MainClass.ShowMSG("Invalid Username","Error","Error");
                        }

                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Username/Password", "Error", "Error");
                        }

                    }
                }
                MainClass.con.Close();

            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Unable to Login" ,"Error" , "Error");
            }
            return checklogin;
        }

        public void getProductList(string proc, ComboBox pb, string displaymember, string valuemember)
        {
            try
            {
                pb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                pb.DisplayMember = displaymember;
                pb.ValueMember = valuemember;
                pb.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ShowStock(DataGridView gv, DataGridViewColumn StockIDGV, DataGridViewColumn SprodIDGV, DataGridViewColumn ProductNamepwGV, DataGridViewColumn PQuantityGV, DataGridViewColumn PurchaseRateGV, DataGridViewColumn PSalesRateGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_GetstockData", MainClass.con);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                StockIDGV.DataPropertyName = dt.Columns["Stock_ID"].ToString();
                PQuantityGV.DataPropertyName = dt.Columns["Stock_QTY"].ToString();
                PurchaseRateGV.DataPropertyName = dt.Columns["Purchase_Rate"].ToString();
                PSalesRateGV.DataPropertyName = dt.Columns["Sales_Rate"].ToString();
                SprodIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                ProductNamepwGV.DataPropertyName = dt.Columns["product"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MainClass.ShowMSG("unable to category data", "Error", "Error");

            }
        }



    }
}
    