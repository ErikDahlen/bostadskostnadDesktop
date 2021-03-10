using System;
using System.Collections.Generic;
using System.Text;

namespace BoendekostnadetDesktop
{
    class Parametrar
    {
        private int antalÅr;
        public int AntalÅr
        {
            get { return antalÅr; }
            set { antalÅr = value; }
        }
        private int hyra;
        public int Hyra
        {
            get { return hyra; }
            set { hyra = value; }
        }
        private int bostadsrättPris;
        public int BostadsrättPris
        {
            get { return bostadsrättPris; }
            set { bostadsrättPris = value; }
        }
        private decimal bostadsrättRänta;
        public decimal BostadsrättRänta
        {
            get { return bostadsrättRänta; }
            set { bostadsrättRänta = value; }
        }
        private int bostadsrättAvgift;
        public int BostadsrättAvgift
        {
            get { return bostadsrättAvgift; }
            set { bostadsrättAvgift = value; }
        }
        private int husPris;
        public int HusPris
        {
            get { return husPris; }
            set { husPris = value; }
        }
        private decimal husRänta;
        public decimal HusRänta
        {
            get { return husRänta; }
            set { husRänta = value; }
        }
        private int delaSvaretMed;
        public int DelaSvaretMed
        {
            get { return delaSvaretMed; }
            set { delaSvaretMed = value; }
        }
    }
}
