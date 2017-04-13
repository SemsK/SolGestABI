using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestABI
{
    /// <summary>
    /// Classe des contacts : permet de mémoriser les informations concernant un contact ;
    /// Elle comporte des propriétés et des attributs / Données partagées par toutes les instances (=> Static)
    /// </summary>
    public class ClasseContact
    {
        /// <summary>
        /// Nombre de contacts de la classe (public car partagé par toutes les instances).
        /// </summary>
        public static Int32 compteurContact = 0;

        /// <summary>
        /// Obtient le nom du contact forcé en MAJUSCULE.
        /// </summary>
        private String nomContact;
        /// <summary>
        /// Nom du contact ALPHABÉTIQUE ; le service commercial devra rentrer uniquement des lettres.
        /// </summary>
        public String NomContact
        {
            get { return this.nomContact; }
            set { this.nomContact = value.Trim().ToUpper() ; } // Met le nom en majuscule.
        }

        /// <summary>
        /// Obtient le prénom du contact forcé en MINUSCULE.
        /// </summary>
        private String prenomContact;
        /// <summary>
        /// Prénom du contact ALPHABÉTIQUE ; le service commercial devra rentrer uniquement des lettres.
        /// </summary>
        public String PrenomContact
        {
            get { return this.prenomContact; }
            set { this.prenomContact = value.Trim().ToLower(); } // Met le prénom en minuscule.
        }

        /// <summary>
        /// Obtient la fonction du contact.
        /// </summary>
        private String fonctionContact;
        /// <summary>
        /// Fonction du contact  ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres ou des lettres.
        /// </summary>
        public String FonctionContact
        {
            get { return fonctionContact; }
            set { fonctionContact = value;  }
        }

        /// <summary>
        /// Obtient le numéro du contact.
        /// </summary>
        private Int32 idContact;
        /// <summary>
        /// Numéro du contact NUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres.
        /// </summary>
        public Int32 IdContact
        {
            get { return idContact; }
            set { idContact = value;  }
        }

        /// <summary>
        /// Obtient le numéro de téléphone du contact.
        /// </summary>
        private String telContact;
        /// <summary>
        /// Numéro de tél du contact ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres ou des espaces.
        /// </summary>
        public String TelContact
        {
            get { return telContact; }
            set { telContact = value; }
        }

        /// <summary>
        /// Obtient l'adresse mail du contact.
        /// </summary>
        private String mailContact;
        /// <summary>
        /// Adresse mail du contact ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement une adresse valide.
        /// </summary>
        public String MailContact
        {
            get { return mailContact; }
            set { mailContact = value; }
        }

        /// <summary>
        /// Obtient le nom du document forcé en MAJUSCULE.
        /// </summary>
        private String nomDoc;
        /// <summary>
        /// Nom du projet ALPHANUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres ou des lettres.
        /// </summary>
        public String NomDoc
        {
            get { return this.nomDoc; }
            set { this.nomDoc = value.Trim().ToUpper(); } // Met le nom du Projet en majuscule.
        }
        
        /// <summary>
        /// Obtient le nombre d'heures d'intervention cumulées par un contact.
        /// </summary>
        private Int32 dureeCumul;
        /// <summary>
        /// Nombre d'heures cumulées NUMÉRIQUE ; le service commercial devra rentrer uniquement des chiffres.
        /// </summary>
        public Int32 DureeCumul
        {
            get { return dureeCumul ; }
            set { dureeCumul = value; }
        }
    }
}
