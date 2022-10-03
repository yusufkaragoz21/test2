using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using firma.Classes;

namespace firma.Forms
{
    public partial class StokHarForm : Form
    {
        #region Nesne
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");


        SqlDataAdapter adapter = new SqlDataAdapter();
        int fisno = 0;
        StokHarMain Stok = null;
        //  StokHarDetail StokDetail = null;

        #endregion
        public StokHarForm(int fisno)
        {
            this.fisno = fisno;
            InitializeComponent();
        }


        private void StokHarForm_Load(object sender, EventArgs e)
        {
            Stok = new StokHarMain();
            Stok.Id = fisno;  //fis formdan seçtiğim fisin fis id sini clasa gönderiyorum
            Stok.LoadData();
            //StokDetail = new StokHarDetail(ds);
            //StokDetail.LoadDataDetail();
            Bindings();
            ConfigureCombo();
        }
        private void Bindings()
        {
            //DataRow row = ds.stokhardetail.NewRow();
            //row["id"] = Stok.Id;
            //ds.stokhardetail.Rows.Add(row);
            dataGridDetaylar.DataSource = Stok.Ds.stokhardetail; //datagridDetail binding

            text_fis_no.DataBindings.Add(new Binding("Text", Stok.Ds.stokharmain, "fis_no", true));
            text_belge_no.DataBindings.Add(new Binding("Text", Stok.Ds.stokharmain, "belge_no", true));
            text_aciklama.DataBindings.Add(new Binding("Text", Stok.Ds.stokharmain, "aciklama", true));
            comboFirma.DataBindings.Add(new Binding("SelectedValue", Stok.Ds.stokharmain, "firma_id", true));
            comboFirma.DataBindings.Add(new Binding("text", Stok.Ds.stokharmain, "firma_kod", true));
            comboDepo.DataBindings.Add(new Binding("SelectedValue", Stok.Ds.stokharmain, "depo_id", true));
            comboDepo.DataBindings.Add(new Binding("text", Stok.Ds.stokharmain, "depo_kod", true));
            text_fis_tipi.DataBindings.Add(new Binding("Text", Stok.Ds.stokharmain, "fis_tipi", true));

            if (Stok.Ds.stokharmain.Select("", "", DataViewRowState.CurrentRows).Length == 0)
            {

                //Stok.FisID = Helpers.Helper.MethodFisID("StokHareketleriMain");
                //DataRow r = Stok.Ds.stokharmain.NewRow();
                //r["id"] = Stok.FisID;
                //r["fis_no"] = Stok.FisID.ToString("000000");
                //Stok.Ds.stokharmain.Rows.Add(r);

            }
            if (Stok.Ds.stokhardetail.Select("", "", DataViewRowState.CurrentRows).Length == 0)
            {
                ////detay id için 
                //Stok.Id = Helpers.Helper.MethodID("StokDetaylar");

                //////string a = "select id from idler where tableName ='StokDetaylar'    ";
                //////Stok.Id =Stok.GetId();
                //DataRow row = ds.stokhardetail.NewRow();
                //row["id"] = Stok.Id;
                //ds.stokhardetail.Rows.Add(row);
            }
        }
        private void ConfigureCombo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, kod from Depo", baglanti);
            da.Fill(dt);
            comboDepo.ValueMember = "id";
            comboDepo.DisplayMember = "kod";
            comboDepo.DataSource = dt;

            DataTable dt2 = new DataTable();
            da = new SqlDataAdapter("select id, kod from Firma", baglanti);
            da.Fill(dt2);
            comboFirma.ValueMember = "id";
            comboFirma.DisplayMember = "kod";
            comboFirma.DataSource = dt2;
        }
        /*
        public struct Validate
        {
            public string name { get; set; }
            public bool IsFinished { get; set; }
        }
        */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var r = Stok.Validate();
            if (!r.resultbool)
            {
                MessageBox.Show(r.resultmessage);return;
            }
            baglanti.Open();
            SqlTransaction trans = baglanti.BeginTransaction();//SQL bağlantımız için Transaction işlemini başlatıyoruz
            Stok.SaveData(trans);
            baglanti.Close();
        }

        private void dataGridDetaylar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 form3 = null;
            switch (e.ColumnIndex)
            {
                case 2:
                    form3 = new Form3("Urunler");
                    form3.ShowDialog();
                    dataGridDetaylar.CurrentRow.Cells["urun_id"].Value = form3.GetId;
                    dataGridDetaylar.CurrentRow.Cells["urun_kod"].Value = form3.GetKod;
                    break;
                case 4:
                    form3 = new Form3("Renk");
                    form3.ShowDialog();
                    dataGridDetaylar.CurrentRow.Cells["renk_id"].Value = form3.GetId;
                    dataGridDetaylar.CurrentRow.Cells["renk_kod"].Value = form3.GetKod;
                    break;
                case 6:
                    form3 = new Form3("Birim");
                    form3.ShowDialog();
                    dataGridDetaylar.CurrentRow.Cells["birim_id"].Value = form3.GetId;
                    dataGridDetaylar.CurrentRow.Cells["birim_kod"].Value = form3.GetKod;
                    break;
                default:
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            // if (textBox_Results != null && !string.IsNullOrWhiteSpace(textBox_Results.Text))

            SqlTransaction trans = baglanti.BeginTransaction();//SQL bağlantımız için Transaction işlemini başlatıyoruz
            Stok.DeleteData(trans);
            this.Close();
            baglanti.Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*burda fis_id yi datagride ekleyecegiz*/
        private void dataGridDetaylar_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (dataGridDetaylar.Rows.Count > 0)
            //{
            //    dataGridDetaylar.CurrentRow.Cells["fis_id"].Value = Stok.FisID;
            //}

        }

        private void dataGridDetaylar_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //if (dataGridDetaylar.CurrentRow != null)
            //{
            //    //if (dataGridDetaylar.CurrentRow.Cells["id"].Value == DBNull.Value)
            //        dataGridDetaylar.CurrentRow.Cells["id"].Value = Helpers.Helper.MethodID("StokDetaylar");
            //}


        }






        //public void IdCek()
        //{
        //    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        //    int id = -1;
        //    baglanti.Open();
        //    SqlCommand cmm = new SqlCommand();
        //    cmm.Connection = baglanti;
        //    string tablename = "StokDetaylar";
        //    cmm.CommandText = "select id from idler where tableName = "+tablename ;
        //    SqlDataReader reader = cmm.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        id = Convert.ToInt32(reader.GetValue("id"));
        //    }

        //    baglanti.Close();
        //}
    }
}
