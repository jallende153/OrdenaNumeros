using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Ingrese el Primer Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el Tercer Número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num1> num2 && num1 > num3)
            {
                Console.WriteLine("El número mayor es: {0} ", num1);
                if(num2 > num3)
                {
                    Console.WriteLine("El número del medio es: {0}", num2);
                    Console.WriteLine("El número menor es: {0}", num3);
                }
                else
                {
                    Console.WriteLine("El número del medio es: {0}", num3);
                    Console.WriteLine("El número menor es: {0}", num2);
                }
            }
            else
            {
                if(num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("El número mayor es: {0} ", num2);
                    if (num1 > num3)
                    {
                        Console.WriteLine("El número del medio es: {0}", num1);
                        Console.WriteLine("El número menor es: {0}", num3);
                    }
                    else
                    {
                        Console.WriteLine("El número del medio es: {0}", num3);
                        Console.WriteLine("El número menor es: {0}", num1);
                    }
                }
                else
                {
                    Console.WriteLine("El número mayor es: {0} ", num3);
                    if (num1 > num2)
                    {
                        Console.WriteLine("El número del medio es: {0}", num1);
                        Console.WriteLine("El número menor es: {0}", num2);
                    }
                    else
                    {
                        Console.WriteLine("El número del medio es: {0}", num2);
                        Console.WriteLine("El número menor es: {0}", num1);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
