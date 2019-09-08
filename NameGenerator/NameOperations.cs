using System;
using System.Collections.Generic;
using System.IO;

namespace NameGenerator
{
    class NameOperations
    {
        private List<string> names, surnames;

        public NameOperations(string namesFileName, string surnamesFileName)
        {
            StreamReader namesFile, surnamesFile;
            string line;

            names = new List<string>();
            surnames = new List<string>();
            try
            {
                namesFile = new StreamReader(namesFileName);
                surnamesFile = new StreamReader(surnamesFileName);

                while ((line = namesFile.ReadLine()) != null)
                {
                    names.Add(line);
                }

                while ((line = surnamesFile.ReadLine()) != null)
                {
                    surnames.Add(line);
                }

                namesFile.Close();
                surnamesFile.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("At least one of file not found!");
            }
        }

        public List<string> GetNames()
        {
            return names;
        }

        public List<string> GetSurnames()
        {
            return surnames;
        }

        public string GetRandomName()
        {
            String name, surname;
            Random random;

            if ((names.Count > 0) && (surnames.Count > 0))
            {
                random = new Random();
                name = names[random.Next(names.Count)];
                surname = surnames[random.Next(surnames.Count)];

                if (name.EndsWith("a") && surname.EndsWith("i"))
                {
                    surname = surname.Replace(surname, surname.Substring(0, surname.Length - 1) + "a");
                }

                return name + " " + surname;
            }
            else
            {
                throw FormatException("List of names and surnames cannot be empty!");
            }


        }

        private Exception FormatException(string v)
        {
            throw new FormatException(v);
        }
    }
}
