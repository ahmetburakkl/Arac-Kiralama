
namespace WindowsFormsApp1
{
    partial class araç
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(araç));
            this.panelüst = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.minimizebuttons = new System.Windows.Forms.PictureBox();
            this.closebuttons = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtgünlük = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtyakıttürü = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelüst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebuttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelüst
            // 
            this.panelüst.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelüst.Controls.Add(this.label9);
            this.panelüst.Controls.Add(this.minimizebuttons);
            this.panelüst.Controls.Add(this.closebuttons);
            this.panelüst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelüst.Location = new System.Drawing.Point(0, 0);
            this.panelüst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelüst.Name = "panelüst";
            this.panelüst.Size = new System.Drawing.Size(1102, 50);
            this.panelüst.TabIndex = 0;
            this.panelüst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelüst_MouseDown);
            this.panelüst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelüst_MouseMove);
            this.panelüst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelüst_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "Araç Ekleme Sayfası";
            // 
            // minimizebuttons
            // 
            this.minimizebuttons.Image = ((System.Drawing.Image)(resources.GetObject("minimizebuttons.Image")));
            this.minimizebuttons.Location = new System.Drawing.Point(995, 6);
            this.minimizebuttons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minimizebuttons.Name = "minimizebuttons";
            this.minimizebuttons.Size = new System.Drawing.Size(45, 37);
            this.minimizebuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizebuttons.TabIndex = 1;
            this.minimizebuttons.TabStop = false;
            this.minimizebuttons.Click += new System.EventHandler(this.minimizebuttons_Click);
            // 
            // closebuttons
            // 
            this.closebuttons.Image = ((System.Drawing.Image)(resources.GetObject("closebuttons.Image")));
            this.closebuttons.Location = new System.Drawing.Point(1051, 6);
            this.closebuttons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closebuttons.Name = "closebuttons";
            this.closebuttons.Size = new System.Drawing.Size(45, 37);
            this.closebuttons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closebuttons.TabIndex = 2;
            this.closebuttons.TabStop = false;
            this.closebuttons.Click += new System.EventHandler(this.closebuttons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = " Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Renk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(432, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Km:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(401, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Günlük:";
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtplaka.Location = new System.Drawing.Point(125, 63);
            this.txtplaka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(223, 30);
            this.txtplaka.TabIndex = 9;
            // 
            // txtmarka
            // 
            this.txtmarka.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Location = new System.Drawing.Point(125, 105);
            this.txtmarka.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(223, 30);
            this.txtmarka.TabIndex = 10;
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmodel.Location = new System.Drawing.Point(125, 147);
            this.txtmodel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(223, 30);
            this.txtmodel.TabIndex = 11;
            // 
            // txtrenk
            // 
            this.txtrenk.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrenk.Location = new System.Drawing.Point(125, 190);
            this.txtrenk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(223, 30);
            this.txtrenk.TabIndex = 12;
            // 
            // txtkm
            // 
            this.txtkm.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkm.Location = new System.Drawing.Point(484, 109);
            this.txtkm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(223, 30);
            this.txtkm.TabIndex = 13;
            // 
            // txtgünlük
            // 
            this.txtgünlük.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgünlük.Location = new System.Drawing.Point(484, 189);
            this.txtgünlük.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtgünlük.Name = "txtgünlük";
            this.txtgünlük.Size = new System.Drawing.Size(223, 30);
            this.txtgünlük.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 253);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtyakıttürü
            // 
            this.txtyakıttürü.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyakıttürü.Location = new System.Drawing.Point(484, 146);
            this.txtyakıttürü.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtyakıttürü.Name = "txtyakıttürü";
            this.txtyakıttürü.Size = new System.Drawing.Size(223, 30);
            this.txtyakıttürü.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(373, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yakıt Türü:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(411, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Resim:";
            // 
            // txtresim
            // 
            this.txtresim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresim.Location = new System.Drawing.Point(484, 62);
            this.txtresim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(182, 30);
            this.txtresim.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(675, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(350, 240);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(104, 42);
            this.btnekle.TabIndex = 27;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(559, 240);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(148, 42);
            this.btngüncelle.TabIndex = 28;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(460, 240);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(93, 42);
            this.btnsil.TabIndex = 29;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(93, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 27);
            this.label10.TabIndex = 30;
            this.label10.Text = "İd:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(125, 252);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(104, 30);
            this.txtid.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(790, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // araç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 573);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtyakıttürü);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtgünlük);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelüst);
            this.Font = new System.Drawing.Font("Verdana", 16.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "araç";
            this.Text = "araç";
            this.Load += new System.EventHandler(this.araç_Load);
            this.panelüst.ResumeLayout(false);
            this.panelüst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebuttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebuttons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelüst;
        private System.Windows.Forms.PictureBox minimizebuttons;
        private System.Windows.Forms.PictureBox closebuttons;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtgünlük;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtyakıttürü;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
    }
}