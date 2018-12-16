using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class LoginRequest
    {
        public string mail { get; set; }
        public string password { get; set; }
    }
}