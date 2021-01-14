
namespace Cassandra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.allRes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lokacije = new System.Windows.Forms.ComboBox();
            this.btnResLokacije = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikaziRestOcenaVeca = new System.Windows.Forms.Button();
            this.brnPrikaziRestKraceVreme = new System.Windows.Forms.Button();
            this.txtVremeCekanja = new System.Windows.Forms.TextBox();
            this.numOcena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikaziKorisnike = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnPretraziBr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMuzika = new System.Windows.Forms.CheckBox();
            this.btnLokacijaMuzika = new System.Windows.Forms.Button();
            this.lokacijaMuzika = new System.Windows.Forms.ComboBox();
            this.btnDodajRestoran = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // allRes
            // 
            this.allRes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.allRes.FlatAppearance.BorderSize = 3;
            this.allRes.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.allRes.Location = new System.Drawing.Point(43, 59);
            this.allRes.Name = "allRes";
            this.allRes.Size = new System.Drawing.Size(177, 47);
            this.allRes.TabIndex = 0;
            this.allRes.Text = "Restorani";
            this.allRes.UseVisualStyleBackColor = true;
            this.allRes.Click += new System.EventHandler(this.allRes_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Lista svih restorana u gradu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restorani na lokaciji:";
            // 
            // lokacije
            // 
            this.lokacije.FormattingEnabled = true;
            this.lokacije.Location = new System.Drawing.Point(340, 19);
            this.lokacije.Name = "lokacije";
            this.lokacije.Size = new System.Drawing.Size(121, 21);
            this.lokacije.TabIndex = 4;
            // 
            // btnResLokacije
            // 
            this.btnResLokacije.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResLokacije.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResLokacije.Location = new System.Drawing.Point(500, 20);
            this.btnResLokacije.Name = "btnResLokacije";
            this.btnResLokacije.Size = new System.Drawing.Size(87, 22);
            this.btnResLokacije.TabIndex = 5;
            this.btnResLokacije.Text = "Prikazi";
            this.btnResLokacije.UseVisualStyleBackColor = true;
            this.btnResLokacije.Click += new System.EventHandler(this.btnResLokacije_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Restorani sa vecom/jednakom ocenom od: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Restorani sa kracim vremenom cekanja od:\r\n(u minutima)";
            // 
            // btnPrikaziRestOcenaVeca
            // 
            this.btnPrikaziRestOcenaVeca.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziRestOcenaVeca.Location = new System.Drawing.Point(500, 48);
            this.btnPrikaziRestOcenaVeca.Name = "btnPrikaziRestOcenaVeca";
            this.btnPrikaziRestOcenaVeca.Size = new System.Drawing.Size(87, 23);
            this.btnPrikaziRestOcenaVeca.TabIndex = 8;
            this.btnPrikaziRestOcenaVeca.Text = "Prikazi";
            this.btnPrikaziRestOcenaVeca.UseVisualStyleBackColor = true;
            this.btnPrikaziRestOcenaVeca.Click += new System.EventHandler(this.btnPrikaziRestOcenaVeca_Click);
            // 
            // brnPrikaziRestKraceVreme
            // 
            this.brnPrikaziRestKraceVreme.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnPrikaziRestKraceVreme.Location = new System.Drawing.Point(500, 73);
            this.brnPrikaziRestKraceVreme.Name = "brnPrikaziRestKraceVreme";
            this.brnPrikaziRestKraceVreme.Size = new System.Drawing.Size(87, 24);
            this.brnPrikaziRestKraceVreme.TabIndex = 9;
            this.brnPrikaziRestKraceVreme.Text = "Prikazi";
            this.brnPrikaziRestKraceVreme.UseVisualStyleBackColor = true;
            this.brnPrikaziRestKraceVreme.Click += new System.EventHandler(this.brnPrikaziRestKraceVreme_Click);
            // 
            // txtVremeCekanja
            // 
            this.txtVremeCekanja.Location = new System.Drawing.Point(403, 77);
            this.txtVremeCekanja.Name = "txtVremeCekanja";
            this.txtVremeCekanja.Size = new System.Drawing.Size(58, 20);
            this.txtVremeCekanja.TabIndex = 11;
            // 
            // numOcena
            // 
            this.numOcena.Location = new System.Drawing.Point(381, 51);
            this.numOcena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOcena.Name = "numOcena";
            this.numOcena.Size = new System.Drawing.Size(80, 20);
            this.numOcena.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(85, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lista svih korisnika";
            // 
            // btnPrikaziKorisnike
            // 
            this.btnPrikaziKorisnike.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziKorisnike.Location = new System.Drawing.Point(69, 36);
            this.btnPrikaziKorisnike.Name = "btnPrikaziKorisnike";
            this.btnPrikaziKorisnike.Size = new System.Drawing.Size(153, 50);
            this.btnPrikaziKorisnike.TabIndex = 14;
            this.btnPrikaziKorisnike.Text = "Korisnici";
            this.btnPrikaziKorisnike.UseVisualStyleBackColor = true;
            this.btnPrikaziKorisnike.Click += new System.EventHandler(this.btnPrikaziKorisnike_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Da li se korisnik nalazi na spisku svih korisnika?\r\n";
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(165, 145);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(100, 20);
            this.txtBroj.TabIndex = 16;
            // 
            // btnPretraziBr
            // 
            this.btnPretraziBr.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziBr.Location = new System.Drawing.Point(96, 192);
            this.btnPretraziBr.Name = "btnPretraziBr";
            this.btnPretraziBr.Size = new System.Drawing.Size(100, 23);
            this.btnPretraziBr.TabIndex = 17;
            this.btnPretraziBr.Text = "Proveri";
            this.btnPretraziBr.UseVisualStyleBackColor = true;
            this.btnPretraziBr.Click += new System.EventHandler(this.btnPretraziBr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Broj telefona:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Izaberite lokaciju i da li zelite muziku:";
            // 
            // cbMuzika
            // 
            this.cbMuzika.AutoSize = true;
            this.cbMuzika.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMuzika.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMuzika.Location = new System.Drawing.Point(271, 110);
            this.cbMuzika.Name = "cbMuzika";
            this.cbMuzika.Size = new System.Drawing.Size(60, 17);
            this.cbMuzika.TabIndex = 20;
            this.cbMuzika.Text = "muzika";
            this.cbMuzika.UseVisualStyleBackColor = true;
            // 
            // btnLokacijaMuzika
            // 
            this.btnLokacijaMuzika.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLokacijaMuzika.Location = new System.Drawing.Point(500, 104);
            this.btnLokacijaMuzika.Name = "btnLokacijaMuzika";
            this.btnLokacijaMuzika.Size = new System.Drawing.Size(87, 23);
            this.btnLokacijaMuzika.TabIndex = 21;
            this.btnLokacijaMuzika.Text = "Prikazi";
            this.btnLokacijaMuzika.UseVisualStyleBackColor = true;
            this.btnLokacijaMuzika.Click += new System.EventHandler(this.btnLokacijaMuzika_Click);
            // 
            // lokacijaMuzika
            // 
            this.lokacijaMuzika.FormattingEnabled = true;
            this.lokacijaMuzika.Location = new System.Drawing.Point(350, 107);
            this.lokacijaMuzika.Name = "lokacijaMuzika";
            this.lokacijaMuzika.Size = new System.Drawing.Size(111, 21);
            this.lokacijaMuzika.TabIndex = 22;
            // 
            // btnDodajRestoran
            // 
            this.btnDodajRestoran.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRestoran.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDodajRestoran.Location = new System.Drawing.Point(43, 132);
            this.btnDodajRestoran.Name = "btnDodajRestoran";
            this.btnDodajRestoran.Size = new System.Drawing.Size(177, 48);
            this.btnDodajRestoran.TabIndex = 23;
            this.btnDodajRestoran.Text = "Dodaj restoran";
            this.btnDodajRestoran.UseVisualStyleBackColor = true;
            this.btnDodajRestoran.Click += new System.EventHandler(this.btnDodajRestoran_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(122, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 40);
            this.label8.TabIndex = 24;
            this.label8.Text = "Izaberite datum da biste videli \r\nsve rezervacije za tad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPrikaziKorisnike);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPretraziBr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Location = new System.Drawing.Point(550, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 229);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.allRes);
            this.groupBox2.Controls.Add(this.btnDodajRestoran);
            this.groupBox2.Location = new System.Drawing.Point(29, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 229);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restoran";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(352, 39);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 20);
            this.datum.TabIndex = 27;
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacije.Location = new System.Drawing.Point(607, 32);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(148, 38);
            this.btnRezervacije.TabIndex = 28;
            this.btnRezervacije.Text = "Prikazi";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lokacije);
            this.groupBox3.Controls.Add(this.btnResLokacije);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numOcena);
            this.groupBox3.Controls.Add(this.btnPrikaziRestOcenaVeca);
            this.groupBox3.Controls.Add(this.lokacijaMuzika);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbMuzika);
            this.groupBox3.Controls.Add(this.btnLokacijaMuzika);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtVremeCekanja);
            this.groupBox3.Controls.Add(this.brnPrikaziRestKraceVreme);
            this.groupBox3.Location = new System.Drawing.Point(29, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 133);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prikaz restorana koji ispunjavaju uslove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Pocetna stranica";
            ((System.ComponentModel.ISupportInitialize)(this.numOcena)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allRes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lokacije;
        private System.Windows.Forms.Button btnResLokacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikaziRestOcenaVeca;
        private System.Windows.Forms.Button brnPrikaziRestKraceVreme;
        private System.Windows.Forms.TextBox txtVremeCekanja;
        private System.Windows.Forms.NumericUpDown numOcena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaziKorisnike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Button btnPretraziBr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbMuzika;
        private System.Windows.Forms.Button btnLokacijaMuzika;
        private System.Windows.Forms.ComboBox lokacijaMuzika;
        private System.Windows.Forms.Button btnDodajRestoran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

