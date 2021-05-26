using System;
using MarketingSystems.Service;

namespace MarketingSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection =0;

            do {
                f1:
                Console.WriteLine("1.  Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2.  Satislar uzerinde emeliyyat aparmaq");
                Console.WriteLine("0.  Sistemden cixmaq");

                Console.WriteLine("Zehmet olmasa yuxaridaki emeliyyatlardan birini secin");

                string selectionStr = Console.ReadLine();
                if (!int.TryParse(selectionStr, out selection))
                {
                    Console.WriteLine("Reqem daxil edin");
                    goto f1;
                };

                switch (selection)
                {
                    case 1:
                        DisplayMenuServices.AddProductMenu();
                        break;
                    case 2:
                        DisplayMenuServices.DisplayProducts();
                        break;
                            ;
                    default:
                        break;
                }





            }
            while (selection != 0) ;
        }
    }
}
