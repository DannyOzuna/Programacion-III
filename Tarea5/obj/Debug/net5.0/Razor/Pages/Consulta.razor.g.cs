#pragma checksum "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3b2f3e354814a517ae7a16699dc459585c3347"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Tarea5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\Programacion-III\tarea5\_Imports.razor"
using Tarea5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
using Models.DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consulta1")]
    public partial class Consulta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-8 alert alert-info text-center\"><h1>Ejercicio 1</h1>\r\n      <p>Listado de los empleados, nombre, apellido y Telefono</p></div></div>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(3, "<thead><tr><th>Id</th>\r\n            <th>Nombre</th>\r\n            <th>Apellido</th>\r\n            <th>Telefono</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 21 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
         foreach (var empleado in GetEmployees())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
                     empleado.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 25 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
                     empleado.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
                     empleado.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
                     empleado.HomePhone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta.razor"
      
    List<Employee> GetEmployees() => (from d in new northwindContext().Employees
                                        select d).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
