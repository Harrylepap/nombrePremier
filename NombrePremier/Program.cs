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
            int diviseur, nbr, nombreViaUser, compt = 0;
            bool Est_premier;
            Console.Write("Entrez un nombres :  ");
            nombreViaUser = int.Parse(Console.ReadLine());

            for (nbr = 2; nbr <= nombreViaUser; nbr++)
            {
                diviseur = 2;
                Est_premier = true;
                do
                {
                    if (nbr % diviseur == 0)
                    {
                        Est_premier = false;
                    }
                    else
                    {
                        diviseur = diviseur + 1;
                    }
                } while ((diviseur <= nbr / 2) && (Est_premier == true));
                if (Est_premier)
                {
                    compt++;
                    Console.Write(nbr + ", ");
                }
            }
            Console.ReadLine();
        }
    }
}
