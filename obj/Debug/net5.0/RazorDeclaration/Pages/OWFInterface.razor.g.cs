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
#line 2 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
using OWFBlazorDemo.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/owfInterface")]
    public partial class OWFInterface : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
       
    private readonly DotNetObjectReference<OWFInterface> _objeRef;
    private string uuid = "";
    private string user = "";
    private string groups = "";

    protected override async Task OnInitializedAsync()
    {
        if (AppState == null)
        {
            System.Console.WriteLine("App State is NULL");
        }

        uuid = (string)AppState.get("uuid", "");
        user = (string)AppState.get("user", "");
        groups = (string)AppState.get("groups", "");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            string initialization = (string)AppState.get("initializtion", "false");
            if (initialization == "false") {
            NavigationManager.NavigateTo("/");  
            }

            await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.register", _objeRef);

            if (uuid == "")
            {
                await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.user.uuid", "GetUserUUID", true, "owf");
            }
        }
    }

    public OWFInterface()
    {
        _objeRef = DotNetObjectReference.Create(this);
    }

    [JSInvokable]
    public async Task GetUserUUID(string message)
    {
        uuid = message;
        base.StateHasChanged();

        AppState.set("uuid", uuid);
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.user.uuid");

        // invoke next call to get user info
        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.user", "GetUser", true, "owf");
    }

    [JSInvokable]
    public async Task GetUser(string message)
    {
        user = JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        AppState.set("user", user);
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.user");

        // invoke next call to get user group info
        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.user.groups", "GetUserGroups", true,
        "owf");
    }

    [JSInvokable]
    public async Task GetUserGroups(string message)
    {
        groups = JSONServices.JSONAsHTMLString("{groups: " + message + "}");
        base.StateHasChanged();

        AppState.set("groups", groups);
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.user.groups");
    }

    async void IDisposable.Dispose()
    {
        JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.deregister");
        _objeRef.Dispose();
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
