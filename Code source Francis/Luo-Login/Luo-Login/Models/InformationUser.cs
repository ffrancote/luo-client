using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luo_Login.Models
{
  class InformationUser
  {
    private int _classement;
    private string _nom;
    private string _prenom;
    private int _niveau;

    /// <summary>
    /// Classement du joueur
    /// </summary>
    public int Classement
    {
      get { return _classement; }
      set { _classement = value; }
    }
    /// <summary>
    /// Niveau du joueur
    /// </summary>
    public int Niveau
    {
      get { return _niveau; }
      set { _niveau = value; }
    }
    /// <summary>
    /// Prénom du joueur
    /// </summary>
    public string Prenom
    {
      get { return _prenom; }
      set { _prenom = value; }
    }
    /// <summary>
    /// Nom du joueur
    /// </summary>
    public string Nom
    {
      get { return _nom; }
      set { _nom = value; }
    }

    #region Constructeur

    public InformationUser()
    {
    }

    public InformationUser(InformationUser information)
    {
    }

    public InformationUser(User user)
    {
      GetInformation();
    }

    #endregion

    /// <summary>
    /// Reçois l'information sur le joueur pour le constructeur
    /// </summary>
    /// <returns></returns>
    public bool GetInformation()
    {
      return true;
    }
  }
}
