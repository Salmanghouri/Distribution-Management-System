using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_ByG
{
    class Insertion
    {
        //user insertiom

        public void InsertUser(string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@psw", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }

        //category insertion

        public void InsertCat(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }

        //product insertion

        public void InsertProduct(string product, string barcode, float price, DateTime? expiry, int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_ProductInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " added to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }
        }

        //Stock Insertion
        public void InsertStock(int stokproID,float Quantity,float purchaserate,float salesrate )
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_StockInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Stockqty", Quantity);
                cmd.Parameters.AddWithValue("@purchaserate", purchaserate);
                cmd.Parameters.AddWithValue("@salesrate", salesrate);
                cmd.Parameters.AddWithValue("@sto_proID", stokproID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(stokproID + " added to the system successfully..", "Success..", "Sucess");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
    }
}
