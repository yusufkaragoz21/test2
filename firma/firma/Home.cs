using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using firma.Forms;
namespace firma
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Urunler");
            form1.MdiParent = this ;
            form1.Show();

        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Renk");
            form1.MdiParent = this;
            form1.Show();
        }

        private void birimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Birim");
            form1.MdiParent= this;
            form1.Show();
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Depo");
            form1.MdiParent = this;
            form1.Show();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1("Firma");
            form1.MdiParent = this;
            form1.Show();
        }

        private void girisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.MdiParent = this;
            //form2.Show();
            /*
            StokHarForm ss=new StokHarForm();
            ss.MdiParent = this;
            ss.Show();
            */
            StokFisForm sf = new StokFisForm();
            sf.MdiParent = this;
            sf.Show();



        }

       
    }
}
