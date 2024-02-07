using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User : IdentityUser<int>
    {
        public int Age { get; set; }
        public Level Level { get; set; }
    }
}
