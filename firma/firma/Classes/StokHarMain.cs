using firma.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using firma.Helpers;

namespace firma.Classes
{
    public class StokHarMain
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlCommand komut;
        SqlDataAdapter adapter = null;
        DS.dsStokHar ds = null;
        int id = -1;

        //public int FisID
        //{
        //    set { fisid = value; }
        //    get { return fisid; }
        //}
        #region Proprty
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public DS.dsStokHar Ds { get { return this.ds; } }
        #endregion


        #region Constrac

        public StokHarMain(dsStokHar ds)
        {
            this.ds = ds;
            Init();
        }
        public StokHarMain()
        {
            this.ds = new dsStokHar();
            Init();
        }
        #endregion
        private void Init()
        {
            this.ds.stokhardetail.RowChanged += Stokhardetail_RowChanged;
        }
        private void Stokhardetail_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add)
            {
                if (e.Row["id"] == DBNull.Value || e.Row["id"] == null)
                    e.Row["id"] = Helpers.Helper.GetId("StokDetaylar");
                if (e.Row["fis_id"] == DBNull.Value || e.Row["fis_id"] == null)
                    e.Row["fis_id"] = Id;
            }
        }


        //En son yüklendiğinden DataSet veya çağrıldığından beri AcceptChanges()
        //yapılan tüm değişiklikleri içeren öğesinin bir kopyasını alır.


        public void LoadData()
        {
            if (id > 0)
            {
                adapter = new SqlDataAdapter("select a.id,a.fis_no,a.belge_no,a.aciklama,firma_id=b.id," +
                   "firma_kod=b.kod,depo_id=d.id,depo_kod=d.kod ,a.fis_tipi from  StokHareketleriMain a " +
                   "left outer join Firma b on(b.id = a.firma_id) " +
                   "left outer join Depo d on(d.id = a.depo_id) where a.id =" + id, baglanti);
                adapter.Fill(ds.stokharmain);

                StokHarMain Stok = new StokHarMain(ds);

                SqlDataAdapter da = new SqlDataAdapter("select sd.id, sd.fis_id, urun_kod = ur.kod ,sd.urun_id ," +
                    "birim_kod =br.kod,sd.birim_id,renk_kod=rn.kod ,sd.renk_id ,sd.miktar from " +
                       "StokDetaylar sd left outer join Urunler ur on(ur.id=sd.urun_id) " +
                       "left outer join Birim br on(br.id = sd.birim_id) " +
                       "left outer join Renk rn on(rn.id = sd.renk_id)    where fis_id = " + id, baglanti);

                da.Fill(ds.stokhardetail);
            }
            if (id < 0)//yeni kayıt
            {
                Id = Helpers.Helper.GetId("StokHareketleriMain");
                DataRow r = Ds.stokharmain.NewRow();
                r["id"] = Id;
                r["fis_no"] = Id.ToString("000000");
                Ds.stokharmain.Rows.Add(r);
            }
            #region çöp
            //komut.Parameters.Add("@id", SqlDbType.Int, 20,);
            /*
             SqlCommand cmdekle = new SqlCommand("INSERT INTO MusteriBilgileri(Adi,Soyadi,Telefon,Adres)
            VALUES (@Adi,@Soyadi,@Telefon,@Adres); select ident_current('musteribilgileri')", cnn);
          //  komut.Parameters.Add("@id", SqlDbType.Int, 20).Value = a ;
                                    //komut.Parameters.Add("@id", SqlDbType.Int, 20).Value = id;

            cmdekle.Parameters.Add("@Adi", txtAd.Text);
            cmdekle.Parameters.Add("@Soyadi", txtSoyad.Text);
            cmdekle.Parameters.Add("@Telefon", txtTel.Text);
            cmdekle.Parameters.Add("@Adres", txtAdres.Text);
            int id = cmd.ExecuteScalar();

            SqlCommand cmdeklebelge = new SqlCommand("insert into.......musteriid=@musteriid", cnn);
            cmdeklebelge.Paremeters.AddWithValue("@musteriid",id);  
            ..

            cmdeklebelge.ExecuteNonQuery(); 
             */
            #endregion

        }
        public void SaveData(SqlTransaction trans)
        {
            //if (!Validate())
            //{
            //    return;
            //}
            try
            {
                CreateData();
                CreateDataDetail();
                trans.Commit();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                trans.Rollback();
            }
            finally
            {
            }
        }
        public void DeleteData(SqlTransaction trans)
        {
            try
            {
                DeleteDetail();
                DeleteMain();
                trans.Commit();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                trans.Rollback();
            }
            finally
            {
                MessageBox.Show("silindi");
            }
            #region command delete
            //ds.stokharmain.Rows.Remove(ds.stokharmain.Rows[0]);
            //DataRow r = ds.stokharmain.Rows[0];
            //r.Delete();
            //CreateData();
            //if (transaction != null)
            //{
            //    adapter.DeleteCommand.Transaction = transaction;
            //    adapter.Update(ds.stokharmain);
            //}
            //else
            //{
            //    adapter.Update(ds.stokharmain);
            //}
            #endregion
        }
        private void DeleteMain()
        {
            baglanti.Open();
            komut = new SqlCommand("delete from StokHareketleriMain where id =" + Id, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void DeleteDetail()
        {
            baglanti.Open();
            komut = new SqlCommand("delete from StokDetaylar where fis_id =" + Id, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public  Result Validate()
        {
          //  string txtismi = "";
            foreach (DataRow r in ds.stokharmain.Rows)
            {
                if (r["belge_no"].ToString().Trim() == "")
                {
                    return new Result { resultbool = false, resultmessage = "Belge no boş olamaz!" };
                    
                }
                if (r["aciklama"].ToString().Trim() == "")
                {
                    return new Result { resultbool = false, resultmessage = "Açıklama boş olamaz!" };
                    
                }
                if (r["firma_id"].ToString().Trim() == "")
                {
                    return new Result { resultbool = false, resultmessage = "Firma boş olamaz!" };
                }
                if (r["depo_id"].ToString().Trim() == "")
                {
                    //if (r["depo_id"].ToString().Trim() == null) 
                    //{//property den önce 
                    //    MessageBox.Show("depo boş olamaz !");
                    //    return false;
                    //}

                    return new Result { resultbool = false, resultmessage = "Depo boş olamaz!" };
                }
                if (r["fis_tipi"].ToString().Trim() == "")
                {
                    return new Result { resultbool = false, resultmessage = "fis tipi boş olamaz!" };
                }
            }
            return new Result { resultbool = true, resultmessage = "" };
        }
        private void ValidateDelete()
        {

        }
        public void CreateData()
        {
            baglanti.Open();
            //stok main 
            ds.stokharmain[0].EndEdit();
            foreach (DataRow r in ds.stokharmain.Rows)
            {
                switch (r.RowState)
                {
                    case DataRowState.Added:
                        komut = new SqlCommand("insert into StokHareketleriMain (id,fis_no,belge_no,aciklama,firma_id,depo_id,fis_tipi) " +
                            "values(@id,@fis_no,@belge_no,@aciklama,@firma_id,@depo_id,@fis_tipi) ", baglanti);
                        komut.Parameters.Clear();
                        komut.Parameters.AddWithValue("@id", r["id"]);
                        komut.Parameters.Add("@fis_no", SqlDbType.NVarChar, 20).Value = r["fis_no"];
                        komut.Parameters.Add("@belge_no", SqlDbType.Int, 50).Value = r["belge_no"];
                        komut.Parameters.Add("@aciklama", SqlDbType.NVarChar, 50).Value = r["aciklama"];
                        komut.Parameters.Add("@firma_id", SqlDbType.Int).Value = r["firma_id"];
                        komut.Parameters.Add("@depo_id", SqlDbType.Int).Value = r["depo_id"];
                        komut.Parameters.Add("@fis_tipi", SqlDbType.NVarChar, 50).Value = r["fis_tipi"];
                        komut.ExecuteNonQuery();
                        break;
                    case DataRowState.Deleted:
                        adapter.DeleteCommand = new SqlCommand("delete from StokHareketleriMain where id = @id", baglanti);
                        adapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 20).Value = r["id"];
                        komut.ExecuteNonQuery();
                        break;
                    case DataRowState.Modified:
                        komut = new SqlCommand("update StokHareketleriMain set  belge_no=@belge_no,aciklama=@aciklama," +
                             " firma_id=@firma_id, depo_id=@depo_id, fis_tipi=@fis_tipi   " + "where id=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", r["id"]);
                        komut.Parameters.Add("@belge_no", SqlDbType.Int, 50).Value = r["belge_no"];
                        komut.Parameters.Add("@aciklama", SqlDbType.NVarChar, 50).Value = r["aciklama"];
                        komut.Parameters.Add("@firma_id", SqlDbType.Int).Value = r["firma_id"];
                        komut.Parameters.Add("@depo_id", SqlDbType.Int).Value = r["depo_id"];
                        komut.Parameters.Add("@fis_tipi", SqlDbType.NVarChar, 50).Value = r["fis_tipi"];
                        komut.ExecuteNonQuery();
                        break;
                }
            }
            ds.stokharmain.AcceptChanges();
            baglanti.Close();
        }
        public void CreateDataDetail()
        {
            baglanti.Open();
            foreach (DataRow r in ds.stokhardetail.Rows)
            {
                r.EndEdit();
                switch (r.RowState)
                {
                    case DataRowState.Unchanged:
                        break;
                    case DataRowState.Added:
                        komut = new SqlCommand("insert into StokDetaylar(id, fis_id, urun_id, birim_id, renk_id, miktar) " +
                            "values(@id, @fis_id, @urun_id, @birim_id, @renk_id, @miktar)", baglanti);
                        komut.Parameters.Add("@id", SqlDbType.Int, 20).Value = r["id"];
                        komut.Parameters.Add("@fis_id", SqlDbType.Int, 20).Value = r["fis_id"];
                        komut.Parameters.Add("@urun_id", SqlDbType.Int, 20).Value = r["urun_id"];
                        komut.Parameters.Add("@birim_id", SqlDbType.Int, 20).Value = r["birim_id"];
                        komut.Parameters.Add("@renk_id", SqlDbType.Int, 20).Value = r["renk_id"];
                        komut.Parameters.Add("@miktar", SqlDbType.NVarChar, 50).Value = r["miktar"];
                        komut.ExecuteNonQuery();
                        break;
                    case DataRowState.Modified:
                        ds.stokhardetail[0].EndEdit();

                        komut = new SqlCommand("update StokDetaylar set urun_id=@urun_id,birim_id=@birim_id" +
                            ",renk_id=@renk_id, miktar=@miktar " + "where id=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", r["id"]);
                        komut.Parameters.Add("@urun_id", SqlDbType.Int, 20).Value = r["urun_id"];
                        komut.Parameters.Add("@birim_id", SqlDbType.Int, 20).Value = r["birim_id"];
                        komut.Parameters.Add("@renk_id", SqlDbType.Int, 20).Value = r["renk_id"];
                        komut.Parameters.Add("@miktar", SqlDbType.NVarChar, 20).Value = r["miktar"];
                        komut.ExecuteNonQuery();
                        break;
                    case DataRowState.Deleted:
                        komut = new SqlCommand("delete from StokDetaylar where id =@id", baglanti);

                        komut.Parameters.Add("@id", SqlDbType.Int, 20).Value = r["id"];

                        komut.ExecuteNonQuery();
                        break;
                }
            }
            ds.stokhardetail.AcceptChanges();
            baglanti.Close();
        }

        //public int GetId()
        //{
        //    int id = -1;
        //    baglanti.Open();
        //    SqlCommand cmm = new SqlCommand();
        //    cmm.Connection = baglanti;
        //    cmm.CommandText = "select fisid = max(fis_id)+1 from StokHareketleriMain ";
        //    SqlDataReader reader = cmm.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        id = Convert.ToInt32(reader.GetValue("fisid"));
        //    }

        //    baglanti.Close();
        //    return id;
        //}


    }
}

