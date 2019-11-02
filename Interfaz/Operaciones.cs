using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    public class Operaciones : Numeros, IOperacion
    {
        Numeros n = new Numeros();
        public void Division()
        {
            Console.WriteLine("Metodo de Dividir");
            Console.WriteLine("Ingrese el numero a dividir");
            n.N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n.N2 = Convert.ToDouble(Console.ReadLine());
            double res = n.N1 / n.N2;
            Console.WriteLine("El resultado de dividir {0} entre {1} es = {2}", n.N1, n.N2, res);
        }

        public void Multiplicacion()
        {
            Console.WriteLine("Metodo de Multiplicar");
            Console.WriteLine("Ingrese el 1 numero");
            n.N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el 2 numero");
            n.N2 = Convert.ToDouble(Console.ReadLine());
            double res = n.N1 * n.N2;
            Console.WriteLine("El resultado de Multipliacar {0} entre {1} es = {2}", n.N1, n.N2, res);
        }

        public void Resta()
        {
            Console.WriteLine("Metodo de Restar");
            Console.WriteLine("Ingrese el numero a dividir");
            n.N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n.N2 = Convert.ToDouble(Console.ReadLine());
            double res = n.N1 - n.N2;
            Console.WriteLine("El resultado de Restar {0} entre {1} es = {2}", n.N1, n.N2, res);
        }

        public void Suma()
        {
            Console.WriteLine("Metodo de Sumar");
            Console.WriteLine("Ingrese el numero a dividir");
            n.N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n.N2 = Convert.ToDouble(Console.ReadLine());
            double res = n.N1 + n.N2;
            Console.WriteLine("El resultado de Sumar {0} entre {1} es = {2}", n.N1, n.N2, res);
        }
    }
}
