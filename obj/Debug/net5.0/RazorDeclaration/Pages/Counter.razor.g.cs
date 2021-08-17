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
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "E:\home\development\blazer\OWFBlazorDemo\Pages\Counter.razor"
       
    private readonly DotNetObjectReference<Counter> _objeRef;
    private int currentCount = 0;
    private string text { get; set; }

    [Parameter]
    public int IncrementAmount { get; set; } = 1;

    protected override async Task OnInitializedAsync()
    {
        if (AppState == null) {
            System.Console.WriteLine("App State is NULL");
        }

        currentCount = (int)AppState.get("counter", 0);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.register", _objeRef);
            AppState.set("counter", 0);
        }
    }

    public Counter()
    {
        _objeRef = DotNetObjectReference.Create(this);
    }

    private async Task IncrementCount()
    {
        currentCount += IncrementAmount;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("OWF.Eventing.publish", "blazor.counter", "{'counter': " + currentCount + ",'status': 'increment'}");
    }

    private async Task DecrementCount()
    {
        currentCount -= IncrementAmount;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("OWF.Eventing.publish", "blazor.counter", "{'counter': " + currentCount + ",'status': 'decrement'}");
    }

    private async Task ResetCount()
    {
        currentCount = 0;
        AppState.set("counter", currentCount);

        await JS.InvokeVoidAsync("OWF.Eventing.publish", "blazor.counter", "{'counter': " + currentCount + ",'status': 'reset'}");
    }

    private async Task StartMapStatus()
    {
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "map.status.view", "ReceiveMapStatusView");
    }

    private async Task StopMapStatus()
    {
        text = "{cleared}";
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "map.status.view");
    }

    [JSInvokable]
    public async Task ReceiveMapStatusView(string mapView)
    {
        text = JSONServices.JSONAsHTMLString(mapView);
        base.StateHasChanged();
    }

    async void IDisposable.Dispose()
    {
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "map.status.view");
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.deregister");    
        _objeRef.Dispose();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OWFBlazorDemo.Services.AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
