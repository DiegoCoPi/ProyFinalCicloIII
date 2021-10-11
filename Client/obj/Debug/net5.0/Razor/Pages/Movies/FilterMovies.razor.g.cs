#pragma checksum "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58bcd1f3676eea7efad94efb3090e138918dcbb8"
// <auto-generated/>
#pragma warning disable 1591
namespace proyFinal.Client.Pages.Movies
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
#line 2 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
using proyFinal.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/filter")]
    public partial class FilterMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 12 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                           (KeyboardEventArgs e)=>MovieSearch(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "movie_name");
            __builder.AddAttribute(15, "placeholder", "Buscar pelicula");
            __builder.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                movie_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie_name = __value, movie_name));
            __builder.SetUpdatesAttributeName("Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group mb-3");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                        categorySelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categorySelected = __value, categorySelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "0");
            __builder.AddMarkupContent(29, "Selecciona una categoría");
            __builder.CloseElement();
#nullable restore
#line 20 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                         foreach (var item in categories)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", 
#nullable restore
#line 22 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, 
#nullable restore
#line 22 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n   \r\n\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-inline");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "checkbox");
            __builder.AddAttribute(40, "class", "form-check-input");
            __builder.AddAttribute(41, "id", "estrenos");
            __builder.AddAttribute(42, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                                                 futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<label class=\"form-check-label\" for=\"estrenos\">Próximos estrenos</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "checkbox");
            __builder.AddAttribute(51, "class", "form-check-input");
            __builder.AddAttribute(52, "id", "cartelera");
            __builder.AddAttribute(53, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                                                  enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.AddMarkupContent(56, "<label class=\"form-check-label\" for=\"cartelera\">En cartelera</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-group mx-sm-3 mb-3");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "checkbox");
            __builder.AddAttribute(62, "class", "form-check-input");
            __builder.AddAttribute(63, "id", "mejora_calificada");
            __builder.AddAttribute(64, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                                                          mejorCalificada

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mejorCalificada = __value, mejorCalificada));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.AddMarkupContent(67, "<label class=\"form-check-label\" for=\"mejora_calificada\">Mejor calificadas</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n    ");
            __builder.OpenElement(69, "div");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "type", "button");
            __builder.AddAttribute(72, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                                             ShowMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "button");
            __builder.AddAttribute(77, "type", "button");
            __builder.AddAttribute(78, "class", "btn btn-danger mb-2 mx-sm-3");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                                                                            ClearInputs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "Limpiar campos");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenComponent<proyFinal.Client.Pages.Components.ServiceComponent>(82);
            __builder.AddAttribute(83, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<proyFinal.Shared.Entity.Movie>>(
#nullable restore
#line 56 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
                          Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\ProysCicloIII\proyFinal\Client\Pages\Movies\FilterMovies.razor"
       
    private List<Movie> Movies;
    private List<Category> categories = new List<Category>();
    string movie_name = "";
    string categorySelected = "";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool mejorCalificada = false;

    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

    private void ShowMovies()
    {
        Movies = movie.GetMovies().Where(x=>x.Name.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Pelicula: {movie_name}, categoría seleccionada {categorySelected}");
        Console.WriteLine($"Próximos estrenos {futurosEstrenos}, en cartelera: {enCartelera} mejor calificada {mejorCalificada}");
    }

private void ClearInputs(){
    Movies = movie.GetMovies();
    movie_name = "";
    categorySelected = "0";
    futurosEstrenos = false;
    enCartelera = false;
    mejorCalificada = false;
}

    private void MovieSearch(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            ShowMovies();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
