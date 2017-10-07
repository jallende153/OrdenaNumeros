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
            do
            {
                Console.Write("Ingrese el Primer Número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Segundo Número: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Tercer Número: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine("El número mayor es el Primer número: {0} ", num1);
                    if (num2 > num3)
                    {
                        Console.WriteLine("El número del medio es le Segundo número: {0}", num2);
                        Console.WriteLine("El número menor es el Tercer número: {0}", num3);
                    }
                    else
                    {
                        Console.WriteLine("El número del medio es el Tercer Número: {0}", num3);
                        Console.WriteLine("El número menor es el Segundo Número: {0}", num2);
                    }
                }
                else
                {
                    if (num2 > num1 && num2 > num3)
                    {
                        Console.WriteLine("El número mayor es el Segundo Número: {0} ", num2);
                        if (num1 > num3)
                        {
                            Console.WriteLine("El número del medio es el Primer Número: {0}", num1);
                            Console.WriteLine("El número menor es el Tercer Número: {0}", num3);
                        }
                        else
                        {
                            Console.WriteLine("El número del medio es el Tercer Número: {0}", num3);
                            Console.WriteLine("El número menor es el Primer Número: {0}", num1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número mayor es el Tercer Número: {0} ", num3);
                        if (num1 > num2)
                        {
                            Console.WriteLine("El número del medio es Primer Número: {0}", num1);
                            Console.WriteLine("El número menor es el Segundo Número: {0}", num2);
                        }
                        else
                        {
                            Console.WriteLine("El número del medio es el Segundo Número: {0}", num2);
                            Console.WriteLine("El número menor es el Primer Número: {0}", num1);
                        }
                    }
                }
            } while (true);
        }
    }
}
