using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorWASM.Shared.Models.AuthenticationUser
{
    public class AppUser
    {
        [Key]
        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Cellnumber { get; set; } = null!;
        public string Emailid { get; set; } = null!;      
    }
}
