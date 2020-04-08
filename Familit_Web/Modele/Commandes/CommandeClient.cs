using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Modele.Commandes
{
  public class CommandeClient : Commande
  {
    public int VendeurID { get; set; }
    public string MoyenDePaiement { get; set; }
    public string Statut { get; set; }
    public bool? Livraison { get; set; }
    public DateTime? DateDeLivraison { get; set; }
  }
}
