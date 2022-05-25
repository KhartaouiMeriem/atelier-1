using System;
using System.Collections.Generic;
using System.Text;

namespace Banque_csharpe
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        
        public Client(string n, string p, string ad)
        {
            this.nom = n;
            this.prenom = p;
            this.adresse = ad;
        }
         public void print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string s = "nom: " + this.nom + "\n" + this.prenom  + this.prenom+"\n"+"adresse: " + this.adresse+ "\n";
            return s;
        }
    }
}
