
namespace GestiuneCheltuieli
{
    partial class Logare
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
            this.btnNume = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.lstbxAfis = new System.Windows.Forms.ListBox();
            this.btnPrenume = new System.Windows.Forms.Button();
            this.btnEconomii = new System.Windows.Forms.Button();
            this.btnCheltuieli = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtEc = new System.Windows.Forms.TextBox();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.txtVenit = new System.Windows.Forms.TextBox();
            this.btnVenit = new System.Windows.Forms.Button();
            this.rtbDolari = new System.Windows.Forms.RadioButton();
            this.rtbLei = new System.Windows.Forms.RadioButton();
            this.rtbEuro = new System.Windows.Forms.RadioButton();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnScade = new System.Windows.Forms.Button();
            this.btnMoneda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNume
            // 
            this.btnNume.Location = new System.Drawing.Point(12, 56);
            this.btnNume.Name = "btnNume";
            this.btnNume.Size = new System.Drawing.Size(137, 34);
            this.btnNume.TabIndex = 4;
            this.btnNume.Text = "Modificare Nume";
            this.btnNume.UseVisualStyleBackColor = true;
            this.btnNume.Click += new System.EventHandler(this.btnL_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bine ai venit!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.Location = new System.Drawing.Point(185, 27);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(0, 17);
            this.lblmesaj.TabIndex = 6;
            this.lblmesaj.Click += new System.EventHandler(this.lblmesaj_Click);
            // 
            // lstbxAfis
            // 
            this.lstbxAfis.FormattingEnabled = true;
            this.lstbxAfis.ItemHeight = 16;
            this.lstbxAfis.Items.AddRange(new object[] {
            ""});
            this.lstbxAfis.Location = new System.Drawing.Point(339, 27);
            this.lstbxAfis.Name = "lstbxAfis";
            this.lstbxAfis.Size = new System.Drawing.Size(640, 388);
            this.lstbxAfis.TabIndex = 7;
            this.lstbxAfis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPrenume
            // 
            this.btnPrenume.Location = new System.Drawing.Point(12, 96);
            this.btnPrenume.Name = "btnPrenume";
            this.btnPrenume.Size = new System.Drawing.Size(153, 34);
            this.btnPrenume.TabIndex = 8;
            this.btnPrenume.Text = "Modificare  Prenume";
            this.btnPrenume.UseVisualStyleBackColor = true;
            this.btnPrenume.Click += new System.EventHandler(this.btnPrenume_Click);
            // 
            // btnEconomii
            // 
            this.btnEconomii.Location = new System.Drawing.Point(12, 136);
            this.btnEconomii.Name = "btnEconomii";
            this.btnEconomii.Size = new System.Drawing.Size(137, 34);
            this.btnEconomii.TabIndex = 9;
            this.btnEconomii.Text = "Adauga Economii";
            this.btnEconomii.UseVisualStyleBackColor = true;
            this.btnEconomii.Click += new System.EventHandler(this.btnEconomii_Click);
            // 
            // btnCheltuieli
            // 
            this.btnCheltuieli.Location = new System.Drawing.Point(12, 216);
            this.btnCheltuieli.Name = "btnCheltuieli";
            this.btnCheltuieli.Size = new System.Drawing.Size(137, 34);
            this.btnCheltuieli.TabIndex = 10;
            this.btnCheltuieli.Text = "Adauga Cheltuieli";
            this.btnCheltuieli.UseVisualStyleBackColor = true;
            this.btnCheltuieli.Click += new System.EventHandler(this.btnCheltuieli_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(171, 62);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(132, 22);
            this.txtNume.TabIndex = 12;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(171, 102);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(132, 22);
            this.txtPrenume.TabIndex = 13;
            // 
            // txtEc
            // 
            this.txtEc.Location = new System.Drawing.Point(171, 142);
            this.txtEc.Name = "txtEc";
            this.txtEc.Size = new System.Drawing.Size(132, 22);
            this.txtEc.TabIndex = 14;
            // 
            // txtCh
            // 
            this.txtCh.Location = new System.Drawing.Point(171, 222);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(132, 22);
            this.txtCh.TabIndex = 15;
            // 
            // txtVenit
            // 
            this.txtVenit.Location = new System.Drawing.Point(171, 182);
            this.txtVenit.Name = "txtVenit";
            this.txtVenit.Size = new System.Drawing.Size(132, 22);
            this.txtVenit.TabIndex = 18;
            this.txtVenit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnVenit
            // 
            this.btnVenit.Location = new System.Drawing.Point(12, 176);
            this.btnVenit.Name = "btnVenit";
            this.btnVenit.Size = new System.Drawing.Size(137, 34);
            this.btnVenit.TabIndex = 17;
            this.btnVenit.Text = "Modifica Venit";
            this.btnVenit.UseVisualStyleBackColor = true;
            this.btnVenit.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDolari
            // 
            this.rtbDolari.AutoSize = true;
            this.rtbDolari.Location = new System.Drawing.Point(242, 322);
            this.rtbDolari.Name = "rtbDolari";
            this.rtbDolari.Size = new System.Drawing.Size(66, 21);
            this.rtbDolari.TabIndex = 20;
            this.rtbDolari.TabStop = true;
            this.rtbDolari.Text = "Dolari";
            this.rtbDolari.UseVisualStyleBackColor = true;
            // 
            // rtbLei
            // 
            this.rtbLei.AutoSize = true;
            this.rtbLei.Location = new System.Drawing.Point(171, 322);
            this.rtbLei.Name = "rtbLei";
            this.rtbLei.Size = new System.Drawing.Size(48, 21);
            this.rtbLei.TabIndex = 21;
            this.rtbLei.TabStop = true;
            this.rtbLei.Text = "Lei";
            this.rtbLei.UseVisualStyleBackColor = true;
            // 
            // rtbEuro
            // 
            this.rtbEuro.AutoSize = true;
            this.rtbEuro.Location = new System.Drawing.Point(171, 349);
            this.rtbEuro.Name = "rtbEuro";
            this.rtbEuro.Size = new System.Drawing.Size(59, 21);
            this.rtbEuro.TabIndex = 22;
            this.rtbEuro.TabStop = true;
            this.rtbEuro.Text = "Euro";
            this.rtbEuro.UseVisualStyleBackColor = true;
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(12, 392);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(137, 34);
            this.btnSterge.TabIndex = 23;
            this.btnSterge.Text = "Sterge istoric";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(171, 392);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(137, 34);
            this.btnIesire.TabIndex = 24;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnScade
            // 
            this.btnScade.Location = new System.Drawing.Point(12, 269);
            this.btnScade.Name = "btnScade";
            this.btnScade.Size = new System.Drawing.Size(266, 34);
            this.btnScade.TabIndex = 25;
            this.btnScade.Text = "Scade cheltuieli din economii";
            this.btnScade.UseVisualStyleBackColor = true;
            this.btnScade.Click += new System.EventHandler(this.btnScade_Click);
            // 
            // btnMoneda
            // 
            this.btnMoneda.Location = new System.Drawing.Point(12, 322);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Size = new System.Drawing.Size(137, 34);
            this.btnMoneda.TabIndex = 26;
            this.btnMoneda.Text = "Schimba moneda";
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 451);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.btnMoneda);
            this.Controls.Add(this.btnScade);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.rtbEuro);
            this.Controls.Add(this.rtbLei);
            this.Controls.Add(this.rtbDolari);
            this.Controls.Add(this.txtVenit);
            this.Controls.Add(this.btnVenit);
            this.Controls.Add(this.txtCh);
            this.Controls.Add(this.txtEc);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnCheltuieli);
            this.Controls.Add(this.btnEconomii);
            this.Controls.Add(this.btnPrenume);
            this.Controls.Add(this.lstbxAfis);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNume);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Logare";
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.Logare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmesaj;
        private System.Windows.Forms.ListBox lstbxAfis;
        private System.Windows.Forms.Button btnPrenume;
        private System.Windows.Forms.Button btnEconomii;
        private System.Windows.Forms.Button btnCheltuieli;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtEc;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.TextBox txtVenit;
        private System.Windows.Forms.Button btnVenit;
        private System.Windows.Forms.RadioButton rtbDolari;
        private System.Windows.Forms.RadioButton rtbLei;
        private System.Windows.Forms.RadioButton rtbEuro;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnScade;
        private System.Windows.Forms.Button btnMoneda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}