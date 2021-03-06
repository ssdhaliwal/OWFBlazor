#pragma checksum "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ae260217ec86e891965ad991f995d07c2706da"
// <auto-generated/>
#pragma warning disable 1591
namespace OWFBlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using OWFBlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using OWFBlazorDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
using OWFBlazorDemo.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>App State Storage: Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "+ Increment");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "&nbsp;\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
                                          DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "- Decrement");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "&nbsp;\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
                                          ResetCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "0 Reset");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n<br>\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    protected override async Task OnInitializedAsync()
    {
        if (AppState == null)
        {
            System.Console.WriteLine("App State is NULL");
        }

        currentCount = (int)AppState.get("counter", 0);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            string initialization = (string)AppState.get("initialization", "false");
            if (initialization == "false") {
                NavigationManager.NavigateTo("/");  
            }

            AppState.set("counter", 0);
        }
    }

    public Counter()
    {
    }

    private async Task IncrementCount()
    {
        currentCount += IncrementAmount;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.broadcast", "blazor.counter", "{'counter': " +
        currentCount + ",'status': 'increment'}");
    }

    private async Task DecrementCount()
    {
        currentCount -= IncrementAmount;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.broadcast", "blazor.counter", "{'counter': " +
        currentCount + ",'status': 'decrement'}");
    }

    private async Task ResetCount()
    {
        currentCount = 0;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.broadcast", "blazor.counter", "{'counter': " +
        currentCount + ",'status': 'reset'}");
    }

    async void IDisposable.Dispose()
    {
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OWFBlazorDemo.Services.AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
