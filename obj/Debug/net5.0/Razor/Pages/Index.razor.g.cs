#pragma checksum "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f3d05e12c7952a2e34590212e37f5dd52283b4"
// <auto-generated/>
#pragma warning disable 1591
namespace appblazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using appblazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Diego\Desktop\TCC\appblazor\_Imports.razor"
using appblazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
using appblazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazor_WebAssembly_TCC</h1>\r\n\r\nAplicação Blazor Wasm\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Código</th>\r\n                <th>Name</th>\r\n                <th>Capital</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 17 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
             if(countrys != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                 foreach (var forecast in countrys)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 22 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                             forecast.alpha2Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                        ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 23 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                             forecast.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 24 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                             forecast.capital

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Diego\Desktop\TCC\appblazor\Pages\Index.razor"
      
    string busca;
    HttpRequestMessage requestMessage;
    HttpResponseMessage responseMessage;
    HttpClient http;
    List<Country> countrys;
    protected override async Task OnInitializedAsync(){
            http = new HttpClient();
            requestMessage = new HttpRequestMessage{
                Method = HttpMethod.Get,
                RequestUri = new Uri(@"https://restcountries.eu/rest/v2/all")

            };

            responseMessage = await http.SendAsync(requestMessage);
            countrys = JsonSerializer.Deserialize<List<Country>>(await responseMessage.Content.ReadAsStringAsync());            
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591