using DAL_API.Repository.UserRepository;
using Familit_Web.Modele.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Familit_Web.Helper.Services
{
  public class ClientService : IClientRepository<int, Client>
  {
    public bool Activer(int id, Client entity)
    {
      throw new NotImplementedException();
    }

    public Client Add(Client entity)
    {
      throw new NotImplementedException();
    }

    public bool ChangePassword(int id, string password, Client entity)
    {
      throw new NotImplementedException();
    }

    public bool CheckClient(int id, string login, string password, Client entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Client entity)
    {
      throw new NotImplementedException();
    }

    public bool Desactiver(int id, Client entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> Get()
    {
      throw new NotImplementedException();
    }

    public Client Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> GetByName(string name)
    {
      throw new NotImplementedException();
    }

    public Client UpdateAndGet(int id, Client entity)
    {
      throw new NotImplementedException();
    }
  }
}
