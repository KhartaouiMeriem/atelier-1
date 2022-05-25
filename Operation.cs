using System;
using System.Collections.Generic;
using System.Text;

namespace Banque_csharpe
{
    class Operation
    {
        private readonly int numOp;
        private static int num = 0;
        private DateTime d;
        private Devise montant;
        private string libelle;
        public Operation(){
            this.numOp = num++;
            this.d = new DateTime();
            this.montant = new Devise();
            this.libelle = "";
        }
        public Operation(Devise m, string l)
        {
            this.numOp = num++;
            this.d = new DateTime();
            this.montant = m;
            this.libelle = l;
        }
        public void print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string s = "date :" + this.d;
            return s;
        }
    }
}
