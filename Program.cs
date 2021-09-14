using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CRUD_Console_Program 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the CRUD console program :)\n");
            Console.WriteLine("ID - Forename Surname - (Email)");
            Console.WriteLine("----------------------------------------------------------\n");


            string path = @"D:\data.txt"; //setting the path for the data file

            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(path).ToList();//File.ReadAllLines(path)

            foreach (var x in lines) //For every line we do the following:
            {
                
                string[] entries = x.Split(','); //Split the line into an array by comma (ryan, scott bevcomes [0] = ryan and [1] = scott).
                Person newPerson = new Person(); //creating a new person

                if (entries.Length == 4)
                {
                    newPerson.PersonID = Int32.Parse(entries[0]); //populating the object (instance of the Person class) 
                    newPerson.Surname = entries[1];
                    newPerson.Forename = entries[2];
                    newPerson.Email = entries[3];

                    people.Add(newPerson); //Adding the object to our list.
                }
                else
                {
                    Console.WriteLine("ERROR reading line: " + x + " in the doccument");
                }
            }

            foreach (var x in people) 
            {
                Console.WriteLine($"{x.PersonID} - {x.Forename} {x.Surname} - ({x.Email})"); //Because we are using the $ before our "", we can use {} to escape from the string and include code
            }

            Console.ReadLine();

        }
    }
}
