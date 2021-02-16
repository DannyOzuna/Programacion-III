using System;

public class ObtenerCalificacion{
    public string calcular(double cal){
        double num1=0, num2=0, num3=0, res=0;
        Random random = new Random();
        while(res != cal){
            num1 = random.Next(41);
            num2 = random.Next(31);
            num3 = random.Next(31);
            res = num1 + num2 + num3;
        }

        if(cal >= 90){
            return $"A => {num1}, {num2}, {num3}";
        }else if(cal >= 80){
            return $"B => {num1}, {num2}, {num3}";
        }else if(cal >= 70){
            return $"C => {num1}, {num2}, {num3}";
        }else{
            return $"F => {num1}, {num2}, {num3}";
        }
    }
}