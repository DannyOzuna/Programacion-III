using System;
using System.ComponentModel.DataAnnotations;

public class Triangulo{

    [Range(1,99999,ErrorMessage = "El campo debe ser mayor a 0")]
    public double lado1 {get; set;}

    [Range(1,99999,ErrorMessage = "El campo debe ser mayor a 0")]
    public double lado2 {get; set;}

    [Range(1,99999,ErrorMessage = "El campo debe ser mayor a 0")]
    public double lado3 {get; set;}
}