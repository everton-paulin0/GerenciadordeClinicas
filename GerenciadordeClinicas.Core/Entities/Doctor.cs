using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadordeClinicas.Core.Entities.Enum;

namespace GerenciadordeClinicas.Core.Entities
{
    public class Doctor : BaseEntities
    {
        public Doctor(string doctorName, string doctorLastName, DateTime doctorBorn, string doctorPhone, string doctoremail, string doctorCPF, TypeBloodEnum doctorbloodType, string doctoraddress, int doctorNumberAddress, string doctorComplement, string doctorCity, States doctorStates, string doctorPostalCode)
        {
            DoctorName = doctorName;
            DoctorLastName = doctorLastName;
            DoctorBorn = doctorBorn;
            DoctorPhone = doctorPhone;
            DoctorEmail = doctoremail;
            DoctorCPF = doctorCPF;
            DoctorBloodType = doctorbloodType;
            Doctoraddress = doctoraddress;
            DoctorNumberAddress = doctorNumberAddress;
            DoctorComplement = doctorComplement;
            DoctorCity = doctorCity;
            DoctorStates = doctorStates;
            DoctorPostalCode = doctorPostalCode;
        }

        public string DoctorName { get; set; }
        public string DoctorLastName { get; set; }
        public DateTime DoctorBorn { get; set; }
        public string DoctorPhone { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorCPF { get; set; }
        public string CRM { get; set; }
        public string Especiality { get; set; }
        public TypeBloodEnum DoctorBloodType { get; set; }
        public string Doctoraddress { get; set; }
        public int DoctorNumberAddress { get; set; }
        public string DoctorComplement { get; set; }
        public string DoctorCity { get; set; }
        public States  DoctorStates { get; set; }
        public string DoctorPostalCode { get; set; }

    }
}
