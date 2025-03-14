using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadordeClinicas.Core.Entities.Enum;

namespace GerenciadordeClinicas.Core.Entities
{
    public class Attendance : BaseEntities
    {
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }
        public int IdService { get; set; }
        public Service Service { get; set; }
        public int IdDoctor { get; set; }
        public Doctor Doctor { get; set; }
        public string? Covenant { get; set; }
        public DateTime AttendanceStartAt { get; set; }
        public DateTime AttendanceFinishAt { get; set; }
        public TypeAttendanceEnum AttendanceType { get; set; }
    }
}
