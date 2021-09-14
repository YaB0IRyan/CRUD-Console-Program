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

            string path = @"D:\data.txt"; //setting the path for the data file
            List<string> lines = File.ReadAllLines(path).ToList();//File.ReadAllLines(path) will return an array, with each index containing a line from the file, we are converting this to a list to make it easier to add items to the list

            foreach (string x in lines) 
            {
                Console.WriteLine(x);
            }

            lines.Add("004,Scott,Owen,OwenScott@hotmail.org");//Adding an item to the list.

            File.WriteAllLines(path, lines);//will write the contents of the lines list to the file

        }
    }
}
