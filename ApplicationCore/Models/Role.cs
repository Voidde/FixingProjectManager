﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string? Name { get; set; }
    }
}
