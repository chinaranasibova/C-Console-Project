using MarketingSystems.Data.Entities;
using MarketingSystems.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingSystems.Service
{
    public class MarketingServices : IMarketable
    {
        public List<Sales> Sales { get; set ; }
        public List<Product> Product { get; set ; }

        public MarketingServices()
        {
            Sales = new();
            Product = new();
        }
        public int AddProduct(string name, double price, Categories category, int count)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");

            if (price <= 0)
                throw new ArgumentNullException("price");

            if (count <= 0)
                throw new ArgumentOutOfRangeException("count");

            Product product = new();
            product.Name = name;
            product.Price = price;
            product.Count = count;
            product.categories = category;
            Product.Add(product);

            return product.Code;

        }

        public void AddSales(Salesİtem salesİtem)
        {
          
        }

        public void DeleteProduct(int code)
        {
            int index = Product.FindIndex(d => d.Code == code);

            if (index == -1)
                throw new KeyNotFoundException();

            Product.RemoveAt(index);
        }

        public void DeleteSales(int no)
        {
            int index = Sales.FindIndex(d => d.No == no);

            if (index == -1)
                throw new KeyNotFoundException();

            Sales.RemoveAt(index);

        }

       
        public void EditProductInfo(int code, string name, double price, Categories category, int count)
        {
           
        }

        public void ReturnProductFromSale()
        {
           
        }

        public void ReturnSale()
        {
          
        }

        public void SaleSearchWithDate()
        {
           
        }

        public void SearchProductWithCategoria(Categories category)
        {
            
        }

        public void SearchProductWithPriceRange(double StartPrice, double EndPrice)
        {
          
        }

        public void SearchSaleWitHDateRange()
        {
            throw new NotImplementedException();
        }

        public void SearchSaleWithNo()
        {
        }

        public void SearchSaleWithPriceRange()
        {
           
        }

        public void SearcProductWithName(string name)
        {
            throw new NotImplementedException();
        }

        public void SearcSaleWithNo()
        {
            
        }

        public void SearcSaleWithNo(int no)
        {
           
        }

   
    }
}
