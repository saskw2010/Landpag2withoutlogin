#pragma checksum "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5f42e41231d0223c7db05a5b434bd1a7945e395"
// <auto-generated/>
#pragma warning disable 1591
namespace Landpag2.Pages
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
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Work_Dev_Radzen_CPD\activedirectory\server\_Imports.razor"
using Landpag2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
using Landpag2.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
using Landpag2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-software-modulescatlist")]
    public partial class AddSoftwareModulescatlist : Landpag2.Pages.AddSoftwareModulescatlistComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>>(7);
                __builder2.AddAttribute(8, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>(
#nullable restore
#line 18 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                   softwaremodulescatlist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                      softwaremodulescatlist != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>(this, 
#nullable restore
#line 18 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                                                                                                                                  Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["sprModulecatDescLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Component", "sprModulecatDesc");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Name", "SprModulecatDesc");
                    __builder3.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.sprModulecatDesc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.sprModulecatDesc = __value, softwaremodulescatlist.sprModulecatDesc))));
                    __builder3.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.sprModulecatDesc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\n            ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(33, "class", "row");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(36);
                    __builder3.AddAttribute(37, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["sprModulecatDesc1Label.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Component", "sprModulecatDesc1");
                    __builder3.AddAttribute(39, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(40, "\n              ");
                    __builder3.OpenElement(41, "div");
                    __builder3.AddAttribute(42, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(43);
                    __builder3.AddAttribute(44, "style", "width: 100%");
                    __builder3.AddAttribute(45, "Name", "SprModulecatDesc1");
                    __builder3.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.sprModulecatDesc1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.sprModulecatDesc1 = __value, softwaremodulescatlist.sprModulecatDesc1))));
                    __builder3.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.sprModulecatDesc1));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(52, "class", "row");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(55);
                    __builder3.AddAttribute(56, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["FuturecatDescLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Component", "FuturecatDesc");
                    __builder3.AddAttribute(58, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\n              ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(62);
                    __builder3.AddAttribute(63, "style", "width: 100%");
                    __builder3.AddAttribute(64, "Name", "FuturecatDesc");
                    __builder3.AddAttribute(65, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.FuturecatDesc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.FuturecatDesc = __value, softwaremodulescatlist.FuturecatDesc))));
                    __builder3.AddAttribute(67, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.FuturecatDesc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n            ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(71, "class", "row");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(74);
                    __builder3.AddAttribute(75, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["FuturecatDesc1Label.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Component", "FuturecatDesc1");
                    __builder3.AddAttribute(77, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\n              ");
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(81);
                    __builder3.AddAttribute(82, "style", "width: 100%");
                    __builder3.AddAttribute(83, "Name", "FuturecatDesc1");
                    __builder3.AddAttribute(84, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.FuturecatDesc1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.FuturecatDesc1 = __value, softwaremodulescatlist.FuturecatDesc1))));
                    __builder3.AddAttribute(86, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.FuturecatDesc1));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\n            ");
                    __builder3.OpenElement(88, "div");
                    __builder3.AddAttribute(89, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(90, "class", "row");
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(93);
                    __builder3.AddAttribute(94, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["photopathLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(95, "Component", "photopath");
                    __builder3.AddAttribute(96, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\n              ");
                    __builder3.OpenElement(98, "div");
                    __builder3.AddAttribute(99, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(100);
                    __builder3.AddAttribute(101, "style", "width: 100%");
                    __builder3.AddAttribute(102, "Name", "Photopath");
                    __builder3.AddAttribute(103, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.photopath

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.photopath = __value, softwaremodulescatlist.photopath))));
                    __builder3.AddAttribute(105, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.photopath));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(109, "class", "row");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(112);
                    __builder3.AddAttribute(113, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                    L["InstallcatModuleLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "Component", "InstallcatModule");
                    __builder3.AddAttribute(115, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(116, "\n              ");
                    __builder3.OpenElement(117, "div");
                    __builder3.AddAttribute(118, "class", "col-md-9");
                    __Blazor.Landpag2.Pages.AddSoftwareModulescatlist.TypeInference.CreateRadzenNumeric_0(__builder3, 119, 120, "width: 100%", 121, "InstallcatModule", 122, 
#nullable restore
#line 76 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.InstallcatModule

#line default
#line hidden
#nullable disable
                    , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.InstallcatModule = __value, softwaremodulescatlist.InstallcatModule)), 124, () => softwaremodulescatlist.InstallcatModule);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(125, "\n            ");
                    __builder3.OpenElement(126, "div");
                    __builder3.AddAttribute(127, "class", "row");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(130);
                    __builder3.AddAttribute(131, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 82 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "Icon", "save");
                    __builder3.AddAttribute(133, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                                L["button1.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 82 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                                                                ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(136);
                    __builder3.AddAttribute(137, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 84 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(138, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(139, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 84 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                                               L["button2.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(140, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\AddSoftwareModulescatlist.razor"
                                                                                                                          Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<AddSoftwareModulescatlist> L { get; set; }
    }
}
namespace __Blazor.Landpag2.Pages.AddSoftwareModulescatlist
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
