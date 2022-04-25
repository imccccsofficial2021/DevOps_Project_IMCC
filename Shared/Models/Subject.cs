using System;
using System.Collections.Generic;

namespace MudBlazorWASM.Shared.Models
{

    public partial class Subject
    {
        public Subject()
        {
            Egrades = new HashSet<Egrade>();
        }

        public int Id { get; set; }
        public string SubjectCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string LecUnits { get; set; } = null!;
        public string LabUnits { get; set; } = null!;
        public string TotUnits { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string PreRequisite { get; set; } = null!;

        public virtual ICollection<Egrade> Egrades { get; set; }
    }
}
