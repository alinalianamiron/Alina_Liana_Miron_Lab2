﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alina_Liana_Miron_Lab2.Models;

namespace Alina_Liana_Miron_Lab2.Data
{
    public class Alina_Liana_Miron_Lab2Context : DbContext
    {
        public Alina_Liana_Miron_Lab2Context (DbContextOptions<Alina_Liana_Miron_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Alina_Liana_Miron_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Alina_Liana_Miron_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Alina_Liana_Miron_Lab2.Models.Author>? Author { get; set; }
    }
}
