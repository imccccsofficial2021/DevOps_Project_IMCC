using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MudBlazorWASM.Shared.Models
{

    public partial class SummaryGrade
    {
        [Key]
        public int Id { get; set; }
        public int? Deptno { get; set; }
        public int Offerno { get; set; }
        public string Courseno { get; set; } = null!;
        public int Studno { get; set; }
        public string Last { get; set; } = null!;
        public string First { get; set; } = null!;
        public string? Mi { get; set; }
        public double? Term1 { get; set; }
        public double? Term2 { get; set; }
        public double? Term3 { get; set; }
        public double? Term4 { get; set; }
        public double? Average { get; set; }
        public string Subject { get; set; } = null!;
    }
}
