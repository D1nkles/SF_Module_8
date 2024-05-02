using System.IO;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                int i = 0;
                foreach (string d in dirs) // Выведем их все
                {
                    Console.WriteLine(d);
                    i++;
                }
                Console.WriteLine($"Кол-во папок: {i}");


                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                int k = 0;
                foreach (string s in files)   // Выведем их все
                { 
                    Console.WriteLine(s);
                    k++;
                }
                Console.WriteLine($"Кол-во файлов: {k}");

                Console.WriteLine($"Всего объектов: {i + k}");
            }
        }
    }
}