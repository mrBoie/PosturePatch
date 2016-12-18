using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PostureRepo.Repository_and_BO.dbContext;

namespace PostureRepo.Repository_and_BO
{
    public class ClientRepository : IClientRepository
    {
        public ClientBO CreateClient(ClientBO clientToCreate)
        {
            using (var db = new DatabaseContextContainer())
            {
                var clientEntity = new Client
                {
                    Name = clientToCreate.Name,
                    Description = clientToCreate.Description,
                    DateOfBirth = clientToCreate.DateOfBirth,
                    Gender = (short)clientToCreate.Gender,
                };

                db.ClientSet.Add(clientEntity);

                return clientEntity.toBO();
            }
        }

        public IEnumerable<ClientBO> GetAllClients()
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ClientSet.Select(o=> o.toBO());
            }
        }

        public ClientBO GetClientByID(int id)
        {
            using (var db = new DatabaseContextContainer())
            {
                return db.ClientSet.FirstOrDefault(o => o.Id == id).toBO();
            }
        }

        public bool RemoveClient(ClientBO clientToRemove)
        {
            using (var db = new DatabaseContextContainer())
            {
                var client = db.ClientSet.FirstOrDefault(c => c.Id == clientToRemove.ID);
                if (client == null)
                    return false;

                db.ClientSet.Remove(client);
                db.SaveChanges();
                return true;
            }
        }

        public ClientBO UpdateClient(int id, ClientBO clientToUpdate)
        {
            using (var db = new DatabaseContextContainer())
            {
                var clientEntity = db.ClientSet.FirstOrDefault(c => c.Id == clientToUpdate.ID);

                if (clientEntity == null)
                    return null;

                if (clientToUpdate.Name != null)
                    clientEntity.Name = clientToUpdate.Name;
                if (clientToUpdate.Description != null)
                    clientEntity.Description = clientToUpdate.Description;
                if (clientToUpdate.Gender != 0)
                    clientEntity.Gender = (short)clientToUpdate.Gender;
                if (clientToUpdate.DateOfBirth != null)
                    clientEntity.DateOfBirth = clientToUpdate.DateOfBirth;

                db.SaveChanges();

                return clientEntity.toBO();
            }
        }
    }
}
