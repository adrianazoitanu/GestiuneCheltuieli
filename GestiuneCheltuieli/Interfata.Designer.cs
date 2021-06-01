
namespace GestiuneCheltuieli
{
    partial class Interfata
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtCheltuieli = new System.Windows.Forms.TextBox();
            this.txtEconomii = new System.Windows.Forms.TextBox();
            this.txtVenit = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.rtbDolar = new System.Windows.Forms.RadioButton();
            this.rtbLei = new System.Windows.Forms.RadioButton();
            this.rtbEuro = new System.Windows.Forms.RadioButton();
            this.lblValuta = new System.Windows.Forms.Label();
            this.lblCheltuieli = new System.Windows.Forms.Label();
            this.lblEconomii = new System.Windows.Forms.Label();
            this.lblVenit = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUt = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstbxAfis = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(538, 356);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 25);
            this.btnModifica.TabIndex = 36;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(447, 356);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 25);
            this.btnCauta.TabIndex = 35;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(619, 356);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 25);
            this.btnAdauga.TabIndex = 34;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(307, 358);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(124, 23);
            this.btnAfiseaza.TabIndex = 33;
            this.btnAfiseaza.Text = "Intra in cont";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtCheltuieli
            // 
            this.txtCheltuieli.Location = new System.Drawing.Point(127, 192);
            this.txtCheltuieli.Name = "txtCheltuieli";
            this.txtCheltuieli.Size = new System.Drawing.Size(100, 22);
            this.txtCheltuieli.TabIndex = 32;
            // 
            // txtEconomii
            // 
            this.txtEconomii.Location = new System.Drawing.Point(127, 158);
            this.txtEconomii.Name = "txtEconomii";
            this.txtEconomii.Size = new System.Drawing.Size(100, 22);
            this.txtEconomii.TabIndex = 31;
            // 
            // txtVenit
            // 
            this.txtVenit.Location = new System.Drawing.Point(127, 126);
            this.txtVenit.Name = "txtVenit";
            this.txtVenit.Size = new System.Drawing.Size(100, 22);
            this.txtVenit.TabIndex = 30;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(127, 86);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 22);
            this.txtPrenume.TabIndex = 29;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(127, 49);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 28;
            // 
            // rtbDolar
            // 
            this.rtbDolar.AutoSize = true;
            this.rtbDolar.Location = new System.Drawing.Point(110, 336);
            this.rtbDolar.Name = "rtbDolar";
            this.rtbDolar.Size = new System.Drawing.Size(63, 21);
            this.rtbDolar.TabIndex = 27;
            this.rtbDolar.Text = "Dolar";
            this.rtbDolar.UseVisualStyleBackColor = true;
            // 
            // rtbLei
            // 
            this.rtbLei.AutoSize = true;
            this.rtbLei.Location = new System.Drawing.Point(110, 309);
            this.rtbLei.Name = "rtbLei";
            this.rtbLei.Size = new System.Drawing.Size(48, 21);
            this.rtbLei.TabIndex = 26;
            this.rtbLei.Text = "Lei";
            this.rtbLei.UseVisualStyleBackColor = true;
            // 
            // rtbEuro
            // 
            this.rtbEuro.AutoSize = true;
            this.rtbEuro.Checked = true;
            this.rtbEuro.Location = new System.Drawing.Point(110, 282);
            this.rtbEuro.Name = "rtbEuro";
            this.rtbEuro.Size = new System.Drawing.Size(59, 21);
            this.rtbEuro.TabIndex = 25;
            this.rtbEuro.TabStop = true;
            this.rtbEuro.Text = "Euro";
            this.rtbEuro.UseVisualStyleBackColor = true;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(49, 259);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(48, 17);
            this.lblValuta.TabIndex = 24;
            this.lblValuta.Text = "Valuta";
            // 
            // lblCheltuieli
            // 
            this.lblCheltuieli.AutoSize = true;
            this.lblCheltuieli.Location = new System.Drawing.Point(49, 192);
            this.lblCheltuieli.Name = "lblCheltuieli";
            this.lblCheltuieli.Size = new System.Drawing.Size(65, 17);
            this.lblCheltuieli.TabIndex = 23;
            this.lblCheltuieli.Text = "Cheltuieli";
            // 
            // lblEconomii
            // 
            this.lblEconomii.AutoSize = true;
            this.lblEconomii.Location = new System.Drawing.Point(49, 158);
            this.lblEconomii.Name = "lblEconomii";
            this.lblEconomii.Size = new System.Drawing.Size(65, 17);
            this.lblEconomii.TabIndex = 22;
            this.lblEconomii.Text = "Economii";
            // 
            // lblVenit
            // 
            this.lblVenit.AutoSize = true;
            this.lblVenit.Location = new System.Drawing.Point(49, 126);
            this.lblVenit.Name = "lblVenit";
            this.lblVenit.Size = new System.Drawing.Size(40, 17);
            this.lblVenit.TabIndex = 21;
            this.lblVenit.Text = "Venit";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(49, 89);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(65, 17);
            this.lblPrenume.TabIndex = 20;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(49, 49);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 17);
            this.lblNume.TabIndex = 19;
            this.lblNume.Text = "Nume";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(49, 221);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(49, 17);
            this.lblParola.TabIndex = 38;
            this.lblParola.Text = "Parola";
            this.lblParola.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(127, 221);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 22);
            this.txtParola.TabIndex = 39;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(129, 380);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUt
            // 
            this.MenuUt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.MenuUt.Name = "MenuUt";
            this.MenuUt.Size = new System.Drawing.Size(46, 24);
            this.MenuUt.Text = "File";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // lstbxAfis
            // 
            this.lstbxAfis.FormattingEnabled = true;
            this.lstbxAfis.ItemHeight = 16;
            this.lstbxAfis.Location = new System.Drawing.Point(296, 49);
            this.lstbxAfis.Name = "lstbxAfis";
            this.lstbxAfis.Size = new System.Drawing.Size(470, 276);
            this.lstbxAfis.TabIndex = 47;
            // 
            // Interfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxAfis);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtCheltuieli);
            this.Controls.Add(this.txtEconomii);
            this.Controls.Add(this.txtVenit);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.rtbDolar);
            this.Controls.Add(this.rtbLei);
            this.Controls.Add(this.rtbEuro);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblCheltuieli);
            this.Controls.Add(this.lblEconomii);
            this.Controls.Add(this.lblVenit);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfata";
            this.Text = "Interfata";
            this.Load += new System.EventHandler(this.Interfata_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtCheltuieli;
        private System.Windows.Forms.TextBox txtEconomii;
        private System.Windows.Forms.TextBox txtVenit;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.RadioButton rtbDolar;
        private System.Windows.Forms.RadioButton rtbLei;
        private System.Windows.Forms.RadioButton rtbEuro;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Label lblCheltuieli;
        private System.Windows.Forms.Label lblEconomii;
        private System.Windows.Forms.Label lblVenit;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUt;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ListBox lstbxAfis;
    }
}