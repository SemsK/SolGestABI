using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GestABI
{
    // Classe de gestion des champs remplis

    class Outils
    {
        /// <summary>
        /// La saisie peut-être constitué de lettres, de chiffres, de tirets, d'underscore ou d'espaces mais  doit être inférieure à 25 caractères.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Tout_Inf26_OK(String S)
        {
            Int32 i;
            Char c;
            Boolean code = true;
            if (S.Length < 26 && S.Length > 0)
            {
                for (i = 0; i < S.Length; i++)
                {
                    c = S[i];                        // Vérifie le ènième
                    if (!(Char.IsLetterOrDigit(c)) && !(Convert.ToString(c) == "-") && !(Convert.ToString(c) == " ") && !(Convert.ToString(c) == "_"))
                    {                                // Si ce n'est ni une lettre, un chiffre, un tiret, un espace ou un underscore
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 25 caractères
            }
            return code;
        }

        /// <summary>
        /// La saisie n'est constitué que de chiffres et elle est inférieure à 10 caractères.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Entier_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 10 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)))          // Si le caractère saisie n'est pas un chiffre
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 9 caractères
            }
            return code;
        }

        /// <summary>
        /// La saisie n'est constitué que de chiffres, de points ou de virgules.
        /// </summary>
        /// <param name="S"></param>
        public static bool Est_Decimal_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 28 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)) && !(Convert.ToString(c) == ".") && !(Convert.ToString(c) == ","))
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 9 caractères
            }
            return code;
        }

        /// <summary>
        /// La saisie n'est constitué que de chiffres (Inf à un million, Vraisemblance pour le nombre de l'effectif et le gain/pesrsonne)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Nombre_Valide_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 7 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)))          // Si le caractère saisie n'est pas un chiffre
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 9 caractères
            }
            return code;
        }

        // Gestion de la classe Client "MSClient"

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Raison Sociale"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_RaisonSociale_OK(String S)
        {
            return Est_Tout_Inf26_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Activité"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Activite_OK(String S)
        {
            return Est_Tout_Inf26_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "C.A."
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_CA_OK(String S)
        {
            return Est_Decimal_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Effectif"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Effectif_OK(String S)
        {
            return Est_Nombre_Valide_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Téléphone"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Telephone_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 15 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)) && !(Convert.ToString(c) == " ") && !(Convert.ToString(c) == "-"))
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 9 caractères
            }
            return code;
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Mail"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Mail_OK(String mail)
        {
            string mail1, mail2;
            int atPosition;
            int count;
            int count2;
            int LMail; //"L" est la longueur du mail (util aprés)
            bool MailOK;

            MailOK = true;
            mail = Regex.Replace(mail, "[^a-zA-Z0-9_/./_/@/-]", " ");
            LMail = mail.Length;

            if (mail.Contains("/"))
            {
                MailOK = false;
            }
            for (int i = 0; i < LMail; i++)
            {
                if (mail.Substring(i, 1) == " ")
                {
                    MailOK = false;
                }
            }
            if (!char.IsLetterOrDigit(mail.FirstOrDefault()))
            {
                MailOK = false;
            }
            if (!char.IsLetter(mail.LastOrDefault()))
            {
                MailOK = false;
            }
            count = 0;
            for (int i = 0; i < LMail; i++)
            {
                if (mail[i] == '@')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                MailOK = false;
            }
            if (count >= 2)
            {
                MailOK = false;
            }
            if (mail.Contains("..") == true)
            {
                MailOK = false;
            }

            if (mail.Contains("@"))
            {
                atPosition = mail.IndexOf("@");
                mail1 = mail.Substring(0, atPosition);
                mail2 = mail.Substring(atPosition + 1, mail.Length - mail1.Length - 1);
                if (!char.IsLetterOrDigit(mail2.FirstOrDefault()))
                {
                    MailOK = false;
                }
                if (!char.IsLetterOrDigit(mail1.LastOrDefault()))
                {
                    MailOK = false;
                }

                count2 = 0;
                for (int i = 0; i < mail2.Length; i++)
                {
                    if (mail2[i] == '.')
                    {
                        count2++;
                    }
                }
                if (count2 == 0)
                {
                    MailOK = false;
                }
            }
            return MailOK;
        }

        /// <summary>
        /// Vérifie la vraisemblable de la saisie du champ "Adresse"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Adresse_OK(String S)
        {
            return Est_Tout_Inf26_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Code Postal"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Code_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 5 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 5 caractères
            }
            return code;
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Ville"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Ville_OK(String S)
        {
            return Est_Tout_Inf26_OK(S);
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Commentaires"
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Comm_OK(String S)
        {
            Boolean code = true;
            if (S.Length > 500)
            {
                code = false;
            }
            return code;
        }

        // Gestion de la classe Client "MSContact"

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Nom" du contact.j
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_NomContact_OK(String S)
        {
            Int32 i;
            Char c;
            Boolean code = true;
            if (S.Length < 15 && S.Length > 0)
            {
                for (i = 0; i < S.Length; i++)
                {
                    c = S[i];                        // Vérifie le ènième
                    if (!(Char.IsLetter(c)) && !(Convert.ToString(c) == "-"))
                    {                                // Si ce n'est ni une lettre, ni un tiret.
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 15 caractères
            }
            return code;
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Prénom" du contact.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_PrenomContact_OK(String S)
        {
            Int32 i;
            Char c;
            Boolean code = true;
            if (S.Length < 15 && S.Length > 0)
            {
                for (i = 0; i < S.Length; i++)
                {
                    c = S[i];                        // Vérifie le ènième
                    if (!(Char.IsLetter(c)) && !(Convert.ToString(c) == "-") && (Convert.ToString(c) == " "))
                    {                                // Si ce n'est ni une lettre, ni un tiret.
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 15 caractères
            }
            return code;
        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Fonction" du contact.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_FonctionContact_OK(String S)
        {
            Int32 i;
            Char c;
            Boolean code = true;
            if (S.Length < 15 && S.Length > 0)
            {
                for (i = 0; i < S.Length; i++)
                {
                    c = S[i];                        // Vérifie le ènième
                    if (!(Char.IsLetter(c)) && !(Convert.ToString(c) == "-") && (Convert.ToString(c) == " ") && (Convert.ToString(c) == "/"))
                    {                                // Si ce n'est ni une lettre, ni un tiret.
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 15 caractères
            }
            return code;

        }

        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Numéro" du contact.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_IdContact_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 5 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 5 caractères
            }
            return code;
        }
        
        /// <summary>
        /// Vérifie la vraissemblance de la saisie du champ "Documents" du contact.
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static bool Est_Documents_OK(String S)
        {
            Boolean code = true;
            if (S.Length > 500)
            {
                code = false;
            }
            return code;
        }

        public static bool Est_DureeCumul_OK(String S)
        {
            Char c;
            Boolean code = true;
            if (S.Length < 5 && S.Length > 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    c = S[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;                // Détecte une erreur
                    }
                }                                    // Fin de boucle
            }
            else
            {
                code = false;                        // Détecte une erreur si il y a plus de 5 caractères
            }
            return code;
        }
    }
}
