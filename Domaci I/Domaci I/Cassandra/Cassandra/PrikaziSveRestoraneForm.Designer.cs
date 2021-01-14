
namespace Cassandra
{
    partial class PrikaziSveRestoraneForm
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
            this.ListaSvihRestorana = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikaziMeni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUtisci = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUtisak = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaSvihRestorana);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista svih restorana u gradu";
            // 
            // ListaSvihRestorana
            // 
            this.ListaSvihRestorana.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader6});
            this.ListaSvihRestorana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaSvihRestorana.FullRowSelect = true;
            this.ListaSvihRestorana.GridLines = true;
            this.ListaSvihRestorana.HideSelection = false;
            this.ListaSvihRestorana.Location = new System.Drawing.Point(3, 16);
            this.ListaSvihRestorana.Name = "ListaSvihRestorana";
            this.ListaSvihRestorana.Size = new System.Drawing.Size(789, 391);
            this.ListaSvihRestorana.TabIndex = 0;
            this.ListaSvihRestorana.UseCompatibleStateImageBehavior = false;
            this.ListaSvihRestorana.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "restoranID";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "naziv";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "adresa";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "lokacija";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "radnoVreme";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "telefon";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "vremeCekanja";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 83;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ocena";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "uzivoMuzika";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 76;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(830, 76);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(152, 38);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite koji restoran \r\nzelite da obrisete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberite za koji\r\nrestoran zelite da vidite \r\nmeni:";
            // 
            // btnPrikaziMeni
            // 
            this.btnPrikaziMeni.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziMeni.Location = new System.Drawing.Point(827, 182);
            this.btnPrikaziMeni.Name = "btnPrikaziMeni";
            this.btnPrikaziMeni.Size = new System.Drawing.Size(152, 41);
            this.btnPrikaziMeni.TabIndex = 4;
            this.btnPrikaziMeni.Text = "Prikazi meni";
            this.btnPrikaziMeni.UseVisualStyleBackColor = true;
            this.btnPrikaziMeni.Click += new System.EventHandler(this.btnPrikaziMeni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(844, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // btnUtisci
            // 
            this.btnUtisci.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtisci.Location = new System.Drawing.Point(830, 301);
            this.btnUtisci.Name = "btnUtisci";
            this.btnUtisci.Size = new System.Drawing.Size(152, 40);
            this.btnUtisci.TabIndex = 6;
            this.btnUtisci.Text = "Prikazi utiske";
            this.btnUtisci.UseVisualStyleBackColor = true;
            this.btnUtisci.Click += new System.EventHandler(this.btnUtisci_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izaberite za koji restoran\r\nzelite da vidite\r\nutiske:";
            // 
            // btnAddUtisak
            // 
            this.btnAddUtisak.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUtisak.Location = new System.Drawing.Point(833, 400);
            this.btnAddUtisak.Name = "btnAddUtisak";
            this.btnAddUtisak.Size = new System.Drawing.Size(149, 38);
            this.btnAddUtisak.TabIndex = 8;
            this.btnAddUtisak.Text = "Dodaj utisak";
            this.btnAddUtisak.UseVisualStyleBackColor = true;
            this.btnAddUtisak.Click += new System.EventHandler(this.btnAddUtisak_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(830, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Izaberi restoran:";
            // 
            // PrikaziSveRestoraneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(997, 478);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddUtisak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUtisci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrikaziMeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrikaziSveRestoraneForm";
            this.Text = "Svi restorani";
            this.Load += new System.EventHandler(this.PrikaziSveRestoraneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListaSvihRestorana;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrikaziMeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUtisci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUtisak;
        private System.Windows.Forms.Label label5;
    }
}