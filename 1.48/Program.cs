using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double trapecija1, trapecija2;
            double vychisl, vychisl2;
            double trapecija3;
            double gipotenuza;
            double perimetr;

            while (true)
            {
                Console.Write("Введите первое значение большей трапеции: ");
                trapecija1 = double.Parse(Console.ReadLine());
              
                Console.Write("Введите второе значение меньшей трапеции: ");
                trapecija2 = double.Parse(Console.ReadLine());
                
                Console.Write("Введите третье значение высоты трапеции: ");
                trapecija3 = double.Parse(Console.ReadLine());

                vychisl = trapecija1 - trapecija2;
                vychisl2 = trapecija3;

                gipotenuza = Math.Round(Math.Sqrt((vychisl * vychisl) + (vychisl2 * vychisl2)), 2);

                perimetr = trapecija2 + trapecija1 + (gipotenuza * 2);

                if (trapecija1 <= 0)
                {
                    Console.WriteLine("Нет решения");
                }
                
                else if (trapecija2 <= 0)
                {
                    Console.WriteLine("Нет решения");
                }
                  
                else if (trapecija2 >= trapecija1)
                {
                    Console.WriteLine("Нет решения");
                }              
                else if (trapecija3 <= 0)
                {
                    Console.WriteLine("Нет решения");
                }
                else
                    break;

                Console.WriteLine();
            }
            Console.WriteLine($"Периметр трапеции = {perimetr}");
            Console.ReadLine();

        }
    }
}
