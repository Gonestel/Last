using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь файла");
            string path = Convert.ToString(Console.ReadLine());
            FileInfo fileInf = new FileInfo(path);
            if (File.Exists(path))
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }
            else { File.Create(path);
                Console.WriteLine("Файл отсутствует. Создан новый файл");
            }
            Console.WriteLine("Введите число, чтобы: 1. Удалить файл. 2. Копировать файл по выбранному пути. 3. Переместить файл по выбранному пути");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            { File.Delete(path);
                Console.WriteLine("Файл удалён");
                    }
            else
            {
                if (File.Exists(path) && (v == 2))
                {
                    Console.WriteLine("Введите путь");
                    string newpath = Convert.ToString(Console.ReadLine());
                    File.Copy(path, newpath, true);
                    Console.WriteLine("Файл скопирован");
                }
                else
                {
                    if (File.Exists(path) && (v == 3))
                    {
                        Console.WriteLine("Введите путь");
                        string newpath = Convert.ToString(Console.ReadLine());
                        File.Move(path, newpath);
                        Console.WriteLine("Файл перемещён");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
