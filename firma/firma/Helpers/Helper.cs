using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firma.Helpers
{
    public class Helper
    {

        //public static int MethodFisID(string tablename)
        //{
        //    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        //    int id = -1;
        //    baglanti.Open();
        //    SqlCommand cmm = new SqlCommand();
        //    cmm.Connection = baglanti;
        //    cmm.CommandText = "select fisid = max(id)+1 from  " + tablename;
        //    SqlDataReader reader = cmm.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        id = Convert.ToInt32(reader.GetValue("fisid"));
        //    }

        //    baglanti.Close();
        //    return id;
        //}

        public static int GetId(string tablename)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            int ID = -1;
            int id = 0;
            string tabloadi = "";
            baglanti.Open();
            cmm.Connection = baglanti;
            cmm.CommandText = "select id,tableName from idler where tableName='" + tablename + "'";
            cmm.Connection = baglanti;

            SqlDataReader reader = cmm.ExecuteReader();
            if (reader.Read())
            {
                ID = Convert.ToInt32(reader.GetValue("id"));
                tabloadi = reader.GetValue("tableName").ToString();
            }
            reader.Close();

            if (ID == -1)
            {
                ID = 1;

                cmm = new SqlCommand("insert into idler(id,tableName) values(@id,@tableName)", baglanti);
                // cmm.Connection = baglanti;
                cmm.Parameters.Add("@id", SqlDbType.Int, 20).Value = ID;
                cmm.Parameters.Add("@tableName", SqlDbType.NVarChar, 200).Value = tablename;
                cmm.ExecuteNonQuery();
                return ID;
            }
            else
            {
                ID += 1;
                cmm = new SqlCommand("update idler set id=@id where tableName = @tableName ", baglanti);
                cmm.Parameters.Add("@tableName", SqlDbType.NVarChar, 200).Value = tablename;
                cmm.Parameters.Add("@id", SqlDbType.Int, 20).Value = ID;
                cmm.ExecuteNonQuery();
                return ID;

            }




            baglanti.Close();
            // return ID;
        }
        /*
          SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
            SqlCommand cmm = new SqlCommand();
            int ID = -1;
            baglanti.Open();
            cmm.CommandText = "select id,tableName from idler where tableName = @tableName ";
            cmm.Connection = baglanti;
            SqlDataReader reader = cmm.ExecuteReader();



            cmm.CommandText = "select id from idler where tableName = @tableName ";
            cmm.Parameters.Add("@tableName", SqlDbType.NVarChar, 200).Value = tablename;

            reader = cmm.ExecuteReader();
            if (reader.Read())
            {
                ID = Convert.ToInt32(reader.GetValue("id"));
                string tabloadi=reader.GetValue(tablename).ToString();
            }
            reader.Close();
            cmm=new SqlCommand("update idler set id=id+1 where tableName = @tableName ", baglanti);
            cmm.Parameters.Add("@tableName", SqlDbType.NVarChar, 200).Value = tablename;
            cmm.ExecuteNonQuery();


           
            baglanti.Close();
            return ID;
         */
    }
    public class Result
    {
        public bool resultbool { get; set; } = true;
        public string resultmessage { get; set; } = "";
    }
}
