using System;

public class TrianguloServices{
    public string calcular(Triangulo oTriangulo){
        double lado1 = oTriangulo.lado1, lado2 = oTriangulo.lado2, lado3 = oTriangulo.lado3;
        if((lado1 == lado2) && (lado1 == lado3) && (lado2 == lado3)){
            return "Equilatero";
        }else if((lado1 != lado2) && (lado1 != lado3) && (lado2 != lado3)){
            return "Isosceles";
        }else{
            return "Escaleno";
        }
    }
}