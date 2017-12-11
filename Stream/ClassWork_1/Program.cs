using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1
{   // Ввести назву директорії і перевірити чи вона існує, якщо не існує - створити
    // Створити файл і записати в нього текст
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введiть назву директорії");
            string dir1 = Console.ReadLine();


            if (Directory.Exists(dir1))
            {
                Console.WriteLine("Директорія існує");
            }
            else
            {
                Directory.CreateDirectory(dir1);
            }
            Console.WriteLine("Введiть назву файла");
            string fileName = Console.ReadLine();

            Console.WriteLine("Введiть текст");
            string textFile = Console.ReadLine();

            string address = (dir1 + @"\" + fileName);

            File.WriteAllText(address , textFile);  // запис в файл

            string fileContent = File.ReadAllText(address);  // читання з файлу

            Console.WriteLine(fileContent);
            
            Console.ReadKey();
            }*/

            //переписати на using(stream) 
            Console.WriteLine("Введiть назву директорії");
            string dir1 = Console.ReadLine();

            if (Directory.Exists(dir1))
            {
                Console.WriteLine("Директорія існує");
            }
            else
            {
                Directory.CreateDirectory(dir1);
            }

            Console.WriteLine("Введiть назву файла");
            string fileName = Console.ReadLine();

            Console.WriteLine("Введiть текст");
            string textFile = Console.ReadLine();
            //----------------------------------//
            string address = (dir1 + @"\" + fileName);

            using (Stream streamchik = new FileStream(address, FileMode.OpenOrCreate)) // створюємо або відкриваємо файл на запис
            {
                using (StreamWriter streamchikWrite = new StreamWriter(streamchik))
                {
                    streamchikWrite.WriteLine(textFile);
                }
            }
               Console.WriteLine(new string('-', 50));
               Console.WriteLine("У файлі записано наступне:");
            using (Stream streamchik = new FileStream(address, FileMode.OpenOrCreate)) // створюємо або відкриваємо файл на читання
            {
                using (StreamReader streamchikRead = new StreamReader(streamchik))
                {
                    Console.WriteLine(streamchikRead.ReadToEnd());
                }
            }

            Console.ReadKey();
        }
    }
}
