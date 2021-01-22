using System;

namespace HelloApp
{
    class Person
    {
        public string name;
        public int age;

        public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор

        public Person(string n) { name = n; age = 18; }         // 2 конструктор

        public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

        public void GetInfo()                                                         
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom;

            Console.ReadKey();
        }
    }
}

