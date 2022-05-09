
namespace Teklif_Listesi_Hazırlama_Modülü
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.arabox = new System.Windows.Forms.TextBox();
            this.dataselectbut = new System.Windows.Forms.Button();
            this.araboxresult = new System.Windows.Forms.ListBox();
            this.exportexcel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uruneklebutton = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.bradbox = new System.Windows.Forms.TextBox();
            this.categorybox = new System.Windows.Forms.TextBox();
            this.shoeupperbox = new System.Windows.Forms.TextBox();
            this.airliningbox = new System.Windows.Forms.TextBox();
            this.innersolebox = new System.Windows.Forms.TextBox();
            this.midsolebox = new System.Windows.Forms.TextBox();
            this.outsolebox = new System.Windows.Forms.TextBox();
            this.outsolefeaturesbox = new System.Windows.Forms.TextBox();
            this.toeprotectbox = new System.Windows.Forms.TextBox();
            this.sizerangebox = new System.Windows.Forms.TextBox();
            this.priceboxtl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dolarradio = new System.Windows.Forms.RadioButton();
            this.euroradio = new System.Windows.Forms.RadioButton();
            this.kurbuton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceboxdolar = new System.Windows.Forms.TextBox();
            this.priceboxeuro = new System.Windows.Forms.TextBox();
            this.exportpdf = new System.Windows.Forms.Button();
            this.ekliurunlistesi = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.urunsil = new System.Windows.Forms.Button();
            this.veritabaniformac = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // arabox
            // 
            this.arabox.Location = new System.Drawing.Point(597, 12);
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(256, 20);
            this.arabox.TabIndex = 3;
            this.arabox.TextChanged += new System.EventHandler(this.aratext_TextChanged);
            // 
            // dataselectbut
            // 
            this.dataselectbut.Location = new System.Drawing.Point(761, 178);
            this.dataselectbut.Name = "dataselectbut";
            this.dataselectbut.Size = new System.Drawing.Size(92, 23);
            this.dataselectbut.TabIndex = 4;
            this.dataselectbut.Text = "Ürünü Seç";
            this.dataselectbut.UseVisualStyleBackColor = true;
            this.dataselectbut.Click += new System.EventHandler(this.dataselectbut_Click);
            // 
            // araboxresult
            // 
            this.araboxresult.FormattingEnabled = true;
            this.araboxresult.Location = new System.Drawing.Point(597, 38);
            this.araboxresult.Name = "araboxresult";
            this.araboxresult.Size = new System.Drawing.Size(256, 134);
            this.araboxresult.TabIndex = 5;
            // 
            // exportexcel
            // 
            this.exportexcel.Location = new System.Drawing.Point(761, 455);
            this.exportexcel.Name = "exportexcel";
            this.exportexcel.Size = new System.Drawing.Size(92, 23);
            this.exportexcel.TabIndex = 8;
            this.exportexcel.Text = "Excel Oluştur";
            this.exportexcel.UseVisualStyleBackColor = true;
            this.exportexcel.Click += new System.EventHandler(this.exportexcel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Excel Dosyası|*.xlsx";
            this.saveFileDialog.Title = "Dosya Oluştur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // uruneklebutton
            // 
            this.uruneklebutton.Location = new System.Drawing.Point(108, 306);
            this.uruneklebutton.Name = "uruneklebutton";
            this.uruneklebutton.Size = new System.Drawing.Size(110, 23);
            this.uruneklebutton.TabIndex = 12;
            this.uruneklebutton.Text = "Ürünü Listeye Ekle";
            this.uruneklebutton.UseVisualStyleBackColor = true;
            this.uruneklebutton.Click += new System.EventHandler(this.uruneklebutton_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(5, 19);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(213, 20);
            this.namebox.TabIndex = 14;
            // 
            // bradbox
            // 
            this.bradbox.Location = new System.Drawing.Point(5, 45);
            this.bradbox.Name = "bradbox";
            this.bradbox.Size = new System.Drawing.Size(213, 20);
            this.bradbox.TabIndex = 14;
            // 
            // categorybox
            // 
            this.categorybox.Location = new System.Drawing.Point(5, 71);
            this.categorybox.Name = "categorybox";
            this.categorybox.Size = new System.Drawing.Size(213, 20);
            this.categorybox.TabIndex = 14;
            // 
            // shoeupperbox
            // 
            this.shoeupperbox.Location = new System.Drawing.Point(5, 97);
            this.shoeupperbox.Name = "shoeupperbox";
            this.shoeupperbox.Size = new System.Drawing.Size(213, 20);
            this.shoeupperbox.TabIndex = 14;
            // 
            // airliningbox
            // 
            this.airliningbox.Location = new System.Drawing.Point(5, 123);
            this.airliningbox.Name = "airliningbox";
            this.airliningbox.Size = new System.Drawing.Size(213, 20);
            this.airliningbox.TabIndex = 14;
            // 
            // innersolebox
            // 
            this.innersolebox.Location = new System.Drawing.Point(5, 149);
            this.innersolebox.Name = "innersolebox";
            this.innersolebox.Size = new System.Drawing.Size(213, 20);
            this.innersolebox.TabIndex = 14;
            // 
            // midsolebox
            // 
            this.midsolebox.Location = new System.Drawing.Point(5, 175);
            this.midsolebox.Name = "midsolebox";
            this.midsolebox.Size = new System.Drawing.Size(213, 20);
            this.midsolebox.TabIndex = 14;
            // 
            // outsolebox
            // 
            this.outsolebox.Location = new System.Drawing.Point(5, 201);
            this.outsolebox.Name = "outsolebox";
            this.outsolebox.Size = new System.Drawing.Size(213, 20);
            this.outsolebox.TabIndex = 14;
            // 
            // outsolefeaturesbox
            // 
            this.outsolefeaturesbox.Location = new System.Drawing.Point(5, 227);
            this.outsolefeaturesbox.Name = "outsolefeaturesbox";
            this.outsolefeaturesbox.Size = new System.Drawing.Size(213, 20);
            this.outsolefeaturesbox.TabIndex = 14;
            // 
            // toeprotectbox
            // 
            this.toeprotectbox.Location = new System.Drawing.Point(5, 253);
            this.toeprotectbox.Name = "toeprotectbox";
            this.toeprotectbox.Size = new System.Drawing.Size(213, 20);
            this.toeprotectbox.TabIndex = 14;
            // 
            // sizerangebox
            // 
            this.sizerangebox.Location = new System.Drawing.Point(6, 280);
            this.sizerangebox.Name = "sizerangebox";
            this.sizerangebox.Size = new System.Drawing.Size(212, 20);
            this.sizerangebox.TabIndex = 14;
            // 
            // priceboxtl
            // 
            this.priceboxtl.Location = new System.Drawing.Point(68, 19);
            this.priceboxtl.Name = "priceboxtl";
            this.priceboxtl.Size = new System.Drawing.Size(95, 20);
            this.priceboxtl.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 325);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Resmi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sizerangebox);
            this.groupBox2.Controls.Add(this.toeprotectbox);
            this.groupBox2.Controls.Add(this.outsolefeaturesbox);
            this.groupBox2.Controls.Add(this.outsolebox);
            this.groupBox2.Controls.Add(this.midsolebox);
            this.groupBox2.Controls.Add(this.innersolebox);
            this.groupBox2.Controls.Add(this.airliningbox);
            this.groupBox2.Controls.Add(this.shoeupperbox);
            this.groupBox2.Controls.Add(this.categorybox);
            this.groupBox2.Controls.Add(this.bradbox);
            this.groupBox2.Controls.Add(this.namebox);
            this.groupBox2.Controls.Add(this.uruneklebutton);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 336);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Özellikleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dolarradio);
            this.groupBox3.Controls.Add(this.euroradio);
            this.groupBox3.Controls.Add(this.kurbuton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.priceboxdolar);
            this.groupBox3.Controls.Add(this.priceboxeuro);
            this.groupBox3.Controls.Add(this.priceboxtl);
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kur Hesaplama";
            // 
            // dolarradio
            // 
            this.dolarradio.AutoSize = true;
            this.dolarradio.Location = new System.Drawing.Point(169, 72);
            this.dolarradio.Name = "dolarradio";
            this.dolarradio.Size = new System.Drawing.Size(44, 17);
            this.dolarradio.TabIndex = 17;
            this.dolarradio.TabStop = true;
            this.dolarradio.Text = "Seç";
            this.dolarradio.UseVisualStyleBackColor = true;
            // 
            // euroradio
            // 
            this.euroradio.AutoSize = true;
            this.euroradio.Location = new System.Drawing.Point(169, 46);
            this.euroradio.Name = "euroradio";
            this.euroradio.Size = new System.Drawing.Size(44, 17);
            this.euroradio.TabIndex = 17;
            this.euroradio.TabStop = true;
            this.euroradio.Text = "Seç";
            this.euroradio.UseVisualStyleBackColor = true;
            // 
            // kurbuton
            // 
            this.kurbuton.Location = new System.Drawing.Point(169, 17);
            this.kurbuton.Name = "kurbuton";
            this.kurbuton.Size = new System.Drawing.Size(75, 23);
            this.kurbuton.TabIndex = 16;
            this.kurbuton.Text = "Kur Çevir";
            this.kurbuton.UseVisualStyleBackColor = true;
            this.kurbuton.Click += new System.EventHandler(this.kurbuton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dolar Fiyatı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Euro Fiyatı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "TL Fiyatı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceboxdolar
            // 
            this.priceboxdolar.Location = new System.Drawing.Point(68, 71);
            this.priceboxdolar.Name = "priceboxdolar";
            this.priceboxdolar.Size = new System.Drawing.Size(95, 20);
            this.priceboxdolar.TabIndex = 14;
            // 
            // priceboxeuro
            // 
            this.priceboxeuro.Location = new System.Drawing.Point(68, 45);
            this.priceboxeuro.Name = "priceboxeuro";
            this.priceboxeuro.Size = new System.Drawing.Size(95, 20);
            this.priceboxeuro.TabIndex = 14;
            // 
            // exportpdf
            // 
            this.exportpdf.Location = new System.Drawing.Point(761, 426);
            this.exportpdf.Name = "exportpdf";
            this.exportpdf.Size = new System.Drawing.Size(92, 23);
            this.exportpdf.TabIndex = 8;
            this.exportpdf.Text = "PDF Oluştur";
            this.exportpdf.UseVisualStyleBackColor = true;
            this.exportpdf.Click += new System.EventHandler(this.exportpdf_Click);
            // 
            // ekliurunlistesi
            // 
            this.ekliurunlistesi.FormattingEnabled = true;
            this.ekliurunlistesi.Location = new System.Drawing.Point(6, 22);
            this.ekliurunlistesi.Name = "ekliurunlistesi";
            this.ekliurunlistesi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ekliurunlistesi.Size = new System.Drawing.Size(212, 95);
            this.ekliurunlistesi.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.urunsil);
            this.groupBox4.Controls.Add(this.ekliurunlistesi);
            this.groupBox4.Location = new System.Drawing.Point(354, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 152);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listeye Ekli Ürünler";
            // 
            // urunsil
            // 
            this.urunsil.Location = new System.Drawing.Point(108, 123);
            this.urunsil.Name = "urunsil";
            this.urunsil.Size = new System.Drawing.Size(110, 23);
            this.urunsil.TabIndex = 19;
            this.urunsil.Text = "Seçili Ürünü Sil";
            this.urunsil.UseVisualStyleBackColor = true;
            this.urunsil.Click += new System.EventHandler(this.urunsil_Click);
            // 
            // veritabaniformac
            // 
            this.veritabaniformac.Location = new System.Drawing.Point(748, 484);
            this.veritabaniformac.Name = "veritabaniformac";
            this.veritabaniformac.Size = new System.Drawing.Size(105, 23);
            this.veritabaniformac.TabIndex = 20;
            this.veritabaniformac.Text = "Veritabanı Ayarları";
            this.veritabaniformac.UseVisualStyleBackColor = true;
            this.veritabaniformac.Click += new System.EventHandler(this.veritabaniformac_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF|*.pdf";
            this.saveFileDialog1.Title = "Dosya Oluştur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(673, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 519);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.veritabaniformac);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exportpdf);
            this.Controls.Add(this.exportexcel);
            this.Controls.Add(this.araboxresult);
            this.Controls.Add(this.dataselectbut);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Teklif Listesi Hazırlama Modülü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox arabox;
        private System.Windows.Forms.Button dataselectbut;
        private System.Windows.Forms.ListBox araboxresult;
        private System.Windows.Forms.Button exportexcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uruneklebutton;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox bradbox;
        private System.Windows.Forms.TextBox categorybox;
        private System.Windows.Forms.TextBox shoeupperbox;
        private System.Windows.Forms.TextBox airliningbox;
        private System.Windows.Forms.TextBox innersolebox;
        private System.Windows.Forms.TextBox midsolebox;
        private System.Windows.Forms.TextBox outsolebox;
        private System.Windows.Forms.TextBox outsolefeaturesbox;
        private System.Windows.Forms.TextBox toeprotectbox;
        private System.Windows.Forms.TextBox sizerangebox;
        private System.Windows.Forms.TextBox priceboxtl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kurbuton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceboxdolar;
        private System.Windows.Forms.TextBox priceboxeuro;
        private System.Windows.Forms.RadioButton dolarradio;
        private System.Windows.Forms.RadioButton euroradio;
        private System.Windows.Forms.Button exportpdf;
        private System.Windows.Forms.ListBox ekliurunlistesi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button urunsil;
        private System.Windows.Forms.Button veritabaniformac;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

