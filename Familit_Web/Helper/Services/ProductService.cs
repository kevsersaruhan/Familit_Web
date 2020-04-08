using DAL_API.Repository.ProduitRepository;
using Familit_Web.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class ProductService : IProductRepository<int, Produit>
  {
    public bool Activer(int id, Produit entity)
    {
      throw new NotImplementedException();
    }

    public Produit Add(Produit entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Produit entity)
    {
      throw new NotImplementedException();
    }

    public bool Desactiver(int id, Produit entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> Get()
    {
      throw new NotImplementedException();
    }

    public Produit Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductByFournisseur(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductByName(string s)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductFav(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductListByCaracteristique(int idcaract)
    {
      throw new NotImplementedException();
    }

    public Produit UpdateAndGet(int id, Produit entity)
    {
      throw new NotImplementedException();
    }
  }
}
