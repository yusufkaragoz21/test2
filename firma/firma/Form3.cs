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

namespace firma
{
    public partial class Form3 : Form
    {
        #region tanimlar 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adptr;
        string tablename;
        DataTable tbl = new DataTable();
        DataTable dt = new DataTable();
        int fisno;
        int getid = 0;




        #endregion
        public int GetId { get { return getid; } set { getid = value; } }

        string Getkod = "";
        public string GetKod
        {
            get
            {
                return Getkod;
            }
            set
            {
                // dışardan gelen veri üzerinde hangi işlem yapılacaktır
                Getkod = value;
            }
        }

        public Form3(string tablename)
        {
            this.tablename = tablename;
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {



          
            GetList();
           // GetFisNo();
          

        }
      
     

     
        DataTable GetList()
        {
            tbl.Clear();
            adptr = new SqlDataAdapter("select id,  kod, aciklama from " + tablename, baglanti);
            adptr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            this.dataGridView1.Columns["id"].Visible = false;
            return tbl;
        }
        int GetFisNo()
        {
            baglanti.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = baglanti;
            cmm.CommandText = "select fisid = max(fis_id) from StokHareketleriMain ";
            SqlDataReader reader = cmm.ExecuteReader();

            if (reader.Read())
            {
                string aa = reader.GetValue("fisid").ToString();
                fisno = Convert.ToInt32(aa);

            }
            // textFisno.Text = fisno.ToString("000000");

            baglanti.Close();
            return fisno;
        }






        // form3 datagridview double  click
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetKod= dataGridView1.CurrentRow.Cells["kod"].Value.ToString();
            getid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            this.Close();
        }

      
    }


    
}
