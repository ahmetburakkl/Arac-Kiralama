namespace WindowsFormsApp1
{
    partial class frmanasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmanasayfa));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnAraç = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlişlem = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconrestart = new System.Windows.Forms.PictureBox();
            this.minimizebuttons = new System.Windows.Forms.PictureBox();
            this.maximizebuttons = new System.Windows.Forms.PictureBox();
            this.closebuttons = new System.Windows.Forms.PictureBox();
            this.btnkayma = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlişlem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebuttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebuttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnkayma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.White;
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.label2);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.pictureBox4);
            this.MenuVertical.Controls.Add(this.btnSozlesme);
            this.MenuVertical.Controls.Add(this.btnAraç);
            this.MenuVertical.Controls.Add(this.btnMusteri);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(86, 574);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "RENT A CAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.2F);
            this.label1.Location = new System.Drawing.Point(115, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "KÖKLÜ ";
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.BackColor = System.Drawing.Color.Transparent;
            this.btnSozlesme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSozlesme.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSozlesme.FlatAppearance.BorderSize = 0;
            this.btnSozlesme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSozlesme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSozlesme.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSozlesme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSozlesme.Location = new System.Drawing.Point(48, 342);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(241, 46);
            this.btnSozlesme.TabIndex = 2;
            this.btnSozlesme.Text = "SÖZLEŞME";
            this.btnSozlesme.UseVisualStyleBackColor = false;
            this.btnSozlesme.Click += new System.EventHandler(this.btnSozlesme_Click);
            // 
            // btnAraç
            // 
            this.btnAraç.BackColor = System.Drawing.Color.Transparent;
            this.btnAraç.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAraç.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAraç.FlatAppearance.BorderSize = 0;
            this.btnAraç.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAraç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraç.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraç.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraç.Location = new System.Drawing.Point(48, 263);
            this.btnAraç.Name = "btnAraç";
            this.btnAraç.Size = new System.Drawing.Size(241, 46);
            this.btnAraç.TabIndex = 1;
            this.btnAraç.Text = "ARAÇ";
            this.btnAraç.UseVisualStyleBackColor = false;
            this.btnAraç.Click += new System.EventHandler(this.btnAraç_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteri.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(48, 184);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(241, 46);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "MÜŞTERİ";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.iconrestart);
            this.panel2.Controls.Add(this.minimizebuttons);
            this.panel2.Controls.Add(this.maximizebuttons);
            this.panel2.Controls.Add(this.closebuttons);
            this.panel2.Controls.Add(this.btnkayma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(86, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 50);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pnlişlem
            // 
            this.pnlişlem.BackColor = System.Drawing.Color.LightGray;
            this.pnlişlem.Controls.Add(this.dataGridView1);
            this.pnlişlem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlişlem.Location = new System.Drawing.Point(86, 50);
            this.pnlişlem.Name = "pnlişlem";
            this.pnlişlem.Size = new System.Drawing.Size(1014, 524);
            this.pnlişlem.TabIndex = 2;
            this.pnlişlem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlişlem_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // iconrestart
            // 
            this.iconrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestart.BackColor = System.Drawing.Color.Transparent;
            this.iconrestart.Image = global::WindowsFormsApp1.Properties.Resources.maximizebuttons;
            this.iconrestart.Location = new System.Drawing.Point(906, 7);
            this.iconrestart.Name = "iconrestart";
            this.iconrestart.Size = new System.Drawing.Size(45, 37);
            this.iconrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconrestart.TabIndex = 3;
            this.iconrestart.TabStop = false;
            this.iconrestart.Visible = false;
            this.iconrestart.Click += new System.EventHandler(this.iconrestart_Click);
            // 
            // minimizebuttons
            // 
            this.minimizebuttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebuttons.Image = global::WindowsFormsApp1.Properties.Resources.minimizebuttons;
            this.minimizebuttons.Location = new System.Drawing.Point(855, 7);
            this.minimizebuttons.Name = "minimizebuttons";
            this.minimizebuttons.Size = new System.Drawing.Size(45, 37);
            this.minimizebuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizebuttons.TabIndex = 2;
            this.minimizebuttons.TabStop = false;
            this.minimizebuttons.Click += new System.EventHandler(this.minimizebuttons_Click);
            // 
            // maximizebuttons
            // 
            this.maximizebuttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizebuttons.BackColor = System.Drawing.Color.Transparent;
            this.maximizebuttons.Image = global::WindowsFormsApp1.Properties.Resources.maximizebuttons;
            this.maximizebuttons.Location = new System.Drawing.Point(906, 6);
            this.maximizebuttons.Name = "maximizebuttons";
            this.maximizebuttons.Size = new System.Drawing.Size(45, 37);
            this.maximizebuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizebuttons.TabIndex = 2;
            this.maximizebuttons.TabStop = false;
            this.maximizebuttons.Click += new System.EventHandler(this.maximizebuttons_Click);
            // 
            // closebuttons
            // 
            this.closebuttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebuttons.Image = global::WindowsFormsApp1.Properties.Resources.close_buttonsf;
            this.closebuttons.Location = new System.Drawing.Point(957, 6);
            this.closebuttons.Name = "closebuttons";
            this.closebuttons.Size = new System.Drawing.Size(45, 37);
            this.closebuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebuttons.TabIndex = 1;
            this.closebuttons.TabStop = false;
            this.closebuttons.Click += new System.EventHandler(this.closebuttons_Click);
            // 
            // btnkayma
            // 
            this.btnkayma.BackColor = System.Drawing.Color.Transparent;
            this.btnkayma.Image = global::WindowsFormsApp1.Properties.Resources._1_TlgXIboiNz2O__aCYYztBg;
            this.btnkayma.Location = new System.Drawing.Point(6, 6);
            this.btnkayma.Name = "btnkayma";
            this.btnkayma.Size = new System.Drawing.Size(45, 40);
            this.btnkayma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnkayma.TabIndex = 0;
            this.btnkayma.TabStop = false;
            this.btnkayma.Click += new System.EventHandler(this.btnkayma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(22, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 65);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(9, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 62);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 65);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // frmanasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1100, 574);
            this.Controls.Add(this.pnlişlem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmanasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmanasayfa_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlişlem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebuttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebuttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnkayma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnkayma;
        private System.Windows.Forms.PictureBox closebuttons;
        private System.Windows.Forms.PictureBox maximizebuttons;
        private System.Windows.Forms.PictureBox minimizebuttons;
        private System.Windows.Forms.PictureBox iconrestart;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnAraç;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlişlem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

