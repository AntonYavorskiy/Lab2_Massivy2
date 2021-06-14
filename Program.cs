using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_mas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа 2. Массивы 2:Вывести количество отрицательных элементов.");
            int v = 33;
            Console.WriteLine("                      Порядковый номер по списку группы: 33");
            Console.WriteLine("                                " + ((v % 10) + 1) + " Вариант");


            Console.Write("Введите количество элементов:");
            var len = int.Parse(0 + Console.ReadLine());


            int minus = 0;
            var array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1 + " Элемент = ");
                array[i] = int.Parse(Console.ReadLine());


            }
            Console.Write("Количество отрицательных элементов в массиве: ");
           
            for (int i = 0; i < array.Length; i++)
            

                if (array[i] < 0)
                

                    minus++;
                    
                    

                
                Console.Write(minus);

            

            Console.ReadKey();
        }
    }
}
