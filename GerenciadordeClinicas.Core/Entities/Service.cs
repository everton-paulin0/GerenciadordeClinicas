using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadordeClinicas.Core.Entities
{
    public class Service : BaseEntities
    {
        public Service(string serviceName, string servicedescription, double value, DateTime duration)
        {
            ServiceName = serviceName;
            Servicedescription = servicedescription;
            Value = value;
            Duration = duration;
            OwnedUser = [];
        }

        public string ServiceName { get; set; }
        public string Servicedescription { get; set; }
        public double Value { get; set; }
        public DateTime Duration { get; set; }
        public List<User> OwnedUser { get; private set; }
    }
}
