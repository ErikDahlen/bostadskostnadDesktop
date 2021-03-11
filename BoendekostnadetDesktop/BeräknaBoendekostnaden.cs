using System;
using System.Collections.Generic;
using System.Text;

namespace BoendekostnadetDesktop
{
    class BeräknaBoendekostnaden
    {
        private Hyresrätt _hyresrätten = new Hyresrätt();
        private Bostadsrätt _bostadsrätten = new Bostadsrätt();
        private Hus _hus = new Hus();
        private int _antalÅr;
        private decimal _värdeökningAktier;
        private decimal _värdeökningBostadsrätt;
        private decimal _värdeökningHus;
        private int _delaSvaretMed;
        private int _försäljningskostnadBostad;
        private decimal _hävstångAktier;
        public SvarBeräkning Beräkna(Parametrar param)
        {
            AngeParametrar(param);

            //fyll på portföljerna
            var högstaPris = Math.Max(_bostadsrätten.Inköpspris, _hus.Inköpspris + _hus.Inköpskostnad);
            _hyresrätten.Aktieportfölj = högstaPris * 0.15M;
            _bostadsrätten.Aktieportfölj = (högstaPris - _bostadsrätten.Inköpspris) * 0.15M;
            _hus.Aktieportfölj = (högstaPris - (_hus.Inköpspris + _hus.Inköpskostnad)) * 0.15M;

            var hyresKostnad = 0;
            var bostadsrättKostnad = 0;
            var husKostnad = 0;
            for (int i = 0; i < _antalÅr; i++)
            {
                //fixa med hyreskostnaden
                hyresKostnad = hyresKostnad + _hyresrätten.Årskostnad();
                _hyresrätten.ÖkaHyran();

                //fixa med bostadsrattskostnaden
                bostadsrättKostnad = bostadsrättKostnad + _bostadsrätten.Årskostnad();
                _bostadsrätten.ÖkaKostnaden();
                _bostadsrätten.MinskaLån();

                //fixa med huskostnaden
                husKostnad = husKostnad + _hus.Årskostnad();
                _hus.ÖkaKostnaden();
                _hus.MinskaLån();

                var högstaÅrskostnad = HögstaÅrskostnaden();

                //fixa med hyresgästens portfölj
                _hyresrätten.Aktieportfölj = _hyresrätten.Aktieportfölj * (1 + (_värdeökningAktier * (1 + _hävstångAktier))) + högstaÅrskostnad - _hyresrätten.Årskostnad();

                //fixa med bostadsrättens portfölj
                _bostadsrätten.Värde = _bostadsrätten.Värde * (1 + _värdeökningBostadsrätt);
                _bostadsrätten.Aktieportfölj = _bostadsrätten.Aktieportfölj * (1 + (_värdeökningAktier * (1 + _hävstångAktier))) + högstaÅrskostnad - _bostadsrätten.Årskostnad();

                //fixa med husets portfölj
                _hus.Värde = _hus.Värde * (1 + _värdeökningHus);
                _hus.Aktieportfölj = _hus.Aktieportfölj * (1 + (_värdeökningAktier * (1 + _hävstångAktier))) + högstaÅrskostnad - _hus.Årskostnad();
            }
            //skapa svaret
            var svaret = new SvarBeräkning();
            svaret.HyresrättKostnad = "Lägsta bostadsutgifter för hyresrätt är: " + (int)(hyresKostnad / _delaSvaretMed);
            svaret.BostadsrättKostnad = "Lägsta bostadsutgifter för bostadsrätt är: " + (int)(bostadsrättKostnad / _delaSvaretMed);
            svaret.HusKostnad = "Lägsta bostadsutgifter för hus är: " + (int)(husKostnad / _delaSvaretMed);
            svaret.HyresrättFörmögenhet = "Förmögenheten för hyresrätt är: " + (int)(_hyresrätten.Aktieportfölj / _delaSvaretMed) + ". \nVarav allt är aktievärde.";
            svaret.BostadsrättFörmögenhet = "Förmögenheten för bostadsrätt är: " +
                (int)((_bostadsrätten.Värde - _bostadsrätten.Lån + _bostadsrätten.Aktieportfölj - _försäljningskostnadBostad) / _delaSvaretMed) +
                ". \nVarav husvärde " + (int)((_bostadsrätten.Värde - _bostadsrätten.Lån - _försäljningskostnadBostad) / _delaSvaretMed) + "" +
                " och aktievärde " + (int)(_bostadsrätten.Aktieportfölj / _delaSvaretMed) + ".";
            svaret.HusFörmögenhet = "Förmögenheten för hus efter är: " +
                (int)((_hus.Värde - _hus.Lån + _hus.Aktieportfölj - _försäljningskostnadBostad) / _delaSvaretMed) +
                ". \nVarav husvärde " + (int)((_hus.Värde - _hus.Lån - _försäljningskostnadBostad) / _delaSvaretMed) +
                " och aktievärde " + (int)(_hus.Aktieportfölj / _delaSvaretMed) + ".";

            return svaret;
        }
        private void AngeParametrar(Parametrar param)
        {
            //sätt generella parametrar
            _antalÅr = param.AntalÅr;
            _värdeökningAktier = param.VärdeökningAktier;
            _hävstångAktier = param.HävstångAktier; //ange hur många procents hävstång man tar på sina aktier
            _värdeökningBostadsrätt = param.VärdeökningBostadsrätter;
            _värdeökningHus = param.VärdeökningHus;
            _delaSvaretMed = param.DelaSvaretMed; //använd gärna 1, 1000 eller 1000*1000 för att få beloppet i kronor, tusental eller i miljoner
            _försäljningskostnadBostad = param.FörsäljningBostad; //exempelvis mäklare, fina till bostaden osv.

            //sätt parametrar för hyresrätten
            _hyresrätten.Hyra = param.Hyra;
            _hyresrätten.Hyresökning = param.Hyresökning;

            //sätt parametrar för bostadsrätten
            _bostadsrätten.Avgift = param.BostadsrättAvgift;
            _bostadsrätten.Avgiftsökning = param.BostadsrättAvgifthöjning;
            _bostadsrätten.Inköpspris = param.BostadsrättPris;
            _bostadsrätten.Lån = (int)(_bostadsrätten.Inköpspris * 0.85M);
            _bostadsrätten.Värde = _bostadsrätten.Inköpspris;
            _bostadsrätten.Ränta = param.BostadsrättRänta;
            _bostadsrätten.FastAmmortering = 3000;
            _bostadsrätten.AmmorteraEnligtAmmorteringsreglerna = true;
            _bostadsrätten.LågLönExtraAmmortering = false;
            _bostadsrätten.Underhåll = param.BostadsrättUnderhåll;
            _bostadsrätten.UnderhållÖkning = param.BostadsrättUnderhållsökning;

            //sätt parametrar för hus
            _hus.Driftkostnad = 3000;
            _hus.Driftkostnadsökning = 0.02M;
            _hus.Inköpspris = param.HusPris;
            _hus.Inköpskostnad = (int)(_hus.Inköpspris * 0.025M); //kostnad för lagfart och pantbrev, 2.5% antar att pantbrev finns på en del av lånekostnaden men inte allt.
            _hus.Lån = (int)(_hus.Inköpspris * 0.85M);
            _hus.Värde = _hus.Inköpspris;
            _hus.Ränta = param.HusRänta;
            _hus.FastAmmortering = 3000;
            _hus.AmmorteraEnligtAmmorteringsreglerna = true;
            _hus.LågLönExtraAmmortering = false;
            _hus.Underhåll = 5000;
            _hus.UnderhållÖkning = 0.02M;
        }
        private int HögstaÅrskostnaden()
        {
            //räkna ut vem som har högst årskostnad
            var kostnader = new int[3];
            kostnader[0] = _hyresrätten.Årskostnad();
            kostnader[1] = _bostadsrätten.Årskostnad();
            kostnader[2] = _hus.Årskostnad();
            var högst = kostnader[0];
            foreach (var kostnad in kostnader)
            {
                if (kostnad > högst)
                {
                    högst = kostnad;
                }
            }
            return högst;
        }
    }
}
