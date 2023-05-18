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

namespace Bedir_Hotel_Pansiyon_ve_Dinlenme
{
    public partial class FormAdmin : Form
    {
        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection conn;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user=txt_username.Text;
            string password=txt_password.Text;

            conn=new SqlConnection("Data Source=Burak_Laptop;Initial Catalog=Bedir_Hotel;Integrated Security=True");
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select*from AdminGiris where Kullanici='"+txt_username.Text+"'AND Sifre='"+txt_password.Text+"'";
            reader = cmd.ExecuteReader();

            if(reader.Read())
            {
               // MessageBox.Show("Tebrikler Giriş Başarılı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmAnaform frmAnaform = new FrmAnaform();
                frmAnaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
            
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
