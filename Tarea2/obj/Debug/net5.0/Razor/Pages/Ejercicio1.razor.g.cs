#pragma checksum "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5059c2710a8d2e02c469d1a09a6d8d3369c906a6"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio1")]
    public partial class Ejercicio1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row justify-content-center ""><div class=""col-10 alert alert-primary text-center""><h2>Ejercicio 1</h2>
        <p>Programa que acepte una frase u oración, luego muestre la cantidad de vocales, espacios y consonantes que tiene la misma.</p></div></div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card text-center col-6");
            __builder.AddMarkupContent(5, "<h5 class=\"card-header\">\n          Escriba la Frase u Oración\n      </h5>\n      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control mb-3");
            __builder.AddAttribute(11, "placeholder", "Escriba la frase aquí...");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                                                    frase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => frase = __value, frase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                        calcular

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddContent(19, "Calcular");
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
         if (mostrar == true)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                            limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "ml-1 btn btn-danger");
            __builder.AddContent(24, "Limpiar");
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n      ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-footer text-muted");
#nullable restore
#line 25 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
           if (mostrar == true)
          {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, "Cantidad de vocales: ");
            __builder.AddContent(30, 
#nullable restore
#line 27 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                     voc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, "Cantidad de espacios: ");
            __builder.AddContent(34, 
#nullable restore
#line 28 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                      esp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.OpenElement(36, "p");
            __builder.AddContent(37, "Cantidad de consonantes: ");
            __builder.AddContent(38, 
#nullable restore
#line 29 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
                                         cons

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 30 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "<p>Creado por Danny Ozuna Vasquez&copy;</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio1.razor"
 
    string frase="", frasex="";
    int voc=0, esp=0, cons=0, i=0; 
    bool mostrar = false;

    void calcular(){
        //Aqui estoy preparando los arrgles
        var vocales = new[] {'A','E', 'I','O', 'U'};
        var consonantes = new[] {'B', 'C', 'D', 'F', 'G','H','J','K','L','M','N','Ñ','P','Q','R','S','T','V','W','X','Y','Z'};
        var espacios = new[] {' '};

        //Convirtiendo los frase obtenida en mayusculas
        frasex = frase.ToUpper();

        //Recorriendo en arreglo de vocales
        foreach(var vocal in vocales){
            i += frasex.Count(x => x == vocal);
        }
        voc = i;
        i=0;

        //Recorriendo en arreglo de consonates
        foreach(var consonante in consonantes){
            i += frasex.Count(x => x == consonante);
        }
        cons= i;
        i=0;

        //Recorriendo en arrglo de espacios
        foreach(var espacio in espacios){
            i += frasex.Count(x => x == espacio);
        }
        esp = i;
        i=0;
        mostrar = true;
    }

    void limpiar(){
        mostrar = false;
        frase = "";
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
