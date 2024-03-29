﻿using System;

namespace CoderaShopping.Business
{
    public class LookupViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        
    }

    public class IdentityLookupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}