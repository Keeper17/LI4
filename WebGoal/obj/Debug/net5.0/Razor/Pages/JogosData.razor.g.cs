#pragma checksum "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5ec535bc640647a570a447da1bee6f440337db"
// <auto-generated/>
#pragma warning disable 1591
namespace WebGoal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using WebGoal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\_Imports.razor"
using WebGoal.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/jogosdata")]
    public partial class JogosData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
 if (Main == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Erro ao chamar a API (ou limite de 10 requests atingido)</p>");
#nullable restore
#line 7 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mb-2 p-3");
            __builder.AddMarkupContent(3, "\r\n        Escolha a Liga que pretende analisar:\r\n        ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                                                               GetDataAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                                            League

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => League = __value, League));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "selected");
            __builder.AddAttribute(11, "disabled");
            __builder.AddAttribute(12, "value", "-1");
            __builder.AddContent(13, " Liga");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "PPL");
            __builder.AddContent(17, " Primeira Liga Portuguesa");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "PL");
            __builder.AddContent(21, " Premier League");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "BL1");
            __builder.AddContent(25, " Bundesliga");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "PD");
            __builder.AddContent(29, " La Liga");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "mb-2 p-3");
            __builder.AddMarkupContent(32, "\r\n        Data do Jogo que pretende observar:\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "date");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 23 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                                   Date.ToString(dateFormatString)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "format-value", 
#nullable restore
#line 24 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                              dateFormatString

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                                                           OnDateChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"



    if (Main.matches.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<p> Não existem jogos para esta data. </p>");
#nullable restore
#line 32 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
    }
    else
    {




#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.AddMarkupContent(41, "<thead><tr><th>Hora</th>\r\n                    <th>Status</th>\r\n                    <th>Equipa1</th>\r\n                    <th>Resultado</th>\r\n                    <th>Equipa2</th></tr></thead>\r\n            ");
            __builder.OpenElement(42, "tbody");
#nullable restore
#line 50 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                 foreach (var match in Main.matches)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 53 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                             match.utcDate.TimeOfDay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 54 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                             match.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 55 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                             match.homeTeam.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 56 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                             match.score.fullTime.homeTeam

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " - ");
            __builder.AddContent(56, 
#nullable restore
#line 56 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                                                              match.score.fullTime.awayTeam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 57 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                             match.awayTeam.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\António Gonçalves\Desktop\LI_4_F\WebGoal\Pages\JogosData.razor"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
