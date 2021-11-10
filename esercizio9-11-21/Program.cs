using System;

namespace esercizio9_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dammi l'indirizzo del file");
            string indirizzo = Console.ReadLine();

            string testoFile = LeggiIlFile(indirizzo);

            if (testoFile == null)
            {
                return;
            }

            Console.WriteLine("Vuoi un Nuovo file o vuoi Sovrascrivere il precedente?");
            Console.WriteLine("Seleziona N per nuovo e S per sovrascrivere");
            string sceltaNuovo = Console.ReadLine();

            string testoModificato = Replace(testoFile, parolaDaCercare, parolaDaRimpiazzare);

            ScriviIlFile(testoModificato, indirizzo, sceltaNuovo);
            break;
                case 2:
                    Console.WriteLine("Se vuoi rendere maiusole tutte le lettere premi T"
                                      + Environment.NewLine
                                      + "se invece vuoi rendere maiuscole le lettere dopo il punto premi P");
            string sceltaPunto = Console.ReadLine();

            public static string Replace(string testo, string parolaDaCercare, string parolaDaRimpiazzare)
            {
                string testoModificato = testo.Replace(parolaDaCercare, parolaDaRimpiazzare);

                return testoModificato;
            }
            public static string LeggiIlFile(string indirizzo)
            {
                if (File.Exists(indirizzo))
                {
                    try
                    {
                        string testoDelFile = File.ReadAllText(indirizzo);
                        return testoDelFile;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("File non accessibile");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Il file non esiste");
                    return null;
                }
            }

        }
    }
}
