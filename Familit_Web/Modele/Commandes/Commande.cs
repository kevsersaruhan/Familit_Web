using Familit_Web.Modele.Etablissements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Modele.Commandes
{
  public class Commande
  {
    public Commande()
    {
      DetailsCommande = new List<LigneDeCommande>();
    }
    public int ClientID { get; set; }
    public int ID { get; set; }
    public IEnumerable<LigneDeCommande> DetailsCommande { get; set; }
    public DateTime DateDeCommande { get; set; }
    public double Total { get; set; }
    public double Acompte { get; set; }
    public double Solde { get; set; }
    public Showroom Showroom { get; set; }
    public string TypeDeCommande{ get; set; }
  }
}
