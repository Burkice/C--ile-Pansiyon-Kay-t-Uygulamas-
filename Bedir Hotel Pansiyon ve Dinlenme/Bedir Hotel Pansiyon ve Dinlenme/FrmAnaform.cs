using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedir_Hotel_Pansiyon_ve_Dinlenme
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btn_yeniMüsteri_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri_Ekle yeni_Müsteri_Ekle = new Yeni_Müsteri_Ekle();
            yeni_Müsteri_Ekle.Show();
            this.Hide();

        }

        private void btn_oda_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMüsteri frmMüsteri =new FrmMüsteri();
            frmMüsteri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İLK C# PROJEM /2023 - İSTANBUL");
        }

        private void FrmAnaform_Load(object sender, EventArgs e)
        {
           // label1.Text = DateTime.Now.ToLongDateString();
           // label2.Text = DateTime.Now.ToLongTimeString();
           //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToLongDateString();
            //label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
