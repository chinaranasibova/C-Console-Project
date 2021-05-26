using MarketingSystems.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingSystems.Data.Entities
{
    public class Product
    {
      static int  _code=0;
        public string Name { get; set; } 
        public double Price { get; set; }
        public int  Count { get; set; }
        public int Code { get; set; }
        public  Categories categories { get; set; }
        public Product()
        {
            this.Code = ++_code;
        }

    }
}
