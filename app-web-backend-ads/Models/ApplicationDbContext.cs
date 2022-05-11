﻿using Microsoft.EntityFrameworkCore;

namespace app_web_backend_ads.Models
{
       public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
