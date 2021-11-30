using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    internal class Product {
        public Product(string name, float  price) {
            NameProduct = name;
            Price = price;
        }
        public string NameProduct { get; private set; }
        public float Price { get; private set; }
        public override string ToString() {
            return $"{NameProduct} {Price}";
        }
    }
}
