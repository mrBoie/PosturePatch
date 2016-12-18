using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using PostureRepo.Repository_and_BO.Client;

//namespace PostureRepo.Repositories.Models
//{
//    class ClientRepository : DbContext, IClientRepository
//    {
//        public ClientRepository()
//        {

//        }

//        public bool CreateClient(ClientBO clientToCreate)
//        {
//            using (var db = new DatabaseContext())
//            {
//                db.Clients.Add(clientToCreate);
//                db.SaveChanges();
//            }
//            return true;
//        }

//        public IEnumerable<ClientBO> GetAllClients()
//        {
//            using (var db = new DatabaseContext())
//            {
//                return db.Clients.ToList();
//            }
//        }

//        public ClientBO GetClientByID(int id)
//        {
//            using (var db = new DatabaseContext())
//            {
//                return db.Clients.FirstOrDefault(client => client.ID == id);
//            }
//        }

//        public bool RemoveClient(ClientBO clientToRemove)
//        {
//            using (var db = new DatabaseContext())
//            {
//                var client = db.Clients.FirstOrDefault(c => c.ID == clientToRemove.ID);
//                if (client == null)
//                    return false;

//                db.Clients.Remove(client);
//                db.SaveChanges();
//                return true;
//            }
//        }

//        public ClientBO UpdateClient(int id, ClientBO clientToUpdate)
//        {
//            using (var db = new DatabaseContext())
//            {
//                var client = db.Clients.FirstOrDefault(c => c.ID == clientToUpdate.ID);

//                if (client == null)
//                    return null;
//            }
//        }
//    }
//}
