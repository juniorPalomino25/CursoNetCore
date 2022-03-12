using System;

namespace CursoNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
             //tipo de variables

            //valores numericos
            int year = 22; //entero
            float flotante = 13.5f; //float 7 dígitos -> 32 bits
            double doble = 12.004; //15 - 16 dígitos  -> 64 bits
            decimal decimals = 15.0000342M; // 28 - 29 digicots -> 128 bits

            // cadenas y caracteres
            char letra = 'a'; //caracter
            string nombre = "junior jose";

            //valores booleanos
            bool valor = true;

            //instanciando algunos objetos
            String apellidos = "palomino loa";

            //instanciando estructuras
            Decimal dec = 24.00928M;
            Char sexo = 'M';
            Int16 ciclo = 9;

            Console.WriteLine("Hello " + nombre + " " +apellidos + " {0} {1} {2} {3} {4} {5}", year, flotante, sexo, dec, apellidos,nombre + "\n");
            
            // Operadores

            //operador aritmético
            int valor1 = 10;
            int valor2 = 2;
            var suma = valor1 + valor2;
            var resta = valor1 - valor2;
            var mult = valor1 * valor2;
            var div = valor1 / valor2;

            Console.WriteLine("Operadores matemáticos \n");
            Console.WriteLine("valor 1: "+valor1 + " y valor 2: " +valor2 + "\n");
            Console.WriteLine("la suma es: " + suma + "\n");
            Console.WriteLine("la resta es: " + resta + "\n");
            Console.WriteLine("la multiplicacion es: " + mult + "\n");
            Console.WriteLine("la division es: " + div + "\n"); 

            //operador asignacion
            var aux = valor1;
            valor1 = valor2;
            valor2 = aux;
            Console.WriteLine("nuevo valor 1: " + valor1 + "\n");
            Console.WriteLine("nuevo valor 2: " + valor2 + "\n");

            //operador relacional
            var bandera = 5 < 2;
            Console.WriteLine("5<2 ? : " + bandera);

            //operador de igualdad
            var esIgual = 5 == 2;
            var esDiferente = 5 != 2;
            Console.WriteLine("5 = 2 ? : " + esIgual);
            Console.WriteLine("5 <> 2 ? : " + esDiferente);


            Console.ReadLine();
        }
    }
}
