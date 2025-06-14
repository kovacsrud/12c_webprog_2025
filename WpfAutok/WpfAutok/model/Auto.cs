﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutok.model
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int Evjarat { get; set; }
        public string Uzem { get; set; }
        public int Hengerurtartalom { get; set; }
        public int Teljesitmeny { get; set; }
        public int FutottKm { get; set; }
        public int Ar { get; set; }

        public Auto(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);

            Id=Convert.ToInt32(adatok[0]);
            Marka=adatok[1].Trim();
            Tipus=adatok[2].Trim();
            Evjarat=Convert.ToInt32(adatok[3]);
            Uzem=adatok[4].Trim();
            Hengerurtartalom=Convert.ToInt32(adatok[5]);
            Teljesitmeny=Convert.ToInt32(adatok[6]);
            FutottKm=Convert.ToInt32(adatok[7]);
            Ar=Convert.ToInt32(adatok[8]);
        }


    }
}
