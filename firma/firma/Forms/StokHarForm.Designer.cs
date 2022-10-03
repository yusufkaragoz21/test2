namespace firma.Forms
{
    partial class StokHarForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.Label();
            this.depo = new System.Windows.Forms.Label();
            this.fis_tipi = new System.Windows.Forms.Label();
            this.text_fis_no = new System.Windows.Forms.TextBox();
            this.text_belge_no = new System.Windows.Forms.TextBox();
            this.text_aciklama = new System.Windows.Forms.TextBox();
            this.text_fis_tipi = new System.Windows.Forms.TextBox();
            this.comboFirma = new System.Windows.Forms.ComboBox();
            this.comboDepo = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridDetaylar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetaylar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.Location = new System.Drawing.Point(575, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 49);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "fisno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "belge no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "aciklama";
            // 
            // firma
            // 
            this.firma.AutoSize = true;
            this.firma.Location = new System.Drawing.Point(361, 19);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(37, 15);
            this.firma.TabIndex = 4;
            this.firma.Text = "Firma";
            // 
            // depo
            // 
            this.depo.AutoSize = true;
            this.depo.Location = new System.Drawing.Point(359, 61);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(35, 15);
            this.depo.TabIndex = 5;
            this.depo.Text = "Depo";
            // 
            // fis_tipi
            // 
            this.fis_tipi.AutoSize = true;
            this.fis_tipi.Location = new System.Drawing.Point(359, 101);
            this.fis_tipi.Name = "fis_tipi";
            this.fis_tipi.Size = new System.Drawing.Size(39, 15);
            this.fis_tipi.TabIndex = 6;
            this.fis_tipi.Text = "fis tipi";
            // 
            // text_fis_no
            // 
            this.text_fis_no.Enabled = false;
            this.text_fis_no.Location = new System.Drawing.Point(92, 16);
            this.text_fis_no.Name = "text_fis_no";
            this.text_fis_no.ReadOnly = true;
            this.text_fis_no.Size = new System.Drawing.Size(100, 23);
            this.text_fis_no.TabIndex = 7;
            // 
            // text_belge_no
            // 
            this.text_belge_no.Location = new System.Drawing.Point(92, 53);
            this.text_belge_no.Name = "text_belge_no";
            this.text_belge_no.Size = new System.Drawing.Size(100, 23);
            this.text_belge_no.TabIndex = 8;
            // 
            // text_aciklama
            // 
            this.text_aciklama.Location = new System.Drawing.Point(92, 93);
            this.text_aciklama.Name = "text_aciklama";
            this.text_aciklama.Size = new System.Drawing.Size(100, 23);
            this.text_aciklama.TabIndex = 9;
            // 
            // text_fis_tipi
            // 
            this.text_fis_tipi.Location = new System.Drawing.Point(418, 93);
            this.text_fis_tipi.Name = "text_fis_tipi";
            this.text_fis_tipi.Size = new System.Drawing.Size(121, 23);
            this.text_fis_tipi.TabIndex = 10;
            // 
            // comboFirma
            // 
            this.comboFirma.FormattingEnabled = true;
            this.comboFirma.Location = new System.Drawing.Point(418, 16);
            this.comboFirma.Name = "comboFirma";
            this.comboFirma.Size = new System.Drawing.Size(121, 23);
            this.comboFirma.TabIndex = 11;
            // 
            // comboDepo
            // 
            this.comboDepo.FormattingEnabled = true;
            this.comboDepo.Location = new System.Drawing.Point(418, 53);
            this.comboDepo.Name = "comboDepo";
            this.comboDepo.Size = new System.Drawing.Size(121, 23);
            this.comboDepo.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.Location = new System.Drawing.Point(650, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 49);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.Location = new System.Drawing.Point(725, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 49);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridDetaylar
            // 
            this.dataGridDetaylar.AllowUserToOrderColumns = true;
            this.dataGridDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fis_id,
            this.urun_id,
            this.urun_kod,
            this.renk_id,
            this.renk_kod,
            this.birim_id,
            this.birim_kod,
            this.miktar});
            this.dataGridDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDetaylar.Location = new System.Drawing.Point(0, 0);
            this.dataGridDetaylar.Name = "dataGridDetaylar";
            this.dataGridDetaylar.RowTemplate.Height = 25;
            this.dataGridDetaylar.Size = new System.Drawing.Size(800, 315);
            this.dataGridDetaylar.TabIndex = 15;
            this.dataGridDetaylar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDetaylar_CellDoubleClick);
            this.dataGridDetaylar.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridDetaylar_RowsAdded);
            this.dataGridDetaylar.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridDetaylar_RowValidating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_belge_no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboDepo);
            this.panel1.Controls.Add(this.text_fis_no);
            this.panel1.Controls.Add(this.comboFirma);
            this.panel1.Controls.Add(this.text_aciklama);
            this.panel1.Controls.Add(this.text_fis_tipi);
            this.panel1.Controls.Add(this.firma);
            this.panel1.Controls.Add(this.fis_tipi);
            this.panel1.Controls.Add(this.depo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 135);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridDetaylar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 315);
            this.panel3.TabIndex = 18;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // fis_id
            // 
            this.fis_id.DataPropertyName = "fis_id";
            this.fis_id.HeaderText = "fis_id";
            this.fis_id.Name = "fis_id";
            // 
            // urun_id
            // 
            this.urun_id.DataPropertyName = "urun_id";
            this.urun_id.HeaderText = "urun_id";
            this.urun_id.Name = "urun_id";
            this.urun_id.Visible = false;
            // 
            // urun_kod
            // 
            this.urun_kod.DataPropertyName = "urun_kod";
            this.urun_kod.HeaderText = "Ürün";
            this.urun_kod.Name = "urun_kod";
            // 
            // renk_id
            // 
            this.renk_id.DataPropertyName = "renk_id";
            this.renk_id.HeaderText = "renk_id";
            this.renk_id.Name = "renk_id";
            this.renk_id.Visible = false;
            // 
            // renk_kod
            // 
            this.renk_kod.DataPropertyName = "renk_kod";
            this.renk_kod.HeaderText = "Renk";
            this.renk_kod.Name = "renk_kod";
            // 
            // birim_id
            // 
            this.birim_id.DataPropertyName = "birim_id";
            this.birim_id.HeaderText = "birim_id";
            this.birim_id.Name = "birim_id";
            this.birim_id.Visible = false;
            // 
            // birim_kod
            // 
            this.birim_kod.DataPropertyName = "birim_kod";
            this.birim_kod.HeaderText = "birim";
            this.birim_kod.Name = "birim_kod";
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "miktar";
            this.miktar.Name = "miktar";
            // 
            // StokHarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StokHarForm";
            this.Text = "StokHarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StokHarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetaylar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label firma;
        private Label depo;
        private Label fis_tipi;
        private TextBox text_fis_no;
        private TextBox text_belge_no;
        private TextBox text_aciklama;
        private TextBox text_fis_tipi;
        private ComboBox comboFirma;
        private ComboBox comboDepo;
        private Button buttonDelete;
        private Button buttonExit;
        private DataGridView dataGridDetaylar;
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