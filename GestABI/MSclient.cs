using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestABI
{
    /// <summary>
    /// Classe des Clients : Cette classe va me permettre de mémoriser le informations concernants un client ;
    /// Elle comporte des propriétés et des attributs / Données partagées par toutes les instances ( => Static)
    /// </summary>
    public class MSclient
    {
        /// <summary>
        /// Nombre de clients de la classe (public car partagé par toutes les instances).
        /// </summary>
        public static Int32 Nclient;

        /// <summary>
        /// Obtient le nom du client forcé en MAJUSCULE.
        /// </summary>
        private String nomClient;
        /// <summary>
        /// Nom du client ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres ou des lettres.
        /// </summary>
        public String NomClient
        {
            get { return this.nomClient; }
            set { this.nomClient = value.Trim().ToUpper(); } // Met le nom du client en majuscule.
        }

        /// <summary>
        /// Obtient le numéro du client.
        /// </summary>
        private Int32 idClient;
        /// <summary>
        /// Numéro du client NUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres.
        /// </summary>
        public Int32 IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        /// <summary>
        /// Obtient le type du client.
        /// </summary>
        private String typeClient;
        /// <summary>
        /// Type du client PRÉDÉFINI ; le service commercial devra choisir entre PUBLIC ou PRIVÉ.
        /// </summary>
        public String TypeClient
        {
            get { return typeClient; }
            set { typeClient = value; }
        }

        /// <summary>
        /// Obtient l'activité du client.
        /// </summary>
        private String activite;
        /// <summary>
        /// Activité du client ALPHABÉTIQUE ; le service commercial devra rentrer uniquement des lettres.
        /// </summary>
        public String Activite
        {
            get { return activite; }
            set { activite = value; }
        }

        /// <summary>
        /// Obtient le chiffre d'affaire du client.
        /// </summary>
        private Decimal cA;
        /// <summary>
        /// Chiffre d'affaire du client NUMÉRIQUE ; le service commercial devra rentrer uniquement un nombre DÉCIMAL.
        /// </summary>
        public Decimal CA
        {
            get { return cA; }
            set { cA = value; }
        }

        /// <summary>
        /// Obtient la nature du client.
        /// </summary>
        private String nature;
        /// <summary>
        /// Nature du client PRÉDÉFINI ; le service commercial devra choisir entre PRINCIPALE, SECONDAIRE ou ANCIENNE.
        /// </summary>
        public String Nature
        {
            get { return nature; }
            set { nature = value; }
        }

        /// <summary>
        /// Obtient la raison sociale du client.
        /// </summary>
        private String raisonSociale;
        /// <summary>
        /// Raison Sociale du client ALPHABÉTIQUE ; le service commercial devra rentrer uniquement des lettres.
        /// </summary>
        public String RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }

        /// <summary>
        /// Obtient l'effectif du client.
        /// </summary>
        private Int32 effectif;
        /// <summary>
        /// Effectif du client NUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres.
        /// </summary>
        public Int32 Effectif
        {
            get { return effectif; }
            set { effectif = value;  }
        }

        /// <summary>
        /// Obtient le numéro de téléphone du client.
        /// </summary>
        private String telephone;
        /// <summary>
        /// Numéro de tél du client ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres ou des espaces.
        /// </summary>
        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        /// <summary>
        /// Obtient l'adresse mail du client.
        /// </summary>
        private String mail;
        /// <summary>
        /// Adresse mail du client ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement une adresse valide.
        /// </summary>
        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        /// <summary>
        /// Obtient l'adresse (Numéro, Rue, etc...) du client.
        /// </summary>
        private String adresse;
        /// <summary>
        /// Adresse du client ALPHANUMÉRIQUE ; pas de contrainte pour le service commercial.
        /// </summary>
        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        /// <summary>
        /// Obtient le code postal du client.
        /// </summary>
        private String codeClient;
        /// <summary>
        /// Code postal du client NUMÉRIQUE ; le service commercial devra rentrer uniquement un numéro à 5 chiffres.
        /// </summary>
        public String CodeClient
        {
            get { return codeClient; }
            set { // Le service commercial doit fournir un code postal à 5 chiffres
                Int32 i ;                  // Variable de boucle
                Boolean erreur = false;   // indicateur d'erreur
                if (value.Length ==5)     // 5 caractères attendus : OK => Controle alors un à un 
                {
                    for (i = 0; i< value.Length; i++) // Controle les chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i])))   
                        { erreur = true; }
                    } // Fin de boucle du contrôle des chiffres
                    if (erreur)       // On a rencontré un non-chiffre             
                    {                 // Avertissement par messagebox          
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MClient", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        codeClient = value;  // Tout est bon, on affecte la propriété
                    }
                }
                else  // Il n'y a pas 5 caractères : Avertissement par messagebox
                {             
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MClient", System.Windows.Forms.MessageBoxButtons.OK);
                }
                }
        }
        /// <summary>
        /// Obtient la ville du client forcée en MAJUSCULE.
        /// </summary>
        private String ville;
        /// <summary>
        /// Ville du client ALPHABÉTIQUE ; le service commercial devra rentrer uniquement des lettres.
        /// </summary>
        public String Ville
        {
            get { return ville; }
            set { ville = value.Trim().ToUpper(); } // Met la ville du client en majuscule.
        }

        /// <summary>
        /// Obtient les commentaires du client. 
        /// </summary>
        private String commClient;
        /// <summary>
        /// Commentaires sur le client ALPHANUMÉRIQUE ; pas de contrainte pour le service commercial.
        /// </summary>
        public String CommClient
        {
            get { return commClient; }
            set { commClient = value; }
        }

    }
}
