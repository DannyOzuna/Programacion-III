// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Tarea3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danny/Desktop/Programacion/Tarea3/_Imports.razor"
using Tarea3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danny/Desktop/Programacion/Tarea3/Pages/Ejercicio6.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danny/Desktop/Programacion/Tarea3/Pages/Ejercicio6.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio6")]
    public partial class Ejercicio6 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/danny/Desktop/Programacion/Tarea3/Pages/Ejercicio6.razor"
      
    string errores = "";
    DatosYoutube rs = null;
    bool validar =  false;
    private async Task obtener(){
        validar =  true;
        rs = await Http.GetFromJsonAsync<DatosYoutube>(("https://www.googleapis.com/youtube/v3/search?key=AIzaSyB5BFlhHvcKpQnLXlAZXnWDmaDTgIwOfcs&channelId=UCQgqPr74n5FlllbAGORhX-g&part=snippet,id&order=date&maxResults=5"));

        if(rs.pageInfo.totalResults > 0){
            validar = false;

        }else{
            validar = false;
            errores = "No se encontro resultados";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591