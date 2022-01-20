using System;

namespace SololearnClassAndObjects
{
    internal class Program
    {
        class Dog
        {
            public string name;
            public int age;
            public string breed;
            public string color;
            public Dog() //Example using the special member of a class called Constructor
            {
                Console.WriteLine($"\nBark! Bark!!");
            }

            public Dog(string nickName)
            {
                name = nickName;
            }
            public string GetName()
            {
                return name;
            }

            public string NewDogName { get; set; }

            private int queensAge = 5;
            public int QueensAge //Using an if statement with the set accessor to check if dog named Queen is older than 3 years old
            {
                get { return queensAge; }
                set
                {
                    if (queensAge > 3)
                    {
                        queensAge = value;
                    }
                }
            }

        }

        class BankAccount
        {
            private double balance = 0;
            public void Deposit(double n)
            {
                balance += n;
            }
            public void Withdraw(double n)
            {
                balance -= n;
            }
            public double GetBalance()
            {
                return balance;
                Console.WriteLine(balance);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"\nHello world, meet my dog. Here are some fun facts about him:");

            Dog king = new Dog();

            king.name = "King";
            king.age = 3;
            king.breed = "American Akita";
            king.color = "black, white and brown spotting layered";

            Console.WriteLine($"\nHis name is {king.name}!");
            Console.WriteLine($"\nHe is {king.age} years old...");
            Console.WriteLine($"\nHe's an {king.breed}");
            Console.WriteLine($"\nAnd he has a mixture of {king.color} fur, which makes him very adorable :-)...");

            Dog g = new Dog(); //Example creating and calling a new instance or object of type Dog using the Constructor member of a class

            Dog q = new Dog($"\nG.O.A.T");
            Console.WriteLine(q.GetName());

            Dog p = new Dog();
            p.name = "Queen";
            Console.WriteLine($"\nKing's lady dog friend's name is, {p.name} :-D!");


        }

       
    }

}