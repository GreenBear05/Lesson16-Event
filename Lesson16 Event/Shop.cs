using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class Shop {
        public Shop(string name) {
            Name = name;
        }
        public string Name { get; private set; }

        public List<Product> Products = new List<Product>() {
            new Product ("сахар",100),
            new Product ("Хлеб",50),
            new Product ("Соль",10)
        };
        public void Search(string name) {
            
            var a = Products.Where(products => products.NameProduct.ToLower() ==  name.ToLower());
            foreach(var item in a) {
                Console.WriteLine(item);
            }
        }
        public void infoProducts() {
            foreach(var item in Products) { Console.WriteLine(item); }
        }
        public void Purchase(Person person, Bank bank,string str) {
            // var str = "хлеб";
            var prod = Products.Where(products => products.NameProduct.ToLower() == str.ToLower());
            foreach(var item in prod) {
                if(bank.Transaction(item.Price, person))
                    person.PurchasedProduct.Add(item);
            }
           // bank.Transaction(500,person);
            
            
        }
    }
}
