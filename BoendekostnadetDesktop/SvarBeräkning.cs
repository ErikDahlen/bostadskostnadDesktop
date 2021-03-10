using System;
using System.Collections.Generic;
using System.Text;

namespace BoendekostnadetDesktop
{
    class SvarBeräkning
    {
        private string hyresrättKostnad;
        public string HyresrättKostnad
        {
            get { return hyresrättKostnad; }
            set { hyresrättKostnad = value; }
        }
        private string bostadsrättKostnad;
        public string BostadsrättKostnad
        {
            get { return bostadsrättKostnad; }
            set { bostadsrättKostnad = value; }
        }
        private string husKostnad;
        public string HusKostnad
        {
            get { return husKostnad; }
            set { husKostnad = value; }
        }
        private string hyresrättFörmögenhet;
        public string HyresrättFörmögenhet
        {
            get { return hyresrättFörmögenhet; }
            set { hyresrättFörmögenhet = value; }
        }
        private string bostadsrättFörmögenhet;
        public string BostadsrättFörmögenhet
        {
            get { return bostadsrättFörmögenhet; }
            set { bostadsrättFörmögenhet = value; }
        }
        private string husFörmögenhet;
        public string HusFörmögenhet
        {
            get { return husFörmögenhet; }
            set { husFörmögenhet = value; }
        }
    }
}
