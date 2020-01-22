namespace WcfAutokauppa1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaTietokantayhteyttä = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennna = new System.Windows.Forms.Button();
            this.uusitietue = new System.Windows.Forms.Button();
            this.seuraava = new System.Windows.Forms.Button();
            this.edellinen = new System.Windows.Forms.Button();
            this.rekisteripva = new System.Windows.Forms.Label();
            this.rekisterointipvaCB = new System.Windows.Forms.DateTimePicker();
            this.variCB = new System.Windows.Forms.ComboBox();
            this.polttoaineCB = new System.Windows.Forms.ComboBox();
            this.malliCB = new System.Windows.Forms.ComboBox();
            this.merkkiCB = new System.Windows.Forms.ComboBox();
            this.hintaCB = new System.Windows.Forms.ComboBox();
            this.moottoritilavuusCB = new System.Windows.Forms.ComboBox();
            this.mittarilukemaCB = new System.Windows.Forms.ComboBox();
            this.vari = new System.Windows.Forms.Label();
            this.malli = new System.Windows.Forms.Label();
            this.polttoaine = new System.Windows.Forms.Label();
            this.merkki = new System.Windows.Forms.Label();
            this.hinta = new System.Windows.Forms.Label();
            this.moottoritilavuus = new System.Windows.Forms.Label();
            this.mittarilukema = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1942, 40);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(64, 36);
            this.file.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(151, 38);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // about
            // 
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaTietokantayhteyttä});
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(92, 36);
            this.about.Text = "About";
            // 
            // testaaTietokantayhteyttä
            // 
            this.testaaTietokantayhteyttä.Name = "testaaTietokantayhteyttä";
            this.testaaTietokantayhteyttä.Size = new System.Drawing.Size(381, 38);
            this.testaaTietokantayhteyttä.Text = "Testaa tietokantayhteyttä";
            // 
            // tallennna
            // 
            this.tallennna.Location = new System.Drawing.Point(1254, 325);
            this.tallennna.Name = "tallennna";
            this.tallennna.Size = new System.Drawing.Size(209, 70);
            this.tallennna.TabIndex = 45;
            this.tallennna.Text = "Tallenna";
            this.tallennna.UseVisualStyleBackColor = true;
            this.tallennna.Click += new System.EventHandler(this.tallennna_Click);
            // 
            // uusitietue
            // 
            this.uusitietue.Location = new System.Drawing.Point(1254, 215);
            this.uusitietue.Name = "uusitietue";
            this.uusitietue.Size = new System.Drawing.Size(209, 70);
            this.uusitietue.TabIndex = 44;
            this.uusitietue.Text = "Uusitietue";
            this.uusitietue.UseVisualStyleBackColor = true;
            this.uusitietue.Click += new System.EventHandler(this.uusitietue_Click);
            // 
            // seuraava
            // 
            this.seuraava.Location = new System.Drawing.Point(848, 575);
            this.seuraava.Name = "seuraava";
            this.seuraava.Size = new System.Drawing.Size(185, 66);
            this.seuraava.TabIndex = 43;
            this.seuraava.Text = "Seuraava";
            this.seuraava.UseVisualStyleBackColor = true;
            // 
            // edellinen
            // 
            this.edellinen.Location = new System.Drawing.Point(184, 577);
            this.edellinen.Name = "edellinen";
            this.edellinen.Size = new System.Drawing.Size(185, 64);
            this.edellinen.TabIndex = 42;
            this.edellinen.Text = "Edellinen";
            this.edellinen.UseVisualStyleBackColor = true;
            // 
            // rekisteripva
            // 
            this.rekisteripva.AutoSize = true;
            this.rekisteripva.Location = new System.Drawing.Point(179, 461);
            this.rekisteripva.Name = "rekisteripva";
            this.rekisteripva.Size = new System.Drawing.Size(142, 25);
            this.rekisteripva.TabIndex = 41;
            this.rekisteripva.Text = "Rekisteri pvm";
            // 
            // rekisterointipvaCB
            // 
            this.rekisterointipvaCB.CustomFormat = "MM-dd-yyyy";
            this.rekisterointipvaCB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rekisterointipvaCB.Location = new System.Drawing.Point(401, 461);
            this.rekisterointipvaCB.Name = "rekisterointipvaCB";
            this.rekisterointipvaCB.Size = new System.Drawing.Size(200, 31);
            this.rekisterointipvaCB.TabIndex = 40;
            // 
            // variCB
            // 
            this.variCB.FormattingEnabled = true;
            this.variCB.Location = new System.Drawing.Point(872, 449);
            this.variCB.Name = "variCB";
            this.variCB.Size = new System.Drawing.Size(121, 33);
            this.variCB.TabIndex = 39;
            // 
            // polttoaineCB
            // 
            this.polttoaineCB.FormattingEnabled = true;
            this.polttoaineCB.Location = new System.Drawing.Point(872, 365);
            this.polttoaineCB.Name = "polttoaineCB";
            this.polttoaineCB.Size = new System.Drawing.Size(121, 33);
            this.polttoaineCB.TabIndex = 38;
            // 
            // malliCB
            // 
            this.malliCB.FormattingEnabled = true;
            this.malliCB.Location = new System.Drawing.Point(872, 295);
            this.malliCB.Name = "malliCB";
            this.malliCB.Size = new System.Drawing.Size(121, 33);
            this.malliCB.TabIndex = 37;
            // 
            // merkkiCB
            // 
            this.merkkiCB.FormattingEnabled = true;
            this.merkkiCB.Location = new System.Drawing.Point(872, 218);
            this.merkkiCB.Name = "merkkiCB";
            this.merkkiCB.Size = new System.Drawing.Size(121, 33);
            this.merkkiCB.TabIndex = 36;
            
            this.merkkiCB.SelectedValueChanged += new System.EventHandler(this.LisaaMallit);
            // 
            // hintaCB
            // 
            this.hintaCB.FormattingEnabled = true;
            this.hintaCB.Location = new System.Drawing.Point(401, 372);
            this.hintaCB.Name = "hintaCB";
            this.hintaCB.Size = new System.Drawing.Size(121, 33);
            this.hintaCB.TabIndex = 35;
            // 
            // moottoritilavuusCB
            // 
            this.moottoritilavuusCB.FormattingEnabled = true;
            this.moottoritilavuusCB.Location = new System.Drawing.Point(401, 296);
            this.moottoritilavuusCB.Name = "moottoritilavuusCB";
            this.moottoritilavuusCB.Size = new System.Drawing.Size(121, 33);
            this.moottoritilavuusCB.TabIndex = 34;
            // 
            // mittarilukemaCB
            // 
            this.mittarilukemaCB.FormattingEnabled = true;
            this.mittarilukemaCB.Location = new System.Drawing.Point(401, 215);
            this.mittarilukemaCB.Name = "mittarilukemaCB";
            this.mittarilukemaCB.Size = new System.Drawing.Size(121, 33);
            this.mittarilukemaCB.TabIndex = 33;
            // 
            // vari
            // 
            this.vari.AutoSize = true;
            this.vari.Location = new System.Drawing.Point(747, 449);
            this.vari.Name = "vari";
            this.vari.Size = new System.Drawing.Size(50, 25);
            this.vari.TabIndex = 32;
            this.vari.Text = "Väri";
            // 
            // malli
            // 
            this.malli.AutoSize = true;
            this.malli.Location = new System.Drawing.Point(747, 295);
            this.malli.Name = "malli";
            this.malli.Size = new System.Drawing.Size(57, 25);
            this.malli.TabIndex = 31;
            this.malli.Text = "Malli";
            // 
            // polttoaine
            // 
            this.polttoaine.AutoSize = true;
            this.polttoaine.Location = new System.Drawing.Point(747, 373);
            this.polttoaine.Name = "polttoaine";
            this.polttoaine.Size = new System.Drawing.Size(108, 25);
            this.polttoaine.TabIndex = 30;
            this.polttoaine.Text = "Polttoaine";
            // 
            // merkki
            // 
            this.merkki.AutoSize = true;
            this.merkki.Location = new System.Drawing.Point(747, 218);
            this.merkki.Name = "merkki";
            this.merkki.Size = new System.Drawing.Size(76, 25);
            this.merkki.TabIndex = 29;
            this.merkki.Text = "Merkki";
            // 
            // hinta
            // 
            this.hinta.AutoSize = true;
            this.hinta.Location = new System.Drawing.Point(179, 372);
            this.hinta.Name = "hinta";
            this.hinta.Size = new System.Drawing.Size(62, 25);
            this.hinta.TabIndex = 28;
            this.hinta.Text = "Hinta";
            // 
            // moottoritilavuus
            // 
            this.moottoritilavuus.AutoSize = true;
            this.moottoritilavuus.Location = new System.Drawing.Point(179, 296);
            this.moottoritilavuus.Name = "moottoritilavuus";
            this.moottoritilavuus.Size = new System.Drawing.Size(163, 25);
            this.moottoritilavuus.TabIndex = 27;
            this.moottoritilavuus.Text = "moottoritilavuus";
            // 
            // mittarilukema
            // 
            this.mittarilukema.AutoSize = true;
            this.mittarilukema.Location = new System.Drawing.Point(179, 218);
            this.mittarilukema.Name = "mittarilukema";
            this.mittarilukema.Size = new System.Drawing.Size(140, 25);
            this.mittarilukema.TabIndex = 26;
            this.mittarilukema.Text = "Mittarilukema";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 930);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tallennna);
            this.Controls.Add(this.uusitietue);
            this.Controls.Add(this.seuraava);
            this.Controls.Add(this.edellinen);
            this.Controls.Add(this.rekisteripva);
            this.Controls.Add(this.rekisterointipvaCB);
            this.Controls.Add(this.variCB);
            this.Controls.Add(this.polttoaineCB);
            this.Controls.Add(this.malliCB);
            this.Controls.Add(this.merkkiCB);
            this.Controls.Add(this.hintaCB);
            this.Controls.Add(this.moottoritilavuusCB);
            this.Controls.Add(this.mittarilukemaCB);
            this.Controls.Add(this.vari);
            this.Controls.Add(this.malli);
            this.Controls.Add(this.polttoaine);
            this.Controls.Add(this.merkki);
            this.Controls.Add(this.hinta);
            this.Controls.Add(this.moottoritilavuus);
            this.Controls.Add(this.mittarilukema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem testaaTietokantayhteyttä;
        private System.Windows.Forms.Button tallennna;
        private System.Windows.Forms.Button uusitietue;
        private System.Windows.Forms.Button seuraava;
        private System.Windows.Forms.Button edellinen;
        private System.Windows.Forms.Label rekisteripva;
        private System.Windows.Forms.DateTimePicker rekisterointipvaCB;
        private System.Windows.Forms.ComboBox variCB;
        private System.Windows.Forms.ComboBox polttoaineCB;
        private System.Windows.Forms.ComboBox malliCB;
        private System.Windows.Forms.ComboBox merkkiCB;
        private System.Windows.Forms.ComboBox hintaCB;
        private System.Windows.Forms.ComboBox moottoritilavuusCB;
        private System.Windows.Forms.ComboBox mittarilukemaCB;
        private System.Windows.Forms.Label vari;
        private System.Windows.Forms.Label malli;
        private System.Windows.Forms.Label polttoaine;
        private System.Windows.Forms.Label merkki;
        private System.Windows.Forms.Label hinta;
        private System.Windows.Forms.Label moottoritilavuus;
        private System.Windows.Forms.Label mittarilukema;
    }
}

