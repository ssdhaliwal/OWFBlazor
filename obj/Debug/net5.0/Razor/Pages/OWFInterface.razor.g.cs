#pragma checksum "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0056954a817fbdfbb65041580a657852cb560e6"
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
#line 3 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
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
            __builder.AddMarkupContent(0, "<h1><code>OWF</code> Interface</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "<code>UUID</code>: ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                        uuid

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(5, "<code>User</code>: <br>");
            __builder.AddContent(6, 
#nullable restore
#line 12 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                               (MarkupString)user

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(8, "<code>Groups</code>: <br>");
            __builder.AddContent(9, 
#nullable restore
#line 14 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                 (MarkupString)groups

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n    <br>\r\n    <br>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                     Preference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "id", "savePreference");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<label for=\"savePreferenceKey\">Key</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "savePreferenceKey");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                                       Preference.Key

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Preference.Key = __value, Preference.Key))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Preference.Key));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(23, "<label for=\"savePreferenceValue\">Value</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(24);
                __builder2.AddAttribute(25, "id", "savePreferenceValue");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "rows", "5");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                                             Preference.Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Preference.Value = __value, Preference.Value))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Preference.Value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n        ");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "btn btn-primary");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                                  onGetPreference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "Get");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "&nbsp;\r\n        ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "class", "btn btn-primary");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                                  onSetPreference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(40, "Set");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "&nbsp;\r\n        ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
                                                  onDeletePreference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(45, "Delete");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddContent(47, 
#nullable restore
#line 31 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
      (MarkupString)text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "E:\home\development\blazer\OWFBlazorDemo\Pages\OWFInterface.razor"
       
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
            await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.register", _objeRef);

            if (uuid == "")
            {
                await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.user.uuid", "GetUserUUID", true, "owf");
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
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.user.uuid");

        // invoke next call to get user info
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.user", "GetUser", true, "owf");
    }

    [JSInvokable]
    public async Task GetUser(string message)
    {
        user = JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        AppState.set("user", user);
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.user");

        // invoke next call to get user group info
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.user.groups", "GetUserGroups", true, "owf");
    }

    [JSInvokable]
    public async Task GetUserGroups(string message)
    {
        groups = JSONServices.JSONAsHTMLString("{groups: " + message + "}");
        base.StateHasChanged();

        AppState.set("groups", groups);
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.user.groups");
    }

    async void IDisposable.Dispose()
    {
        JS.InvokeVoidAsync("dotnetInterface.NotificationManager.deregister");
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
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.preference.get", "GetUserPreference", true, "owf",
        Preference.Key);
    }

    [JSInvokable]
    public async Task GetUserPreference(string message)
    {
        System.Console.WriteLine(message);
        text = "GetUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.preference.get");
    }

    private async Task onSetPreference()
    {
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.preference.set", "SetUserPreference", true, "owf",
        Preference.Key, Preference.Value);
    }

    [JSInvokable]
    public async Task SetUserPreference(string message)
    {
        text = "SetUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.preference.set");
    }

    private async Task onDeletePreference()
    {
        await JS.InvokeVoidAsync("dotnetInterface.NotificationManager.start", "owf.preference.delete", "DeleteUserPreference", true, "owf",
        Preference.Key);
    }

    [JSInvokable]
    public async Task DeleteUserPreference(string message)
    {
        text = "DeleteUserPreference -> " + JSONServices.JSONAsHTMLString(message);
        base.StateHasChanged();

        //JS.InvokeVoidAsync("dotnetInterface.NotificationManager.stop", "owf.preference.delete");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OWFBlazorDemo.Services.AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
