using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    interface IClientRepository
    {
        IEnumerable<ClientBO> GetAllClients();
        ClientBO GetClientByID(int id);
        bool RemoveClient(ClientBO clientToRemove);
        ClientBO UpdateClient(int id, ClientBO clientToUpdate);
        bool CreateClient(ClientBO clientToCreate);
    }
}
