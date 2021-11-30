using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    internal class Shop {
        public Shop(string name) {
            Name = name;
        }
        public string Name { get; private set; }

        public List<Product> products = new List<Product>() {
            new Product ("сахар",100),
            new Product ("Хлеб",50),
            new Product ("Соль",10)
        };
        public Product Search(string name) {
            
            var a = products.Where(products => products.NameProduct.ToLower() ==  name.ToLower());
            foreach(var item in a) {
                Console.WriteLine(item);
            }
            
            return products[0];
        }

    }
}
