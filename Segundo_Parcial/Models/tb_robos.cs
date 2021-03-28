using System;
using System.ComponentModel.DataAnnotations;

namespace Segundo_Parcial.Models{
    public class Tb_robos {
        [Key]
        public int id {get; set;}
        public string cedula {get; set;}
        public string fecha {get; set;}
        public string info_robo {get; set;}
        public decimal valor {get; set;}
        public string lugar {get; set;}
        public int? latitud {get; set;}
        public int? longitud {get; set;}

    }
}