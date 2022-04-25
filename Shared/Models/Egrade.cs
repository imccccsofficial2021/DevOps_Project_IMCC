using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    [Serializable]
    public partial class Egrade
    {
        [Key]
        public int Id { get; set; }
        public string StudentNo { get; set; } = null!;
        public string StudentName { get; set; } = null!;
        public int SubjectCodeId { get; set; }
        public string Description { get; set; } = null!;
        public string OfferNo { get; set; } = null!;
        public string TotUnits { get; set; } = null!;
        public string Day { get; set; } = null!;
        public string Time { get; set; } = null!;
        public string Semester { get; set; } = null!;
        public string Syear { get; set; } = null!;
        public int DepartmentsId { get; set; }

     //   public virtual Department Departments { get; set; } = null!;
        public virtual Subject SubjectCode { get; set; } = null!;
    }
}
