using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
        
        static void Main(string[] args)
        {

            Method1();
            Console.WriteLine();
            Console.WriteLine();
            Method1_obj();
            Console.WriteLine();
            Console.WriteLine();
            Method2();
            Console.WriteLine();
            Console.WriteLine();
            Method2_obj();
            Console.WriteLine();
            Console.WriteLine();
            Method3();
            Console.WriteLine();
            Console.WriteLine();
            Method3_obj();
            Console.WriteLine();
            Console.WriteLine();
            Method4();
            Console.WriteLine();
            Console.WriteLine();
            Method4_obj();
            Console.WriteLine();
            Console.WriteLine();
            Method5();
            Console.WriteLine();
            Console.WriteLine();
            Method5_obj();
        }



        private static List<Person> GetPerson()
        {
           return new List<Person> 
            {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv" },
            new Person(){ Name = "Liza",   Age = 18, City = "Moscow" },
            new Person(){ Name = "Oleg",   Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Kyiv" }
            };
        }


        //1-Выбрать людей, старших 25 лет.запросы.
        public static void Method1()
        {
            List<Person> person = GetPerson();
            var older = from pers in person where (pers.Age > 25) select pers;
            foreach(var old in older)
            {
                Console.WriteLine($"{old.Name},{old.City},{old.Age}");
            }
        }

        //1-Выбрать людей, старших 25 лет.обьекты.
        public static void Method1_obj()
        {
            List<Person> person = GetPerson();
            var result = person.Where(r => r.Age > 25);
            foreach(var item in result)
            {
                Console.WriteLine(item.Name+","+item.City+","+item.Age);
            }
            
        }


        //2-Выбрать людей, проживающих не в Киеве.запросы.
        public static void Method2()
        {
            List<Person> person = GetPerson();
            var older = from pers in person where (pers.City!="Kyiv") select pers;
            foreach (var old in older)
            {
                Console.WriteLine($"{old.Name},{old.City},{old.Age}");
            }
        }

        //2-Выбрать людей, проживающих не в Киеве.обьекты.
        public static void Method2_obj()
        {
            List<Person> person = GetPerson();
            var result = person.Where(r => r.City != "Kyiv");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "," + item.City + "," + item.Age);
            }
        }

        //3-Выбрать имена людей, проживающих в Киеве.запросы.
        public static void Method3()
        {
            List<Person> person = GetPerson();
            var older = from pers in person where (pers.City == "Kyiv") select pers;
            foreach (var old in older)
            {
                Console.WriteLine($"{old.Name},{old.City},{old.Age}");
            }
        }

        //3-Выбрать имена людей, проживающих в Киеве.обьекты.
        public static void Method3_obj()
        {
            List<Person> person = GetPerson();
            var result = person.Where(r => r.City == "Kyiv");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "," + item.City + "," + item.Age);
            }
        }

        //4-Выбрать людей старших 35 лет с именем Sergey.запросы.
        private static void Method4()
        {
            List<Person> person = GetPerson();
            var older = from pers in person where (pers.Age > 35&&pers.Name=="Sergey") select pers;
            foreach (var old in older)
            {
                Console.WriteLine($"{old.Name},{old.City},{old.Age}");
            }
        }
        //4-Выбрать людей старших 35 лет с именем Sergey.обьекты.
        private static void Method4_obj()
        {
            List<Person> person = GetPerson();
            var result = person.Where(r => r.Age >35 && r.Name=="Sergey");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "," + item.City + "," + item.Age);
            }
        }

        //5-Выбрать людей, проживающих в Москве.запросы.
        private static void Method5()
        {
            List<Person> person = GetPerson();
            var older = from pers in person where (pers.City=="Moscow") select pers;
            foreach (var old in older)
            {
                Console.WriteLine($"{old.Name},{old.City},{old.Age}");
            }
        }

        //5-Выбрать людей, проживающих в Москве.обьекты.
        private static void Method5_obj()
        {
            List<Person> person = GetPerson();
            var result = person.Where(r => r.City=="Moscow");
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "," + item.City + "," + item.Age);
            }
        }


    }
}
