using Familit_Web.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Modele.Commandes
{
  public class LigneDeCommande
  {
    public int ID { get; set; }
    public int IDCommande { get; set; }
    public Produit Product { get; set; }
    public int Quantite { get; set; }
    public double TOTAL { get; set; }
    public double HTVA { get; set; }
    public double TVAC { get; set; }
  }
}
