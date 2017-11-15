using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Домашка3: 
+1. Створити базовий абстрактний клас. Мінімум 2 властивості 
2. Створити два дочірніх класи. Мінімум 3 властивості і всі різних типів
3. Створити масив (кількість єлементів вказує користувач)
4. Дати користувачеві заповнити масив. Користувач має сам обрати який саме клас (з двох дочірніх) він зараз хоче створити. 
5. Користувач у будь-який момент заповнення масива може переглянути уже заповнені елементи
*/

namespace HomeTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Чим поїдемо таксі чи трамваєм? 1 - Taxi; 2- Tram");
            string userNumberStr = Console.ReadLine();
            int userNumber = Convert.ToInt32(userNumberStr);

            Console.WriteLine("Ви обрали ");
            if (userNumber == 1)
                Console.WriteLine("- Taxi");
            else
            {
                if (userNumber == 2)
                    Console.WriteLine("- Tram");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your entered value is vrong!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

            Console.WriteLine("Скільки одиниць транспорту викликати?");
            string amountStr = Console.ReadLine();
            int amountNumber = Convert.ToInt32(amountStr);


            if (userNumber == 1)
            {
                Taxi tax = new Taxi(); 
                tax.Name = "Lastochka";      

                Taxi someAnotherTaxi = new Taxi(); 
                tax.Clone(tax, someAnotherTaxi);       
               // Console.WriteLine(someAnotherTaxi.Name);

                Taxi[] taxis = new Taxi[amountNumber];
                for (int i = 0; i < taxis.Length; i++ )
                {
                    taxis[i] = new Taxi();
                    tax.Name = "Lastochka" + (i+1);
                    tax.Clone(tax, taxis[i]);
                }


                Console.WriteLine($"За вами виїхали машини таксі у кількості {amountNumber} штук");
                foreach (Taxi taxi in taxis)
                {
                          Console.WriteLine(taxi.Name);
                }
            }
            else
            {
                Tram trami = new Tram();
                trami.Name = "Cucarachas_tram";

                Tram someAnotherTram = new Tram();
                trami.Clone(trami, someAnotherTram);
              //  Console.WriteLine(someAnotherTram.Name);

                Tram[] trams = new Tram[amountNumber];
                for (int i = 0; i < trams.Length; i++)
                {
                    trams[i] = new Tram();
                    trami.Name = "Cucarachas_tram" + (i+1);
                    trami.Clone(trami, trams[i]);
                }


                Console.WriteLine($"У місто виїхали трамваї у кількості {amountNumber} штук");
                foreach (Tram tram in trams)
                {
                    Console.WriteLine(tram.Name);
                }
            }

            Console.ReadKey();
        }

    }
    
}
