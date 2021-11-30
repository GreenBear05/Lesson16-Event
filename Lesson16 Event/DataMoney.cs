using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class DataMoney {
        public event Action<float> GoOnTransaction;
        public float Money { get; private set; }
        public void Transaction(float price) {
            
            if(price <= Money) { 
                Money = Money - price;
                //если несделать проверку через операто "?" то будет ошибка без подписки 
                GoOnTransaction?.Invoke(Money);
                Console.WriteLine(Money);
            } else { Console.WriteLine("Недостаточно стредсв"); }
        }
        public void TransactionReg(float money) {
            
            GoOnTransaction?.Invoke(Money = money);
        }
    }
}
