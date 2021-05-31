using MarketingSystems.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingSystems.Data.Entities
{
    public class Sales:BaseEntity
    {
        private static int _count = 0;
        public int No { get; set; }
        public int PriceAmount { get; set; }
        public Salesİtems Salesİtem { get; set; }
        public DateTime SaleDate{ get; set; }
       

        public Sales()
        {
            _count++;

            No = _count;
        }
    }
   

}
