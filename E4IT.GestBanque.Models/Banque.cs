﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4IT.GestBanque.Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

        public string Nom { get; set; }

        public Courant this[string numero]
        {
            get
            {
                return _comptes[numero];
            }
        }

        public void Ajouter(Courant courant)
        {
            _comptes.Add(courant.Numero, courant);
        }

        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }
    }
}