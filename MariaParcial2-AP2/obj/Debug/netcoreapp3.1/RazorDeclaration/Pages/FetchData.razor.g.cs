#pragma checksum "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa45e639ba2f064fc190e2d4bc72ff23360c3272"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MariaParcial2_AP2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using MariaParcial2_AP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using MariaParcial2_AP2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\FetchData.razor"
using MariaParcial2_AP2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Aplicada2\MariaParcial2-AP2\MariaParcial2-AP2\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
