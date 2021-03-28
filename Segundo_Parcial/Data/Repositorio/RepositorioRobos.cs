using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Segundo_Parcial.Models;
using Microsoft.EntityFrameworkCore;

namespace Segundo_Parcial.Data.Repositorio{
    public class RepositorioRobos : IRepositorioRobos{
        public readonly AppDbContext context;

        public RepositorioRobos(AppDbContext context){
            this.context = context;
        }
        public async Task<List<Tb_robos>> GetTb_Robos(){
            return await context.tb_Robos.ToListAsync();
        }
    }
}