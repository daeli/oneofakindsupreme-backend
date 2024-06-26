﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Infrastructure.Data.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Backend.Infrastructure.Data.EF
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        
        }

        public DbSet<Project> Projects { get; set; }
    }
}
