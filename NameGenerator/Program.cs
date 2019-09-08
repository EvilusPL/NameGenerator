using System;
using System.IO;

namespace NameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NameOperations nameOperations;
            
            try
            {
                nameOperations = new NameOperations("names.txt", "surnames.txt");
                Console.WriteLine(nameOperations.GetRandomName());
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
