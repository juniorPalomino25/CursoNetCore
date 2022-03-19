using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_de_net_core
{
    class Program : Menu
    {
        static void Main()
        {
            Console.WriteLine("Seccion golosinas\n\n");
            new Program().golosinas();
            Console.WriteLine("\n\n");
            Console.WriteLine("Seccion Frutas\n\n");
            new Program().frutas();
        }
      
    }
}
