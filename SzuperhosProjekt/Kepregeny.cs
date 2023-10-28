using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string fajlEleresiUtvonal)
        {
            using StreamReader sr = new StreamReader(fajlEleresiUtvonal);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] pieces = line.Split(' ');
                if (pieces[0] == "Vasember")
                {
                    Vasember v = new Vasember();
                    for (int i = 0; i < int.Parse(pieces[1]); i++)
                    {
                        v.KutyutKeszit();
                    }
                    szuperhosok.Add(v);
                }
                else
                {
                    Batman batman = new Batman();
                    for (int i = 0; i < int.Parse(pieces[1]); i++)
                    {
                        batman.KutyutKeszit();
                    }
                    szuperhosok.Add(batman);
                }
            }
        }

        public static void Szuperhosok()
        {
            for (int i = 0; i < szuperhosok.Count; i++)
            {
                Console.WriteLine(szuperhosok[i]);
            }
        }
    }
}
