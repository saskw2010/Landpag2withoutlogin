#pragma checksum "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b71a9a5112e667156cb35e1724e6168a99cec1"
// <auto-generated/>
#pragma warning disable 1591
namespace Landpag2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Landpag2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
using Landpag2.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : Landpag2.Layouts.MainLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenTooltip>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContextMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenHeader>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row justify-content-start align-items-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-6 d-flex align-items-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSidebarToggle>(14);
                __builder2.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.EventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 16 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                     SidebarToggle0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                __builder2.AddAttribute(18, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                            L["label0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n      ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-6 text-right");
                __Blazor.Landpag2.Shared.MainLayout.TypeInference.CreateRadzenDropDown_0(__builder2, 22, 23, 
#nullable restore
#line 22 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                new[] { new { Text="Arabic", Value="ar" },new { Text="English", Value="en" }}

#line default
#line hidden
#nullable disable
                , 24, "Text", 25, "Value", 26, "Dropdown1", 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 22 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                                                                                                                                                                                           Dropdown1Change

#line default
#line hidden
#nullable disable
                ), 28, 
#nullable restore
#line 22 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                                                                                                                                                        Culture

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Culture = __value, Culture)), 30, () => Culture);
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenBody>(32);
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenContentContainer>(34);
                __builder2.AddAttribute(35, "Name", "main");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 31 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
__builder3.AddContent(37, Body);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 28 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                  body0 = (Radzen.Blazor.RadzenBody)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenSidebar>(40);
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenPanelMenu>(42);
                __builder2.AddAttribute(43, "style", "height: 100%");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(45);
                    __builder3.AddAttribute(46, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                    L["panelmenu0.i-soft.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "Path", "i-soft");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPanelMenuItem>(49);
                    __builder3.AddAttribute(50, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                                    L["panelmenu0.software-modulescatlists.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Path", "software-modulescatlists");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(52, (__value) => {
#nullable restore
#line 35 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                     sidebar0 = (Radzen.Blazor.RadzenSidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFooter>(54);
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(56);
                __builder2.AddAttribute(57, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Shared\MainLayout.razor"
                        L["footerText.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<MainLayout> L { get; set; }
    }
}
namespace __Blazor.Landpag2.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg4, int __seq5, global::System.Object __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Name", __arg3);
        __builder.AddAttribute(__seq4, "Change", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591