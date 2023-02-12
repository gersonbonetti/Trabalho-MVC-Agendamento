using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Patient>? PatientList { get; set; }
    }
}
