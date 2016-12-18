using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureRepo.Repository_and_BO
{
    class SessionBO
    {
        public int ID { get; set; }
        public DateTime SessionDate { get; set; }
        public int SessionLength { get; set; }
        public string Notes { get; set; }
    }
}
