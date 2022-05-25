Devise(double val);
		bool operator>=(Devise* d) const;
		Devise& operator-(const Devise& d) const;
		Devise& operator+(const Devise& d) const;
		void afficher() const;
	private: 
		double m_valeur;
