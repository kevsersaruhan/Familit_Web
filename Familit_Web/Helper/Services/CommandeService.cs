using Familit_Web.Modele.Commandes;
using DAL_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class CommandeService : IRepository<int, Commande>
  {
    public Commande Add(Commande entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Commande entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Commande> Get()
    {
      throw new NotImplementedException();
    }

    public Commande Get(int id)
    {
      throw new NotImplementedException();
    }

    public Commande UpdateAndGet(int id, Commande entity)
    {
      throw new NotImplementedException();
    }
  }
}
