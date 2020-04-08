
using DAL_API.Repository.EtablissementRepository;
using DAL_API.Services;
using Familit_Web.Modele.Etablissements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class ShowroomService : IShowroomRepository<int, Showroom>
  {
    private ShowroomRepository _repo = new ShowroomRepository();
    public bool Activer(int id, Showroom entity)
    {
      return _repo.Activer(id, entity);
    }

    public Showroom Add(Showroom entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Showroom entity)
    {
      throw new NotImplementedException();
    }

    public bool Desactiver(int id, Showroom entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Showroom> Get()
    {
      throw new NotImplementedException();
    }

    public Showroom Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Showroom> GetShowroomByName(string name)
    {
      throw new NotImplementedException();
    }

    public Showroom UpdateAndGet(int id, Showroom entity)
    {
      throw new NotImplementedException();
    }
  }
}
