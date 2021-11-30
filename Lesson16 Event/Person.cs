using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class Person {

        public event Action<int,float> GoOnTransaction;
        public Person(int id , int money) { Id = id; Money = money; }
        
        List<Product> products = new List<Product>();
        public int Id { get; private set; }
        public string Name { get; set; }
        public float Money { get; private set; }

        public void TransactionConfirmation(float money) {
            Money = money;
        }

    }
}
