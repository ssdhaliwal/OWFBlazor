#pragma checksum "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e48979ee6710f6c950829f4b6f709d2c17f2cd"
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
#line 2 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
using OWFBlazorDemo.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appState")]
    public partial class APPState : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<code>App State Storage: Child List</code>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                 MyList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "id", "myList");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<label for=\"myListValue\">Key</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "myListValue");
                __builder2.AddAttribute(8, "class", "form-control");
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                             MyList.Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MyList.Value = __value, MyList.Value))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => MyList.Value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(13, "button");
                __builder2.AddAttribute(14, "class", "btn btn-primary");
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onAddList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(16, "Add (Value)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "&nbsp;\r\n    ");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "class", "btn btn-primary");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onAddListFromList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(21, "Add (CSV-List)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "&nbsp;<br>\r\n    ");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "class", "btn btn-primary");
                __builder2.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onSubtractList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(26, "Subtract (Value)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "&nbsp;\r\n    ");
                __builder2.OpenElement(28, "button");
                __builder2.AddAttribute(29, "class", "btn btn-primary");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onSubtractListPartial

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(31, "Subtract (Value-Partial)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "&nbsp;\r\n    ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onSubtractListFromList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(36, "Subtract (CSV-List)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "&nbsp;<br>\r\n    ");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "class", "btn btn-primary");
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onCheckList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(41, "Check (Value)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "&nbsp;\r\n    ");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "class", "btn btn-primary");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onCheckListPartial

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(46, "Check (Value-Partial)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "&nbsp;\r\n    ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "class", "btn btn-primary");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onCheckListFromListMatched

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(51, "Check (CSV-List Matched)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "&nbsp;\r\n    ");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "class", "btn btn-primary");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onCheckListFromList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(56, "Check (CSV-List Not-Matched)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "&nbsp;<br>\r\n    ");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "class", "btn btn-primary");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onListAll

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(61, "List (ALL)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "&nbsp;\r\n    ");
                __builder2.OpenElement(63, "button");
                __builder2.AddAttribute(64, "class", "btn btn-primary");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(66, "List (Value)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "&nbsp;\r\n    ");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "class", "btn btn-primary");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onListPartial

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "List (Value-Partial)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "&nbsp;\r\n    ");
                __builder2.OpenElement(73, "button");
                __builder2.AddAttribute(74, "class", "btn btn-primary");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onListFromListMatched

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "List (CSV-List Matched)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "&nbsp;\r\n    ");
                __builder2.OpenElement(78, "button");
                __builder2.AddAttribute(79, "class", "btn btn-primary");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                                              onListFromList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(81, "List (CSV-List Not-Matched)");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "&nbsp;\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(84, "p");
            __builder.AddMarkupContent(85, "<code>List</code>: <br>");
            __builder.AddContent(86, 
#nullable restore
#line 33 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
                               (MarkupString)text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\home\development\blazer\OWFBlazorDemo\Pages\APPState.razor"
       
    public class MyListObject
    {
        public string Value { get; set; }
    }
    public MyListObject MyList = new MyListObject();
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
            string initialization = (string)AppState.get("initializtion", "false");
            if (initialization == "false") {
            NavigationManager.NavigateTo("/");  
            }
        }
    }

    public APPState()
    {
    }

    private async Task onAddList()
    {
        // adding one value
        AppState.add("MyList", MyList.Value);
        onListAll();
    }

    private async Task onAddListFromList() {
        // adding multiple values, comma separated
        AppState.add("MyList", (MyList.Value).Split(",").ToList<string>());
        onListAll();
    }
    private async Task onSubtractList() {
        // subtracting one value
        AppState.subtract("MyList", MyList.Value);
        onListAll();
    }
    private async Task onSubtractListPartial() {
        // subtracting one value
        AppState.subtract("MyList", MyList.Value, true);
        onListAll();
    }
    private async Task onSubtractListFromList() {
        // subtracting multiple values, comma separated
        AppState.subtract("MyList", (MyList.Value).Split(",").ToList<string>());
        onListAll();
    }
    private async Task onCheckList() {
        // check one value
        onListAll();

        bool checkResult = AppState.check("MyList", MyList.Value);
        text += "<br />(check) -> " + checkResult.ToString();
        base.StateHasChanged();
    }
    private async Task onCheckListPartial() {
        // check one value (partial)
        onListAll();
        bool checkResult = AppState.check("MyList", MyList.Value, true);
        text += "<br />(check) -> " + checkResult.ToString();
        base.StateHasChanged();
    }
    private async Task onCheckListFromListMatched() {
        // check multiple values, comma separated (all exist)
        onListAll();
        bool checkResult = AppState.check("MyList", (MyList.Value).Split(",").ToList<string>(), true);
        text += "<br />(check) -> " + checkResult.ToString();
        base.StateHasChanged();
    }
    private async Task onCheckListFromList() {
        // check multiple values, comma separated (any exist)
        onListAll();
        bool checkResult = AppState.check("MyList", (MyList.Value).Split(",").ToList<string>());
        text += "<br />(check) -> " + checkResult.ToString();
        base.StateHasChanged();
    }
    private async Task onListAll() {
        text = "(list) -> " + string.Join(",", (AppState.list("MyList")).Select(x => x.ToString()).ToArray());
        base.StateHasChanged();
    }
    private async Task onList() {
        onListAll();
        text += "<br />(result) -> " + string.Join(",", AppState.list("MyList", MyList.Value).Select(x => x.ToString()).ToArray());
        base.StateHasChanged();
    }
    private async Task onListPartial() {
        onListAll();
        text += "<br />(result) -> " + string.Join(",", AppState.list("MyList", MyList.Value, true).Select(x => x.ToString()).ToArray());
        base.StateHasChanged();
    }
    private async Task onListFromListMatched() {
        onListAll();
        text += "<br />(result) -> " + string.Join(",", (AppState.list("MyList", (MyList.Value).Split(",").ToList<string>())).Select(x => x.ToString()).ToArray());
        base.StateHasChanged();
    }
    private async Task onListFromList() {
        onListAll();
        text += "<br />(result) -> " + string.Join(",", (AppState.list("MyList", (MyList.Value).Split(",").ToList<string>(), false)).Select(x => x.ToString()).ToArray());
        base.StateHasChanged();
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
