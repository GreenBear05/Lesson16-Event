using System;
using System.Collections.Generic;

namespace Lesson16_Event {
    public class Program {
        static void Main(string[] args) {
            var shop = new Shop("sportmaster");
            var bank = new Bank("sberbank");
            // создание персонажей 
            var listperson = new List<Person> {
                new Person() { Name = "Sergay"},
                new Person() { Name = "Irna" }
            };
            Console.WriteLine("Регистрация персонажа Банк");
            bank.RegPerson(listperson[0]);
            bank.RegPerson(listperson[1]);
            Console.WriteLine("Деньги персонажа " + listperson[1].Money);
            Console.WriteLine("Введите предмет из списка предмет");
            shop.infoProducts();
            var str = Console.ReadLine();
            shop.Purchase(listperson[1], bank, str);
            Console.WriteLine("Предметы персонажа");
            foreach(var item in listperson[1].PurchasedProduct) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        #region MyRegion


        //Console.WriteLine(bank.Money);

        //    Person person = new Person();

        //    Person.GoToSleep+=Person_GoToSleep;
        //    // Person.GoToSleep += testDel.Gohp;
        //    t.Subscription();
        //    person.TakeTime(DateTime.Parse("13.11.2021 22:45:56"));
        //    person.TakeTime(DateTime.Parse("13.11.2021 4:45:56"));

        //}

        //private static void Person_GoToSleep() {
        //    Console.WriteLine("ЧЕЛОВЕК ПОШЕЛ СПАТЬ.");
        //    Console.ReadKey();
        //}



        //public class Person {
        //    public Person
        //    //public static event Action GoToSleep; // исполнительная часть может быть только в классе в котором обявлен собитие
        //    //public void TakeTime(DateTime now) {
        //    //    if (now.Hour <= 8) {
        //    //        GoToSleep?.Invoke();
        //    //    }
        //    //}
        //    ////public static GoToSleeppod(int hp) => GoToSleep += hp;
        //}
        // public class Bank {
        //    //public static void Gohp()
        //    //{
        //    //    int hp = 1;
        //    //    Console.WriteLine(hp - 1 + " hp");


        //    //}
        //    //public void Subscription()
        //    //{
        //    //    Gohp();
        //    //    Person.GoToSleep += Gohp;
        //    //}
        //}
        //public class Tax{
        #endregion
    }
}
