using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luo_Login.Models
{
  class User
  {
    private string _username;
    private string _password;
    private string _id;

    /// <summary>
    /// Nom d'utilisateur du joueur ex: asdf@gmail.com
    /// </summary>
    public string Username
    {
      get { return _username; }
      set { _username = value; }
    }

    /// <summary>
    /// Mot de pass du joueur ex: asdf1234
    /// </summary>
    public string Password
    {
      get { return _password; }
      set { _password = value; }
    }

    /// <summary>
    /// ID du joueur ex: 1234zyxw
    /// </summary>
    public string Id
    {
      get { return _id; }
      set { _id = value; }
    }

    /// <summary>
    /// Méthode qui reçois comme information l'id du joueur authentifier si l'authentification fonctionne
    /// </summary>
    /// <returns>Id du joueur</returns>
    public string GetIdUser()
    {
      return string.Empty;
    }
  }
}
