using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Patient
    {
        public int Id { get; set; }
        public int? ConditionId { get; set; }
        public virtual Condition? Condition { get; set; }
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public int? MRNumber { get; set; }

        public ICollection<Service>? Service { get; set; }
        public ICollection<Schedule>? Schedule { get; set; }
    }
}
