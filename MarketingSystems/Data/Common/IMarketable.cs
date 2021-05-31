using MarketingSystems.Data.Entities;
using MarketingSystems.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketingSystems.Service
{
    interface IMarketable
    {
        public List<Sales> Sales { get; }
        public List< Product> Product { get;}
        public void AddSales(Salesİtems salesİtem);
        public void ReturnProductFromSale(int No, int CodeProduct ,int count);
        public void ReturnSale();

        public void DeleteSales(int no);

        public List<Sales> SaleSearchWithDate(DateTime date);
        public void SearchSaleWitHDateRange();
       
        public List<Product> SearchSaleWithPriceRange();
        public Sales SearcSaleWithNo(int no);



        public int AddProduct(string name, double price, Categories category, int count);
        public void EditProductInfo(int code, string name, double price, Categories category, int count);
        public List<Product> SearchProductWithCategoria(Categories category);
        public List<Product> DisplayProductsByRangeOfPrice(double minPrice, double maxPrice);
        public void SearcProductWithName(string name);
        public void DeleteProduct(int code);
        

























        public void SearchSaleWithNo();
       
    }
}
