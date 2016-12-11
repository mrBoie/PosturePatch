using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repositorys
{
    interface IClientRepository
    {
        IEnumerable<ClientBO> GetClients();
        ClientBO GetClient(int id);
        bool RemoveClient(ClientBO clientToRemove);
        ClientBO UpdateClient(int id, ClientBO clientToUpdate);
        bool CreateClient(ClientBO clientToCreate);
    }
}
