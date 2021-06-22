using System;
using System.IO;
using System.Text;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.File.AppendAllText("D:\\TextFile.txt", "asassadsd");
            //System.IO.File.WriteAllText("D:\\TextFile.txt", "asassadsd");
            //StreamWriter file = new StreamWriter("D:\\TextFile.txt");
            //file.Write("brrrrrrr");
            //file.Close();
            string path = @"D:\\TestFile2.txt";
            string[] createText = { "Hello", "And", "Welcome", "GoodBye", "or" };
            File.WriteAllLines(path, createText, Encoding.UTF8);        
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
