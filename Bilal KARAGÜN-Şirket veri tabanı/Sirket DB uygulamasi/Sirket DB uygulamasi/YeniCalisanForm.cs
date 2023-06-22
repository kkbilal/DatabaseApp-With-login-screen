using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Sirket_DB_uygulamasi
{
    public partial class YeniCalisanForm : Form
    {
        public YeniCalisanForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=\"Sirket DB\";Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void YeniCalisanForm_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personel(ad,soyad,cinsiyet,dogum_tarihi,dogum_yeri,baslama_tarihi,birim_no,unvan_no,calisma_saati,maas,prim) values ('" + txtad.Text + "','" + txtsoy.Text + "','" + txtcins.Text + "','" + txtdogumt.Text + "','" + txtdogumy.Text + "','" + txtbaslama.Text + "','" + txtbirim.Text + "','" + txtunvan.Text + "','" + txtcalismasaat.Text + "','" + txtmaas.Text + "','" + txtprim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Yapılmıştır!");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void butmain_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
        }
    }
}
