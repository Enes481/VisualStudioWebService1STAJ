﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EDMTAPIAuthentication3.Models
{
    public partial class TblUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
