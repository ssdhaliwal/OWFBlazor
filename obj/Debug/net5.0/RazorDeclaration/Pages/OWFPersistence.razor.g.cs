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
#line 2 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFPersistence.razor"
using OWFBlazorDemo.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/owfPersistence")]
    public partial class OWFPersistence : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFPersistence.razor"
       
    private readonly DotNetObjectReference<OWFPersistence> _objeRef;
    private string uuid = "";
    private string text = "";

    public class PreferenceObject
    {

        public string Key { get; set; }

        public string Value { get; set; }
    }
    public PreferenceObject Preference = new PreferenceObject();

    protected override async Task OnInitializedAsync()
    {
        if (AppState == null)
        {
            System.Console.WriteLine("App State is NULL");
        }

        uuid = (string)AppState.get("uuid", "");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.register", _objeRef);
        }
    }

    public OWFPersistence()
    {
        _objeRef = DotNetObjectReference.Create(this);
    }

    private async Task onGetPreference()
    {
        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.preference.get", "GetUserPreference",
        true, "owf",
        Preference.Key);
    }

    [JSInvokable]
    public async Task GetUserPreference(string message)
    {
        System.Console.WriteLine(message);
        text = "GetUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.preference.get");
    }

    private async Task onSetPreference()
    {
        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.preference.set", "SetUserPreference",
        true, "owf",
        Preference.Key, Preference.Value);
    }

    [JSInvokable]
    public async Task SetUserPreference(string message)
    {
        text = "SetUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.preference.set");
    }

    private async Task onDeletePreference()
    {
        await JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.start", "owf.preference.delete",
        "DeleteUserPreference", true, "owf",
        Preference.Key);
    }

    [JSInvokable]
    public async Task DeleteUserPreference(string message)
    {
        text = "DeleteUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("interopInterface.INTEROPMessageHandler.stop", "owf.preference.delete");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
