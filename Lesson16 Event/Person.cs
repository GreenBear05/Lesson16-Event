using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class Person {

        
        public Person() { }
        
        public List<Product> PurchasedProduct = new List<Product>();
        public Bank bank;
        public int Id { get; private set; }
        public string Name { get; set; }
        public float Money { get; private set; }

        public void TransactionConfirmation(float money) => Money = money;
        public void AddId(int id) => Id = id;

    }
}
