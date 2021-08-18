// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using OWFBlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\home\development\blazer\OWFBlazorDemo\_Imports.razor"
using OWFBlazorDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
using OWFBlazorDemo.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cmapiInterface")]
    public partial class CMAPIInterface : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
       
    private readonly DotNetObjectReference<CMAPIInterface> _objeRef;
    private string text = "";

    protected override async Task OnInitializedAsync()
    {
        if (AppState == null)
        {
            System.Console.WriteLine("App State is NULL");
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.register", _objeRef);

            // start subscriptions
            await JS.InvokeVoidAsync("interopInterface.RegisterEvents");
            await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "map.status.view", "ReceiveMapStatusView");
            await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "map.view.clicked", "ReceiveMapViewClicked");
        }
    }

    public CMAPIInterface()
    {
        _objeRef = DotNetObjectReference.Create(this);
    }

    [JSInvokable]
    public async Task ReceiveMapStatusView(string mapView)
    {
        text += "(map.status.view) -> " + JSONServices.JSONAsHTMLString(mapView) + "<br/>";
        base.StateHasChanged();
    }

    [JSInvokable]
    public async Task ReceiveMapViewClicked(string mapView)
    {
        text += "(map.view.clicked) -> " + JSONServices.JSONAsHTMLString(mapView) + "<br/>";
        base.StateHasChanged();

        // store lat/lon in the list
        // plot temp marker for the last lat/lon
    }

    async void IDisposable.Dispose()
    {
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "map.status.view");
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "map.view.clicked");
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.deregister");
        _objeRef.Dispose();

        // start subscriptions
        JS.InvokeVoidAsync("interopInterface.UnregisterEvents");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OWFBlazorDemo.Services.AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
