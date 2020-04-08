
using DAL_API.Repository.ProduitRepository;
using Familit_Web.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class CaracteristiqueService : ICaracteristiqueRepository<int, Caracteristique>
  {
    public Caracteristique Add(Caracteristique entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Caracteristique entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> Get()
    {
      throw new NotImplementedException();
    }

    public Caracteristique Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByCategorie(int idcat)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByProduct(int idproduct)
    {
      throw new NotImplementedException();
    }

    public Caracteristique UpdateAndGet(int id, Caracteristique entity)
    {
      throw new NotImplementedException();
    }
  }
}
