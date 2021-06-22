using System;
using System.IO;
using System.Text;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\\TestFile2.txt";
            string path2 = @"D:\\TestFile6.txt";
            string[] createText = { "Hello", "And", "Welcome", "GoodBye", "or", "new word" };
            string[] newText = new string[createText.Length];
            File.WriteAllLines(path, createText, Encoding.UTF8);
            int count = 0;
            for (int i = 0; i < createText.Length; i ++)
            {
                if (i % 2 == 0)
                {
                    int a = i;
                    //Console.WriteLine(createText[a--]);
                    newText[count] = createText[a--];
                    count++;
                }
                File.WriteAllLines(path2, newText, Encoding.UTF8);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int a = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    a++;
                    Console.WriteLine(line);
                }
                Console.WriteLine("Количество строк: " + a.ToString());
            }
        }
    }
}

