// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio7")]
    public partial class Ejercicio7 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "/Users/danny/Desktop/Programacion/Tarea2/Pages/Ejercicio7.razor"
      
    ObtenerCalificacion oCalificacion;
    string error = "", rel="";
    double cal = 0;

    private void calcular(){
        if(cal > 100){
            error = "Calificación máxima: 100";
        }else{
            error = "";
            oCalificacion = new ObtenerCalificacion();
            rel = oCalificacion.calcular(cal);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591