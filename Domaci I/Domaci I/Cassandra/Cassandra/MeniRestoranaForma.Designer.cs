
namespace Cassandra
{
    partial class MeniRestoranaForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaMenija = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtImeRestorana = new System.Windows.Forms.TextBox();
            this.btnDodaUMeni = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnikBroj = new System.Windows.Forms.TextBox();
            this.btnPrikaziLicniMeni = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaMenija);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meni jednog restorana";
            // 
            // listaMenija
            // 
            this.listaMenija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaMenija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaMenija.FullRowSelect = true;
            this.listaMenija.GridLines = true;
            this.listaMenija.HideSelection = false;
            this.listaMenija.Location = new System.Drawing.Point(3, 16);
            this.listaMenija.Name = "listaMenija";
            this.listaMenija.Size = new System.Drawing.Size(475, 340);
            this.listaMenija.TabIndex = 0;
            this.listaMenija.UseCompatibleStateImageBehavior = false;
            this.listaMenija.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "restoranID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "meniID";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "naziv";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "tipJela";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "kolicina";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "cena";
            this.columnHeader6.Width = 62;
            // 
            // txtImeRestorana
            // 
            this.txtImeRestorana.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtImeRestorana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImeRestorana.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeRestorana.Location = new System.Drawing.Point(110, 19);
            this.txtImeRestorana.Name = "txtImeRestorana";
            this.txtImeRestorana.Size = new System.Drawing.Size(310, 29);
            this.txtImeRestorana.TabIndex = 1;
            // 
            // btnDodaUMeni
            // 
            this.btnDodaUMeni.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaUMeni.Location = new System.Drawing.Point(23, 67);
            this.btnDodaUMeni.Name = "btnDodaUMeni";
            this.btnDodaUMeni.Size = new System.Drawing.Size(205, 43);
            this.btnDodaUMeni.TabIndex = 2;
            this.btnDodaUMeni.Text = "Dodaj u meni";
            this.btnDodaUMeni.UseVisualStyleBackColor = true;
            this.btnDodaUMeni.Click += new System.EventHandler(this.btnDodaUMeni_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.Location = new System.Drawing.Point(322, 67);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(196, 43);
            this.btnUkloni.TabIndex = 5;
            this.btnUkloni.Text = "Ukloni iz menija";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnUbaci
            // 
            this.btnUbaci.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbaci.Location = new System.Drawing.Point(322, 71);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(196, 43);
            this.btnUbaci.TabIndex = 6;
            this.btnUbaci.Text = "Dodaj u licni meni";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izaberite stavke koje zelite u svom \r\nlicnom meniju:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(186, 195);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(206, 42);
            this.btnKreiraj.TabIndex = 8;
            this.btnKreiraj.Text = "Kreiraj licni meni";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unesite Vas broj telefona:";
            // 
            // txtKorisnikBroj
            // 
            this.txtKorisnikBroj.Location = new System.Drawing.Point(322, 147);
            this.txtKorisnikBroj.Name = "txtKorisnikBroj";
            this.txtKorisnikBroj.Size = new System.Drawing.Size(196, 20);
            this.txtKorisnikBroj.TabIndex = 10;
            // 
            // btnPrikaziLicniMeni
            // 
            this.btnPrikaziLicniMeni.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziLicniMeni.Location = new System.Drawing.Point(186, 243);
            this.btnPrikaziLicniMeni.Name = "btnPrikaziLicniMeni";
            this.btnPrikaziLicniMeni.Size = new System.Drawing.Size(206, 64);
            this.btnPrikaziLicniMeni.TabIndex = 11;
            this.btnPrikaziLicniMeni.Text = "Prikazi licni meni i rezervisi!";
            this.btnPrikaziLicniMeni.UseVisualStyleBackColor = true;
            this.btnPrikaziLicniMeni.Click += new System.EventHandler(this.btnPrikaziLicniMeni_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Da biste rezervisali dodajte stavke u licni meni, kreirajte licni meni i \r\nunesit" +
    "e svoj broj telefona!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImeRestorana);
            this.groupBox2.Controls.Add(this.btnDodaUMeni);
            this.groupBox2.Controls.Add(this.btnUkloni);
            this.groupBox2.Location = new System.Drawing.Point(532, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 129);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restoran";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnUbaci);
            this.groupBox3.Controls.Add(this.btnKreiraj);
            this.groupBox3.Controls.Add(this.btnPrikaziLicniMeni);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtKorisnikBroj);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(532, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 313);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezervacija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "*obavezno za licni meni i rezervaciju";
            // 
            // MeniRestoranaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1094, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MeniRestoranaForma";
            this.Text = "MeniRestoranaForma";
            this.Load += new System.EventHandler(this.MeniRestoranaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaMenija;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtImeRestorana;
        private System.Windows.Forms.Button btnDodaUMeni;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnikBroj;
        private System.Windows.Forms.Button btnPrikaziLicniMeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}