﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
