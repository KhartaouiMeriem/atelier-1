using System;
using System.Collections.Generic;
using System.Text;

namespace Banque_csharpe
{
    class Compte
    {
        private readonly int num =0;
        static int cpt=0;
        private Client cli;
        private Devise solde;
        //private List<Operation> = new List<Operation>();
        
       public Compte(Client cl,Devise s)
        {
            this.num = cpt + 1;
            this.cli= cl;
            this.solde = s;
        }
        public void print()
        {
            cli.print();
            solde.print();
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string s = "numero de compte est: " + this.num + "\n"+"solde: " + this.solde + "\n";
            return s;
        }
        public void crediter(Devise d2)
        {

            this.solde=this.solde+d2;
        }
        public void debiter( Devise d2)
        {   if(this.solde > d2) { 
            this.solde = this.solde - d2;
            }
        }
        public void transferer(Devise d1 , Devise d2)
        {
            if()
        }
    }
}
