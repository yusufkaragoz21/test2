using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace firma
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P2C9SBB\\SQLEXPRESS;Initial Catalog=KeyFirma;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adptr;
        string tablename;
        DataTable tbl = new DataTable();

        public Form1(string tablename)
        {
            this.tablename = tablename;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetList();
        }



        DataTable GetList()
        {
            tbl.Clear();
            adptr = new SqlDataAdapter("select id, kod, aciklama from " + tablename, baglanti);
            adptr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            this.dataGridView1.Columns["id"].Visible = false;
            return tbl;
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(adptr);
            adptr.Update(tbl);
            GetList();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     



















        /*
   public void veri_sil(int id)
   {
       string query = "delete from "+tablename+" where id=@id";
       SqlCommand komut =new SqlCommand(query,baglanti);
       baglanti.Open();
       komut.Parameters.AddWithValue("@id", id);
       komut.ExecuteNonQuery();
       baglanti.Close();

   }
   //ekle
   private void button3_Click(object sender, EventArgs e)
   {

       SqlConnection baglanti =this.baglanti;
       baglanti.Open();
       if (baglanti.State == System.Data.ConnectionState.Open)
       {              
           string query = " insert into " + tablename + "(kod,aciklama) values('" + textBox5.Text + "','"+textBox6.Text+"')";
           SqlCommand komut = new SqlCommand(query, baglanti);
           komut.ExecuteNonQuery();
           MessageBox.Show("Eklendi");
           baglanti.Close();
       }
   }

   private void button4_Click(object sender, EventArgs e)
   {
       DataTable dt = new DataTable();  
       SqlConnection baglanti = this.baglanti;
       baglanti.Open();
       if (baglanti.State == System.Data.ConnectionState.Open)
       {

           SqlDataAdapter da = new SqlDataAdapter("select * from " + tablename + "", baglanti);
           da.Fill(dt);    
           dataGridView1.DataSource = dt;
           baglanti.Close();
       }
   }
   public void veri_getir()
   {
       DataTable dt = new DataTable();
       SqlConnection baglanti = this.baglanti;
       baglanti.Open();
       if (baglanti.State == System.Data.ConnectionState.Open)
       {
           SqlDataAdapter da = new SqlDataAdapter("select * from " + tablename + "", baglanti);
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           baglanti.Close();
       }

   }
   int i=0;
   private void button5_Click(object sender, EventArgs e)
   {
       SqlConnection baglanti = this.baglanti;
       baglanti.Open();
       if (baglanti.State == System.Data.ConnectionState.Open)
       {
           string query = "update " + tablename + " set kod=@kod,aciklama=@aciklama where id=@id";
           SqlCommand komut = new SqlCommand(query, baglanti);
           komut.Parameters.AddWithValue("@kod", textBox5.Text);
           komut.Parameters.AddWithValue("@aciklama", textBox6.Text);
           komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);

           komut.ExecuteNonQuery();
           MessageBox.Show("guncellendi");
           baglanti.Close();
           veri_getir();

       }

   }

   private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
   {
       i = e.RowIndex;
       textBox5.Text= dataGridView1.Rows[i].Cells[1].Value.ToString();
       textBox6.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

   }

   private void button6_Click(object sender, EventArgs e)
   {
       foreach(DataGridViewRow row in dataGridView1.SelectedRows)
       {
           int id =Convert.ToInt32(row.Cells[0].Value.ToString());
           veri_sil(id);
           veri_getir();
       }
   }*/












        /*
        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = this.baglanti;
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = " insert into Renk(kod,aciklama) values('" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlCommand komut = new SqlCommand(query, baglanti);
                //komut.ExecuteNonQuery();
                MessageBox.Show("Renk Eklendi");
                baglanti.Close();
            }
        }

        //renk silme
        public void renk_sil(int id)
        {
            string query = "delete from Renk where id=@id";
            SqlCommand komut = new SqlCommand(query, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void renk_getir()
        {
            DataTable dt = new DataTable();
            SqlConnection baglanti = this.baglanti;
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Renk", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }

        }
        private void silmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                renk_sil(id);
                renk_getir();
            }
        }

        //renk guncelle
        private void güncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = this.baglanti;
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = "update Renk set kod=@kod,aciklama=@aciklama where id=@id";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.Parameters.AddWithValue("@kod", textBox5.Text);
                komut.Parameters.AddWithValue("@aciklama", textBox6.Text);
                komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("renkler guncellendi");
                baglanti.Close();
                renk_getir();

            }

        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection baglanti = this.baglanti;
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from Renk", baglanti);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
        }*/
    }
}