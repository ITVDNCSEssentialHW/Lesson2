using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Converter
    {
        double usd, eur, rub, grv, currencyVol;
        bool sell;

        public Converter(double usd, double eur, double rub, double grv)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            this.grv = grv;
        }

        private double RUBtoUSD()
        {
            return rub / usd;
        }
        private double RUBtoEUR()
        {
            return rub / eur;
        }
        private double RUBtoGRV()
        {
            return rub / grv;
        }
        
        public Converter(double usd, double eur, double grv, double currencyVol, bool sell)
        {
            this.usd = usd;
            this.eur = eur;
            this.grv = grv;
            this.currencyVol = currencyVol;
            this.sell = true;
        }

        private double USDtoRUB()
        {
            return currencyVol * usd;
        }
        private double EURtoRUB()
        {
            return currencyVol * eur;
        }
        private double GRVtoRUB()
        {
            return currencyVol * grv;
        }
        //Buy
        public double RUBUSD { get { return RUBtoUSD(); } }
        public double RUBEUR { get { return RUBtoEUR(); } }
        public double RUBGRV { get { return RUBtoGRV(); } }
        //Sell
        public double USDRUB { get { return USDtoRUB(); } }
        public double EURRUB { get { return EURtoRUB(); } }
        public double GRVRUB { get { return GRVtoRUB(); } }
    }
}
