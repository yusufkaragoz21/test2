using firma.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace firma.Classes
{
    public class StokHarDetail
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlCommand komut;
        SqlDataAdapter adapter = null;
        DS.dsStokHar ds = null;
        int fisno;
        StokHarMain Stok = null;
        int i=0;

        public DataSet Ds { get { return this.ds; } }

        public StokHarDetail(dsStokHar ds)
        {
            this.ds = ds;
        }
        public StokHarDetail()
        {

        }

        public void LoadDataDetail()
        {
            //StokHarMain Stok = new StokHarMain(ds);
            //SqlDataAdapter da = new SqlDataAdapter("select sd.id, sd.fis_id, urun_kod = ur.kod ,sd.urun_id ,birim_kod =br.kod,sd.birim_id,renk_kod=rn.kod ,sd.renk_id ,sd.miktar from " +
            //       "StokDetaylar sd left outer join Urunler ur on(ur.id=sd.urun_id) " +
            //       "left outer join Birim br on(br.id = sd.birim_id) " +
            //       "left outer join Renk rn on(rn.id = sd.renk_id)  where fis_id = " + fisno, baglanti);
            //da.Fill(ds.stokhardetail);


        }
        public void SaveData(SqlTransaction transaction)
        {
            //baglanti.Open();
            ////     ds.stokhardetail[i].EndEdit();
            //foreach (DataRow r in ds.stokhardetail.Rows)
            //{
            //    r.EndEdit();
            //    switch (r.RowState)
            //    {
            //        case DataRowState.Unchanged:
            //            break;
            //        case DataRowState.Added:
                
            //            komut = new SqlCommand("insert into StokDetaylar(fis_id, urun_id, birim_id, renk_id, miktar) " +
            //                "values(@fis_id,@urun_id,@birim_id,@renk_id,@miktar)", baglanti);
            //            komut.Parameters.Add("fis_id", SqlDbType.Int, 20).Value = r["fis_id"];
            //            komut.Parameters.Add("urun_id", SqlDbType.Int, 20).Value = r["urun_id"];
            //            komut.Parameters.Add("birim_id", SqlDbType.Int, 20).Value = r["birim_id"];
            //            komut.Parameters.Add("renk_id", SqlDbType.Int, 20).Value = r["renk_id"];
            //            komut.Parameters.Add("miktar", SqlDbType.NVarChar, 50).Value = r["miktar"];
            //            komut.ExecuteNonQuery();
                      
            //            break;
            //        case DataRowState.Modified:
            //            komut = new SqlCommand("update StokDetaylar set urun_id=@urun_id,birim_id=@birim_id,renk_id=@renk_id," +
            //                "miktar=@miktar_id" + "where fis_id=@fis_id", baglanti);
            //            komut.Parameters.Add("urun_id", SqlDbType.Int, 20).Value = r["urun_id"];
            //            komut.Parameters.Add("birim_id", SqlDbType.Int, 20).Value = r["birim_id"];
            //            komut.Parameters.Add("renk_id", SqlDbType.Int, 20).Value = r["renk_id"];
            //            komut.Parameters.Add("miktar", SqlDbType.NVarChar, 50).Value = r["miktar"];
            //            komut.Parameters.Add("@fis_id", SqlDbType.Int, 20).Value = Stok.FisID;

            //            komut.ExecuteNonQuery();
            //            break;
            //        case DataRowState.Deleted:
            //            komut = new SqlCommand("delete from StokDetaylar where id =urun_id=@urun_id", baglanti);
            //            komut.Parameters.Add("@fis_id", SqlDbType.Int, 20).Value = Stok.FisID;

            //            komut.ExecuteNonQuery();
            //            break;

            //    }
              

            //}
            //ds.stokhardetail.AcceptChanges();
            //baglanti.Close();





            #region cop
            //adapter = new SqlDataAdapter("select sd.id, sd.fis_id ,sd.urun_id,sd.birim_id,sd.renk_id ,sd.miktar  from" +
            //    " StokDetaylar sd where coalesce(fis_id, -1) <> -1 and fis_id = " + fisno, baglanti);
            //commandBuilder = new SqlCommandBuilder(adapter);

            //adapter.Update(ds.stokhardetail);

            //if ( transaction != null)
            //{
            //    adapter.SelectCommand.Transaction = transaction;
            //    adapter.InsertCommand.Transaction = transaction;
            //    adapter.DeleteCommand.Transaction = transaction;
            //    adapter.Update(ds.stokhardetail);
            //}
            //else
            //{
            //    adapter.Update(ds.stokhardetail);
            //}
            #endregion

        }
        private void CrudDetail()
        {
            //foreach(DataRow r in ds.stokhardetail.Rows)
            //{
            //    switch (r.RowState)
            //    {
            //        case DataRowState.Added:
            //   DataRow r = ds.stokharmain.Rows[0];
            //    }

            //}
        }



    }
}
