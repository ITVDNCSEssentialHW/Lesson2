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

        private double GRVtoUSD()
        {
            return grv / usd;
        }
        private double GRVtoEUR()
        {
            return grv / eur;
        }
        private double GRVtoRUB()
        {
            return grv / rub;
        }
        
        public Converter(double usd, double eur, double rub, double currencyVol, bool sell)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            this.currencyVol = currencyVol;
            this.sell = true;
        }

        private double USDtoGRV()
        {
            return currencyVol * usd;
        }
        private double EURtoGRV()
        {
            return currencyVol * eur;
        }
        private double RUBtoGRV()
        {
            return currencyVol * rub;
        }
        //Buy
        public double GRVUSD { get { return GRVtoUSD(); } }
        public double GRVEUR { get { return GRVtoEUR(); } }
        public double GRVRUB { get { return GRVtoRUB(); } }
        //Sell
        public double USDGRV { get { return USDtoGRV(); } }
        public double EURGRV { get { return EURtoGRV(); } }
        public double RUBGRV { get { return RUBtoGRV(); } }
    }
}
