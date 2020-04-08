using Familit_Web.Modele.Commandes;
using Familit_Web.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Modele.Users
{
  public class Client : User
  {
    public Client()
    {
      ListFav = new List<Produit>();
      ListCommande = new List<CommandeClient>();
    }
    public string NumBCE { get; set; }
    public bool EstFournisseur { get; set; }
    public IEnumerable<Produit> ListFav { get; set; }
    public IEnumerable<CommandeClient> ListCommande { get; set; }
  }
}
