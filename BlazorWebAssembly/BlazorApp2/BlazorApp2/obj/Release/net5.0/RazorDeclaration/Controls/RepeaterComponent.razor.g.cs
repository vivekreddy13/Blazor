// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp2.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using BlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\_Imports.razor"
using BlazorApp2.Controls;

#line default
#line hidden
#nullable disable
    public partial class RepeaterComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\vivek\OneDrive\Desktop\BlazorWebAssembly\BlazorApp2\BlazorApp2\Controls\RepeaterComponent.razor"
 
    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment<TItem> Row { get; set; }

    [Parameter]
    public RenderFragment Footer { get; set; }

    [Parameter]
    public RenderFragment<TItem> EditTemplate { get; set; }

    [Parameter]
    public List<TItem> Items { get; set; }

    public TItem ItemToEdit { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
