﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeuTrabalho.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
