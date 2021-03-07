using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationSystem.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string School { get; set; }
    }
}
