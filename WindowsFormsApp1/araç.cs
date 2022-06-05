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
    public partial class araç : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;      
        public araç()
        {
            InitializeComponent();
        }
        void AraçGetir()
        {
            baglanti = new SqlConnection("server=DESKTOP-R5V47BO; Initial Catalog=araç_kıralama;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From araçbilgi2", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void closebuttons_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimizebuttons_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void araç_Load(object sender, EventArgs e)
        {
            AraçGetir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtresim.Text = openFileDialog1.FileName;
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into araçbilgi2 (id,plaka,marka,model,renk,km,günlük,resim,yakıt_türü) values (@id,@plaka,@marka,@model,@renk,@km,@günlük,@resim,@yakıt_türü)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut.Parameters.AddWithValue("@model", txtmodel.Text);
            komut.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut.Parameters.AddWithValue("@km", txtkm.Text);
            komut.Parameters.AddWithValue("@günlük", txtgünlük.Text);
            komut.Parameters.AddWithValue("@resim", txtresim.Text);
            komut.Parameters.AddWithValue("@yakıt_türü", txtyakıttürü.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AraçGetir();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtplaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtgünlük.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtyakıttürü.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtresim.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From araçbilgi2 Where plaka=@plaka";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@plaka", (txtplaka.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AraçGetir();
        }
        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update araçbilgi2 Set plaka=@plaka, marka=@marka, model=@model, renk=@renk, km=@km, günlük=@günlük, resim=@resim, yakıt_türü=@yakıt_türü Where id=@id ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
            komut.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut.Parameters.AddWithValue("@model", txtmodel.Text);
            komut.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut.Parameters.AddWithValue("@km", txtkm.Text);
            komut.Parameters.AddWithValue("@günlük", txtgünlük.Text);
            komut.Parameters.AddWithValue("@resim", txtresim.Text);
            komut.Parameters.AddWithValue("@yakıt_türü", txtyakıttürü.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AraçGetir();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panelüst_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panelüst_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panelüst_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
    }
}
