/*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. 
Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
Exemplo:
Qual é a cotação do dólar? 3.10
Quantos dólares você vai comprar? 200.00
Valor a ser pago em reais = 657.20*/


using Exercicio_POO_07_Calculadora;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual a cotação do dólar?");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Quantos dólares você vai comprar?");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double soma = ConversorDeMoeda.CalcularDolarParaReal(quantia, cotacao);
        Console.WriteLine("Valor a ser pago em reais = R$" + soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}