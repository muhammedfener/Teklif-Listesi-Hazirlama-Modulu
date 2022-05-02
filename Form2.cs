using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Teklif_Listesi_Hazırlama_Modülü
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void baglantitestbut_Click(object sender, EventArgs e)
        {
            string db = "server=" + dbip.Text + "; uid=" + dbuser.Text + "; pwd=" + dbpass.Text + "; database=" + dbname.Text + ";";
            MySqlConnection testbaglanti = new MySqlConnection(db);
            try
            {
                testbaglanti.Open();
                MessageBox.Show("Bağlantı Başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı Hatası!" + hata.ToString(), "HATA!");
            }
        }

        private void baglantikaydetbut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbip = dbip.Text;
            Properties.Settings.Default.dbname = dbname.Text;
            Properties.Settings.Default.dbuser = dbuser.Text;
            Properties.Settings.Default.dbpass = dbpass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Ayarlar Kaydedildi. Uygulama Yeniden Başlatılacak.");
            Application.Restart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dbip.Text = Properties.Settings.Default.dbip;
            dbname.Text = Properties.Settings.Default.dbname;
            dbuser.Text = Properties.Settings.Default.dbuser;
            dbpass.Text = Properties.Settings.Default.dbpass;
        }
    }
}
