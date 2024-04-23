﻿namespace E4IT.GestBanque.Models
{
    public class Courant : Compte
    {
        

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                //Coder de manière defensive
                if (value < 0)
                    return; //à remplacer par une erreur

                _ligneDeCredit = value;
            }
        }

        public override void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }
    }
}

