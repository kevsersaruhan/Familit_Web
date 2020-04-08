using Familit_Web.Modele.Commandes;
using DAL_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class LigneDeCommandeService : IRepository<int, LigneDeCommande>
  {
    public LigneDeCommande Add(LigneDeCommande entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, LigneDeCommande entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<LigneDeCommande> Get()
    {
      throw new NotImplementedException();
    }

    public LigneDeCommande Get(int id)
    {
      throw new NotImplementedException();
    }

    public LigneDeCommande UpdateAndGet(int id, LigneDeCommande entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<LigneDeCommande> GetByCommandeId(int idCommande)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<LigneDeCommande> GetByProductId(int idProduct)
    {
      throw new NotImplementedException();
    }
  }
}
