using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class Bank {
        
        public Bank(string nameBank) { NameBank = nameBank; dataMoney = new Dictionary<int, DataMoney>(); }
        public string NameBank { get; }
        public int IdPerson { get; }
       
        public Dictionary<int, DataMoney> dataMoney { get; private set; }
        
       
        public void RegPerson(Person person) {
           
            dataMoney.Add(person.Id, new DataMoney());
            dataMoney[person.Id].GoOnTransaction += person.TransactionConfirmation;
            dataMoney[person.Id].TransactionReg(person.Money);
            

        }
        public void Transaction(float price, Person person) {
            dataMoney[person.Id].Transaction(price);

        }
    }
}
