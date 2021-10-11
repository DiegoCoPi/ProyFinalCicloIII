#pragma checksum "C:\ProysCicloIII\proyFinal\Client\Pages\Actors\CreateActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b784cb56b538231b81e3235817f9f0295bfea44"
// <auto-generated/>
#pragma warning disable 1591
namespace proyFinal.Client.Pages.Actors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using proyFinal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using proyFinal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using proyFinal.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\proyFinal\Client\_Imports.razor"
using proyFinal.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\proyFinal\Client\Pages\Actors\CreateActor.razor"
using proyFinal.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors/create")]
    public partial class CreateActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Actores</h3>\r\n");
            __builder.OpenComponent<proyFinal.Client.Pages.Components.FormActor>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "C:\ProysCicloIII\proyFinal\Client\Pages\Actors\CreateActor.razor"
                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Actor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<proyFinal.Shared.Entity.Actor>(
#nullable restore
#line 8 "C:\ProysCicloIII\proyFinal\Client\Pages\Actors\CreateActor.razor"
                                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\ProysCicloIII\proyFinal\Client\Pages\Actors\CreateActor.razor"
       
    private Actor Actor = new Actor();

    private async Task Create()
    {
        var httpResponse = await repositorio.Post("api/actors", Actor);
        if (httpResponse.Error)
        {
           await mostrarMensajes.ShowErrorMessage(await httpResponse.GetBody());
        }
        else
        {
            navigationManager.NavigateTo("/actors");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IErrorMessage mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie repositorio { get; set; }
    }
}
#pragma warning restore 1591
