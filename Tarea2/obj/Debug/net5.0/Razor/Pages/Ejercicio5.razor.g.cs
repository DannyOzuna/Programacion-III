#pragma checksum "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37d4c028445edb415c46d4b1f798391744ccd0b"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea2.Pages
{
    #line hidden
    using System;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio5")]
    public partial class Ejercicio5 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center \"><div class=\"col-10 alert alert-primary text-center\"><h2>Ejercicio 5</h2>\n        <p>Programa que acepte un numero del 1 al 100000, mostrarlo en letras. Ejemplo 90 => noventa. (En español)</p></div></div>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card col-6");
            __builder.AddMarkupContent(5, "<h5 class=\"card-header text-center\">Conversión de letra a numero</h5>\n      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.AddMarkupContent(8, "<label>Digite el numero:</label>\n          ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "number");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
                                             valor

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => valor = __value, valor, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n          ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary mt-3");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
                                                         conversion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Convertir");
            __builder.CloseElement();
#nullable restore
#line 17 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
           if(@resultado.Length > 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-danger mt-3 ml-2");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
                                                               limpirar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Limpiar");
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
 if (@resultado.Length > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row justify-content-center mt-3");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-4 alert alert-info text-center");
            __builder.OpenElement(27, "h2");
            __builder.AddContent(28, 
#nullable restore
#line 28 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
                 resultado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio5.razor"
      
    double valor = 0;
    string resultado = "";
    Conversion oConversion = new Conversion();
    private void conversion(){
        resultado = oConversion.enletras(valor);
    }

    private void limpirar(){
        valor = 0;
        resultado = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
