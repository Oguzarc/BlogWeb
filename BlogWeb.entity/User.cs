﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogWeb.entity
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
    }
}
