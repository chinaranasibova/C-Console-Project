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
        public List<Sales> Sales { get; set; }
        public List< Product> Product { get; set; }
        public void AddSales(Salesİtem salesİtem);
        public void ReturnProductFromSale();
        public void ReturnSale();

        public void DeleteSales(int no);

        public void SaleSearchWithDate();
        public void SearchSaleWitHDateRange();
       
        public void SearchSaleWithPriceRange();
        public void SearcSaleWithNo(int no);



        public int AddProduct(string name, double price, Categories category, int count);
        public void EditProductInfo(int code, string name, double price, Categories category, int count);
        public void SearchProductWithCategoria(Categories category);
        public void SearchProductWithPriceRange(Double StartPrice, double EndPrice);
        public void SearcProductWithName(string name);
        public void DeleteProduct(int code);
        

























        public void SearchSaleWithNo();
       
    }
}
