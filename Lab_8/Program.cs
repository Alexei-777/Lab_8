using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//1.    Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов. 

namespace Lab_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo a = new DirectoryInfo("D:/111");
            Console.WriteLine("Каталоги");
            foreach (var item in a.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Подкаталоги");
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(it.Name);
                Console.WriteLine();
            }
            Console.WriteLine("Файлы");
            foreach (var item in a.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
