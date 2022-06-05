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
    public partial class giris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public giris()
        {
            InitializeComponent();
        }
        private void giris_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtkullanıcı.Text;
            string sifre = txtsifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-R5V47BO;Initial Catalog=araç_kıralama;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * From giris where  kullanıcı_ad='" + txtkullanıcı.Text + "' And sifre='" + txtsifre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                frmanasayfa geçiş = new frmanasayfa();
                geçiş.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA PAROLA HATALI !");
            }
            con.Close();
        }
        private void closebuttons_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}
