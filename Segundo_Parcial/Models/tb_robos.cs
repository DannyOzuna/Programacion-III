using System;
using System.ComponentModel.DataAnnotations;

namespace Segundo_Parcial.Models{
    public class Tb_robos {
        [Key]
        public int id {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string nombre {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string cedula {get; set;}
        public DateTime fecha {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string info_robo {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public decimal valor {get; set;}
        [Required (ErrorMessage = "Campo Vacío")]
        public string lugar {get; set;}
        public string latitud {get; set;}
        public string longitud {get; set;}

    }
}