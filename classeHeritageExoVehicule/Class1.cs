﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeHeritageExoVehicule
{
    public class Agence
    {
        public string Adresse { set; get; }
        public string Ville { get; set; }
       // List<Employe> Employes = new List<Employe>();
        List<Vehicule> Parc = new List<Vehicule>();

        public List<Employe> Personnel { get; set; }


}
    public class Employe : Personne
    {

        public int SalaireAnnuelBrut { set; get; }
        Agence Agence = new Agence();


    }
    public abstract class Personne
    {
        public string Nom { set; get; }
        public string Prenom { set; get; }

    }

    public class Client : Personne
    {
        public string Numero { set; get; }

    }

    public class ContratLocation
    {
        public DateTime DateDebut { set; get; }
        public DateTime DateFin { set; get; }
        public int KilometrageMax { get; set; }
        public Client Client { get; set; }
        public Vehicule Vehicule { get; set; }
        double prix;


        public double CalculerMontantLocation(DateTime DateDebut, DateTime DateFin)
        {
            var nbJours = (DateFin - DateDebut).TotalDays;

            return Vehicule.getPrixJour()*nbJours;

        }


    }
    public abstract class Vehicule
    {
        public string Marque { set; get; }
        public string Model { set; get; }
        double prix;

        public double getPrixJour()
        {
            return prix;
        }

    }
    public class Camionette : Vehicule
    {
        public int PoidsMaxEnKilo { set; get; }
        public int PrixJour { set; get; }
    }
    public class Voiture : Vehicule
    {
        public int PrixJour { set; get; } = 5;

  


    }
    public class CategorieVoiture
    {
        public string Nom { set; get; }
        public double PrixJour { set; get; }

        public List <Voiture> Voitures { get; set; }

    }

}
