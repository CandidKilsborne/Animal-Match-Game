#pragma checksum "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c309da2881fbdc63a314b20498c3f855cbb2943"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .container {\r\n        width: 400px;\r\n    }\r\n    button {\r\n        width: 100px;\r\n        height: 100px;\r\n        font-size: 50px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 16 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\Pages\Index.razor"
         foreach (var animal in shuffledAnimals)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "class", "btn btn-outline-dark");
            __builder.OpenElement(10, "h1");
            __builder.AddContent(11, 
#nullable restore
#line 20 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\Pages\Index.razor"
                         animal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\apaul\source\repos\BlazorMatchGame\BlazorMatchGame\Pages\Index.razor"
       
    List<string> animalEmoji = new List<string>()
    {
        "🐶", "🐶",
        "🐺", "🐺",
        "🐮", "🐮",
        "🦊", "🦊",
        "🐱", "🐱",
        "🦁", "🦁",
        "🐯", "🐯",
        "🐹", "🐹",
    };

    List<string> shuffledAnimals = new List<string>();

    protected override void OnInitialized()
    {
        SetUpGame();
    }

    private void SetUpGame()
    {
        Random random = new Random();
        shuffledAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
