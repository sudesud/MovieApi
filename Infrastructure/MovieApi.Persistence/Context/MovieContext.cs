﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;

namespace MovieApi.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SANANE\\SQLEXPRESS;initial Catalog=ApiMovieDb; integrated Security=true;TrustServerCertificate=true");


        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Movie>Movies { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Cast> Casts { get; set; }






    }
}
