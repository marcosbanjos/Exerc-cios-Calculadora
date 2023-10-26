using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Criar um script que solicite 2 numeros ao usuário
                e ao final mostre a soma dos valores           
            */

            // Definindo as variaveis
            decimal numero_um;
            decimal numero_dois;
            decimal resultado;
       

            Console.WriteLine("SOMA\n");

            // Inserindo valores
            Console.Write("Informe o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o segundo numero: ");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("-----------------------------------");

            // Calculando
            Console.WriteLine("Resultados\n");

            resultado = numero_um + numero_dois;

            Console.WriteLine(
                "A soma do numero " + numero_um + 
                " com o numero " + numero_dois + 
                " é: " + resultado
            );

            resultado = numero_um - numero_dois;

            Console.WriteLine(
                "A subtração do numero " + numero_um +
                " com o numero " + numero_dois +
                " é: " + resultado
            );

            resultado = numero_um * numero_dois;

            Console.WriteLine(
                "A multiplicação do numero " + numero_um +
                " com o numero " + numero_dois +
                " é: " + resultado
            );

            resultado = numero_um / numero_dois;

            Console.WriteLine(
                "A divisão do numero " + numero_um +
                " pelo o numero " + numero_dois +
                " é: " + resultado
            );

            Console.ReadLine();
            
        }
    }
}
