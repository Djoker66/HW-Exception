using System;

namespace HW_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[4];

            notebooks[0] = new Notebook("Macbook Pro 15", 3500);
            notebooks[1] = new Notebook("Lenovo", 2500);
            notebooks[2] = new Notebook("HP Air", 1500);
            notebooks[3] = new Notebook("Asus ROG", 3200);

            string opt;

            do
            {
                Console.WriteLine("2. Yeni notebook yarat");
                Console.WriteLine("1. Notebooklar uzerinde axtaris");
                Console.WriteLine("0. Menudan cix");

                opt = Console.ReadLine();

                if (opt == "1")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin:");
                    string search = Console.ReadLine();

                    var filteredArr = SearchByName(notebooks, search);

                    ShowNotebooksInfo(filteredArr);
                }

                else if (opt == "2")

                {
                    bool hasProblem = false;

                    do
                    {

                        try
                        {
                            for (int i = 0; i < 1; i++)
                            {
                                Console.WriteLine("Yeni notebook yarat");
                                Console.WriteLine("Name daxil edin");
                                string name = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    throw new NameFormatException("Name null ve ya bow ola bilmez!");
                                }

                                Console.WriteLine("Price daxil edin");
                                string pricestr = Console.ReadLine();
                                double price = Convert.ToDouble(pricestr);

                                if (price <=0)
                                {
                                    throw new PriceFormatException("Price 0 dan az ola bilmez");
                                }

                                Console.WriteLine("Ram daxil edin");
                                string ramstr = Console.ReadLine();
                                byte ram = Convert.ToByte(ramstr);

                                if (ram < 2 && ram > 128)
                                {
                                    throw new RamFormatException("Ram 2 den az ola bilmez ve 128 den boyuk ola bilmez");
                                }

                                notebooks[i] = new Notebook(name, price, ram);

                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Bilinmedik bir xeta bas verdi :(");
                            Console.WriteLine("Xeta: " + e.Message);
                            Console.WriteLine("Yeniden daxil edin!");
                            hasProblem = true;
                        }

                        Console.WriteLine("All notebooks:");
                        for (int i = 0; i < notebooks.Length; i++)
                        {
                            Console.WriteLine(notebooks[i].GetInfo());
                        }

                    } while(hasProblem);

                }

            } while (opt != "0");

            { Console.WriteLine("Menudan cixdiq"); };
        }

        static Notebook[] SearchByName(Notebook[] arr, string search)
        {
            Notebook[] newArr = new Notebook[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;

        }

        static void ShowNotebooksInfo(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetInfo());
            }
        }

    }
}

