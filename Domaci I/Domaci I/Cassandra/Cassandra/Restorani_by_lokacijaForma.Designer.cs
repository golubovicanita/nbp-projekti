
namespace Cassandra
{
    partial class Restorani_by_lokacijaForma
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
            this.restoraniLokacija = new System.Windows.Forms.ListView();
            this.restoranID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lokacija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radnoVreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vremeCekanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ocena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restoraniLokacija);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista restorana koji se nalaze na izabranoj lokaciji";
            // 
            // restoraniLokacija
            // 
            this.restoraniLokacija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.restoranID,
            this.naziv,
            this.adresa,
            this.lokacija,
            this.radnoVreme,
            this.telefon,
            this.vremeCekanja,
            this.ocena,
            this.columnHeader1});
            this.restoraniLokacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restoraniLokacija.FullRowSelect = true;
            this.restoraniLokacija.GridLines = true;
            this.restoraniLokacija.HideSelection = false;
            this.restoraniLokacija.Location = new System.Drawing.Point(3, 16);
            this.restoraniLokacija.Name = "restoraniLokacija";
            this.restoraniLokacija.Size = new System.Drawing.Size(752, 394);
            this.restoraniLokacija.TabIndex = 0;
            this.restoraniLokacija.UseCompatibleStateImageBehavior = false;
            this.restoraniLokacija.View = System.Windows.Forms.View.Details;
            // 
            // restoranID
            // 
            this.restoranID.Text = "restoranID";
            this.restoranID.Width = 63;
            // 
            // naziv
            // 
            this.naziv.Text = "naziv";
            this.naziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.naziv.Width = 111;
            // 
            // adresa
            // 
            this.adresa.Text = "adresa";
            this.adresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adresa.Width = 117;
            // 
            // lokacija
            // 
            this.lokacija.Text = "lokacija";
            this.lokacija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lokacija.Width = 80;
            // 
            // radnoVreme
            // 
            this.radnoVreme.Text = "radnoVreme";
            this.radnoVreme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radnoVreme.Width = 75;
            // 
            // telefon
            // 
            this.telefon.Text = "telefon";
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telefon.Width = 79;
            // 
            // vremeCekanja
            // 
            this.vremeCekanja.Text = "vremeCekanja";
            this.vremeCekanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vremeCekanja.Width = 86;
            // 
            // ocena
            // 
            this.ocena.Text = "ocena";
            this.ocena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "uzivoMuzika";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite restoran\r\n ciji meni zelite\r\n da vidite";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(791, 200);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(150, 42);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Restorani_by_lokacijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Restorani_by_lokacijaForma";
            this.Text = "Restorani_by_lokacijaForma";
            this.Load += new System.EventHandler(this.Restorani_by_lokacijaForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView restoraniLokacija;
        private System.Windows.Forms.ColumnHeader restoranID;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader adresa;
        private System.Windows.Forms.ColumnHeader lokacija;
        private System.Windows.Forms.ColumnHeader radnoVreme;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader vremeCekanja;
        private System.Windows.Forms.ColumnHeader ocena;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
    }
}