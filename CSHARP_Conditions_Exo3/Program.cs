using System;

namespace CSHARP_Conditions_Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour sujet n°2 035 654. Veuillez nous indiquer vôtre âge en nombre de cycles solaires terrestres standard.");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Sujet n°2 035 654. Veuillez maintenant nous indiquer si vous êtes un homme par la lettre h, ou une femme par la lettre f.");
            string sexe = Console.ReadLine().ToLower();
            
            //attente des valeurs "h" ou "f"

            if (age >= 18 && sexe == "f")
                {
                    Console.WriteLine($"Sujet n°2 035 654. Vous êtes donc un sujet féminin majeur. Veuillez vous diriger vers la cuisine pour me faire un sandwich.");
                }
            else if (age >= 18 && sexe=="h")
                {
                    Console.WriteLine($"Sujet n°2 035 654. Vous êtes donc un sujet masculin majeur. Allez donc faire de l'argent, feignant.");
                }
            else if (age < 18 && sexe == "f")
                {
                Console.WriteLine($"Sujet n°2 035 654. Vous êtes donc un sujet féminin mineur. Tenez, voici une poupée Barbie résidente de l'abri.");
                }
            else if (age < 18 && sexe == "h")
                {
                Console.WriteLine($"Sujet n°2 035 654. Vous êtes donc un sujet masculin mineur. Allez donc jouer à la petite voiture.");
                }
            else
                   {
                Console.WriteLine("ERREUR, ERREUR. Instructions non contractuelles, veuillez réitérer l'opération");
            }
        }
    }
}
