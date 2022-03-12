using System;

namespace CursoNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de variables
            int year = 22; //entero
            float flotante = 13.5f; //float 7 dígitos -> 32 bits
            double doble = 12.004; //15 - 16 dígitos  -> 64 bits
            decimal decimals = 15.0000342M; // 28 - 29 digicots -> 128 bits

            // cadenas y caracteres
            char letra = 'a'; //caracter
            string nombre = "junior palomino";

            //valores booleanos
            bool valor = true;

            //instanciando algunos objetos
            String apellidos = "palomino loa";

            //instanciando estructuras
            Decimal dec = 24.00928M;
            Char sexo = 'M';
            Int16 ciclo = 9;

            Console.WriteLine("Hello World! {0} {1} ", year, ciclo);
            Console.ReadLine();
        }
    }
}
