#pragma checksum "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c03e8399317fd844e9c1a6c088ed2cd870c0559"
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
#line 5 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
using Landpag2.Models.Authenticationconn;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-software-modulescatlist/{sprModulecatid}")]
    public partial class EditSoftwareModulescatlist : Landpag2.Pages.EditSoftwareModulescatlistComponent
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
                __builder2.AddAttribute(6, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "style", "font-weight: bold");
                __builder2.AddAttribute(9, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                      L["closeLabel.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                       !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 17 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                             L["closeButton.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                               !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                                                  CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "style", "font-weight: bold");
                __builder2.AddAttribute(27, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                      L["label0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                  hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n      ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 27 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "autorenew");
                __builder2.AddAttribute(35, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(36, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                              L["button0.Text"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                                           hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>>(44);
                __builder2.AddAttribute(45, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>(
#nullable restore
#line 33 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                     softwaremodulescatlist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                                        softwaremodulescatlist != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Submit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>(this, 
#nullable restore
#line 33 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                                                                                             Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                    __builder3.AddAttribute(55, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["sprModulecatDescLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Component", "sprModulecatDesc");
                    __builder3.AddAttribute(57, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(61);
                    __builder3.AddAttribute(62, "style", "width: 100%");
                    __builder3.AddAttribute(63, "Name", "SprModulecatDesc");
                    __builder3.AddAttribute(64, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.sprModulecatDesc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.sprModulecatDesc = __value, softwaremodulescatlist.sprModulecatDesc))));
                    __builder3.AddAttribute(66, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.sprModulecatDesc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n            ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(70, "class", "row");
                    __builder3.OpenElement(71, "div");
                    __builder3.AddAttribute(72, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(73);
                    __builder3.AddAttribute(74, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["sprModulecatDesc1Label.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "Component", "sprModulecatDesc1");
                    __builder3.AddAttribute(76, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(80);
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.AddAttribute(82, "Name", "SprModulecatDesc1");
                    __builder3.AddAttribute(83, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.sprModulecatDesc1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.sprModulecatDesc1 = __value, softwaremodulescatlist.sprModulecatDesc1))));
                    __builder3.AddAttribute(85, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.sprModulecatDesc1));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n            ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(89, "class", "row");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(92);
                    __builder3.AddAttribute(93, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["FuturecatDescLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "Component", "FuturecatDesc");
                    __builder3.AddAttribute(95, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\n              ");
                    __builder3.OpenElement(97, "div");
                    __builder3.AddAttribute(98, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(99);
                    __builder3.AddAttribute(100, "style", "width: 100%");
                    __builder3.AddAttribute(101, "Name", "FuturecatDesc");
                    __builder3.AddAttribute(102, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.FuturecatDesc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(103, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.FuturecatDesc = __value, softwaremodulescatlist.FuturecatDesc))));
                    __builder3.AddAttribute(104, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.FuturecatDesc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(105, "\n            ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(111);
                    __builder3.AddAttribute(112, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["FuturecatDesc1Label.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "Component", "FuturecatDesc1");
                    __builder3.AddAttribute(114, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(118);
                    __builder3.AddAttribute(119, "style", "width: 100%");
                    __builder3.AddAttribute(120, "Name", "FuturecatDesc1");
                    __builder3.AddAttribute(121, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.FuturecatDesc1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.FuturecatDesc1 = __value, softwaremodulescatlist.FuturecatDesc1))));
                    __builder3.AddAttribute(123, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.FuturecatDesc1));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\n            ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(127, "class", "row");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(130);
                    __builder3.AddAttribute(131, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["photopathLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "Component", "photopath");
                    __builder3.AddAttribute(133, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(137);
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.AddAttribute(139, "Name", "Photopath");
                    __builder3.AddAttribute(140, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.photopath

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.photopath = __value, softwaremodulescatlist.photopath))));
                    __builder3.AddAttribute(142, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => softwaremodulescatlist.photopath));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(143, "\n            ");
                    __builder3.OpenElement(144, "div");
                    __builder3.AddAttribute(145, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(146, "class", "row");
                    __builder3.OpenElement(147, "div");
                    __builder3.AddAttribute(148, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(149);
                    __builder3.AddAttribute(150, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                    L["InstallcatModuleLabel.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(151, "Component", "InstallcatModule");
                    __builder3.AddAttribute(152, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(153, "\n              ");
                    __builder3.OpenElement(154, "div");
                    __builder3.AddAttribute(155, "class", "col-md-9");
                    __Blazor.Landpag2.Pages.EditSoftwareModulescatlist.TypeInference.CreateRadzenNumeric_0(__builder3, 156, 157, "width: 100%", 158, "InstallcatModule", 159, 
#nullable restore
#line 91 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                  softwaremodulescatlist.InstallcatModule

#line default
#line hidden
#nullable disable
                    , 160, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => softwaremodulescatlist.InstallcatModule = __value, softwaremodulescatlist.InstallcatModule)), 161, () => softwaremodulescatlist.InstallcatModule);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(162, "\n            ");
                    __builder3.OpenElement(163, "div");
                    __builder3.AddAttribute(164, "class", "row");
                    __builder3.OpenElement(165, "div");
                    __builder3.AddAttribute(166, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(167);
                    __builder3.AddAttribute(168, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 97 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(169, "Icon", "save");
                    __builder3.AddAttribute(170, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 97 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                L["button3.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(171, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 97 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(173);
                    __builder3.AddAttribute(174, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 99 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(175, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(176, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 99 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                               L["button4.Text"]

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(177, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "F:\Work_Dev_Radzen_CPD\activedirectory\server\Pages\EditSoftwareModulescatlist.razor"
                                                                                                                          Button4Click

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<EditSoftwareModulescatlist> L { get; set; }
    }
}
namespace __Blazor.Landpag2.Pages.EditSoftwareModulescatlist
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
