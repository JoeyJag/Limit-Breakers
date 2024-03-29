﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Limit_Breakers.Models
{
    public class RiotContext:DbContext
    {
        public RiotContext() : base("RiotContext")
        {

        }
        public DbSet<Register> Register { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Games> Games { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}