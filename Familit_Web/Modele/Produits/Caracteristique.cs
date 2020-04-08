using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Modele.Produits
{
  public class Caracteristique
  {
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Details { get; set; }
    public Categorie Categorie { get; set; }
    public IEnumerable<Produit> ListeProduits { get; set; }
    public int CatId { get; set; }
  }
}
