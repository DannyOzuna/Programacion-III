using System;
using Microsoft.EntityFrameworkCore;
using Segundo_Parcial.Models;

namespace Segundo_Parcial.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<Tb_robos> tb_Robos {get; set;}
    }
}
