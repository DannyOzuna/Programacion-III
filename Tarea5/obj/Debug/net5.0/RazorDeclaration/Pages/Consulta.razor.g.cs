// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Tarea5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\Programacion\Tarea5\_Imports.razor"
using Tarea5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\Programacion\Tarea5\Pages\Consulta.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\danny\Desktop\Programacion\Tarea5\Pages\Consulta.razor"
      
    //List<Employee> GetEmployees() => new northwindContext().Employees(e => e.FirstName).ToList();
    List<Employee> GetEmployees() => (from d in new northwindContext().Employees
                                        select d).ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591