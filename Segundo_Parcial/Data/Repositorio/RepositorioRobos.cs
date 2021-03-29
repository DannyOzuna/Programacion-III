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

        public async Task<Tb_robos> GetTb_Robos(string cedula){
            var rs = await context.tb_Robos.FirstOrDefaultAsync(r => r.cedula == cedula);
            if(rs != null){
                return rs;
            }else{
                return null;
            }
        }

        public async Task<Tb_robos> Add(Tb_robos oRobos){
            if(oRobos != null){
                var existe = await context.tb_Robos.FirstOrDefaultAsync(r => r.cedula == oRobos.cedula);
                if(existe != null){
                    return null;
                }else{
                    await context.AddAsync(oRobos);
                    await context.SaveChangesAsync();
                }
                return oRobos;
            }else{
                return new Tb_robos();
            }
        }

        public async Task<Tb_robos> Update(int id, Tb_robos oRobos){
            var oRobosdb = await context.tb_Robos.FindAsync(id);
            oRobosdb.nombre = oRobos.nombre;
            oRobosdb.cedula = oRobos.cedula;
            oRobosdb.fecha = oRobos.fecha;
            oRobosdb.lugar = oRobos.lugar;
            oRobosdb.valor = oRobos.valor;
            oRobosdb.info_robo = oRobos.info_robo;
            oRobosdb.latitud = oRobos.latitud;
            oRobosdb.longitud = oRobosdb.longitud;
            await context.SaveChangesAsync();
            return oRobosdb;
        }
    }
}