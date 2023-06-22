using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirket_DB_uygulamasi
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Frmadmin fr = new Frmadmin();
            fr.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            YeniCalisanForm fr = new  YeniCalisanForm();
            fr.Show();
            this.Hide();
        }

        private void btngör_Click(object sender, EventArgs e)
        {
            Frmpersoneller fr = new Frmpersoneller();
            fr.Show();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            frmtablolar fr = new frmtablolar();
            fr.Show();
            this.Hide();
        }
    }
}
