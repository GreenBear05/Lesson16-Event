using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Event {
    public class DataMoney {
        public event Action<float> GoOnTransaction;
        public float Money { get; private set; }
        public bool Transaction(float price) {
            
            if(price <= Money) { 
                Money = Money - price;
                //если несделать проверку через операто "?" то будет ошибка без подписки 
                GoOnTransaction?.Invoke(Money);
                Console.WriteLine(Money);
                return true;
            } else { Console.WriteLine("Недостаточно стредсв"); return false; }
        }

        float Basemoney = 5000;
        public void Replenishment() => GoOnTransaction?.Invoke(Money = 5000);
        
       
    }
}
