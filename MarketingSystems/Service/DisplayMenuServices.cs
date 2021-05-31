using ConsoleTables;
using MarketingSystems.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingSystems.Service
{

    public class DisplayMenuServices
    {
        static MarketingServices marketingServices = new MarketingServices();
        #region MyRegion
        public static void DisplayProducts()
        {
            var table = new ConsoleTable("Code", "Name", "categories", "Price");

            foreach (var product in marketingServices.Product)
            {
                table.AddRow(product.Code, product.Name, product.categories,product.Price.ToString("#.00"));
            }

            table.Write();
            Console.WriteLine();
        }


        #endregion

        #region MyRegion
        public static void DisplaySales()
        {
            var table = new ConsoleTable("No", "PriceAmount", " Salesİtem", "DateTime");

            foreach (var sales in marketingServices.Sales)
            {
                table.AddRow(sales.No, sales.PriceAmount, sales.Salesİtem, sales.SaleDate);
            }

            table.Write();
            Console.WriteLine();
        }

        #endregion
        #region MyRegion
        public static void AddProductMenu()
        {
            Console.WriteLine("Mehsulun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Mehsulun qiymetini daxil edin");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Kateqoriya daxil edin");
            Categories category = Enum.Parse<Categories>(Console.ReadLine());
            Console.WriteLine("Mehsulun sayini daxil edin");
            int count = int.Parse(Console.ReadLine());
            marketingServices.AddProduct(name, price, category, count);



            #endregion

        }
        public static void EditProductInfoMenu()
        {
            Console.WriteLine("Mehsulun  kodunu daxil edin");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Qiymeti daxil edin");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Kategoriya daxil edin");
            Categories category = Enum.Parse<Categories>(Console.ReadLine());
            Console.WriteLine("Mehsulun sayini daxil edin");
            int count = int.Parse(Console.ReadLine());
            marketingServices.EditProductInfo(code,name,price,category,count);
        }
        public static void DeleteProductMenu()
        {
            Console.WriteLine("Mehsulun kodunu daxil edin");
            int code = int.Parse(Console.ReadLine());
            marketingServices.DeleteProduct(code);

        }
        public static void DisplayProductsByRangeOfPriceMenu()
        {
            if (MarketingServices.())
            {
                bool result;
                double minPrice;
                double maxPrice;

                do
                {
                    do
                    {
                        Console.WriteLine("================================================================");
                        Console.WriteLine("  Mehsulun minimum qiymetini daxil edin: ");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.Write(" "); result = double.TryParse(Console.ReadLine(), out minPrice);


                        if (!result)
                        {
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine("  Mehsulun minimum qiymeti herf ve ya bosluq ola bilmez!");
                        }
                        else if (minPrice < 0)
                        {
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine("  Mehsulun minimum qiymeti menfi eded ola bilmez!");
                        }

                    } while (!result || minPrice < 0);


                    do
                    {
                        Console.WriteLine("================================================================");
                        Console.WriteLine("  Mehsulun maksimum qiymetini daxil edin: ");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.Write(" "); double.TryParse(Console.ReadLine(), out maxPrice);

                        if (maxPrice <= 0)
                        {
                            Console.WriteLine("----------------------------------------------------------------");
                            Console.WriteLine("  Mehsulun maksimum qiymeti herf, 0 ve ya menfi eded ola bilmez!");
                        }

                    } while (maxPrice <= 0);

                    if (minPrice > maxPrice)
                    {
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("  Minimum qiymet maksimumdan boyuk ola bilmez!");
                    }

                } while (minPrice > maxPrice);

             
            }
            else
            {
               
                Console.WriteLine("  Anbarda mehsul yoxdur!");
            }
        }
    }

    }
    
