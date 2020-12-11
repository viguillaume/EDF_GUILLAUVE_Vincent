using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEDFWPF
{
    class ClientPerso
    {
        private int identifiant;
        private string nom;
        private string prenom;
        private int ancienReleve;
        private int dernierReleve;

        public ClientPerso(int unId, string unNom, string unPrenom, int unAncienR, int unNouveauR)
        {
            Identifiant = unId;
            Nom = unNom;
            Prenom = unPrenom;
            AncienReleve = unAncienR;
            DernierReleve = unNouveauR;
        }

        public int Identifiant { get => identifiant; set => identifiant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AncienReleve { get => ancienReleve; set => ancienReleve = value; }
        public int DernierReleve { get => dernierReleve; set => dernierReleve = value; }
    }

}
