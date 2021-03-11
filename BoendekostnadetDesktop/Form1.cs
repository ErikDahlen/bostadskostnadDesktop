using System;
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
            ÅterställInställningar();
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
            param.DelaSvaretMed = HämtaDelaSvaretMed();

            //Standardparametrar bostadsrätt
            param.BostadsrättPris = HämtaIntParameter(tbxBostadsrättPris.Text, "Bostadsrättens pris", ref resultat);
            param.BostadsrättRänta = HämtaDecimalParameter(tbxBostadsrättenRänta.Text.Replace("%", ""), "Bostadsrättens ränta", ref resultat) / 100;
            param.BostadsrättAvgift = HämtaIntParameter(tbxBostadsrättAvgift.Text, "Bostadsrättens avgift", ref resultat);

            //Standardparametrar hus
            param.HusPris = HämtaIntParameter(tbxHusPris.Text, "Husets pris", ref resultat);
            param.HusRänta = HämtaDecimalParameter(tbxHusRänta.Text.Replace("%", ""), "Bostadsrättens ränta", ref resultat) / 100;

            //Avancerade inställningar generelt och hyresrätt
            param.VärdeökningAktier = HämtaDecimalParameter(tbxVärdeökningAktier.Text.Replace("%", ""), "Värdeökningen på aktier", ref resultat) / 100;
            param.HävstångAktier = HämtaDecimalParameter(tbxHävstångAktier.Text.Replace("%", ""), "Hävstången på aktier", ref resultat) / 100;
            param.VärdeökningBostadsrätter = HämtaDecimalParameter(tbxVärdeökningBostadsrätt.Text.Replace("%", ""), "Värdeökningen på bostadsrätter", ref resultat) / 100;
            param.VärdeökningHus = HämtaDecimalParameter(tbxVärdeökningHus.Text.Replace("%", ""), "Värdeökningen på hus", ref resultat) / 100;
            param.FörsäljningBostad = HämtaIntParameter(tbxFörsäljningBostad.Text, "Bostadens försäljningskostnad", ref resultat);
            param.Hyresökning = HämtaDecimalParameter(tbxHyresökning.Text.Replace("%", ""), "Hyresökningen", ref resultat) / 100;
            param.BostadsrättAvgifthöjning = HämtaDecimalParameter(tbxBostadsrättAvgiftshöjning.Text.Replace("%", ""), "Bostadsrättens avgiftshöjning", ref resultat) / 100;
            param.BostadsrättUnderhåll = HämtaIntParameter(tbxBostadsrättUnderhåll.Text, "Bostadsrättens underhållskostnad", ref resultat);
            param.BostadsrättUnderhållsökning = HämtaDecimalParameter(tbxBostadsrättUnderhållsökning.Text.Replace("%", ""), "Bostadsrättens underhållskostnadsökning", ref resultat) / 100;
            param.BostadsrättEnligtAmmorteringskravet = cbxBostadsrättEnligtAmmorteringskravet.Checked;
            param.BostadsrättLågLönAmmortering = cbxBostadsrättLågLönAmmortering.Checked;
            param.BostadsrättFastAmmortering = HämtaIntParameter(tbxBostadsrättFastAmmortering.Text, "Bostadsrättens fasta ammortering", ref resultat);
            param.HusDriftkostnad = HämtaIntParameter(tbxHusDriftkostnader.Text, "Husets driftkostnader", ref resultat);
            param.HusDriftkostnadsökning = HämtaDecimalParameter(tbxHusDriftkostnadsökning.Text.Replace("%", ""), "Husets driftkostnadsökning", ref resultat) / 100;
            param.HusInköpskostnad = HämtaDecimalParameter(tbxHusInköpskostnad.Text.Replace("%", ""), "Husets inköpskostnad för lagfart och pantbrev", ref resultat) / 100;
            param.HusUnderhållskostnad = HämtaIntParameter(tbxHusUnderhållskostnad.Text, "Husets underhållskostnader", ref resultat);
            param.HusUnderhållsökning = HämtaDecimalParameter(tbxHusUnderhållsökning.Text.Replace("%", ""), "Husets underhållskostnadsökning", ref resultat) / 100;
            param.HusEnligtAmmorteringskravet = cbxHusEnligtAmmorteringskravet.Checked;
            param.HusLågLönAmmortering = cbxHusLågLönAmmortering.Checked;
            param.HusFastAmmortering = HämtaIntParameter(tbxHusFastAmmortering.Text, "Husets fasta ammortering", ref resultat);
            param.BostadsrättAndelLånVidKöpet = HämtaDecimalParameter(tbxBostadsrättAndelLånVidKöp.Text.Replace("%", ""), "Bostadsrättens lån till andel av inköpspriset", ref resultat) / 100;
            param.HusAndelLånVidKöpet = HämtaDecimalParameter(tbxHusAndelLånVidKöpet.Text.Replace("%", ""), "Husets lån till andel av inköpspriset", ref resultat) / 100;

            return resultat;
        }
        private int HämtaDelaSvaretMed()
        {
            if (rbnTusental.Checked)
            {
                return 1000;
            }
            if (rbnMiljoner.Checked)
            {
                return 1000 * 1000;
            }
            return 1;
        }
        private decimal HämtaDecimalParameter(string text, string namn, ref bool resultat)
        {
            decimal decimalOut = 0;
            if (decimal.TryParse(text.Replace(" ", ""), out decimalOut))
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
            if (int.TryParse(text.Replace(" ", ""), out intOut))
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
            tbxHyra.Text = "10 000";
            tbxBostadsrättPris.Text = "2 000 000";
            tbxBostadsrättenRänta.Text = "1,4%";
            tbxBostadsrättAvgift.Text = "4000";
            tbxHusPris.Text = "3 000 000";
            tbxHusRänta.Text = "1,4%";
            rbnTusental.Checked = true;
        }

        private void btnÅterställInställningar_Click(object sender, EventArgs e)
        {
            ÅterställInställningar();
        }
        private void ÅterställInställningar()
        {
            tbxVärdeökningAktier.Text = "7%";
            tbxHävstångAktier.Text = "0%";
            tbxVärdeökningBostadsrätt.Text = "4%";
            tbxVärdeökningHus.Text = "4%";
            tbxFörsäljningBostad.Text = "80 000";
            tbxHyresökning.Text = "2%";
            tbxBostadsrättAvgiftshöjning.Text = "2%";
            tbxBostadsrättUnderhåll.Text = "1000";
            tbxBostadsrättUnderhållsökning.Text = "2%";
            cbxBostadsrättEnligtAmmorteringskravet.Checked = true;
            cbxBostadsrättLågLönAmmortering.Checked = false;
            tbxBostadsrättFastAmmortering.Text = "3000";
            tbxHusDriftkostnader.Text = "3000";
            tbxHusDriftkostnadsökning.Text = "2%";
            tbxHusInköpskostnad.Text = "2,5%";
            tbxHusUnderhållskostnad.Text = "5000";
            tbxHusUnderhållsökning.Text = "2%";
            cbxHusEnligtAmmorteringskravet.Checked = true;
            cbxHusLågLönAmmortering.Checked = false;
            tbxHusFastAmmortering.Text = "3000";
            tbxBostadsrättAndelLånVidKöp.Text = "85%";
            tbxHusAndelLånVidKöpet.Text = "85%";
        }

        private void Bostadskostnader_Load(object sender, EventArgs e)
        {

        }

        private void cbxqBostadsrättAmmorteringskravet_CheckedChanged(object sender, EventArgs e)
        {
            tbxBostadsrättFastAmmortering.Enabled = !cbxBostadsrättEnligtAmmorteringskravet.Checked;
            cbxBostadsrättLågLönAmmortering.Enabled = cbxBostadsrättEnligtAmmorteringskravet.Checked;
        }

        private void cbxHusEnligtAmmorteringskravet_CheckedChanged(object sender, EventArgs e)
        {
            tbxHusFastAmmortering.Enabled = !cbxHusEnligtAmmorteringskravet.Checked;
            cbxHusLågLönAmmortering.Enabled = cbxHusEnligtAmmorteringskravet.Checked;
        }
    }
}
