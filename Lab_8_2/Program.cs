using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.

namespace Lab_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество цифр");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            Random random = new Random();
            string path = "D:/111/text.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < N; i++)
                {
                    sw.WriteLine(random.Next(0, 100));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < N; i++)
                {
                    S = S + Int32.Parse(sr.ReadLine());
                }
            }
            Console.WriteLine($"Сумма чисел в файле text.txt равна: {S}");
            Console.ReadKey();
        }
    }
}
