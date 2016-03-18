using System;
using System.Collections.Generic;

namespace ProblemaNumerosRomanosTest
{
    public class ConversorDeNumeroRomano
    {

        private static Dictionary<string, int> tabela = new Dictionary<string, int>()
        {
            {"I",1 },
            {"V",5 },
            {"X",10 },
            {"L",50 },
            {"C",100 },
            {"D",500 },
            {"M",1000 },
        };

        public int Converte(string nRomano)
        {
            return tabela[nRomano];
        }
    }
}