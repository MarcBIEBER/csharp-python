using System;

namespace dev_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            bienvenue();
            leave();
        }
        public static void bienvenue() 
        {
            Console.WriteLine("Bonjour quel est votre prénom ?\n");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nBonjour {name}, nous somme le {date:d}, a {date:t}, !");
            Console.WriteLine($"\n{name}, nous aimerions savoir pourquoi tu es ici ? C'est pour coder ou juste recopier tes camarade ? Merci de répondre par 1 pour coder ou 2 pour recopier uniquement\n");
            int reponse = 0;
            Console.Write("\nEntrez votre réponse\n");
            int.TryParse(Console.ReadLine(), out reponse);

            if (reponse == 1) {
                Console.WriteLine("\nBienvenue sur notre editeur de texte, bonne séance à toi\n");
                //open editeur (faire en winforms) a faire
            }
            else if (reponse == 2) {
                Console.WriteLine("\nTu es une cheater HORS DE MA VU MALAUTRUE !\n");
                leave();
            }
            else if (reponse > 2) {
              Console.WriteLine("\nMauvaise réponse tu sais pas lire ? Recommence tout !\n");
              Console.ReadKey(true);
              Environment.Exit(reponse);
            }
        }
        public static void leave()
        {
            Console.ReadLine();
            int resultat = 0;
            Console.WriteLine("Appuie sur ou 3 pour recommencer mais il y aura un questionnaire ou 4 pour quitter !\n");
            Console.Write("\nEntre ta réponse petit voyou\n");
            int.TryParse(Console.ReadLine(), out resultat);
            
            if (resultat >= 4) {
                Console.ReadKey(true);
                Environment.Exit(resultat);
            }
            if (resultat == 3) {
                questionnaire();
            }
            Environment.Exit(0);
        }
        public static void questionnaire() 
        {
            Console.WriteLine("\nComment s'appel la structure du programme principal ?\n");
            string question = "main\0";
            string repond = Console.ReadLine();
            int i = 0;
            while (question[i] != '\0') {
                if (question[i] != repond[i]) {
                    Console.WriteLine("\nC'est faux tu repars du début ! enjoy\n");
                    Console.ReadKey(true);
                    Console.Clear();
                    bienvenue();
                    break;
                }
                i += 1;
            }
            Console.WriteLine("\nC'est juste question suivante, Comment s'appel le monde de skyrim ?\n");
            string question1 = "Bordeciel\0";
            string repond1 = Console.ReadLine();
            for (int j = 0; question1[j] != '\0'; j++) {
                if (question1[j] != repond1[j]) {
                    Console.WriteLine("\nC'est faux ! enjoy\n");
                    Console.ReadKey(true);
                    Console.Clear();
                    bienvenue();
                    break; 
                }
            }
            Console.WriteLine("\nFélicitations jeune padawan tu as le droit de travailler maintenant !\n");
            //open editeur (faire en winforms) a faire
        } 
    }
}
