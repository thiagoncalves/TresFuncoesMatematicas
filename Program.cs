using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresFuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int valor1;

            Console.Write("Informe o prmeiro valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            int resultado1 = Porcentagem2Valor(valor, valor1);
            Console.WriteLine("A porcentagem acresida do segundo valor ao primeiro " +
                "é de: " + resultado1);

            int resultado2 = Soma(valor, valor1);
            Console.WriteLine("A soma dos dois números é: " + resultado2);

            double resultado3 = JurosCompostos(valor, valor1);
            Console.WriteLine("O valor recebido no final é de : " + resultado3);

            Console.ReadLine();

        }

        public static int Porcentagem2Valor(int valor1, int valor2)
        {
            int resultado;
            resultado = valor1 + valor1 * valor2 / 100;
            return resultado;
        }

        public static int Soma(int valor1, int valor2)
        {
            int resultado;
            resultado = valor1 + valor2;
            return resultado;
        }

        public static double JurosCompostos(double valor1, int valor2)
        {

            for (int i = 0; i < valor2; i++)
            {
                valor1 = valor1 * (1 + 0.7);
                i ++;
            }
            return valor1;
        }

    }
}
