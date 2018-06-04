using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreViaUtilisateur, i, resultat;
            bool etat = true;

            System.Console.Write("Entrez un nombre : ");
            nombreViaUtilisateur = int.Parse(System.Console.ReadLine());

            for(i = 2; i <= nombreViaUtilisateur / 2; i++)
            {
                resultat = nombreViaUtilisateur % i;
                if(resultat == 0)
                {
                    etat = false;
                    break;
                }
            }
            if (etat)
            {
                System.Console.WriteLine(nombreViaUtilisateur + " est un nombre premier.");
            }
            else
            {
                System.Console.WriteLine(nombreViaUtilisateur + " n'est pas un nombre premier.");
            }

            System.Console.ReadLine();
        }
    }
}
