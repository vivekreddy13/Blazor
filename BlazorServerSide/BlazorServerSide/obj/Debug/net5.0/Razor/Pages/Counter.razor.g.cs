#pragma checksum "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada974545528a9ffee893dbedb87254d004f64c9"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorServerSide.Pages.Counter.TypeInference.CreateCascadingValue_0(__builder, 0, 1, "Counter", 2, 
#nullable restore
#line 1 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                       currentCount

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __Blazor.BlazorServerSide.Pages.Counter.TypeInference.CreateCascadingValue_1(__builder2, 4, 5, "TitleColor", 6, 
#nullable restore
#line 2 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                               "blue"

#line default
#line hidden
#nullable disable
                , 7, 
#nullable restore
#line 2 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                , 8, (__builder3) => {
                    __builder3.OpenComponent<BlazorServerSide.Controls.CounterComponent1>(9);
                    __builder3.CloseComponent();
                }
                );
            }
            );
            __builder.AddMarkupContent(10, "\r\n<br>\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                 (()=>
                                 {
                                     child.Show();

                                 })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n    Show Child\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenComponent<BlazorServerSide.Controls.ChildComponent>(21);
            __builder.AddComponentReferenceCapture(22, (__value) => {
#nullable restore
#line 17 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                      child = (BlazorServerSide.Controls.ChildComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                                 (()=>
                                 {
                                     dialog.Show();

                                 })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n    Show Dialog\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenComponent<BlazorServerSide.Controls.DialogComponent>(29);
            __builder.AddComponentReferenceCapture(30, (__value) => {
#nullable restore
#line 27 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
                       dialog = (BlazorServerSide.Controls.DialogComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n<br>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\vivek\OneDrive\Desktop\BlazorServerSide\BlazorServerSide\Pages\Counter.razor"
       
    [Parameter]
    public EventCallback<int> SetCurrentCount { get; set; }

    [Parameter]
    public Action<int> SetCount { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
        SetCurrentCount.InvokeAsync(currentCount);
    }

    private ChildComponent child;
    private DialogComponent dialog;


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorServerSide.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
