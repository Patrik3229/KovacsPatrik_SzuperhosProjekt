﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Kepregeny.Szereplok("szereplok.txt");
            Kepregeny.Szuperhosok();
        }
    }
}
