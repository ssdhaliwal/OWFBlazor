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
    [Microsoft.AspNetCore.Components.RouteAttribute("/owfInterface")]
    public partial class OWFInterface : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
       
    private readonly DotNetObjectReference<OWFInterface> _objeRef;
    private string uuid = "";
    private string user = "";
    private string groups = "";
    private string text = "";

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
            await JS.InvokeVoidAsync("NotificationManager.register", _objeRef);

            if (uuid == "")
            {
                await JS.InvokeVoidAsync("NotificationManager.start", "owf.user.uuid", "GetUserUUID", true);
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
        JS.InvokeVoidAsync("NotificationManager.stop", "owf.user.uuid");

        await JS.InvokeVoidAsync("NotificationManager.start", "owf.user", "GetUser", true);
    }

    [JSInvokable]
    public async Task GetUser(string message)
    {
        user = message;
        base.StateHasChanged();

        AppState.set("user", user);
        JS.InvokeVoidAsync("NotificationManager.stop", "owf.user");

        await JS.InvokeVoidAsync("NotificationManager.start", "owf.user.groups", "GetUserGroups", true);
    }

    [JSInvokable]
    public async Task GetUserGroups(string message)
    {
        groups = message;
        base.StateHasChanged();

        AppState.set("groups", groups);
        JS.InvokeVoidAsync("NotificationManager.stop", "owf.user.groups");
    }

    async void IDisposable.Dispose()
    {
        JS.InvokeVoidAsync("NotificationManager.deregister");
        _objeRef.Dispose();
    }

    public class PreferenceObject
    {

        public string Key { get; set; }

        public string Value { get; set; }
    }
    public PreferenceObject Preference = new PreferenceObject();

    private async Task onGetPreference()
    {
        await JS.InvokeVoidAsync("NotificationManager.start", "owf.preference.get", "GetUserPreference", true,
        Preference.Key);
    }

    [JSInvokable]
    public async Task GetUserPreference(string message)
    {
        text = "GetUserPreference -> " + message;
        base.StateHasChanged();

        //JS.InvokeVoidAsync("NotificationManager.stop", "owf.preference.set");
    }

    private async Task onSetPreference()
    {
        await JS.InvokeVoidAsync("NotificationManager.start", "owf.preference.set", "SetUserPreference", true,
        Preference.Key, Preference.Value);
    }

    [JSInvokable]
    public async Task SetUserPreference(string message)
    {
        text = "SetUserPreference -> " + message;
        base.StateHasChanged();

        //JS.InvokeVoidAsync("NotificationManager.stop", "owf.preference.set");
    }

    private async Task onDeletePreference()
    {
        await JS.InvokeVoidAsync("NotificationManager.start", "owf.preference.delete", "DeleteUserPreference", true,
        Preference.Key);
    }

    [JSInvokable]
    public async Task DeleteUserPreference(string message)
    {
        text = "DeleteUserPreference -> " + message;
        base.StateHasChanged();

        //JS.InvokeVoidAsync("NotificationManager.stop", "owf.preference.set");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OWFBlazorDemo.Services.AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
