using System.ComponentModel.DataAnnotations;

namespace Tarea4{
    public class Infraccion{
        [Key]
        public int Id {get; set;}
        [Required]
        [StringLength(11)]
        public string Cedula {get; set;}
        [Required]
        [StringLength(100)]
        public string Nombre {get; set;}
        [Required]
        [StringLength(100)]
        public string Apellido {get; set;}
        public string Placa {get; set;}
        public string Marca {get; set;}
        public string Latitud  {get; set;}
        public string Longitud {get; set;}
        public string Descripcion {get; set;}
        public bool pago {get; set;}
    }
}