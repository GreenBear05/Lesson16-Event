﻿using System;
using System.Collections.Generic;

namespace Lesson16_Event {
    internal class Program {
        static void Main(string[] args) {
            var shop = new Shop("sportmaster");
            var bank = new Bank("sberbank");
            string a = "Хлеб";
            var pr = shop.Search(a);
            
            int id = 1;
            int id2 = 2;
            var listperson = new List<Person> {
                new Person(id, 5000) { Name = "Sergay" },
                new Person(id2, 9000) { Name = "Irna" }
            };

            bank.RegPerson(listperson[0]);
            bank.RegPerson(listperson[1]);

            bank.Transaction(5000, listperson[0]);
            bank.Transaction(5000, listperson[1]);
            //listperson[1].Transaction(500, bank);
             
            Console.WriteLine(listperson[0].Money);
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