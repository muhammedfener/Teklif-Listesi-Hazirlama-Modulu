
namespace Teklif_Listesi_Hazırlama_Modülü
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.TextBox();
            this.dbuser = new System.Windows.Forms.TextBox();
            this.dbpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baglantitestbut = new System.Windows.Forms.Button();
            this.baglantikaydetbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbip
            // 
            this.dbip.Location = new System.Drawing.Point(104, 6);
            this.dbip.Name = "dbip";
            this.dbip.Size = new System.Drawing.Size(100, 20);
            this.dbip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veritabanı Adresi";
            // 
            // dbname
            // 
            this.dbname.Location = new System.Drawing.Point(104, 32);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(100, 20);
            this.dbname.TabIndex = 0;
            // 
            // dbuser
            // 
            this.dbuser.Location = new System.Drawing.Point(104, 58);
            this.dbuser.Name = "dbuser";
            this.dbuser.Size = new System.Drawing.Size(100, 20);
            this.dbuser.TabIndex = 0;
            // 
            // dbpass
            // 
            this.dbpass.Location = new System.Drawing.Point(104, 84);
            this.dbpass.Name = "dbpass";
            this.dbpass.Size = new System.Drawing.Size(100, 20);
            this.dbpass.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // baglantitestbut
            // 
            this.baglantitestbut.Location = new System.Drawing.Point(68, 110);
            this.baglantitestbut.Name = "baglantitestbut";
            this.baglantitestbut.Size = new System.Drawing.Size(65, 46);
            this.baglantitestbut.TabIndex = 2;
            this.baglantitestbut.Text = "Bağlantıyı Test Et";
            this.baglantitestbut.UseVisualStyleBackColor = true;
            this.baglantitestbut.Click += new System.EventHandler(this.baglantitestbut_Click);
            // 
            // baglantikaydetbut
            // 
            this.baglantikaydetbut.Location = new System.Drawing.Point(139, 110);
            this.baglantikaydetbut.Name = "baglantikaydetbut";
            this.baglantikaydetbut.Size = new System.Drawing.Size(65, 46);
            this.baglantikaydetbut.TabIndex = 2;
            this.baglantikaydetbut.Text = "Bilgileri Kaydet";
            this.baglantikaydetbut.UseVisualStyleBackColor = true;
            this.baglantikaydetbut.Click += new System.EventHandler(this.baglantikaydetbut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 167);
            this.Controls.Add(this.baglantikaydetbut);
            this.Controls.Add(this.baglantitestbut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbpass);
            this.Controls.Add(this.dbuser);
            this.Controls.Add(this.dbname);
            this.Controls.Add(this.dbip);
            this.Name = "Form2";
            this.Text = "Veritabanı Bilgileri";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dbip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbname;
        private System.Windows.Forms.TextBox dbuser;
        private System.Windows.Forms.TextBox dbpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button baglantitestbut;
        private System.Windows.Forms.Button baglantikaydetbut;
    }
}