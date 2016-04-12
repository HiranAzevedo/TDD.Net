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
            int valor = 0;
            int valorDireita = 0;
            for (int i = nRomano.Length-1; i>=0; i--)
            {
                int atual = tabela[nRomano[i].ToString()];
                int multiplicador = 1;

                if (atual < valorDireita)
                {
                    multiplicador = -1;
                }

                valor += atual * multiplicador;

                valorDireita = atual;
            }

            return valor;
        }
    }
}