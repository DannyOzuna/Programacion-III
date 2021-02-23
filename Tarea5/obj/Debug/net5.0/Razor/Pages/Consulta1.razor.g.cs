#pragma checksum "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf6f447d1be5e2693a94458693826097bd0253ef"
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
#line 1 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Tarea5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\Programacion-III\Tarea5\_Imports.razor"
using Tarea5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
using Models.DB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/consulta1")]
    public partial class Consulta1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-8 alert alert-info text-center\"><h1>Ejercicio 1</h1>\r\n      <p>Listado de los empleados, nombre, apellido y Telefono</p></div></div>\r\n\r\n");
            __builder.OpenComponent<Tarea5.Pages.Filtro>(1);
            __builder.AddAttribute(2, "nombre", "Nombre");
            __builder.AddAttribute(3, "buscarTexto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
                                     buscarTexto

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __Blazor.Tarea5.Pages.Consulta1.TypeInference.CreateTablaComponente_0(__builder, 5, 6, 
#nullable restore
#line 13 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
                        filtrar

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "<th>Id</th>\r\n        ");
                __builder2.AddMarkupContent(9, "<th>Nombre</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>Apellido</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>Telefono</th>");
            }
            , 12, (empleado) => (__builder2) => {
                __builder2.OpenElement(13, "td");
                __builder2.AddContent(14, 
#nullable restore
#line 21 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
             empleado.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 22 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
             empleado.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 23 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
             empleado.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
             empleado.HomePhone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\danny\Desktop\Programacion-III\Tarea5\Pages\Consulta1.razor"
      
    public List<Employee> filtrar = (from d in new northwindContext().Employees
                                        select d).ToList();
    public void buscarTexto(ChangeEventArgs changeEventArgs){
        string buscarText = changeEventArgs.Value.ToString();
        filtrar = new northwindContext().Employees.Where(e => e.FirstName.Contains(buscarText) || e.LastName.Contains(buscarText) || e.HomePhone.Contains(buscarText)).ToList();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Tarea5.Pages.Consulta1
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTablaComponente_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::Tarea5.Pages.TablaComponente<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "TableBody", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591