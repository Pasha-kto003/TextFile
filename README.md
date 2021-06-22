# TextFile
Запись, и подсчет
string path = @"D:\\TestFile2.txt"; // создание пути на документ
string path2 = @"D:\\TestFile6.txt"; // создание пути на документ
string[] createText = { "Hello", "And", "Welcome", "GoodBye", "or", "new word" }; // создание массивов строк
string[] newText = new string[createText.Length]; // создание массивов строк
File.WriteAllLines(path, createText, Encoding.UTF8); // запись массива в файл. Создает новый файл, записывает в него одну или несколько строк, затем закрывает файл.
int count = 0; //запись во второй файл нечетных чисел
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
 using (StreamReader sr = new StreamReader(path)) // считывание файла и подсчет количества строк
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
