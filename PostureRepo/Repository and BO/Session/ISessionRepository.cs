using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    interface ISessionRepository
    {
        IEnumerable<SessionBO> GetAllSessions();
        IEnumerable<SessionBO> GetAllSessionsByClient(ClientBO client);
        SessionBO GetSessionByID(int id);
        bool UpdateSession(SessionBO session);
        bool DeleteSession(SessionBO session);
        bool CreateSession(SessionBO session);
    }
}
