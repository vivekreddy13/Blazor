// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.BaseComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Index.razor"
       
    IndexViewModel person = null;
    int selectedGroup = 1;
    int selectedLocationId = 1;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        person = new IndexViewModel
        {
            SalesPerson = "Alex",
            Amount = 15000,
            Locations = new List<Location>
                {
                    new Location { Id = 1, City = "Toronto", ProvState = "Ontario", Country = "Canada" },
                    new Location { Id = 2, City = "Montreal", ProvState = "Quebec", Country = "Canada" }
                }


        };
    }

    #region "View Model"

    class IndexViewModel
    {
        public string SalesPerson { get; set; }
        public double Amount { get; set; }
        public bool isActive { get; set; }
        public List<Location> Locations;
    }

    class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string ProvState { get; set; }
        public string Country { get; set; }
    }

    #endregion

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
