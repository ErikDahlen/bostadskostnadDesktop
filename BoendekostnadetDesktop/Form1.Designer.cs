
namespace BoendekostnadetDesktop
{
    partial class Bostadskostnader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabBeräkna = new System.Windows.Forms.TabPage();
            this.btnÅterställAnget = new System.Windows.Forms.Button();
            this.groupBoxResultat = new System.Windows.Forms.GroupBox();
            this.lblHusFörmögenhet = new System.Windows.Forms.Label();
            this.lblBostadsrättFörmögenhet = new System.Windows.Forms.Label();
            this.lblHyresFörmögenhet = new System.Windows.Forms.Label();
            this.lblHusKostnad = new System.Windows.Forms.Label();
            this.lblBostadsrättKostnad = new System.Windows.Forms.Label();
            this.lblHyreskostnad = new System.Windows.Forms.Label();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.groupBoxAnge = new System.Windows.Forms.GroupBox();
            this.rbnMiljoner = new System.Windows.Forms.RadioButton();
            this.rbnTusental = new System.Windows.Forms.RadioButton();
            this.rbnKronor = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxHusRänta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHusPris = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxBostadsrättAvgift = new System.Windows.Forms.TextBox();
            this.tbxBostadsrättenRänta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBostadsrättPris = new System.Windows.Forms.TextBox();
            this.tbxHyra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxÅr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.tabInställningar = new System.Windows.Forms.TabPage();
            this.btnÅterställInställningar = new System.Windows.Forms.Button();
            this.lblInställningar = new System.Windows.Forms.Label();
            this.groupBoxInställningar = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxVärdeökningAktier = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tabBeräkna.SuspendLayout();
            this.groupBoxResultat.SuspendLayout();
            this.groupBoxAnge.SuspendLayout();
            this.tabInställningar.SuspendLayout();
            this.groupBoxInställningar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabBeräkna);
            this.tabMain.Controls.Add(this.tabInställningar);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(775, 425);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabBeräkna
            // 
            this.tabBeräkna.Controls.Add(this.btnÅterställAnget);
            this.tabBeräkna.Controls.Add(this.groupBoxResultat);
            this.tabBeräkna.Controls.Add(this.btnBeräkna);
            this.tabBeräkna.Controls.Add(this.groupBoxAnge);
            this.tabBeräkna.Controls.Add(this.lblIntro);
            this.tabBeräkna.Location = new System.Drawing.Point(4, 24);
            this.tabBeräkna.Name = "tabBeräkna";
            this.tabBeräkna.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeräkna.Size = new System.Drawing.Size(767, 397);
            this.tabBeräkna.TabIndex = 0;
            this.tabBeräkna.Text = "Beräkna";
            this.tabBeräkna.UseVisualStyleBackColor = true;
            // 
            // btnÅterställAnget
            // 
            this.btnÅterställAnget.Location = new System.Drawing.Point(552, 75);
            this.btnÅterställAnget.Name = "btnÅterställAnget";
            this.btnÅterställAnget.Size = new System.Drawing.Size(179, 23);
            this.btnÅterställAnget.TabIndex = 4;
            this.btnÅterställAnget.Text = "Återställ det du anget";
            this.btnÅterställAnget.UseVisualStyleBackColor = true;
            this.btnÅterställAnget.Click += new System.EventHandler(this.btnÅterställAnget_Click);
            // 
            // groupBoxResultat
            // 
            this.groupBoxResultat.Controls.Add(this.lblHusFörmögenhet);
            this.groupBoxResultat.Controls.Add(this.lblBostadsrättFörmögenhet);
            this.groupBoxResultat.Controls.Add(this.lblHyresFörmögenhet);
            this.groupBoxResultat.Controls.Add(this.lblHusKostnad);
            this.groupBoxResultat.Controls.Add(this.lblBostadsrättKostnad);
            this.groupBoxResultat.Controls.Add(this.lblHyreskostnad);
            this.groupBoxResultat.Location = new System.Drawing.Point(358, 104);
            this.groupBoxResultat.Name = "groupBoxResultat";
            this.groupBoxResultat.Size = new System.Drawing.Size(373, 269);
            this.groupBoxResultat.TabIndex = 3;
            this.groupBoxResultat.TabStop = false;
            this.groupBoxResultat.Text = "Resultat";
            // 
            // lblHusFörmögenhet
            // 
            this.lblHusFörmögenhet.AutoSize = true;
            this.lblHusFörmögenhet.Location = new System.Drawing.Point(6, 224);
            this.lblHusFörmögenhet.Name = "lblHusFörmögenhet";
            this.lblHusFörmögenhet.Size = new System.Drawing.Size(164, 15);
            this.lblHusFörmögenhet.TabIndex = 5;
            this.lblHusFörmögenhet.Text = "Förmögenheten för huset är...";
            // 
            // lblBostadsrättFörmögenhet
            // 
            this.lblBostadsrättFörmögenhet.AutoSize = true;
            this.lblBostadsrättFörmögenhet.Location = new System.Drawing.Point(6, 189);
            this.lblBostadsrättFörmögenhet.Name = "lblBostadsrättFörmögenhet";
            this.lblBostadsrättFörmögenhet.Size = new System.Drawing.Size(207, 15);
            this.lblBostadsrättFörmögenhet.TabIndex = 4;
            this.lblBostadsrättFörmögenhet.Text = "Förmögenheten för bostadsrätten är...";
            // 
            // lblHyresFörmögenhet
            // 
            this.lblHyresFörmögenhet.AutoSize = true;
            this.lblHyresFörmögenhet.Location = new System.Drawing.Point(6, 150);
            this.lblHyresFörmögenhet.Name = "lblHyresFörmögenhet";
            this.lblHyresFörmögenhet.Size = new System.Drawing.Size(194, 15);
            this.lblHyresFörmögenhet.TabIndex = 3;
            this.lblHyresFörmögenhet.Text = "Förmögenheten för hyresrätten är...";
            // 
            // lblHusKostnad
            // 
            this.lblHusKostnad.AutoSize = true;
            this.lblHusKostnad.Location = new System.Drawing.Point(6, 114);
            this.lblHusKostnad.Name = "lblHusKostnad";
            this.lblHusKostnad.Size = new System.Drawing.Size(198, 15);
            this.lblHusKostnad.TabIndex = 2;
            this.lblHusKostnad.Text = "Lägsta boendekostnad för huset är...";
            // 
            // lblBostadsrättKostnad
            // 
            this.lblBostadsrättKostnad.AutoSize = true;
            this.lblBostadsrättKostnad.Location = new System.Drawing.Point(6, 75);
            this.lblBostadsrättKostnad.Name = "lblBostadsrättKostnad";
            this.lblBostadsrättKostnad.Size = new System.Drawing.Size(241, 15);
            this.lblBostadsrättKostnad.TabIndex = 1;
            this.lblBostadsrättKostnad.Text = "Lägsta boendekostnad för bostadsrätten är...";
            // 
            // lblHyreskostnad
            // 
            this.lblHyreskostnad.AutoSize = true;
            this.lblHyreskostnad.Location = new System.Drawing.Point(6, 37);
            this.lblHyreskostnad.Name = "lblHyreskostnad";
            this.lblHyreskostnad.Size = new System.Drawing.Size(228, 15);
            this.lblHyreskostnad.TabIndex = 0;
            this.lblHyreskostnad.Text = "Lägsta boendekostnad för hyresrätten är...";
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(358, 75);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(139, 23);
            this.btnBeräkna.TabIndex = 2;
            this.btnBeräkna.Text = "Beräkna kostnaden";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // groupBoxAnge
            // 
            this.groupBoxAnge.Controls.Add(this.rbnMiljoner);
            this.groupBoxAnge.Controls.Add(this.rbnTusental);
            this.groupBoxAnge.Controls.Add(this.rbnKronor);
            this.groupBoxAnge.Controls.Add(this.label8);
            this.groupBoxAnge.Controls.Add(this.label7);
            this.groupBoxAnge.Controls.Add(this.tbxHusRänta);
            this.groupBoxAnge.Controls.Add(this.label6);
            this.groupBoxAnge.Controls.Add(this.tbxHusPris);
            this.groupBoxAnge.Controls.Add(this.label5);
            this.groupBoxAnge.Controls.Add(this.tbxBostadsrättAvgift);
            this.groupBoxAnge.Controls.Add(this.tbxBostadsrättenRänta);
            this.groupBoxAnge.Controls.Add(this.label4);
            this.groupBoxAnge.Controls.Add(this.label3);
            this.groupBoxAnge.Controls.Add(this.tbxBostadsrättPris);
            this.groupBoxAnge.Controls.Add(this.tbxHyra);
            this.groupBoxAnge.Controls.Add(this.label2);
            this.groupBoxAnge.Controls.Add(this.tbxÅr);
            this.groupBoxAnge.Controls.Add(this.label1);
            this.groupBoxAnge.Location = new System.Drawing.Point(33, 75);
            this.groupBoxAnge.Name = "groupBoxAnge";
            this.groupBoxAnge.Size = new System.Drawing.Size(298, 298);
            this.groupBoxAnge.TabIndex = 1;
            this.groupBoxAnge.TabStop = false;
            this.groupBoxAnge.Text = "Ange följande";
            // 
            // rbnMiljoner
            // 
            this.rbnMiljoner.AutoSize = true;
            this.rbnMiljoner.Location = new System.Drawing.Point(111, 273);
            this.rbnMiljoner.Name = "rbnMiljoner";
            this.rbnMiljoner.Size = new System.Drawing.Size(69, 19);
            this.rbnMiljoner.TabIndex = 17;
            this.rbnMiljoner.TabStop = true;
            this.rbnMiljoner.Text = "miljoner";
            this.rbnMiljoner.UseVisualStyleBackColor = true;
            // 
            // rbnTusental
            // 
            this.rbnTusental.AutoSize = true;
            this.rbnTusental.Location = new System.Drawing.Point(177, 249);
            this.rbnTusental.Name = "rbnTusental";
            this.rbnTusental.Size = new System.Drawing.Size(67, 19);
            this.rbnTusental.TabIndex = 16;
            this.rbnTusental.TabStop = true;
            this.rbnTusental.Text = "tusental";
            this.rbnTusental.UseVisualStyleBackColor = true;
            // 
            // rbnKronor
            // 
            this.rbnKronor.AutoSize = true;
            this.rbnKronor.Location = new System.Drawing.Point(111, 249);
            this.rbnKronor.Name = "rbnKronor";
            this.rbnKronor.Size = new System.Drawing.Size(60, 19);
            this.rbnKronor.TabIndex = 15;
            this.rbnKronor.TabStop = true;
            this.rbnKronor.Text = "kronor";
            this.rbnKronor.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Visa svaret i:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ränta för huset:";
            // 
            // tbxHusRänta
            // 
            this.tbxHusRänta.Location = new System.Drawing.Point(209, 208);
            this.tbxHusRänta.Name = "tbxHusRänta";
            this.tbxHusRänta.Size = new System.Drawing.Size(70, 23);
            this.tbxHusRänta.TabIndex = 12;
            this.tbxHusRänta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ange priset på huset:";
            // 
            // tbxHusPris
            // 
            this.tbxHusPris.Location = new System.Drawing.Point(209, 178);
            this.tbxHusPris.Name = "tbxHusPris";
            this.tbxHusPris.Size = new System.Drawing.Size(70, 23);
            this.tbxHusPris.TabIndex = 10;
            this.tbxHusPris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Avgift per månad bostadsrätten:";
            // 
            // tbxBostadsrättAvgift
            // 
            this.tbxBostadsrättAvgift.Location = new System.Drawing.Point(209, 148);
            this.tbxBostadsrättAvgift.Name = "tbxBostadsrättAvgift";
            this.tbxBostadsrättAvgift.Size = new System.Drawing.Size(70, 23);
            this.tbxBostadsrättAvgift.TabIndex = 8;
            this.tbxBostadsrättAvgift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxBostadsrättenRänta
            // 
            this.tbxBostadsrättenRänta.Location = new System.Drawing.Point(209, 118);
            this.tbxBostadsrättenRänta.Name = "tbxBostadsrättenRänta";
            this.tbxBostadsrättenRänta.Size = new System.Drawing.Size(70, 23);
            this.tbxBostadsrättenRänta.TabIndex = 7;
            this.tbxBostadsrättenRänta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ränta för bostadsrätten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ange priset på bostadsrätten:";
            // 
            // tbxBostadsrättPris
            // 
            this.tbxBostadsrättPris.Location = new System.Drawing.Point(209, 88);
            this.tbxBostadsrättPris.Name = "tbxBostadsrättPris";
            this.tbxBostadsrättPris.Size = new System.Drawing.Size(70, 23);
            this.tbxBostadsrättPris.TabIndex = 4;
            this.tbxBostadsrättPris.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxHyra
            // 
            this.tbxHyra.Location = new System.Drawing.Point(209, 58);
            this.tbxHyra.Name = "tbxHyra";
            this.tbxHyra.Size = new System.Drawing.Size(70, 23);
            this.tbxHyra.TabIndex = 3;
            this.tbxHyra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ange vad hyran skulle vara:";
            // 
            // tbxÅr
            // 
            this.tbxÅr.Location = new System.Drawing.Point(209, 29);
            this.tbxÅr.Name = "tbxÅr";
            this.tbxÅr.Size = new System.Drawing.Size(70, 23);
            this.tbxÅr.TabIndex = 1;
            this.tbxÅr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ange antal år du tänker dig bo:";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(33, 29);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(602, 15);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Fyll i alla parametrar för ditt boende. Desto mer exakt du anger parametrarna des" +
    "to mer exakt svar kommer du få.";
            // 
            // tabInställningar
            // 
            this.tabInställningar.Controls.Add(this.btnÅterställInställningar);
            this.tabInställningar.Controls.Add(this.lblInställningar);
            this.tabInställningar.Controls.Add(this.groupBoxInställningar);
            this.tabInställningar.Location = new System.Drawing.Point(4, 24);
            this.tabInställningar.Name = "tabInställningar";
            this.tabInställningar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInställningar.Size = new System.Drawing.Size(767, 397);
            this.tabInställningar.TabIndex = 1;
            this.tabInställningar.Text = "Inställningar";
            this.tabInställningar.UseVisualStyleBackColor = true;
            // 
            // btnÅterställInställningar
            // 
            this.btnÅterställInställningar.Location = new System.Drawing.Point(580, 14);
            this.btnÅterställInställningar.Name = "btnÅterställInställningar";
            this.btnÅterställInställningar.Size = new System.Drawing.Size(164, 23);
            this.btnÅterställInställningar.TabIndex = 2;
            this.btnÅterställInställningar.Text = "Återställ inställningar";
            this.btnÅterställInställningar.UseVisualStyleBackColor = true;
            this.btnÅterställInställningar.Click += new System.EventHandler(this.btnÅterställInställningar_Click);
            // 
            // lblInställningar
            // 
            this.lblInställningar.AutoSize = true;
            this.lblInställningar.Location = new System.Drawing.Point(21, 14);
            this.lblInställningar.Name = "lblInställningar";
            this.lblInställningar.Size = new System.Drawing.Size(495, 15);
            this.lblInställningar.TabIndex = 1;
            this.lblInställningar.Text = "Här kan du ange avancerade inställningar. Känner du dig osäker så uppskatta dessa" +
    " inte själv.";
            // 
            // groupBoxInställningar
            // 
            this.groupBoxInställningar.Controls.Add(this.tbxVärdeökningAktier);
            this.groupBoxInställningar.Controls.Add(this.label9);
            this.groupBoxInställningar.Location = new System.Drawing.Point(21, 41);
            this.groupBoxInställningar.Name = "groupBoxInställningar";
            this.groupBoxInställningar.Size = new System.Drawing.Size(723, 334);
            this.groupBoxInställningar.TabIndex = 0;
            this.groupBoxInställningar.TabStop = false;
            this.groupBoxInställningar.Text = "Avancerade inställningar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Årlig värdeökning aktier";
            // 
            // tbxVärdeökningAktier
            // 
            this.tbxVärdeökningAktier.Location = new System.Drawing.Point(163, 20);
            this.tbxVärdeökningAktier.Name = "tbxVärdeökningAktier";
            this.tbxVärdeökningAktier.Size = new System.Drawing.Size(66, 23);
            this.tbxVärdeökningAktier.TabIndex = 1;
            // 
            // Bostadskostnader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "Bostadskostnader";
            this.Text = "Bostadskostnader";
            this.tabMain.ResumeLayout(false);
            this.tabBeräkna.ResumeLayout(false);
            this.tabBeräkna.PerformLayout();
            this.groupBoxResultat.ResumeLayout(false);
            this.groupBoxResultat.PerformLayout();
            this.groupBoxAnge.ResumeLayout(false);
            this.groupBoxAnge.PerformLayout();
            this.tabInställningar.ResumeLayout(false);
            this.tabInställningar.PerformLayout();
            this.groupBoxInställningar.ResumeLayout(false);
            this.groupBoxInställningar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabBeräkna;
        private System.Windows.Forms.TabPage tabInställningar;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.GroupBox groupBoxResultat;
        private System.Windows.Forms.Button btnBeräkna;
        private System.Windows.Forms.GroupBox groupBoxAnge;
        private System.Windows.Forms.Button btnÅterställAnget;
        private System.Windows.Forms.Button btnÅterställInställningar;
        private System.Windows.Forms.Label lblInställningar;
        private System.Windows.Forms.GroupBox groupBoxInställningar;
        private System.Windows.Forms.TextBox tbxÅr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHyra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHyreskostnad;
        private System.Windows.Forms.Label lblBostadsrättKostnad;
        private System.Windows.Forms.Label lblHusKostnad;
        private System.Windows.Forms.Label lblHusFörmögenhet;
        private System.Windows.Forms.Label lblBostadsrättFörmögenhet;
        private System.Windows.Forms.Label lblHyresFörmögenhet;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.TextBox tbxBostadsrättPris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBostadsrättenRänta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBostadsrättAvgift;
        private System.Windows.Forms.TextBox tbxHusRänta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxHusPris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbnMiljoner;
        private System.Windows.Forms.RadioButton rbnTusental;
        private System.Windows.Forms.RadioButton rbnKronor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxVärdeökningAktier;
        private System.Windows.Forms.Label label9;
    }
}

