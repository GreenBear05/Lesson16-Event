using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class Bank {
        
        public Bank(string nameBank) { NameBank = nameBank; IdPerson = 0; dataMoney = new Dictionary<int, DataMoney>(); }
        public string NameBank { get; }
        public int IdPerson { get; private set; }
       
        public Dictionary<int, DataMoney> dataMoney { get; private set; }

        public void RegPerson(Person person) {
            person.AddId(IdPerson++);
            dataMoney.Add(person.Id, new DataMoney());
            dataMoney[person.Id].GoOnTransaction += person.TransactionConfirmation;
            dataMoney[person.Id].Replenishment(person.Money);
            
        }
        public bool Transaction(float price, Person person) => dataMoney[person.Id].Transaction(price);
        public float infoMoney(Person person) => dataMoney[person.Id].Money;


    }
}
