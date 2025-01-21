using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_OOP_JoueurHockey
{
    public class JoueursHockey
    {
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public int Numero { get; set; } = 0;
        public string Position { get; set; } = "Donnée non-disponible";
        public int NbButs { get; set; } = 0;
        public int NbPartiesJouees { get; set; } = 0;
        public JoueursHockey(string nom, string prenom, int numero)
        {
            Nom = nom;
            Prenom = prenom;
            Numero = numero;
            //Console.WriteLine(ToString());
        }
        public JoueursHockey(string nom, string prenom, int numero, string position, int nbButs, int nbPartiesJouees) : this(nom, prenom, numero)
        {
            Position = position;
            NbButs = nbButs;
            NbPartiesJouees = nbPartiesJouees;
            //Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"\n{Nom}, {Prenom} :\n" +
                $"Numéro: {Numero}\n" +
                $"Position: {Position}, Nombre de buts : {NbButs}, Nombre de parties jouées : {NbPartiesJouees}\n" +
                $"-----------------------------------------------------------------------------------------------";
        }
    }
}
