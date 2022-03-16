using System;
using System.Text;

namespace CursoNetCore
{
    class Program
    {
        static void Main(string[] args)
        {


            //tipo de variables

            //valores numericos
            //int year = 22; //entero
            //float flotante = 13.5f; //float 7 dígitos -> 32 bits
            //double doble = 12.004; //15 - 16 dígitos  -> 64 bits
            //decimal decimals = 15.0000342M; // 28 - 29 digicots -> 128 bits

            //// cadenas y caracteres
            //char letra = 'a'; //caracter
            //string nombre = "junior jose";

            ////valores booleanos
            //bool valor = true;

            ////instanciando algunos objetos
            //String apellidos = "palomino loa";

            ////instanciando estructuras
            //Decimal dec = 24.00928M;
            //Char sexo = 'M';
            //Int16 ciclo = 9;

            //Console.WriteLine("Hello " + nombre + " " + apellidos + " {0} {1} {2} {3} {4} {5}", year, flotante, sexo, dec, apellidos, nombre + "\n");

            //// Operadores

            ////operador aritmético
            //int valor1 = 10;
            //int valor2 = 2;
            //var suma = valor1 + valor2;
            //var resta = valor1 - valor2;
            //var mult = valor1 * valor2;
            //var div = valor1 / valor2;

            //Console.WriteLine("Operadores matemáticos \n");
            //Console.WriteLine("valor 1: " + valor1 + " y valor 2: " + valor2 + "\n");
            //Console.WriteLine("la suma es: " + suma + "\n");
            //Console.WriteLine("la resta es: " + resta + "\n");
            //Console.WriteLine("la multiplicacion es: " + mult + "\n");
            //Console.WriteLine("la division es: " + div + "\n");

            ////operador asignacion
            //var aux = valor1;
            //valor1 = valor2;
            //valor2 = aux;
            //Console.WriteLine("nuevo valor 1: " + valor1 + "\n");
            //Console.WriteLine("nuevo valor 2: " + valor2 + "\n");

            ////operador relacional
            //var bandera = 5 < 2;
            //Console.WriteLine("5<2 ? : " + bandera);

            ////operador de igualdad
            //var esIgual = 5 == 2;
            //var esDiferente = 5 != 2;
            //Console.WriteLine("5 = 2 ? : " + esIgual + "\n");
            //Console.WriteLine("5 <> 2 ? : " + esDiferente + "\n");

            ////SENTENCIA IF

            //if (valor1 == valor2)
            //{
            //    Console.WriteLine("valor 1 y valor 2 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("valor 1 y valor 2 son diferentes");
            //}

            ////SENTENCIA FOR

            //string name = "juniorpalomino";
            //char[] vname = name.ToCharArray();

            //for (int i = 0; i < name.Length; i++)
            //{

            //    Console.WriteLine(vname[i]);
            //}


            //foreach (var item in name)
            //{
            //    Console.WriteLine(vname);
            //}

            //SENTENCIA SWITCH

            //var data = 2;
            //switch (data)
            //{
            //    case 1: 
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    default: break;
            //}

            //var result = data switch
            //{
            //    1 => "1",
            //    2 => "2",
            //    3 => "3"
            //};
            //Console.WriteLine(result);

            //var (a, b, opcion) = (2,4,"+");
            //var result = opcion switch
            //{
            //    "+" => a+b,
            //    "-" => a-b,
            //    "*" => a*b
            //};
            //Console.WriteLine(result);

            //SENTENCIA WHILE
            //int cont = 1;
            //while (cont<6)
            //{
            //    Console.WriteLine(cont);
            //    cont++;
            //}

            //SENTENCIA DO WHILE
            //int cont = 1;
            //do
            //{
            //   Console.WriteLine(cont);
            //    cont++;
            //} while (cont<=6);


            //string name1 = "jose";
            //string name2 = "junior";
            //string name3 = name1;

            //name1 += name2;
            //Console.WriteLine(name3);

            //INTERPOLACION DE CADENAS DE TIPO STRING
            //var names = (name1 : "junior", name2 : "jose", age: 23);
            //Console.WriteLine($"{names.name1} edad: {names.age}");

            //OPERACIONES STRING

            
            var curso = ".NET CORE USANDO C#";
            var cadena1 = curso.ToCharArray();
            //var cadena1= curso.IndexOf('.');
            //cadena1 = curso.Substring(5, 8);
            //cadena1 = curso.Replace(".", "CURSO DE .");
            //cadena1 = curso.Remove(10);

            StringBuilder namess = new StringBuilder();

            
            Console.WriteLine(cadena1[2]);

            Console.ReadLine();
        }
    }
}
