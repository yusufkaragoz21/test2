namespace firma
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBelgeno = new System.Windows.Forms.TextBox();
            this.textAciklama = new System.Windows.Forms.TextBox();
            this.textFistipi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textFisno = new System.Windows.Forms.TextBox();
            this.comboFirma = new System.Windows.Forms.ComboBox();
            this.comboDepo = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBelgeno
            // 
            this.textBelgeno.Location = new System.Drawing.Point(102, 40);
            this.textBelgeno.Name = "textBelgeno";
            this.textBelgeno.Size = new System.Drawing.Size(100, 23);
            this.textBelgeno.TabIndex = 14;
            // 
            // textAciklama
            // 
            this.textAciklama.Location = new System.Drawing.Point(102, 78);
            this.textAciklama.Name = "textAciklama";
            this.textAciklama.Size = new System.Drawing.Size(100, 23);
            this.textAciklama.TabIndex = 15;
            // 
            // textFistipi
            // 
            this.textFistipi.Location = new System.Drawing.Point(393, 83);
            this.textFistipi.Name = "textFistipi";
            this.textFistipi.Size = new System.Drawing.Size(110, 23);
            this.textFistipi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fis no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Belge No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Aciklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fis tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "firma adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Depo adı";
            // 
            // textFisno
            // 
            this.textFisno.Enabled = false;
            this.textFisno.Location = new System.Drawing.Point(102, 3);
            this.textFisno.Name = "textFisno";
            this.textFisno.Size = new System.Drawing.Size(100, 23);
            this.textFisno.TabIndex = 30;
            // 
            // comboFirma
            // 
            this.comboFirma.FormattingEnabled = true;
            this.comboFirma.Location = new System.Drawing.Point(393, 3);
            this.comboFirma.Name = "comboFirma";
            this.comboFirma.Size = new System.Drawing.Size(110, 23);
            this.comboFirma.TabIndex = 33;
            // 
            // comboDepo
            // 
            this.comboDepo.FormattingEnabled = true;
            this.comboDepo.Location = new System.Drawing.Point(393, 43);
            this.comboDepo.Name = "comboDepo";
            this.comboDepo.Size = new System.Drawing.Size(110, 23);
            this.comboDepo.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fis_id,
            this.urun_id,
            this.urun_kod,
            this.renk_id,
            this.renk_kod,
            this.birim_id,
            this.birim_kod,
            this.miktar});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(712, 247);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // id
            // 
            this.id.Name = "id";
            // 
            // fis_id
            // 
            this.fis_id.Name = "fis_id";
            // 
            // urun_id
            // 
            this.urun_id.Name = "urun_id";
            // 
            // urun_kod
            // 
            this.urun_kod.Name = "urun_kod";
            // 
            // renk_id
            // 
            this.renk_id.Name = "renk_id";
            // 
            // renk_kod
            // 
            this.renk_kod.Name = "renk_kod";
            // 
            // birim_id
            // 
            this.birim_id.Name = "birim_id";
            // 
            // birim_kod
            // 
            this.birim_kod.Name = "birim_kod";
            // 
            // miktar
            // 
            this.miktar.Name = "miktar";
            // 
            // buttonKayit
            // 
            this.buttonKayit.Location = new System.Drawing.Point(0, 0);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(75, 23);
            this.buttonKayit.TabIndex = 0;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(0, 0);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(75, 23);
            this.buttonCikis.TabIndex = 0;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(0, 0);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(827, 457);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox textBelgeno;
        private TextBox textAciklama;
        private TextBox textFistipi;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textFisno;
        private ComboBox comboFirma;
        private ComboBox comboDepo;
        private DataGridView dataGridView2;
        private Button buttonKayit;
        private Button buttonCikis;
        private Button buttonSil;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fis_id;
        private DataGridViewTextBoxColumn urun_id;
        private DataGridViewTextBoxColumn urun_kod;
        private DataGridViewTextBoxColumn renk_id;
        private DataGridViewTextBoxColumn renk_kod;
        private DataGridViewTextBoxColumn birim_id;
        private DataGridViewTextBoxColumn birim_kod;
        private DataGridViewTextBoxColumn miktar;
    }
}