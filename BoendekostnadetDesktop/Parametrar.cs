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
        private decimal värdeökningAktier;
        public decimal VärdeökningAktier
        {
            get { return värdeökningAktier; }
            set { värdeökningAktier = value; }
        }
        private decimal hävstångAktier;
        public decimal HävstångAktier
        {
            get { return hävstångAktier; }
            set { hävstångAktier = value; }
        }
        private decimal värdeökningBostadsrätter;
        public decimal VärdeökningBostadsrätter
        {
            get { return värdeökningBostadsrätter; }
            set { värdeökningBostadsrätter = value; }
        }
        private decimal värdeökningHus;
        public decimal VärdeökningHus
        {
            get { return värdeökningHus; }
            set { värdeökningHus = value; }
        }
        private int försäljningBostad;
        public int FörsäljningBostad
        {
            get { return försäljningBostad; }
            set { försäljningBostad = value; }
        }
        private decimal hyresökning;
        public decimal Hyresökning
        {
            get { return hyresökning; }
            set { hyresökning = value; }
        }
        private decimal bostadsrättAvgifthöjning;
        public decimal BostadsrättAvgifthöjning
        {
            get { return bostadsrättAvgifthöjning; }
            set { bostadsrättAvgifthöjning = value; }
        }
        private int bostadsrättUnderhåll;
        public int BostadsrättUnderhåll
        {
            get { return bostadsrättUnderhåll; }
            set { bostadsrättUnderhåll = value; }
        }
        private decimal bostadsrättUnderhållsökning;
        public decimal BostadsrättUnderhållsökning
        {
            get { return bostadsrättUnderhållsökning; }
            set { bostadsrättUnderhållsökning = value; }
        }
    }
}
