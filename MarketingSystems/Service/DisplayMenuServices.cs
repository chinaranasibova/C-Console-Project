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
        static MarketingServices marketingServices = new();
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
                table.AddRow(sales.No, sales.PriceAmount, sales.Salesİtem, sales.DateTime);
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
    }
    }
