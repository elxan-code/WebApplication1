using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class VmLogin
    {
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
