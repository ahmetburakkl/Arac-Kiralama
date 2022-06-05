using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmanasayfa : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public frmanasayfa()
        {
            InitializeComponent();
        }
        void SözlesmeGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-R5V47BO; Initial Catalog=araç_kıralama;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From sözlesme", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void btnkayma_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 65) 
            {
                MenuVertical.Width = 190;
            }     
            else
                MenuVertical.Width = 65;
        }
        private void closebuttons_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void maximizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestart.Visible = true;
            maximizebuttons.Visible = false;
        }
        private void iconrestart_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestart.Visible = false;
            maximizebuttons.Visible = true;
        }
        private void minimizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri goster = new frmMusteri();
            goster.Show();
        }
        private void btnAraç_Click(object sender, EventArgs e)
        {
            araç goster = new araç();
            goster.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMusteri goster = new frmMusteri();
            goster.Show();
        }
        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            sözleşme goster = new sözleşme();
            goster.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            araç goster = new araç();
            goster.Show();
        }
        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            SözlesmeGetir();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteri goster = new frmMusteri();
            goster.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sözleşme goster = new sözleşme();
            goster.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pnlişlem_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 goster = new Form3();
            goster.Show();
        }
    }
}
