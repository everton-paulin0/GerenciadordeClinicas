using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadordeClinicas.Core.Entities.Enum;

namespace GerenciadordeClinicas.Core.Entities
{
    public class Patient : BaseEntities
    {
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientBorn { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public string PatientCPF { get; set; }
        public TypeBloodEnum PatientBloodType { get; set; }
        public string Patientaddress { get; set; }
        public int PatientNumberAddress { get; set; }
        public string PatientComplement { get; set; }
        public string PatientCity { get; set; }
        public States PatientStates { get; set; }
        public string PatientPostalCode { get; set; }
    }
}
