using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Вручную подготовьте текстовый файл с фрагментом текста.
//Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.

namespace Lab_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/111/text1.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                String Text = sr.ReadToEnd();
                Console.WriteLine($"Количество символов: {Text.Length}");
                int strok = 0;
                int slov = 0;
                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text[i] == ' ')
                    {
                        slov = slov + 1;
                    }
                    if (Text[i] == '.')
                    {
                        strok = strok + 1;
                    }
                }
                Console.WriteLine($"Количество строк: {strok}");
                Console.WriteLine($"Количество слов: {slov}");
            }
            Console.ReadKey();
        }
    }
}

