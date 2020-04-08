using DAL_API.Repository.ProduitRepository;
using Familit_Web.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class CategorieService : ICategorieRepository<int, Categorie>
  {
    public bool Activer(int id, Categorie entity)
    {
      throw new NotImplementedException();
    }

    public Categorie Add(Categorie entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Categorie entity)
    {
      throw new NotImplementedException();
    }

    public bool Desactiver(int id, Categorie entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categorie> Get()
    {
      throw new NotImplementedException();
    }

    public Categorie Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categorie> GetCategorieByName(string s)
    {
      throw new NotImplementedException();
    }

    public Categorie UpdateAndGet(int id, Categorie entity)
    {
      throw new NotImplementedException();
    }
  }
}
