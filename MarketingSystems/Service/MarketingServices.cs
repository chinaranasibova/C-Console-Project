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

        public MarketingServices()
        {
            _sales = new List<Sales>();
            _products = new List<Product>();

        }

        private List<Sales> _sales;
        public List<Sales> Sales => _sales;

        private List<Product> _products;
        public List<Product> Products => _products;

        List<Sales> IMarketable.Sales => throw new NotImplementedException();

        List<Product> IMarketable.Product => throw new NotImplementedException();

        public List<Product> Product =new List<Product>();

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

        public void AddSales()
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

            if (no <= 0)
            {
                throw new ArgumentOutOfRangeException("no");
            }
            int index = _sales.FindIndex(d => d.No == no);

            if (index == -1)
                throw new KeyNotFoundException();

            Sales.RemoveAt(index);

        }

       
        public void EditProductInfo(int code, string name, double price, Categories category, int count)
        {

            try
            {
                Product product = Product.Find(s => s.Code == code);
                product.Name = name;
                product.categories = category;
                product.Price = price;
                product.Count = count;
            }
            catch (Exception e)
            {

                Console.WriteLine("Bele bir mehsul yoxdur");
                Console.WriteLine(e.Message);
            } 
             


            
        }

        public void ReturnProductFromSale(int no, int CodeProduct, int count)
        {

            if (no <= 0)
            {
                throw new ArgumentOutOfRangeException("no");
            }
            if (CodeProduct <= 0)
            {
                throw new ArgumentOutOfRangeException("no");
            }
            if (count<= 0)
            {
                throw new ArgumentOutOfRangeException("no");

            }

          







        }

        public void ReturnSale()
        {
          
        }

        public List<Sales> SaleSearchWithDate(DateTime date)
        {
            List<Sales> sales = _sales.FindAll(s => s.SaleDate.ToString("dd-MM-yyyy") == date.ToString("dd-MM-yyyy"));

            if (sales.Count == 0)
                throw new ArgumentNullException();

            return sales;
        }

        public List<Product> SearchProductWithCategoria(Categories category)
        {
            List<Product> products = _products.FindAll(p => p.categories == category);

            return products;

        }

        
            public List<Product> DisplayProductsByRangeOfPrice(double minPrice, double maxPrice)
            {
                if (minPrice <= 0)
                {
                    throw new ArgumentOutOfRangeException("minPrice");
                }

                if (maxPrice <= 0)
                {
                    throw new ArgumentOutOfRangeException("maxPrice");
                }

                List<Product> products = _products.FindAll(p => p.Price >= minPrice && p.Price <= maxPrice);

                return products;
            
        }

        public void SearchSaleWitHDateRange()
        {
            throw new NotImplementedException();
        }

        public void SearchSaleWithNo()
        {
        }

      

        public void SearcProductWithName(string name)
        {
            throw new NotImplementedException();
        }

       

        public Sales SearcSaleWithNo(int no)
        {
            if (no <= 0)
                throw new ArgumentOutOfRangeException("saleNo");

            int indexSale = _sales.FindIndex(s => s.No == no);

            if (indexSale == -1)
                throw new KeyNotFoundException();

            return _sales[indexSale];
        }

        public void AddSales(Salesİtems salesİtem)
        {
            throw new NotImplementedException();
        }

        List<Product> IMarketable.SearchSaleWithPriceRange()
        {
            throw new NotImplementedException();
        }

        public bool HasProductInDepot()
        {
            if (_products.Count > 0)
                return true;
            return false;
        }

        public bool HasSaleInDepot()
        {
            if (_sales.Count > 0)
                return true;
            return false;
        }

    }
}
