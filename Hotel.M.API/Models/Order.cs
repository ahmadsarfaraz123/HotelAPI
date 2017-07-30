using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.M.API.Models
{
    class Order
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public float Price { get; set; }
        
        public  Food Food { get; set; }
        
        public Category Category{ get; set; }
    }
}
