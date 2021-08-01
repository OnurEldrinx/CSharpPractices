using System;
using System.Collections;
using System.Collections.Generic;


namespace Generic_Collections_List
{
    class Program
    {

        public static void PrintArray<T>(T[] list){

            foreach (var x in list)
            {
                
                Console.WriteLine(x);

            }



        }

        static void Main(string[] args)
        {
            // List<T>
            // using System.Collections.Generic

            List<int> numbers = new List<int>{0,1,2,3,4,5,6,7,8,9};
            
            List<string> colors = new List<string>();
            colors.Add("RED");
            colors.Add("YELLOW");

            int[] numbersArray = {0,1,2,3,4,5,6,7,8,9};
            string[] colorsArray = {"Red","Yellow","Blue"};
            PrintArray<int>(numbersArray);
            PrintArray<string>(colorsArray);

            //Count
            Console.WriteLine("Size of 'numbers' list : "+numbers.Count); // number of elements
            
            numbers.ForEach(n => Console.Write(n + " ")); // easy foreach usage

            Console.WriteLine();

            //Remove
            numbers.Remove(5);
            colors.RemoveAt(0);
            numbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
            colors.ForEach(c => Console.Write(c + " "));

            //Contains
            Console.WriteLine(numbers.Contains(1));
            Console.WriteLine(colors.Contains("BLUE"));

            //IndexOf
            Console.WriteLine(numbers.IndexOf(7));

            //Array to List
            string[] animals = {"Bird","Cat","Dog"};

            List<string> animalList = new List<string>(animals);

            //Clear
            animalList.Clear(); //Removes all elements

            //Store objects in a list

            User a = new User("Onur","Öztop",23);
            User b = new User("David","Mule",32);
            User c = new User("Cindy","Blake",26);

            List<User> users = new List<User>();
            users.Add(a);
            users.Add(b);
            users.Add(c);

        
            
            foreach (var user in users)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Name\t: "+user.Name);
                Console.WriteLine("Surname\t: "+user.Surname);
                Console.WriteLine("Age\t: "+user.Age);
                Console.WriteLine("-----------------------");
            }

        }
    }

    class User{

        private string name;
        private string surname;
        private int age;

        public User(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
