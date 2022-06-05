using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'araç_kıralamaDataSet.sözlesme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sözlesmeTableAdapter.Fill(this.araç_kıralamaDataSet.sözlesme);
            // TODO: Bu kod satırı 'araç_kıralamaDataSet.musteribilgi2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteribilgi2TableAdapter.Fill(this.araç_kıralamaDataSet.musteribilgi2);
            // TODO: Bu kod satırı 'araç_kıralamaDataSet.araçbilgi2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.araçbilgi2TableAdapter.Fill(this.araç_kıralamaDataSet.araçbilgi2);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
