using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestABI
{
    /// <summary>
    /// Classe générale de données / Elle regroupe les données de l'application de gestion des Clients et des Contacts
    /// </summary>
    public class Donnees
    {
        /// <summary>
        /// Collection d'objets MClient
        /// </summary>
        public static List<MSclient> ArrayClient = new List<MSclient>();

        /// <summary>
        /// Collection d'objets MContact
        /// </summary>
        public static List<MScontact> ArrayContact = new List<MScontact>();

    }
}
