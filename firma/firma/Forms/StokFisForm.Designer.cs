namespace firma.Forms
{
    partial class StokFisForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridFis = new System.Windows.Forms.DataGridView();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fis_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belge_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depo_kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fis_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridFis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 404);
            this.panel1.TabIndex = 0;
            // 
            // dataGridFis
            // 
            this.dataGridFis.AllowUserToOrderColumns = true;
            this.dataGridFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fis_no,
            this.belge_no,
            this.aciklama,
            this.firma_kod,
            this.firma_id,
            this.depo_kod,
            this.dataGridViewTextBoxColumn1,
            this.fis_tipi});
            this.dataGridFis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFis.Location = new System.Drawing.Point(0, 0);
            this.dataGridFis.Name = "dataGridFis";
            this.dataGridFis.RowTemplate.Height = 25;
            this.dataGridFis.Size = new System.Drawing.Size(800, 404);
            this.dataGridFis.TabIndex = 0;
            this.dataGridFis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFis_CellDoubleClick);
            // 
            // btnNewSave
            // 
            this.btnNewSave.Location = new System.Drawing.Point(600, 12);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewSave.TabIndex = 1;
            this.btnNewSave.Text = "New Save";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(704, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnNewSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // fis_no
            // 
            this.fis_no.DataPropertyName = "fis_no";
            this.fis_no.HeaderText = "fis_no";
            this.fis_no.Name = "fis_no";
            // 
            // belge_no
            // 
            this.belge_no.DataPropertyName = "belge_no";
            this.belge_no.HeaderText = "belge_no";
            this.belge_no.Name = "belge_no";
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "aciklama";
            this.aciklama.Name = "aciklama";
            // 
            // firma_kod
            // 
            this.firma_kod.DataPropertyName = "firma_kod";
            this.firma_kod.HeaderText = "firma_kod";
            this.firma_kod.Name = "firma_kod";
            this.firma_kod.Visible = false;
            // 
            // firma_id
            // 
            this.firma_id.DataPropertyName = "firma_id";
            this.firma_id.HeaderText = "firma_id";
            this.firma_id.Name = "firma_id";
            this.firma_id.Visible = false;
            // 
            // depo_kod
            // 
            this.depo_kod.DataPropertyName = "depo_kod";
            this.depo_kod.HeaderText = "depo_kod";
            this.depo_kod.Name = "depo_kod";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "depo_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "depo_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // fis_tipi
            // 
            this.fis_tipi.DataPropertyName = "fis_tipi";
            this.fis_tipi.HeaderText = "fis_tipi";
            this.fis_tipi.Name = "fis_tipi";
            // 
            // StokFisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StokFisForm";
            this.Text = "StokFis";
            this.Load += new System.EventHandler(this.StokFis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridFis;
        private Button btnNewSave;
        private Button btnExit;
        private Panel panel2;
        private DataGridViewTextBoxColumn depo_id;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fis_no;
        private DataGridViewTextBoxColumn belge_no;
        private DataGridViewTextBoxColumn aciklama;
        private DataGridViewTextBoxColumn firma_kod;
        private DataGridViewTextBoxColumn firma_id;
        private DataGridViewTextBoxColumn depo_kod;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fis_tipi;
    }
}