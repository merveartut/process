namespace _171180006_MERVE_ARTUT
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.threadSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanılanBellekMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanılanİşlemciYüzdesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesiÖldürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // liste
            // 
            this.liste.ContextMenuStrip = this.contextMenuStrip1;
            this.liste.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste.FormattingEnabled = true;
            this.liste.ItemHeight = 16;
            this.liste.Location = new System.Drawing.Point(109, 74);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(205, 324);
            this.liste.TabIndex = 1;
            this.liste.SelectedIndexChanged += new System.EventHandler(this.liste_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadSayısıToolStripMenuItem,
            this.kullanılanBellekMiktarıToolStripMenuItem,
            this.kullanılanİşlemciYüzdesiToolStripMenuItem,
            this.prosesiÖldürToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 92);
            // 
            // threadSayısıToolStripMenuItem
            // 
            this.threadSayısıToolStripMenuItem.Name = "threadSayısıToolStripMenuItem";
            this.threadSayısıToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.threadSayısıToolStripMenuItem.Text = "thread sayısı";
            this.threadSayısıToolStripMenuItem.Click += new System.EventHandler(this.threadSayısıToolStripMenuItem_Click_1);
            // 
            // kullanılanBellekMiktarıToolStripMenuItem
            // 
            this.kullanılanBellekMiktarıToolStripMenuItem.Name = "kullanılanBellekMiktarıToolStripMenuItem";
            this.kullanılanBellekMiktarıToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.kullanılanBellekMiktarıToolStripMenuItem.Text = "kullanılan bellek miktarı";
            this.kullanılanBellekMiktarıToolStripMenuItem.Click += new System.EventHandler(this.kullanılanBellekMiktarıToolStripMenuItem_Click);
            // 
            // kullanılanİşlemciYüzdesiToolStripMenuItem
            // 
            this.kullanılanİşlemciYüzdesiToolStripMenuItem.Name = "kullanılanİşlemciYüzdesiToolStripMenuItem";
            this.kullanılanİşlemciYüzdesiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.kullanılanİşlemciYüzdesiToolStripMenuItem.Text = "kullanılan işlemci yüzdesi";
            this.kullanılanİşlemciYüzdesiToolStripMenuItem.Click += new System.EventHandler(this.kullanılanİşlemciYüzdesiToolStripMenuItem_Click);
            // 
            // prosesiÖldürToolStripMenuItem
            // 
            this.prosesiÖldürToolStripMenuItem.Name = "prosesiÖldürToolStripMenuItem";
            this.prosesiÖldürToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.prosesiÖldürToolStripMenuItem.Text = "prosesi öldür";
            this.prosesiÖldürToolStripMenuItem.Click += new System.EventHandler(this.prosesiÖldürToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 435);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "işletim_sistemleri_final";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem threadSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanılanBellekMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanılanİşlemciYüzdesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesiÖldürToolStripMenuItem;
    }
}

