using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_07_Calculadora
{
    static class ConversorDeMoeda
    {
        static double Iof = 6;

        public static double CalcularDolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
    }
}
