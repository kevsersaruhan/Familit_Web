using DAL_API.Repository.UserRepository;
using Familit_Web.Modele.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class PersonnelService : IPersonnelRepository<int, Personnel>
  {
    public bool Activer(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public Personnel Add(Personnel entity)
    {
      throw new NotImplementedException();
    }

    public bool ChangePassword(int id, string s, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public void CheckPersonnel(int id, string login, string password, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public bool Desactiver(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public bool DoAdmin(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Personnel> Get()
    {
      throw new NotImplementedException();
    }

    public Personnel Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Personnel> GetPersonnelByShowroom(int idShowroom)
    {
      throw new NotImplementedException();
    }

    public bool UnsetAdmin(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public Personnel UpdateAndGet(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }
  }
}
