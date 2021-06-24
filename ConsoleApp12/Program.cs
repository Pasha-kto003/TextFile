using System;
using System.IO;
using System.Text;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\\TestFile10.txt";
            Console.WriteLine("Введите текст");
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            File.WriteAllLines(path, text);
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine(line);
                }
                Console.WriteLine("Количество строк в массиве: " + count.ToString());
            }
            string[] newtext = new string[text.Length];
            int a = 0;
            string path1 = @"D:\\TestFile14.txt";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newtext[a] = text[i];
                    a++;
                }
                File.WriteAllLines(path1, newtext, Encoding.UTF8);
            }
        }
    }
}

