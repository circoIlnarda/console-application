using System;
using System.IO;

namespace es9_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert file address");
            //string address = Console.ReadLine();
            //string fileText = ReadFile(address);

            //if (fileText == null)
            //{
            //    return;
            //}

            //Console.WriteLine("Save a New file or Rewrite it?");
            //Console.WriteLine("Select N for a new file or R to Rewrite it");
            //string newSelect = Console.ReadLine();

            //Console.WriteLine("give me the word to find...");
            //string wordToFind = Console.ReadLine();
            //Console.WriteLine("give me the word to replace");
            //string wordToReplace = Console.ReadLine();

            //string modText = Replace(fileText, wordToFind, wordToReplace);
            //WriteFile(modText, address, newSelect);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            string indirizzo = args[0];

            string parolaDaCercare = args[1];

            string parolaDaSostituire = args[2];

            string sceltaNuovo = args[3];


            string testoFile = ReadFile(indirizzo);

            string testoModificato = Replace(testoFile, parolaDaCercare, parolaDaSostituire);

            WriteFile(testoModificato, indirizzo, sceltaNuovo);
        }

        public static string Replace(string Text, string wordToFind, string wordToReplace)
        {
            string modText = Text.Replace(wordToFind, wordToReplace);
            return modText;
        }
        public static string ReadFile(string address)
        {
            if (File.Exists(address))
            {
                try
                {
                    string fileText = File.ReadAllText(address);
                    return fileText;
                }
                catch (Exception)
                {
                    Console.WriteLine("File not avaiable");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("file not exist");
                return null;
            }
        }
        public static void WriteFile(string textToSave, string address, string newSelect)
        {
            if (newSelect.Equals("N"))
            {
                string[] path = address.Split("\\");
                path[path.Length - 1] = "copia.txt";
                string newAddress = string.Join("\\", path);
                try
                {
                    File.WriteAllText(newAddress, textToSave);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR. File not saved");
                }
            }
        }
    }
}
