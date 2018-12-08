﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // table name in sql (conventional to pluralize)
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
