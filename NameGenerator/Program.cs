using System;

namespace NameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NameOperations nameOperations;

            nameOperations = new NameOperations("names.txt", "surnames.txt");
            
            try
            {
                Console.WriteLine(nameOperations.GetRandomName());
            } catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
