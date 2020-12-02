using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_ByG
{
    class Updation
    {
        public void updateUser(int id, string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@psw", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " Updated to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }
        public void updateCat(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }
        public void updateProduct(int proID, string product, string barcode, float price, DateTime? expiry, int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " Updated to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }
        public void UpdateStock(int stockid,int stokproID, float Quantity, float purchaserate, float salesrate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_Stokupdatedsg", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Stockqty", Quantity);
                cmd.Parameters.AddWithValue("@purchaserate", purchaserate);
                cmd.Parameters.AddWithValue("@salesrate", salesrate);
                cmd.Parameters.AddWithValue("@sto_proID", stokproID);
                cmd.Parameters.AddWithValue("@stockid", stockid);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(stokproID + " Update to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }

    }
}

