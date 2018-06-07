using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewTagHelper.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Department { get; set; }

        public Product(int id, string name, decimal price, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Department = department;
        }

    }
}
