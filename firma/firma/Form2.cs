using firma.Classes;
using System.Data;
using System.Data.SqlClient;

namespace firma
{
    public partial class Form2 : Form
    {
        #region Nesne
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlCommand komut;
        DataTable dt = new DataTable();
        DataTable tbl = new DataTable();
        int fisno = 0;
        StokHarMain Stok = new StokHarMain();
        DS.dsStokHar ds = new DS.dsStokHar();


        #endregion

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //StokHarMain Stok = new StokHarMain(ds);
            //Stok.LoadData();

            //Bindings();
            //ConfigureCombo();
            





        }

        //Dataset Stok Main
        //  DataSet1TableAdapters.DataTable1TableAdapter dataTable = new DataSet1TableAdapters.DataTable1TableAdapter();   
        // DataSet1TableAdapters.DataTable1TableAdapter dtable = new DataSet1TableAdapters.DataTable1TableAdapter();

        #region 



        private void ConfigureCombo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, kod from Depo", baglanti);
            da.Fill(dt);
            comboDepo.ValueMember = "id";
            comboDepo.DisplayMember = "kod";
            comboDepo.DataSource = dt;
            dt.Clear();
            DataTable dt3 = new DataTable();
            da = new SqlDataAdapter("select id, kod from Firma", baglanti);
            da.Fill(dt);
            comboFirma.ValueMember = "id";
            comboFirma.DisplayMember = "kod";
            comboFirma.DataSource = dt;
        }

        // form2 datagridview double click
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 form3 = null;
            switch (e.ColumnIndex)
            {
                case 2:
                    form3 = new Form3("Urunler");
                    form3.ShowDialog();
                    dataGridView2.CurrentRow.Cells["urun_id"].Value = form3.GetId;
                    dataGridView2.CurrentRow.Cells["urun_kod"].Value = form3.GetKod;
                    break;
                case 4:
                    form3 = new Form3("Renk");
                    form3.ShowDialog();
                    dataGridView2.CurrentRow.Cells["renk_id"].Value = form3.GetId;
                    dataGridView2.CurrentRow.Cells["renk_kod"].Value = form3.GetKod;
                    break;
                case 6:
                    form3 = new Form3("Birim");
                    form3.ShowDialog();
                    dataGridView2.CurrentRow.Cells["birim_id"].Value = form3.GetId;
                    dataGridView2.CurrentRow.Cells["birim_kod"].Value = form3.GetKod;
                    break;
                default:
                    break;
            }
        }


        #endregion
        private void Bindings()
        {

            //SqlDataAdapter  da = new SqlDataAdapter("select sd.id, sd.fis_id, urun_kod = ur.kod ,sd.urun_id ,birim_kod =br.kod,sd.birim_id,renk_kod=rn.kod ,sd.renk_id ,sd.miktar from " +
            //       "StokDetaylar sd left outer join Urunler ur on(ur.id=sd.urun_id) " +
            //       "left outer join Birim br on(br.id = sd.birim_id) " +
            //       "left outer join Renk rn on(rn.id = sd.renk_id)  where fis_id = " + fisno, baglanti);
            //  da.Fill(ds.stokhardetail);
            //  dataGridView2.DataSource = ds.stokhardetail;


            //  da = new SqlDataAdapter("select a.fis_id,a.fis_no,a.belge_no,a.aciklama,firma_id=b.id," +
            //     "firma_kod=b.kod,depo_id=d.id,depo_kod=d.kod ,a.fis_tipi from  StokHareketleriMain a " +
            //     "left outer join Firma b on(b.id = a.firma_id) " +
            //     "left outer join Depo d on(d.id = a.depo_id) where fis_id =" + fisno, baglanti);
            //  da.Fill(ds.stokharmain);


            textFisno.DataBindings.Add(new Binding("Text", ds.stokharmain, "fis_no", true));
            textBelgeno.DataBindings.Add(new Binding("Text", ds.stokharmain, "belge_no", true));
            textAciklama.DataBindings.Add(new Binding("Text", ds.stokharmain, "aciklama", true));
            comboFirma.DataBindings.Add(new Binding("SelectedValue", ds.stokharmain, ds.stokharmain.firma_idColumn.ColumnName, true));
            comboFirma.DataBindings.Add(new Binding("SelectedItem", ds.stokharmain, ds.stokharmain.firma_kodColumn.ColumnName, true));
            comboFirma.DataBindings.Add(new Binding("text", ds.stokharmain, "firma_kod", true));
            comboDepo.DataBindings.Add(new Binding("SelectedValue", ds.stokharmain, ds.stokharmain.depo_idColumn.ColumnName, true));
            comboDepo.DataBindings.Add(new Binding("SelectedItem", ds.stokharmain, ds.stokharmain.depo_kodColumn.ColumnName, true));
            comboDepo.DataBindings.Add(new Binding("text", ds.stokharmain, "depo_kod", true));
            textFistipi.DataBindings.Add(new Binding("Text", ds.stokharmain, "fis_tipi", true));

            ////if (ds.stokharmain.Select("", "", DataViewRowState.CurrentRows).Length == 0)
            ////{
            ////    DataRow r = ds.stokharmain.NewRow();
            ////    r["fis_id"] = Stok.GetFisNo();
            ////    r["fis_no"] = Stok.GetFisNo().ToString("000000");
            ////    ds.stokharmain.Rows.Add(r);
            ////}
        }
        void MainCommand()
        {
            ds.stokharmain[0].EndEdit();
            foreach (DataRow r in ds.stokharmain.Rows)
            {
                switch (r.RowState)
                {
                    case DataRowState.Added:
                        //adptr2.InsertCommand = new SqlCommand("insert into StokHareketleriMain (fis_no,belge_no,aciklama,firma_id,depo_id,fis_tipi) " +
                        //    "values(@fis_no,@belge_no,@aciklama,@firma_id,@depo_id,@fis_tipi) ", baglanti);
                        //adptr2.InsertCommand.Par0ameters.Clear();
                        //adptr2.InsertCommand.Parameters.Add("@fis_no", SqlDbType.NVarChar, 20).Value = r["fis_no"];
                        //adptr2.InsertCommand.Parameters.Add("@belge_no", SqlDbType.Int, 50).Value = r["belge_no"];
                        //adptr2.InsertCommand.Parameters.Add("@aciklama", SqlDbType.NVarChar, 50).Value = r["aciklama"];
                        //adptr2.InsertCommand.Parameters.Add("@firma_id", SqlDbType.Int).Value = r["firma_id"];
                        //adptr2.InsertCommand.Parameters.Add("@depo_id", SqlDbType.Int).Value = r["depo_id"];
                        //adptr2.InsertCommand.Parameters.Add("@fis_tipi", SqlDbType.NVarChar, 50).Value = r["fis_tipi"];

                        break;
                    case DataRowState.Deleted:
                        //delete command
                        //adptr2.DeleteCommand = new SqlCommand("delete from StokHareketleriMain where fis_id = " + fisno, baglanti);
                        //// Add the parameters for the DeleteCommand.
                        //SqlParameter prmtr = adptr2.DeleteCommand.Parameters.Add("@fis_id", SqlDbType.Int, 20, "fis_id");
                        //prmtr.SourceVersion = DataRowVersion.Original;


                        break;
                    case DataRowState.Modified:
                        //update command
                        //adptr2.UpdateCommand = new SqlCommand("update sd set belge_no=@belge_no,aciklama=@aciklama," +
                        //    " firma_kod = b.kod, firma_id=@firma_id, depo_kod = d.kod, depo_id=@depo_id, fis_tipi=@fis_tipi from StokHareketleriMain sd " +
                        //    " left outer join Firma b on(b.id = a.firma_id) " +
                        //    "left outer join Depo b on(b.id = a.depo_id) " + "where fis_id=@fis_id ", baglanti);
                        //adptr2.UpdateCommand.Parameters.Clear();
                        //adptr2.UpdateCommand.Parameters.Add("@belge_no", SqlDbType.Int, 50).Value = r["belge_no"];
                        //adptr2.UpdateCommand.Parameters.Add("@aciklama", SqlDbType.NVarChar, 50).Value = r["aciklama"];
                        //adptr2.UpdateCommand.Parameters.Add("@firma_kod", SqlDbType.NVarChar, 50).Value = ds.stokharmain.firma_kodColumn.ToString();
                        //adptr2.UpdateCommand.Parameters.Add("@firma_id", SqlDbType.Int).Value = r["firma_id"];
                        //adptr2.UpdateCommand.Parameters.Add("depo_kod", SqlDbType.NVarChar, 50).Value = ds.stokharmain.depo_kodColumn.ToString();
                        //adptr2.UpdateCommand.Parameters.Add("@depo_id", SqlDbType.Int).Value = r["depo_id"];
                        //adptr2.UpdateCommand.Parameters.Add("@fis_tipi", SqlDbType.NVarChar, 50).Value = r["fis_tipi"];
                        //prmtr = komut.Parameters.Add("@fis_id", SqlDbType.Int, 20, "fis_id");
                        //prmtr.SourceVersion = DataRowVersion.Original;


                        break;
                }
            }
            ds.stokharmain.AcceptChanges();
        }




        //DataTable Listele()
        //{
        //    adptr = new SqlDataAdapter("select sd.id, sd.fis_id, urun_kod = ur.kod ,sd.urun_id ,birim_kod =br.kod,sd.birim_id,renk_kod=rn.kod ,sd.renk_id ,sd.miktar from " +
        //  "StokDetaylar sd left outer join Urunler ur on(ur.id=sd.urun_id) " +
        //  "left outer join Birim br on(br.id = sd.birim_id) " +
        //  "left outer join Renk rn on(rn.id = sd.renk_id)  where fis_id = " + fisno, baglanti);

        //    adptr.Fill(tbl);

        //    this.dataGridView2.DataSource = tbl;
        //    return tbl;
        //}


        private void SaveStokMain(SqlTransaction transaction)
        {
            // MainCommand();
            //if (Convert.ToInt32(textFisno.Text) == fisno)
            //{
            //    if (transaction != null)
            //    {
            //        adptr2.SelectCommand.Transaction = transaction;
            //        adptr2.InsertCommand.Transaction = transaction;
            //      //adptr2.UpdateCommand.Transaction = transaction;

            //        adptr2.Update(ds.stokharmain);
            //    }
            //    else
            //    {
            //        adptr2.Update(ds.stokharmain);
            //        //SqlClient.SqlDataAdapter.InsertCommand.get, 
            //    }
            //}
        }
        private void InsertDataGrid(SqlTransaction transaction = null)
        {
            //adptr = new SqlDataAdapter("select sd.id, sd.fis_id ,sd.urun_id,sd.birim_id,sd.renk_id ,sd.miktar  from" +
            //    " StokDetaylar sd where coalesce(fis_id, -1) <> -1 and fis_id = " + fisno, baglanti);

            //commandBuilder = new SqlCommandBuilder(adptr);
            //if (transaction != null)
            //{
            //    adptr.SelectCommand.Transaction = transaction;
            //    //adptr.InsertCommand.Transaction = transaction;
            //    //adptr.DeleteCommand.Transaction = transaction;
            //    //adptr.Update(ds.stokhardetail);
            //}
            //else
            //{
            //    //adptr.Update(ds.stokhardetail);
            //}

        }


        private void buttonKayit_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            // dtable.StokMainEkle( fisno,textFisno.Text,Convert.ToInt32( textBelgeno.Text),textAciklama.Text,Convert.ToInt32( comboFirma.Text),Convert.ToInt32(comboDepo.Text),textFistipi.Text );

            SqlTransaction trans = baglanti.BeginTransaction();//SQL bağlantımız için Transaction işlemini başlatıyoruz
            try
            {


                //Stok.SaveData(trans);
                ////    SaveStokMain(trans);
                //InsertDataGrid(trans);
                //trans.Commit();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                trans.Rollback();
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void TransButtonSil(SqlTransaction transaction)
        {
            //ds.stokharmain.Rows.Remove(ds.stokharmain.Rows[0]);
            //DataRow r = ds.stokharmain.Rows[0];
            //r.Delete();
            //MainCommand();
            //if (transaction != null)
            //{
            //    adptr2.DeleteCommand.Transaction = transaction;
            //    adptr2.Update(ds.stokharmain);
            //}
            //else
            //{
            //    adptr2.Update(ds.stokharmain);
            //}
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            SqlTransaction trans = baglanti.BeginTransaction();//SQL bağlantımız için Transaction işlemini başlatıyoruz
            try
            {
                //Stok.DeleteData(trans);
                //TransButtonSil(trans);
                trans.Commit();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                trans.Rollback();
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void DeleteDataGrid2()
        {
            baglanti.Open();
            string sorgu = "delete from StokDetaylar where id =urun_id=@urun_id";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urun_id", dataGridView2.CurrentRow.Cells["urun_kod"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }



        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*burda fis_id yi datagride ekleyecegiz*/
        private void dataGridView2_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
                dataGridView2.CurrentRow.Cells["fis_id"].Value = fisno;
        }




        #region çöp    
        //void ComboxDoldur()
        //{
        //    baglanti.Open();
        //    DataTable dtx = null;
        //    dtx = new DataTable();
        //    SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Urunler ", baglanti);
        //    sqlDa.Fill(dtx);
        //    urun_kod.ValueMember = "id";
        //    urun_kod.DisplayMember = "kod";
        //    //DataPropertyName = "kod";
        //    urun_kod.DataSource = dtx;

        //    dtx = new DataTable();
        //    sqlDa = new SqlDataAdapter("select * from Renk ", baglanti);
        //    sqlDa.Fill(dtx);
        //    renk_kod.ValueMember = "id";
        //    renk_kod.DisplayMember = "kod";
        //    renk_kod.DataSource = dtx;

        //    dtx = new DataTable();
        //    sqlDa = new SqlDataAdapter("select * from Birim ", baglanti);
        //    sqlDa.Fill(dtx);
        //    birim_kod.ValueMember = "id";
        //    birim_kod.DisplayMember = "kod";
        //    birim_kod.DataSource = dtx;

        //    baglanti.Close();
        //}
        /* private void ekle()
        {
            baglanti.Open();


            string sorgu = "select fis_id,urun_id,birim_id,renk_id,miktar from StokDetaylar value ( @fis_id, @urun_id, @birim_id, @renk_id, @miktar )   ";


            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@fis_id", fisno);
            komut.Parameters.AddWithValue("@urun_id",urun_id;
            komut.Parameters.AddWithValue("@birim_id", birim_id);
            komut.Parameters.AddWithValue("@renk_id", renk_id );
            komut.Parameters.AddWithValue("@miktar", miktar);
           // komut.Parameters.AddWithValue("@fis_tipi", textFistipi.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı.");

            baglanti.Close();
            //SqlDataAdapter adptr = new SqlDataAdapter("select sd.fis_id,sd.urun_id,ur.kod,sd.birim_id,sd.renk_id, sd.miktar from StokDetaylar sd inner join Urunler ur   on(sd.urun_id=ur.id)    ", baglanti);

            ////   adptr = new SqlDataAdapter("select fis_id,urun_id,birim_id,renk_id,miktar  from StokDetaylar where fis_id = " + fisno, baglanti);
            //commandBuilder = new SqlCommandBuilder(adptr);
            //adptr.Fill(dt);
            //dataGridView2.DataSource = dt;
            //this.dataGridView2.Columns["id"].Visible = false;

            //this.dataGridView2.DataSource = dt;
            ////Enable add, delete and edit
            //this.dataGridView2.AllowUserToAddRows = true;
            //this.dataGridView2.AllowUserToDeleteRows = true;
            //this.dataGridView2.ReadOnly = false;

            //BindingSource bSource = new BindingSource();
            //bSource.DataSource = dt;


            //dataGridView2.DataSource = bSource;
            //return dt;
        }
       */
        //private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (dataGridView2.CurrentCell.ColumnIndex == 5)
        //    {
        //        e.Control.KeyPress -= AllowNumbersOnly;
        //        e.Control.KeyPress += AllowNumbersOnly;
        //    }

        //}
        //private void AllowNumbersOnly(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //        e.Handled = true;
        //}


        //private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        //    //baglanti.Open();
        //    //if (dataGridView2.CurrentRow.Cells["fis_id"].Value != DBNull.Value)
        //    //{


        //    //    if (MessageBox.Show("silinsin mi ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //    //    {
        //    //        SqlCommand cmd = new SqlCommand("[StokDetaylarSilme]", baglanti);
        //    //        cmd.CommandType = CommandType.StoredProcedure;
        //    //        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView2.CurrentRow.Cells["fis_id"].Value));
        //    //        cmd.ExecuteNonQuery();
        //    //    }
        //    //    else
        //    //    {
        //    //        e.Cancel = true;
        //    //    }

        //    //}
        //    //else
        //    //    e.Cancel = true;
        //}
        #endregion

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
