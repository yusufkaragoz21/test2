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

namespace firma.Forms
{
    public partial class StokFisForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adapter = null;
        DataTable tbl = new DataTable();


        public StokFisForm()
        {
            InitializeComponent();
        }

        private void StokFis_Load(object sender, EventArgs e)
        {
            ViewFis();
        }

        private void ViewFis()
        {
            tbl.Clear();
            adapter = new SqlDataAdapter("select a.id,a.fis_no,a.belge_no,a.aciklama,firma_id=b.id," +
             "firma_kod=b.kod,depo_id=d.id,depo_kod=d.kod ,a.fis_tipi from  StokHareketleriMain a " +
             "left outer join Firma b on(b.id = a.firma_id) " +
             "left outer join Depo d on(d.id = a.depo_id) ", baglanti);
            adapter.Fill(tbl);
            dataGridFis.DataSource = tbl;
        }


        private void btnNewSave_Click(object sender, EventArgs e)
        {
            int a = -1;
            StokHarForm ss = new StokHarForm(a);
            ss.MdiParent = this.MdiParent;
            ss.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridFis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridFis.Rows[e.RowIndex].Cells[0].Value;

            StokHarForm ss = new StokHarForm(id);
            ss.MdiParent = this.MdiParent;
            ss.Show();
        }
    }
}
