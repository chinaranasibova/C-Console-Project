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
                       int selectionProductMethods=0;
                        do
                        {
                            Console.WriteLine("1. Yeni mehsul elave edin");
                            Console.WriteLine("2. Mehsul uzerinde duzelis edin");
                            Console.WriteLine("3. Mehsulu sil");
                            Console.WriteLine("4. Butun mehsullari goster");
                            Console.WriteLine("5. Kateqoriyasina gore butun mehsullari goster");
                            Console.WriteLine("6. Qiymet araligina gore butun mehsullari goster");
                            Console.WriteLine("7. Mehsullar arasinda ada gore axtaris et");


                            string selectionProductMethodsStr = Console.ReadLine();
                            if (!int.TryParse(selectionProductMethodsStr, out selectionProductMethods))
                            {
                                Console.WriteLine("Reqem daxil edin");
                                
                            };

                            switch (selectionProductMethods)
                            {
                                case 1:
                                    DisplayMenuServices.AddProductMenu();
                                    break;
                               

                                case 2:
                                    DisplayMenuServices.EditProductInfoMenu();
                                    break;
                                case 3:
                                    DisplayMenuServices.DeleteProductMenu();
                                    break;
                                case 4:
                                    DisplayMenuServices.DisplayProducts();
                                    break;
                            }



                        }
                        while (selectionProductMethods != 0);

                        break;
                    case 2:
                        
                        break;
                    case 3:

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
