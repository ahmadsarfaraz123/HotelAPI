using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.M.API.Models
{
    class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Food> foods { get; set; }
    }
}
