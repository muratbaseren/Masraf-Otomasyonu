namespace Udemy_MasrafOtomasyonu
{
    partial class frmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpMasrafDetaylar = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.flpDugmeler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMasrafEkle = new System.Windows.Forms.Button();
            this.btnMasrafKaydet = new System.Windows.Forms.Button();
            this.btnMasrafSil = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMasraflar = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbMasrafSahibi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.lblPersonelAdSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMasrafYonet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOnayla = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuGuncellenmeli = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuReddet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMuhasebe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOdendi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpMasrafDetaylar.SuspendLayout();
            this.flpDugmeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mnuTop.SuspendLayout();
            this.cmnuMasrafYonet.SuspendLayout();
            this.cmnuMuhasebe.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpMasrafDetaylar);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.mnuTop);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(856, 613);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpMasrafDetaylar
            // 
            this.grpMasrafDetaylar.Controls.Add(this.txtAciklama);
            this.grpMasrafDetaylar.Controls.Add(this.flpDugmeler);
            this.grpMasrafDetaylar.Controls.Add(this.lblAciklama);
            this.grpMasrafDetaylar.Controls.Add(this.nudTutar);
            this.grpMasrafDetaylar.Controls.Add(this.lblTutar);
            this.grpMasrafDetaylar.Controls.Add(this.txtBaslik);
            this.grpMasrafDetaylar.Controls.Add(this.lblBaslik);
            this.grpMasrafDetaylar.Controls.Add(this.dtpTarih);
            this.grpMasrafDetaylar.Controls.Add(this.lblTarih);
            this.grpMasrafDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMasrafDetaylar.Location = new System.Drawing.Point(11, 13);
            this.grpMasrafDetaylar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMasrafDetaylar.Name = "grpMasrafDetaylar";
            this.grpMasrafDetaylar.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.grpMasrafDetaylar.Size = new System.Drawing.Size(232, 587);
            this.grpMasrafDetaylar.TabIndex = 0;
            this.grpMasrafDetaylar.TabStop = false;
            this.grpMasrafDetaylar.Text = "Masraf Detayları";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(11, 250);
            this.txtAciklama.MaxLength = 150;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(210, 226);
            this.txtAciklama.TabIndex = 8;
            // 
            // flpDugmeler
            // 
            this.flpDugmeler.Controls.Add(this.btnMasrafEkle);
            this.flpDugmeler.Controls.Add(this.btnMasrafKaydet);
            this.flpDugmeler.Controls.Add(this.btnMasrafSil);
            this.flpDugmeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDugmeler.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDugmeler.Location = new System.Drawing.Point(11, 476);
            this.flpDugmeler.Name = "flpDugmeler";
            this.flpDugmeler.Size = new System.Drawing.Size(210, 98);
            this.flpDugmeler.TabIndex = 7;
            // 
            // btnMasrafEkle
            // 
            this.btnMasrafEkle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMasrafEkle.Image = global::Udemy_MasrafOtomasyonu.Properties.Resources.More_32;
            this.btnMasrafEkle.Location = new System.Drawing.Point(112, 3);
            this.btnMasrafEkle.Name = "btnMasrafEkle";
            this.btnMasrafEkle.Size = new System.Drawing.Size(95, 40);
            this.btnMasrafEkle.TabIndex = 0;
            this.btnMasrafEkle.Text = "Ekle";
            this.btnMasrafEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasrafEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafEkle.UseVisualStyleBackColor = true;
            this.btnMasrafEkle.Click += new System.EventHandler(this.btnMasrafEkle_Click);
            // 
            // btnMasrafKaydet
            // 
            this.btnMasrafKaydet.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMasrafKaydet.Image = global::Udemy_MasrafOtomasyonu.Properties.Resources.Share_32;
            this.btnMasrafKaydet.Location = new System.Drawing.Point(11, 3);
            this.btnMasrafKaydet.Name = "btnMasrafKaydet";
            this.btnMasrafKaydet.Size = new System.Drawing.Size(95, 40);
            this.btnMasrafKaydet.TabIndex = 1;
            this.btnMasrafKaydet.Text = "Kaydet";
            this.btnMasrafKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasrafKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafKaydet.UseVisualStyleBackColor = true;
            this.btnMasrafKaydet.Click += new System.EventHandler(this.btnMasrafKaydet_Click);
            // 
            // btnMasrafSil
            // 
            this.btnMasrafSil.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMasrafSil.Image = global::Udemy_MasrafOtomasyonu.Properties.Resources.Less_32;
            this.btnMasrafSil.Location = new System.Drawing.Point(112, 49);
            this.btnMasrafSil.Name = "btnMasrafSil";
            this.btnMasrafSil.Size = new System.Drawing.Size(95, 40);
            this.btnMasrafSil.TabIndex = 2;
            this.btnMasrafSil.Text = "Sil";
            this.btnMasrafSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMasrafSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafSil.UseVisualStyleBackColor = true;
            this.btnMasrafSil.Click += new System.EventHandler(this.btnMasrafSil_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAciklama.Location = new System.Drawing.Point(11, 217);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblAciklama.Size = new System.Drawing.Size(210, 33);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTutar.Location = new System.Drawing.Point(11, 189);
            this.nudTutar.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(210, 28);
            this.nudTutar.TabIndex = 5;
            // 
            // lblTutar
            // 
            this.lblTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTutar.Location = new System.Drawing.Point(11, 156);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTutar.Size = new System.Drawing.Size(210, 33);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar :";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaslik.Location = new System.Drawing.Point(11, 128);
            this.txtBaslik.MaxLength = 50;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(210, 28);
            this.txtBaslik.TabIndex = 3;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(11, 95);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblBaslik.Size = new System.Drawing.Size(210, 33);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Başlık :";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(11, 67);
            this.dtpTarih.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(210, 28);
            this.dtpTarih.TabIndex = 1;
            // 
            // lblTarih
            // 
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarih.Location = new System.Drawing.Point(11, 34);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTarih.Size = new System.Drawing.Size(210, 33);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMasraflar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(595, 585);
            this.panel1.TabIndex = 1;
            // 
            // lstMasraflar
            // 
            this.lstMasraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasraflar.FormattingEnabled = true;
            this.lstMasraflar.ItemHeight = 21;
            this.lstMasraflar.Location = new System.Drawing.Point(10, 52);
            this.lstMasraflar.Name = "lstMasraflar";
            this.lstMasraflar.Size = new System.Drawing.Size(575, 523);
            this.lstMasraflar.TabIndex = 1;
            this.lstMasraflar.SelectedIndexChanged += new System.EventHandler(this.lstMasraflar_SelectedIndexChanged);
            this.lstMasraflar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstMasraflar_Format);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbMasrafSahibi);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(575, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbMasrafSahibi
            // 
            this.cmbMasrafSahibi.FormattingEnabled = true;
            this.cmbMasrafSahibi.Location = new System.Drawing.Point(251, 3);
            this.cmbMasrafSahibi.Name = "cmbMasrafSahibi";
            this.cmbMasrafSahibi.Size = new System.Drawing.Size(321, 29);
            this.cmbMasrafSahibi.TabIndex = 0;
            this.cmbMasrafSahibi.SelectedIndexChanged += new System.EventHandler(this.cmbMasrafSahibi_SelectedIndexChanged);
            this.cmbMasrafSahibi.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbMasrafSahibi_Format);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masraf Sahibi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPersonelAdSoyad});
            this.mnuTop.Location = new System.Drawing.Point(3, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(595, 28);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPersonelAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(155, 24);
            this.lblPersonelAdSoyad.Text = "[PersonelAdSoyad]";
            // 
            // cmnuMasrafYonet
            // 
            this.cmnuMasrafYonet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuMasrafYonet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOnayla,
            this.cmnuGuncellenmeli,
            this.toolStripMenuItem1,
            this.cmnuReddet});
            this.cmnuMasrafYonet.Name = "cmnuMasrafYonet";
            this.cmnuMasrafYonet.Size = new System.Drawing.Size(173, 82);
            // 
            // cmnuOnayla
            // 
            this.cmnuOnayla.Name = "cmnuOnayla";
            this.cmnuOnayla.Size = new System.Drawing.Size(172, 24);
            this.cmnuOnayla.Text = "Onayla";
            this.cmnuOnayla.Click += new System.EventHandler(this.cmnuOnayla_Click);
            // 
            // cmnuGuncellenmeli
            // 
            this.cmnuGuncellenmeli.Name = "cmnuGuncellenmeli";
            this.cmnuGuncellenmeli.Size = new System.Drawing.Size(172, 24);
            this.cmnuGuncellenmeli.Text = "Güncellenmeli";
            this.cmnuGuncellenmeli.Click += new System.EventHandler(this.cmnuGuncellenmeli_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // cmnuReddet
            // 
            this.cmnuReddet.Name = "cmnuReddet";
            this.cmnuReddet.Size = new System.Drawing.Size(172, 24);
            this.cmnuReddet.Text = "Reddet";
            this.cmnuReddet.Click += new System.EventHandler(this.cmnuReddet_Click);
            // 
            // cmnuMuhasebe
            // 
            this.cmnuMuhasebe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuMuhasebe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOdendi});
            this.cmnuMuhasebe.Name = "cmnuMuhasebe";
            this.cmnuMuhasebe.Size = new System.Drawing.Size(176, 56);
            // 
            // cmnuOdendi
            // 
            this.cmnuOdendi.Name = "cmnuOdendi";
            this.cmnuOdendi.Size = new System.Drawing.Size(175, 24);
            this.cmnuOdendi.Text = "Ödendi";
            this.cmnuOdendi.Click += new System.EventHandler(this.cmnuOdendi_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 613);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Otomasyonu : Masraflar";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpMasrafDetaylar.ResumeLayout(false);
            this.grpMasrafDetaylar.PerformLayout();
            this.flpDugmeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.cmnuMasrafYonet.ResumeLayout(false);
            this.cmnuMuhasebe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpMasrafDetaylar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.FlowLayoutPanel flpDugmeler;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnMasrafEkle;
        private System.Windows.Forms.Button btnMasrafKaydet;
        private System.Windows.Forms.Button btnMasrafSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbMasrafSahibi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem lblPersonelAdSoyad;
        private System.Windows.Forms.ListBox lstMasraflar;
        private System.Windows.Forms.ContextMenuStrip cmnuMasrafYonet;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnayla;
        private System.Windows.Forms.ToolStripMenuItem cmnuGuncellenmeli;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuReddet;
        private System.Windows.Forms.ContextMenuStrip cmnuMuhasebe;
        private System.Windows.Forms.ToolStripMenuItem cmnuOdendi;
    }
}