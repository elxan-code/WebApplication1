using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class VmRegister
    {
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RepeatPassword { get; set; }
    }
}
