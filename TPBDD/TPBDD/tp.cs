using System;

public class TP
{

// <NEPASTOUCHER>
    //Constructeur
    public void TP(string pseudo)
    {
        string[] profil = Profil(Pseudo);
        Nom = profil[0];
        Prenom = profil[1];
        Pseudo = profil[2];
        Email = profil[3];
        QuestionSecrete = profil[4];
    }

    //Propriété 
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Pseudo { get; set; }
    public string Email { get; set; }
    public string QuestionSecrete { get; set; }

// </NEPASTOUCHER>    

    // Méthode
    /// <summary>
    /// Fonction de connection
    /// Comparaison entre les données saisi et le donnée de la base de donné
    /// </summary>
	public static void Connection(string pseudo, string motdepasse)
    {

    }

    /// <summary>
    /// Fonction d'inscription
    /// Ajout d'un nouvelle utilisateur
    /// </summary>
    public static void Inscription()
    {

    }

    /// <summary>
    /// A partir du pseudo récupère les informations de profil
    /// </summary>
    /// <param name="Pseudo"></param>
    /// <returns></returns>
    public string[] Profil(string Pseudo)
    {

    }
}
