﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyYoungAlumDataLib
{
    public class SiteUser
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
