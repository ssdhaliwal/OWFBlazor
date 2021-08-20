#pragma checksum "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3e5f779126217e7e6b89700bcd7c99d58bec17"
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
            __builder.AddMarkupContent(0, "<h1><code>CMAPI</code> Interface</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "<code>Map Events</code>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(3, "<code>UUID</code>: ");
            __builder.AddContent(4, 
#nullable restore
#line 12 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                        uuid

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n    <br>\r\n");
            __builder.AddMarkupContent(6, "<ul><li>LISTENERS</li>\r\n    <ul><li>1. Map Click</li>\r\n        <li>2. View State</li></ul></ul>\r\n");
            __builder.AddMarkupContent(7, @"<ul><li>PROJECTION</li>
    <ul><li>1. Marker</li>
        <li>2. LineString</li>
        <li>3. Polygon</li>
        <li>4. KML</li>
        <li>5. Service - Feature</li>
        <li>6. Service - Measurement</li>
        <li>7. Service - Geocoding</li></ul></ul>");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                     MapInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "id", "saveMapInfo");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "<label for=\"saveMapInfoOverlay\">overlay</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "saveMapInfoOverlay");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                        MapInfo.Overlay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MapInfo.Overlay = __value, MapInfo.Overlay))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => MapInfo.Overlay));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.AddMarkupContent(22, "<label for=\"saveMapInfoFeature\">overlay</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "saveMapInfoFeature");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                        MapInfo.Feature

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MapInfo.Feature = __value, MapInfo.Feature))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => MapInfo.Feature));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.AddMarkupContent(30, "<label for=\"saveMapInfoValue\">Coordinates</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(31);
                __builder2.AddAttribute(32, "id", "saveMapInfoValue");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "rows", "5");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                          MapInfo.Value

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => MapInfo.Value = __value, MapInfo.Value))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => MapInfo.Value));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n\r\n        ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                  onPlotMarker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Plot Marker");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "&nbsp;\r\n        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "btn btn-primary");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                  onPlotLineString

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "Plot LineString");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "&nbsp;\r\n        ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-primary");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                                  onPlotPolygon

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, "Plot Polygon");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(54, "<code>Map View</code>: <br>");
            __builder.AddContent(55, 
#nullable restore
#line 51 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
                                   (MarkupString)text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\home\development\blazer\OWFBlazorDemo\Pages\CMAPIInterface.razor"
       
    private readonly DotNetObjectReference<CMAPIInterface> _objeRef;
    private string uuid = "";
    private string text = "";

    public class MapInfoObject
    {
        public string Overlay { get; set; }
        public string Feature { get; set; }
        public string Value { get; set; }
    }
    public MapInfoObject MapInfo = new MapInfoObject();

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
        text = "(map.status.view) -> " + JSONServices.JSONAsHTMLString(mapView) + "<br/>";
        base.StateHasChanged();
    }

    [JSInvokable]
    public async Task ReceiveMapViewClicked(string mapView)
    {
        text = "(map.view.clicked) -> " + JSONServices.JSONAsHTMLString(mapView) + "<br/>";
        base.StateHasChanged();

        // store lat/lon in the list
        // plot temp marker for the last lat/lon

    }

    private async Task onPlotMarker()
    {
        string uuid = Guid.NewGuid().ToString();
        await JS.InvokeVoidAsync("interopInterface.shared.cmapiInterface.PlotMarker", MapInfo.Overlay, MapInfo.Feature, uuid, MapInfo.Value);
    }
    private async Task onPlotLineString()
    {
        string uuid = Guid.NewGuid().ToString();
        await JS.InvokeVoidAsync("interopInterface.shared.cmapiInterface.PlotLineString", MapInfo.Overlay, MapInfo.Feature, uuid, MapInfo.Value);
    }
    private async Task onPlotPolygon()
    {
        string uuid = Guid.NewGuid().ToString();

        // split value to get inner boundaries if specified
        string[] boundaries = MapInfo.Value.Split(new [] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        string outerBoundary = boundaries[0];
        string innerBoundary = "";

        await JS.InvokeVoidAsync("interopInterface.shared.cmapiInterface.PlotPolygon", MapInfo.Overlay, MapInfo.Feature, uuid, outerBoundary, innerBoundary);
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
