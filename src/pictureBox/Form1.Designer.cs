namespace pictureBox
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efektlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koyulaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aciklastirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siyahBeyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kabartmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulanıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.efektlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.çıkToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "acToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // çıkToolStripMenuItem
            // 
            this.çıkToolStripMenuItem.Name = "cikToolStripMenuItem";
            this.çıkToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.çıkToolStripMenuItem.Text = "Çık";
            this.çıkToolStripMenuItem.Click += new System.EventHandler(this.cikToolStripMenuItem_Click);
            // 
            // efektlerToolStripMenuItem
            // 
            this.efektlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tersToolStripMenuItem,
            this.koyulaştırToolStripMenuItem,
            this.aciklastirToolStripMenuItem,
            this.griToolStripMenuItem,
            this.siyahBeyazToolStripMenuItem,
            this.kabartmaToolStripMenuItem,
            this.bulanıkToolStripMenuItem});
            this.efektlerToolStripMenuItem.Name = "efektlerToolStripMenuItem";
            this.efektlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.efektlerToolStripMenuItem.Text = "Efektler";
            // 
            // tersToolStripMenuItem
            // 
            this.tersToolStripMenuItem.Name = "tersToolStripMenuItem";
            this.tersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tersToolStripMenuItem.Text = "Ters";
            this.tersToolStripMenuItem.Click += new System.EventHandler(this.tersToolStripMenuItem_Click);
            // 
            // koyulaştırToolStripMenuItem
            // 
            this.koyulaştırToolStripMenuItem.Name = "koyulaştırToolStripMenuItem";
            this.koyulaştırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.koyulaştırToolStripMenuItem.Text = "Koyulaştır";
            this.koyulaştırToolStripMenuItem.Click += new System.EventHandler(this.koyulastirToolStripMenuItem_Click);
            // 
            // aciklastirToolStripMenuItem
            // 
            this.aciklastirToolStripMenuItem.Name = "aciklastirToolStripMenuItem";
            this.aciklastirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aciklastirToolStripMenuItem.Text = "Açıklaştır";
            this.aciklastirToolStripMenuItem.Click += new System.EventHandler(this.aciklastirToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // siyahBeyazToolStripMenuItem
            // 
            this.siyahBeyazToolStripMenuItem.Name = "siyahBeyazToolStripMenuItem";
            this.siyahBeyazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siyahBeyazToolStripMenuItem.Text = "Siyah/Beyaz";
            this.siyahBeyazToolStripMenuItem.Click += new System.EventHandler(this.siyahBeyazToolStripMenuItem_Click);
            // 
            // kabartmaToolStripMenuItem
            // 
            this.kabartmaToolStripMenuItem.Name = "kabartmaToolStripMenuItem";
            this.kabartmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kabartmaToolStripMenuItem.Text = "Kabartma";
            this.kabartmaToolStripMenuItem.Click += new System.EventHandler(this.kabartmaToolStripMenuItem_Click);
            // 
            // bulanıkToolStripMenuItem
            // 
            this.bulanıkToolStripMenuItem.Name = "bulanıkToolStripMenuItem";
            this.bulanıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bulanıkToolStripMenuItem.Text = "Bulanık";
            this.bulanıkToolStripMenuItem.Click += new System.EventHandler(this.bulanikToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(572, 407);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efektlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koyulaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aciklastirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siyahBeyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kabartmaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulanıkToolStripMenuItem;
    }
}

