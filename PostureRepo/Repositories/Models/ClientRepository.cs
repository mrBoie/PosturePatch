using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostureRepo.Repository.Interfaces;
using System.Data.Entity;

namespace PostureRepo.Repositories.Models
{
    class ClientRepository : DbContext, IClientRepository
    {
        public bool CreateClient(ClientBO clientToCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientBO> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public ClientBO GetClientByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveClient(ClientBO clientToRemove)
        {
            throw new NotImplementedException();
        }

        public ClientBO UpdateClient(int id, ClientBO clientToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
