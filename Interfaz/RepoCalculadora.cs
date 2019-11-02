using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
  public class RepoCalculadora
    {
        Operaciones o = new Operaciones();
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido a my program");
            Menu();
        }
       public void Menu()
        {
            Console.WriteLine("Elige la opcion deseada");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("Elija una opcion");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    o.Suma();
                    Console.ReadKey();
                    break;
                case 2:
                    o.Resta();
                    break;
                 case 3:
                    o.Multiplicacion();
                    break;
                case 4:
                    o.Division();
                    break;
                default:
                    Console.WriteLine("Opcion no validad");
                    Console.WriteLine("Desea regresar al menu oprima °1 para regresar al menu");
                    int op = Convert.ToInt32(Console.ReadLine());
                    if (op == 1)
                    {
                        Menu();
                    }
                    else 
                    {
                        Console.WriteLine("Gracias por visitar mi programa");
                    }
                    break;
            
            }
        }
    }
}
