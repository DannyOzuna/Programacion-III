using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Segundo_Parcial.Models;

namespace Segundo_Parcial.Data.Repositorio{
    public interface IRepositorioRobos{
        public Task<List<Tb_robos>> GetTb_Robos();

        public Task<Tb_robos> Add(Tb_robos oRobos);
    }
}