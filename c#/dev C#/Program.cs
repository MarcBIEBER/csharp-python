using System;

namespace dev_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour quel est votre prénom ?\n");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nBonjour {name}, nous somme le {date:d}, a {date:t}, !");
            Console.WriteLine($"\n{name}, nous aimerions savoir pourquoi tu es ici ? C'est pour coder ou juste recopier tes camarade ? Merci de répondre par 1 pour coder ou 2 pour recopier uniquement");
            int reponse = 0;
            Console.Write("\nEntrez votre réponse\n");
            int.TryParse(Console.ReadLine(), out reponse);
           
            if (reponse == 1)
            {
                Console.WriteLine("\nBienvenue sur notre editeur de texte, bonne séance à toi");
                //open editeur (faire en winforms)
            }
            else if (reponse == 2)
            {
                Console.WriteLine("\nTu es une cheater HORS DE MA VU MALAUTRUE !");
            }
            
            Console.ReadLine();
            Console.WriteLine("\nAppuie sur 3 pour quitter, ou 4 pour recommencer mais il y aura un questionnaire !");
            int resultat = 0;
            Console.Write("\nEntrez votre réponse\n");
            int.TryParse(Console.ReadLine(), out resultat);
            

            if (resultat == 3)
            {
                Console.WriteLine("\nAppuie sur une touche pour quitter, en te souhaitant une bonne journée !");
                Console.ReadKey(true);
            }
            else if (resultat == 4)
            {
                Console.WriteLine("\nComment s'appel la structure du programme principal ?");
            }
            
        }
    }
}
