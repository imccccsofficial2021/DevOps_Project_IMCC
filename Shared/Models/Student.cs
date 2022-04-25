using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{
    [Serializable]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentNo { get; set; } = null!;
        public string StudentName { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public string Birthdate { get; set; } = null!;
        public string FathersName { get; set; } = null!;
        public string MothersName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Age { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Religion { get; set; } = null!;
    }
}
