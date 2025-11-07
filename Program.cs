using System.Globalization;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("--- Avtomobil Satıs ve İcare Proqrami ---");
                Console.WriteLine("1. Masin Satisi");
                Console.WriteLine("2. Masin İcaresi");
                Console.WriteLine("3. Bank");
                Console.WriteLine("0. Cıxıs");
                Console.Write("Seciminizi daxil edin: ");


                Console.WriteLine("Secim: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //CarSaleMenu();
                        break;
                    case "2":
                       // CarRentMenu();
                        break;
                    case "3":
                        //BankMenu();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Yanlis secim. Dogru secim edin(0-3)");
                        break;
                }
            }
        }
        static void SaleACar()
        {

            while (true)
            {
                Console.WriteLine("1. Masin elave et");
                Console.WriteLine("2. Masinlara bax");
                Console.WriteLine("3. Masini sil");
                Console.WriteLine("4. Masinlari filtrle");
                Console.WriteLine("5. Masinlari cesidle");
                Console.WriteLine("6. Masin sat");
                Console.WriteLine("0. Esas menyuya qayit");

                string choice = Console.ReadLine();



                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Masin elave edin: ");

                        CarManage.AddCar();
                        break;
                    case "2":
                        Console.WriteLine("Masinlarin siyahisi: ");
                        CarManage.GetAll();
                        break;
                    case "3":
                        Console.WriteLine("Silinecek Masinin id-si yaz: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        CarManage.Delete(id);
                        break;
                    case "4":
                        Console.WriteLine("Il daxil edin: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        CarManage.Filter(year);
                        break;
                    case "5":
                        Console.WriteLine("Qiymete gore artan cesidler.");
                        CarManage.OrderByCost();
                        break;
                    case "6":
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Dogru secim et(1-6)");
                        break;
                }
            }


        }


    }
}
