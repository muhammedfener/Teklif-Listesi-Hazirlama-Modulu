using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace Teklif_Listesi_Hazırlama_Modülü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> searchname = new List<string>();
        public List<string> productid = new List<string>();
        public List<string> name = new List<string>();
        public List<byte[]> picture = new List<byte[]>();
        public List<string> brad = new List<string>();
        public List<string> category = new List<string>();
        public List<string> shoeupper = new List<string>();
        public List<string> airlining = new List<string>();
        public List<string> innersole = new List<string>();
        public List<string> midsole = new List<string>();
        public List<string> outsole = new List<string>();
        public List<string> outsolefea = new List<string>();
        public List<string> toeprotect = new List<string>();
        public List<string> sizerange = new List<string>();
        public List<string> price = new List<string>();

        public string dbip = Properties.Settings.Default.dbip;
        public string dbname = Properties.Settings.Default.dbname;
        public string dbuser = Properties.Settings.Default.dbuser;
        public string dbpass = Properties.Settings.Default.dbpass;
        public string logo = @"/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0a
HBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDL/2wBDAQkJCQwLDBgNDRgyIRwhMjIyMjIy
MjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjL/wAARCAAyAPMDASIA
AhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQA
AAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3
ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWm
p6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEA
AwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSEx
BhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElK
U1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3
uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD1KP4k
eG5o1lhnvJYnGUkjsJ2Vh6ghORT/APhYfh/+9qH/AILp/wD4ioPBN/b6Z8JtH1C7k2W9tpiSyN6K
q5Nc94Z8UeMfiLaXWraJc6doumRTNDbpcW5uJJiOcsdwC9R0oA6j/hYfh/8Avah/4Lp//iKtv4z0
KPQ4dZa7b7FNN5EbCFyzSZI2bMbs5B4x2rK+H3iDX9bXWbXxFb2kV3pl59lJtgQHIXJbk9DkYrAU
50LQyT/zN7f+jpaAOp/4WH4f/vah/wCC2f8A+Io/4WH4f/vah/4LZ/8A4iuT+JXxD8VfD+5hm+wa
RdaddyMtud0glXAB+cZx37VZ0zxN8S9X8PW2tWeieHmguYBPFGbmUOVIyBjpn8aAOjHxE8O70Dz3
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";
        private void aratext_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(arabox.Text) == false)
            {
                araboxresult.Items.Clear();
                foreach (string str in searchname)
                {
                    if (str.ToLower().Contains(arabox.Text))
                    {
                        araboxresult.Items.Add(str);
                    }
                }
            }
            else if (arabox.Text == "")
            {
                araboxresult.Items.Clear();
                foreach (string str in searchname)
                {
                    araboxresult.Items.Add(str);
                }
            }
        }

        public string urunid;
        public byte[] urunimg;

        /*public string name;
        public string brad;
        public string category;
        public string shoeupper;
        public string airlining;
        public string innersole;
        public string midsole;
        public string outsole;
        public string outsolefeatures;
        public string toeprotect;
        public string sizerange;
        public string price;*/


        public float dolar;
        public float euro;

        private void dataselectbut_Click(object sender, EventArgs e)
        {
            try
            {
                string db = "server=" + dbip + "; uid=" + dbuser + "; pwd=" + dbpass + "; database=" + dbname + ";";
                string selecturunname = araboxresult.SelectedItem.ToString();

                string urunsorgu = "SELECT * FROM products WHERE name='" + selecturunname + "'";
                MySqlConnection baglanti = new MySqlConnection(db);
                MySqlCommand uruncek = new MySqlCommand();
                baglanti.Open();
                uruncek.Connection = baglanti;
                uruncek.CommandText = urunsorgu;
                MySqlDataReader result = uruncek.ExecuteReader();
                result.Read();
                byte[] img;
                long size = result.GetBytes(2, 0, null, 0, 0);
                img = new byte[size];
                result.GetBytes(2, 0, img, 0, img.Length);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                urunid = result.GetString(0);
                namebox.Text = result.GetString(1);
                urunimg = img;
                bradbox.Text = result.GetString(3);
                categorybox.Text = result.GetString(4);
                shoeupperbox.Text = result.GetString(5);
                airliningbox.Text = result.GetString(6);
                innersolebox.Text = result.GetString(7);
                midsolebox.Text = result.GetString(8);
                outsolebox.Text = result.GetString(9);
                outsolefeaturesbox.Text = result.GetString(10);
                toeprotectbox.Text = result.GetString(11);
                sizerangebox.Text = result.GetString(12);
                if (result.IsDBNull(13))
                {
                    priceboxtl.Text = "0";
                }
                else
                {
                    priceboxtl.Text = result.GetString(13);
                }

                result.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            try
            {
                string db = "server=" + dbip + "; uid=" + dbuser + "; pwd=" + dbpass + "; database=" + dbname + ";";
                MySqlConnection baglanti = new MySqlConnection(db);
                MySqlCommand komut = new MySqlCommand();
                baglanti.Open();
                string tumurunlersorgu = "SELECT name FROM products";
                komut.CommandText = tumurunlersorgu;
                komut.Connection = baglanti;
                MySqlDataReader result = komut.ExecuteReader();
                while (result.Read())
                {
                    searchname.Add(result.GetString("name"));
                    araboxresult.Items.Add(result.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına Bağlanırken Hata Oluştu!","Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
                XmlNodeList names = xmlDoc.GetElementsByTagName("Isim");
                XmlNodeList currency = xmlDoc.GetElementsByTagName("BanknoteSelling");
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].InnerText == "ABD DOLARI")
                    {
                        dolar = float.Parse(currency[i].InnerText, CultureInfo.InvariantCulture.NumberFormat);
                    }
                    if (names[i].InnerText == "EURO")
                    {
                        euro = float.Parse(currency[i].InnerText, CultureInfo.InvariantCulture.NumberFormat);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("KUR BİLGİLERİ ALINAMIYOR!");
            }
        }
        public static Bitmap resizeImage(Image imgToResize, Size size)
        {
            return (new Bitmap(imgToResize, size));
        }



        private void exportexcel_Click(object sender, EventArgs e)
        {
            /*if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
            }*/

            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Page 1");

            ws.Columns().Width = 8.43;
            ws.Rows().Height = 15;
            ws.Column(5).Width = 11.29;
            byte[] imageBytes = Convert.FromBase64String(logo);
            var logoimg = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Bitmap logobmp = new Bitmap(logoimg);

            for (int i = 0; i < name.Count; i++)
            {
                if(i%3 == 0)
                {
                    var logoarka = ws.Range(2, 1, 4, 3);
                    var officalarka = ws.Range(2, 4, 4, 9);

                    ws.AddPicture(logobmp, "logo.jpg").MoveTo(ws.Cell(2,1),4,11,ws.Cell(5,4),-4,-11);
                    logoarka.Merge();

                    officalarka.Merge().Value = "OFFICAL PRICE OFFER";
                    officalarka.Style.Font.Bold = true;
                    officalarka.Style.Font.FontSize = 18;
                    officalarka.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    officalarka.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                }
                var urunbaslik = ws.Range(6,1,7,9);
                var resimarka = ws.Range(8,1,19,4);
                var enisoyazi = ws.Range(8,5,8,9);
                var categoryicer = ws.Range(9,6,9,9);
                var shoeuppericer = ws.Range(10,6,10,9);
                var liningicer = ws.Range(11,6,11,9);
                var innersolicer = ws.Range(12, 6, 12, 9);
                var midsolicer = ws.Range(13, 6, 13, 9);
                var outsolicer = ws.Range(14, 6, 14, 9);
                var outsolefeaicer = ws.Range(15, 6, 15, 9);
                var toeproticer = ws.Range(16, 6, 16, 9);
                var sizerngicer = ws.Range(17, 6, 17, 9);
                var priceicer = ws.Range(18,5,19,9);

                var categoryyazi = ws.Cell(9, 5);
                var shoeupperyazi = ws.Cell(10, 5);
                var liningyazi = ws.Cell(11, 5);
                var innersoleyazi = ws.Cell(12, 5);
                var midsoleyazi = ws.Cell(13, 5);
                var outsoleyazi = ws.Cell(14, 5);
                var outsolefeatyazi = ws.Cell(15, 5);
                var toeprotectyazi = ws.Cell(16, 5);
                var sizerangeyazi = ws.Cell(17, 5);

                urunbaslik.Merge().Value = name[0];
                urunbaslik.Style.Font.Bold = true;
                urunbaslik.Style.Font.FontSize = 16;
                urunbaslik.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                urunbaslik.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                urunbaslik.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                resimarka.Merge();
                resimarka.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                resimarka.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                resimarka.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                var ms = new MemoryStream(picture[i]);
                Bitmap bitmap = new Bitmap(ms);
                ws.AddPicture(bitmap, "Test").MoveTo(ws.Cell(8, 1), 10, 1, ws.Cell(20, 5), -10, -1);

                enisoyazi.Merge().Value = "EN ISO 20345:2011";
                enisoyazi.Style.Font.Bold = true;
                enisoyazi.Style.Font.FontSize = 11;
                enisoyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                enisoyazi.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                enisoyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                categoryyazi.Value = "Category:";
                categoryyazi.Style.Font.Bold = true;
                categoryyazi.Style.Font.FontSize = 9;
                categoryyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                categoryyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                categoryicer.Merge().Value = category[i];
                categoryicer.Style.Font.FontSize = 9;
                categoryicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                categoryicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                categoryicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                shoeupperyazi.Value = "Shoe Upper:";
                shoeupperyazi.Style.Font.Bold = true;
                shoeupperyazi.Style.Font.FontSize = 9;
                shoeupperyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                shoeupperyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                shoeuppericer.Merge().Value = shoeupper[i];
                shoeuppericer.Style.Font.FontSize = 9;
                shoeuppericer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                shoeuppericer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                shoeuppericer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                liningyazi.Value = "Lining:";
                liningyazi.Style.Font.Bold = true;
                liningyazi.Style.Font.FontSize = 9;
                liningyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                liningyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                liningicer.Merge().Value = airlining[i];
                liningicer.Style.Font.FontSize = 9;
                liningicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                liningicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                liningicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                innersoleyazi.Value = "Inner Sole:";
                innersoleyazi.Style.Font.Bold = true;
                innersoleyazi.Style.Font.FontSize = 9;
                innersoleyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                innersoleyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                innersolicer.Merge().Value = innersole[i];
                innersolicer.Style.Font.FontSize = 9;
                innersolicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                innersolicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                innersolicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                midsoleyazi.Value = "Midsole:";
                midsoleyazi.Style.Font.Bold = true;
                midsoleyazi.Style.Font.FontSize = 9;
                midsoleyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                midsoleyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                midsolicer.Merge().Value = midsole[i];
                midsolicer.Style.Font.FontSize = 9;
                midsolicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                midsolicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                midsolicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                outsoleyazi.Value = "Outsole:";
                outsoleyazi.Style.Font.Bold = true;
                outsoleyazi.Style.Font.FontSize = 9;
                outsoleyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                outsoleyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                outsolicer.Merge().Value = outsole[i];
                outsolicer.Style.Font.FontSize = 9;
                outsolicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                outsolicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                outsolicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                outsolefeatyazi.Value = "Outsole Features:";
                outsolefeatyazi.Style.Font.Bold = true;
                outsolefeatyazi.Style.Font.FontSize = 9;
                outsolefeatyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                outsolefeatyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                outsolefeaicer.Merge().Value = outsolefea[i];
                outsolefeaicer.Style.Font.FontSize = 9;
                outsolefeaicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                outsolefeaicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                outsolefeaicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                toeprotectyazi.Value = "Toe Protection:";
                toeprotectyazi.Style.Font.Bold = true;
                toeprotectyazi.Style.Font.FontSize = 9;
                toeprotectyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                toeprotectyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                toeproticer.Merge().Value = toeprotect[i];
                toeproticer.Style.Font.FontSize = 9;
                toeproticer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                toeproticer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                toeproticer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                sizerangeyazi.Value = "Size Range:";
                sizerangeyazi.Style.Font.Bold = true;
                sizerangeyazi.Style.Font.FontSize = 9;
                sizerangeyazi.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Bottom);
                sizerangeyazi.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                sizerngicer.Merge().Value = sizerange[i];
                sizerngicer.Style.Font.FontSize = 9;
                sizerngicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                sizerngicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Left);
                sizerngicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                priceicer.Merge().Value = "PRICE" + Environment.NewLine + price[i];
                priceicer.Style.Font.Bold = true;
                priceicer.Style.Font.FontSize = 11;
                priceicer.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Top);
                priceicer.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                priceicer.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                /*
                range13.Merge().Value = "Price:" + Environment.NewLine + price[i];
                range13.Style.Font.Bold = true;
                range13.Style.Font.FontSize = 12;
                range13.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Top);
                range13.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                range13.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                imagerange.Merge();
                imagerange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;*/

            }
            /*var ms = new MemoryStream(urunimg);
            Bitmap bitmap = new Bitmap(ms);
            ws.AddPicture(bitmap, "Test").MoveTo(ws.Cell("B5")).WithSize(275,275);*/
            wb.SaveAs("file.xlsx");

        }

        private void uruneklebutton_Click(object sender, EventArgs e)
        {
            if (euroradio.Checked == true)
            {
                price.Add(priceboxeuro.Text);
            }
            else if (dolarradio.Checked == true)
            {
                price.Add(priceboxdolar.Text);
            }
            else
            {
                MessageBox.Show("Bir Fiyat Birimi Seçin!", "Hata!");
                return;
            }

            productid.Add(urunid);
            name.Add(namebox.Text);
            picture.Add(urunimg);
            brad.Add(bradbox.Text);
            category.Add(categorybox.Text);
            shoeupper.Add(shoeupperbox.Text);
            airlining.Add(airliningbox.Text);
            innersole.Add(innersolebox.Text);
            midsole.Add(midsolebox.Text);
            outsole.Add(outsolebox.Text);
            outsolefea.Add(outsolefeaturesbox.Text);
            toeprotect.Add(toeprotectbox.Text);
            sizerange.Add(sizerangebox.Text);

            ekliurunlistesi.Items.Add(namebox.Text);
        }

        private void kurbuton_Click(object sender, EventArgs e)
        {
            try
            {
                float tlfiyat = float.Parse(priceboxtl.Text, CultureInfo.InvariantCulture.NumberFormat);
                priceboxeuro.Text = Convert.ToString(tlfiyat / euro);
                priceboxdolar.Text = Convert.ToString(tlfiyat / dolar);
            }
            catch (Exception)
            {
                MessageBox.Show("TL Değeri Girin!", "Hata");
            }
        }

        private void exportpdf_Click(object sender, EventArgs e)
        {

        }

        private void urunsil_Click(object sender, EventArgs e)
        {
            string silinecekurunadi = ekliurunlistesi.SelectedItem.ToString();
            int index = name.IndexOf(silinecekurunadi);
            ekliurunlistesi.Items.Remove(silinecekurunadi);
            productid.RemoveAt(index);
            name.RemoveAt(index);
            picture.RemoveAt(index);
            brad.RemoveAt(index);
            category.RemoveAt(index);
            shoeupper.RemoveAt(index);
            airlining.RemoveAt(index);
            innersole.RemoveAt(index);
            midsole.RemoveAt(index);
            outsole.RemoveAt(index);
            outsolefea.RemoveAt(index);
            toeprotect.RemoveAt(index);
            sizerange.RemoveAt(index);
            price.RemoveAt(index);
        }

        private void veritabaniformac_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

    }
}
