#pragma checksum "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d12aaf4a238328213cf80496dc6a4ef962f4fb"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio2")]
    public partial class Ejercicio2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center \"><div class=\"col-10 alert alert-primary text-center\"><h2>Ejercicio 2</h2>\n        <p>Programa que muestre todos los datos de un usuario random users: https://randomuser.me/api/?results=1</p></div></div>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn btn-outline-success btn-lg");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                                                              GetDatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Generar");
            __builder.CloseElement();
#nullable restore
#line 12 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
 if(datos.Count > 0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row justify-content-center");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card text-center");
            __builder.AddAttribute(9, "style", "width: 18rem;");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "card-img-top");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 15 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                                          url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n          ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, 
#nullable restore
#line 18 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                 nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, " <br>\n                Usuario: ");
            __builder.AddContent(21, 
#nullable restore
#line 19 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                          user

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, " <br>\n                Contraceña: ");
            __builder.AddContent(23, 
#nullable restore
#line 20 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                             pass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, " <br>\n                Telefono: ");
            __builder.AddContent(25, 
#nullable restore
#line 21 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                           phone

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, " <br>\n                Celular: ");
            __builder.AddContent(27, 
#nullable restore
#line 22 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                          cel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " <br>\n                Email: ");
            __builder.AddContent(29, 
#nullable restore
#line 23 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
                        email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio2.razor"
      
    ConsumirApi api = new ConsumirApi();
    string nombre="", url="",user="", pass="", phone="", cel ="", email="";
    List<Result> datos = new List<Result>();
    private void GetDatos(){
        datos = api.obtenerDatos();
        foreach(var persona in datos){
            nombre = persona.name.title +". "+ persona.name.first +" "+  persona.name.last;
            url = persona.picture.large;
            user = persona.login.username;
            pass = persona.login.password;
            phone = persona.phone;
            cel = persona.cell;
            email = persona.email;
            break;
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
