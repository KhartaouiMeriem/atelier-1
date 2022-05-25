using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    interface IDevise
    {
      public  Devise(double val);
	  public	bool operator>=(Devise* d) const;
	  public Devise& operator-(const Devise& d) const;
	  public Devise& operator+(const Devise& d) const;
	  public void afficher() const;
	  private double m_valeur;


}