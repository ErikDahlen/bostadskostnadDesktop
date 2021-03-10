﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoendekostnadetDesktop
{
    public partial class Bostadskostnader : Form
    {
        public Bostadskostnader()
        {
            InitializeComponent();
            ÅterställAnget();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBeräkna_Click(object sender, EventArgs e)
        {
            var param = new Parametrar();
            if (HämtaParametrar(ref param))
            {
                var beräknaBoendekostnaden = new BeräknaBoendekostnaden();
                var svaret = beräknaBoendekostnaden.Beräkna(param);

                //visa svaret
                lblHyreskostnad.Text = svaret.HyresrättKostnad;
                lblBostadsrättKostnad.Text = svaret.BostadsrättKostnad;
                lblHusKostnad.Text = svaret.HusKostnad;
                lblHyresFörmögenhet.Text = svaret.HyresrättFörmögenhet;
                lblBostadsrättFörmögenhet.Text = svaret.BostadsrättFörmögenhet;
                lblHusFörmögenhet.Text = svaret.HusFörmögenhet;
            } 
        }
        private bool HämtaParametrar(ref Parametrar param)
        {
            var resultat = true;
            //Standardparametrar generelt och hyresrätt
            param.AntalÅr = HämtaIntParameter(tbxÅr.Text, "Antal år", ref resultat);
            param.Hyra = HämtaIntParameter(tbxHyra.Text, "Hyran", ref resultat);

            //Standardparametrar bostadsrätt
            param.BostadsrättPris = HämtaIntParameter(tbxBostadsrättPris.Text, "Bostadsrättens pris", ref resultat);
            param.BostadsrättRänta = HämtaDecimalParameter(tbxBostadsrättenRänta.Text.Replace("%", ""), "Bostadsrättens ränta", ref resultat) / 100;
            param.BostadsrättAvgift = HämtaIntParameter(tbxBostadsrättAvgift.Text, "Bostadsrättens avgift", ref resultat);

            //Standardparametrar hus
            param.HusPris = HämtaIntParameter(tbxHusPris.Text, "Husets pris", ref resultat);
            param.HusRänta = HämtaDecimalParameter(tbxHusRänta.Text.Replace("%", ""), "Bostadsrättens ränta", ref resultat) / 100;

            return resultat;
        }
        private decimal HämtaDecimalParameter(string text, string namn, ref bool resultat)
        {
            decimal decimalOut = 0;
            if (decimal.TryParse(text, out decimalOut))
            {
                return decimalOut;
            }
            else
            {
                resultat = false;
                MessageBox.Show(namn + " måste vara ett decimaltal.");
                return 0;
            }
        }

        private int HämtaIntParameter(string text, string namn, ref bool resultat)
        {
            int intOut = 0;
            if (int.TryParse(text, out intOut))
            {
                return intOut;
            }
            else
            {
                resultat = false;
                MessageBox.Show(namn + " måste vara ett heltal.");
                return 0;
            }
        }
        
        private void btnÅterställAnget_Click(object sender, EventArgs e)
        {
            ÅterställAnget();
        }
        private void ÅterställAnget()
        {
            tbxÅr.Text = "20";
            tbxHyra.Text = "10000";
            tbxBostadsrättPris.Text = "2000000";
            tbxBostadsrättenRänta.Text = "1,4%";
            tbxBostadsrättAvgift.Text = "4000";
            tbxHusPris.Text = "3000000";
            tbxHusRänta.Text = "1,4%";
        }
    }
}