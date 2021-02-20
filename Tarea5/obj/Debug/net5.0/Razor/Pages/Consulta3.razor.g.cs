#pragma checksum "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d584322cf84a84db3e0fb1f3738b17bec14512f4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea5.Pages
{
    #line hidden
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
#line 2 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
using Models.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consulta3")]
    public partial class Consulta3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-8 alert alert-info text-center\"><h1>Ejercicio 3</h1>\r\n      <p>La cantidad de clientes que existen por pais</p></div></div>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(3, "<thead><tr><td>City</td>\r\n            <td>Cantidad</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 20 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
             foreach (var empleado in GetConsulta3())
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 23 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
                         empleado.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
                         empleado.count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\danny\Desktop\Programacion-III\tarea5\Pages\Consulta3.razor"
       
    List<DataConsulta3> GetConsulta3() => (from e in new northwindContext().Employees
                                            group e by e.City  into r
                                            select new DataConsulta3{
                                                name = r.Key, 
                                                count = r.Count()
                                            }).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
