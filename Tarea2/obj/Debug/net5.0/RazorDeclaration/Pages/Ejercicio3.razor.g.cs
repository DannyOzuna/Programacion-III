// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea2.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Tarea2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danny/Desktop/Programacion/Tarea2/_Imports.razor"
using Tarea2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio3.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio3")]
    public partial class Ejercicio3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio3.razor"
      
    //Declaracion de la Varibles
    string cedula= "";
    string errores = "";
    bool validacion = false;
    //* Método o función para validar una cédula dominicana*
    public void ValidaCedula(){
        //Declaración de variables a nivel de método o función.
        errores = "";
        validacion = false;
        int verificador = 0;
        int digito = 0;
        int digitoVerificador=0;
        int digitoImpar = 0;
        int sumaPar = 0;
        int sumaImpar = 0;
        int longitud = Convert.ToInt32(cedula.Length);
        /*Control de errores en el código*/
        try
        {
            //verificamos que la longitud del parametro sea igual a 11
            if (longitud == 11)
            {
             digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
               //recorremos en un ciclo for cada dígito de la cédula
               for (int i = 9; i >= 0; i--)
               {
                   //si el digito no es par multiplicamos por 2
                   digito = Convert.ToInt32(cedula.Substring(i, 1));
                   if ((i % 2) != 0)
                  {
                       digitoImpar = digito * 2;
                       //si el digito obtenido es mayor a 10, restamos 9
                       if (digitoImpar >= 10)
                       {
                           digitoImpar = digitoImpar - 9;
                       }
                       sumaImpar = sumaImpar + digitoImpar;
                   }
                   /*En los demás casos sumamos el dígito y lo aculamos 
                    en la variable */
                    else
                    {
                        sumaPar = sumaPar + digito;
                    }
                }
               /*Obtenemos el verificador restandole a 10 el modulo 10 
               de la suma total de los dígitos*/
               verificador = 10 - ((sumaPar + sumaImpar) % 10);
             /*si el verificador es igual a 10 y el dígito verificador
               es igual a cero o el verificador y el dígito verificador 
               son iguales retorna verdadero*/
          if (((verificador == 10) && (digitoVerificador == 0))
               || (verificador == digitoVerificador))
               {
                    validacion = true;
               }else{
                   errores = "Cedula Invalida!...";
               }
           }
           else
          {
           errores = "La cedula debe contener once(11) digitos";
          }
       }
      catch
       {
           errores += "No se pudo validar la cédula";
       }
    }
    public void limpiar(){
        errores = "";
        cedula = "";
        validacion = false;
    }
    
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
