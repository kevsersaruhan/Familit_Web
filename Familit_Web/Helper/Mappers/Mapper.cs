using Familit_Web.Modele.Users;

using D = DAL_API.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Familit_Web.Modele.Produits;
using Familit_Web.Modele.Etablissements;
using Familit_Web.Modele.Commandes;
using Familit_Web.Helper.Services;

namespace Familit_Web.Helper.Mappers
{
  public static class Mapper
  {
    private static CommandeClientService _serviceCommande = new CommandeClientService();
    private static ProductService _serviceProduit = new ProductService();
    private static CaracteristiqueService _serviceCaracteristique = new CaracteristiqueService();
    private static PersonnelService _servicePersonnel = new PersonnelService();
    private static LigneDeCommandeService _serviceLigne = new LigneDeCommandeService();
    public static D.Users.Personnel ToDAL(this Personnel p)
    {
      return new D.Users.Personnel
      {
        ID = p.ID,
        Nom = p.Nom,
        Prenom = p.Prenom,
        DateDeNaissance = p.DateDeNaissance,
        HireDate = p.HireDate,
        Fonction = p.Fonction,
        Login = p.Login,
        Password = p.Password,
        NbJoursAbsence = p.NbJoursAbsence,
        NbJourVacance = p.NbJourVacance,
        Salaire = p.Salaire,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        ShowroomId = p.ShowroomId,
        LieuDeTravail = ToDAL(p.LieuDeTravail),
        IsActif = p.IsActif,
        IsAdmin = p.IsAdmin
      };
    }
    public static Personnel ToLOCAL(this D.Users.Personnel p)
    {
      return new Personnel
      {
        ID = p.ID,
        Nom = p.Nom,
        Prenom = p.Prenom,
        DateDeNaissance = p.DateDeNaissance,
        HireDate = p.HireDate,
        Fonction = p.Fonction,
        Login = p.Login,
        Password = p.Password,
        NbJoursAbsence = p.NbJoursAbsence,
        NbJourVacance = p.NbJourVacance,
        Salaire = p.Salaire,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        ShowroomId = p.ShowroomId,
        LieuDeTravail = ToLOCAL(p.LieuDeTravail),
        IsActif = p.IsActif,
        IsAdmin = p.IsAdmin
      };
    }
    public static D.Users.Client ToDAL(this Client p)
    {

      return new D.Users.Client
      {
        ID = p.ID,
        Nom = p.Nom,
        Prenom = p.Prenom,
        Login = p.Login,
        Password = p.Password,
        NumBCE = p.NumBCE,
        EstFournisseur = p.EstFournisseur,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        ListCommande = ListConverter(_serviceCommande.GetCommandeClient(p.ID), ToDAL),
        ListFav = ListConverter(_serviceProduit.GetProductFav(p.ID), ToDAL),
        IsActif = p.IsActif
      };
    }
    public static Client ToLOCAL(this D.Users.Client p)
    {
      return new Client
      {
        ID = p.ID,
        Nom = p.Nom,
        Prenom = p.Prenom,
        Login = p.Login,
        Password = p.Password,
        NumBCE = p.NumBCE,
        EstFournisseur = p.EstFournisseur,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        ListCommande = _serviceCommande.GetCommandeClient(p.ID),
        ListFav = _serviceProduit.GetProductFav(p.ID),
        IsActif = p.IsActif
      };
    }
    public static D.Produits.Produit ToDAL(this Produit p)
    {
      return new D.Produits.Produit
      {
        ID = p.ID,
        Nom = p.Nom,
        Prix = p.Prix,
        PrixDAchatTHTVA = p.PrixDAchatTHTVA,
        TVA = p.TVA,
        NbPiece = p.NbPiece,
        Details = p.Details,
        CatId = p.CatId,
        ClientId = p.ClientId,
        Fournisseur = ToDAL(p.Fournisseur),
        Categorie = ToDAL(p.Categorie),
        IsActif = p.IsActif,
        ListeCaracteristiques = ListConverter(_serviceCaracteristique.GetCaracteristiqueByProduct(p.ID), ToDAL)
      };
    }
    public static Produit ToLOCAL(this D.Produits.Produit p)
    {
      return new Produit
      {
        ID = p.ID,
        Nom = p.Nom,
        Prix = p.Prix,
        PrixDAchatTHTVA = p.PrixDAchatTHTVA,
        TVA = p.TVA,
        NbPiece = p.NbPiece,
        Details = p.Details,
        CatId = p.CatId,
        ClientId = p.ClientId,
        Fournisseur = ToLOCAL(p.Fournisseur),
        Categorie = ToLOCAL(p.Categorie),
        IsActif = p.IsActif,
        ListeCaracteristiques = _serviceCaracteristique.GetCaracteristiqueByProduct(p.ID)
      };
    }
    public static D.Produits.Categorie ToDAL(this Categorie p)
    {
      return new D.Produits.Categorie
      {

        ID = p.ID,
        Nom = p.Nom,
        Details = p.Details,
        IsActif = p.IsActif,
        ListeCaracteristique = ListConverter(_serviceCaracteristique.GetCaracteristiqueByCategorie(p.ID), ToDAL)
      };
    }
    public static Categorie ToLOCAL(this D.Produits.Categorie p)
    {
      return new Categorie
      {
        ID = p.ID,
        Nom = p.Nom,
        Details = p.Details,
        IsActif = p.IsActif,
        ListeCaracteristique = _serviceCaracteristique.GetCaracteristiqueByCategorie(p.ID)
      };
    }
    public static D.Produits.Caracteristique ToDAL(this Caracteristique p)
    {
      return new D.Produits.Caracteristique
      {
        Id = p.Id,
        Nom = p.Nom,
        Details = p.Details,
        CatId = p.CatId,
        Categorie = ToDAL(p.Categorie)
      };
    }
    public static Caracteristique ToLOCAL(this D.Produits.Caracteristique p)
    {
      return new Caracteristique
      {
        Id = p.Id,
        Nom = p.Nom,
        Details = p.Details,
        CatId = p.CatId,
        Categorie = ToLOCAL(p.Categorie)
      };
    }
    public static D.Etablissements.Showroom ToDAL(this Showroom p)
    {
      return new D.Etablissements.Showroom
      {
        ID = p.ID,
        Nom = p.Nom,
        NumBCE = p.NumBCE,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        IsActif = p.IsActif,
        PersonnelList = ListConverter(_servicePersonnel.GetPersonnelByShowroom(p.ID), ToDAL)
      };

    }
    public static Showroom ToLOCAL(this D.Etablissements.Showroom p)
    {
      return new Showroom
      {
        ID = p.ID,
        Nom = p.Nom,
        NumBCE = p.NumBCE,
        AdRue = p.AdRue,
        AdNum = p.AdNum,
        AdCP = p.AdCP,
        AdVille = p.AdVille,
        AdPays = p.AdPays,
        NumTel = p.NumTel,
        Email = p.Email,
        IsActif = p.IsActif,
        PersonnelList = _servicePersonnel.GetPersonnelByShowroom(p.ID)
      };
    }
    public static D.Commandes.Commande ToDAL(this Commande p)
    {
      return new D.Commandes.Commande
      {
        ID = p.ID,
        DateDeCommande = p.DateDeCommande,
        Total = p.Total,
        Acompte = p.Acompte,
        Solde = p.Solde,
        TypeDeCommande = p.TypeDeCommande,
        DetailsCommande = ListConverter(_serviceLigne.GetByCommandeId(p.ID), ToDAL),
        Showroom = ToDAL(p.Showroom),
        ClientID = p.ClientID
      };
    }
    public static Commande ToLOCAL(this D.Commandes.Commande p)
    {
      return new Commande
      {
        ID = p.ID,
        DateDeCommande = p.DateDeCommande,
        Total = p.Total,
        Acompte = p.Acompte,
        Solde = p.Solde,
        TypeDeCommande = p.TypeDeCommande,
        DetailsCommande = _serviceLigne.GetByCommandeId(p.ID),
        Showroom = ToLOCAL(p.Showroom),
        ClientID = p.ClientID
      };
    }
    public static D.Commandes.CommandeClient ToDAL(this CommandeClient p)
    {
      return new D.Commandes.CommandeClient
      {
        ID = p.ID,
        DateDeCommande = p.DateDeCommande,
        Total = p.Total,
        Acompte = p.Acompte,
        Solde = p.Solde,
        MoyenDePaiement = p.MoyenDePaiement,
        Statut = p.Statut,
        DateDeLivraison = p.DateDeLivraison,
        TypeDeCommande = p.TypeDeCommande,
        Livraison = p.Livraison,
        DetailsCommande = ListConverter(_serviceLigne.GetByCommandeId(p.ID), ToDAL),
        Showroom = ToDAL(p.Showroom),
        ClientID = p.ClientID,
        VendeurID = p.VendeurID
      };
    }
    public static CommandeClient ToLOCAL(this D.Commandes.CommandeClient p)
    {
      return new CommandeClient
      {
        ID = p.ID,
        DateDeCommande = p.DateDeCommande,
        Total = p.Total,
        Acompte = p.Acompte,
        Solde = p.Solde,
        MoyenDePaiement = p.MoyenDePaiement,
        Statut = p.Statut,
        DateDeLivraison = p.DateDeLivraison,
        TypeDeCommande = p.TypeDeCommande,
        Livraison = p.Livraison,
        DetailsCommande = _serviceLigne.GetByCommandeId(p.ID),
        Showroom = ToLOCAL(p.Showroom),
        ClientID = p.ClientID,
        VendeurID = p.VendeurID
      };
    }
    public static D.Commandes.LigneDeCommande ToDAL(this LigneDeCommande p)
    {
      return new D.Commandes.LigneDeCommande
      {
        ID = p.ID,
        TOTAL = p.TOTAL,
        HTVA = p.HTVA,
        TVAC = p.TVAC,
        Quantite = p.Quantite,
        IDCommande = p.IDCommande,
        Product = ToDAL(p.Product)
      };
    }
    public static LigneDeCommande ToLOCAL(this D.Commandes.LigneDeCommande p)
    {
      return new LigneDeCommande
      {
        ID = p.ID,
        TOTAL = p.TOTAL,
        HTVA = p.HTVA,
        TVAC = p.TVAC,
        Quantite = p.Quantite,
        IDCommande = p.IDCommande,
        Product = ToLOCAL(p.Product)
      };
    }
    public static IEnumerable<TOut> ListConverter<TOut, TIn>(IEnumerable<TIn> liste, Func<TIn, TOut> selector)
    {

      foreach (TIn item in liste)
      {
        yield return selector(item);
      }

    }
  }
}
