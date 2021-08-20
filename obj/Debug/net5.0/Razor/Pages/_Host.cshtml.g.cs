#pragma checksum "E:\home\development\blazer\OWFBlazorDemo\Pages\_Host.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OWFBlazorDemo.Pages.Pages__Host), @"mvc.1.0.razor-page", @"/Pages/_Host.cshtml")]
namespace OWFBlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e2f00eb3b2226c8d6d5ca86defc50829a51f2c1", @"/Pages/_Host.cshtml")]
    public class Pages__Host : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\home\development\blazer\OWFBlazorDemo\Pages\_Host.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c14361", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />

    <meta http-equiv=""cache-control"" content=""no-cache, no-store, must-revalidate"" />
    <!-- meta http-equiv=""cache-control"" content=""max-age=360"" /-->
    <meta http-equiv=""pragma"" content=""no-cache"" />
    <meta http-equiv=""expires"" content=""0"" />
    <meta http-equiv=""expires"" content=""Tue, 01 Jan 1980 1:00:00 GMT"" />

    <title>OWFBlazorDemo</title>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c15126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""css/dragAndDrop.css"" />

    <link rel=""stylesheet"" href=""css/bootstrap/bootstrap.min.css"" />
    <link href=""css/site.css"" rel=""stylesheet"" />
    <link href=""OWFBlazorDemo.styles.css"" rel=""stylesheet"" />

    <script src=""js/owf-widget-debug.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c17254", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c17516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 32 "E:\home\development\blazer\OWFBlazorDemo\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(App);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "E:\home\development\blazer\OWFBlazorDemo\Pages\_Host.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.ServerPrerendered;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <div id=\"blazor-error-ui\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c19520", async() => {
                    WriteLiteral("\r\n            An error has occurred. This application may no longer respond until reloaded.\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e2f00eb3b2226c8d6d5ca86defc50829a51f2c110877", async() => {
                    WriteLiteral("\r\n            An unhandled exception has occurred. See browser dev tools for details.\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 1437, "\"", 1444, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""reload"">Reload</a>
        <a class=""dismiss"">🗙</a>
    </div>

    <script src=""_framework/blazor.server.js"" autostart=""false""></script>
    <script>
        /*
        + Utility Functions
        */
        class JSUtilities {
            constructor() {

            };

            executeFunctionByName = function (functionName, context /*, args */) {
                let args = Array.prototype.slice.call(arguments, 2);
                let namespaces = functionName.split(""."");
                let func = namespaces.pop();

                for(let i = 0; i < namespaces.length; i++) {
                    context = context[namespaces[i]];
                }

                return context[func].apply(context, args);
            };

            // https://stackoverflow.com/questions/105034/how-to-create-a-guid-uuid
            guid = function() {
                return ([1e7]+-1e3+-4e3+-8e3+-1e11).replace(/[018]/g, c =>
                    (c ^ crypto.getRandomValues(new Uint");
                WriteLiteral(@"8Array(1))[0] & 15 >> c / 4).toString(16)
                );
            };

            ajaxCall = function (url, data, callback, stateChange, type,
                contentType, id) {
                // fix input vars if not defined
                if ((data === undefined) || (data === null) || (!data)) {
                    data = {};
                }

                if ((callback === undefined) || (callback === null) || (!callback)) {
                    callback = function () { };
                }

                if ((stateChange === undefined) || (stateChange === null) || (!stateChange)) {
                    stateChange = function () { };
                }

                if ((type === undefined) || (type === null) || (!type)) {
                    type = 'GET';
                }

                // initiate the call
                var req = new XMLHttpRequest();
                req.onreadystatechange = function () {
                    stateChange({
                    ");
                WriteLiteral(@"    state: req.readyState,
                        status: req.status
                    });

                    if (req.readyState === 4 && req.status === 200) {
                        if (contentType === ""application/octet-stream"") {
                            return callback({
                                ""id"": id,
                                ""payload"": (req.response || req.responseText)
                            });
                        } else {
                            return callback({
                                ""id"": id,
                                ""payload"": req.responseText
                            });
                        }
                    }
                };

                req.open(type, url, true);
                req.withCredentials = true;
                //req.setRequestHeader(""Cache-Control"", ""max-age=0"");

                //req.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
                //req.setReques");
                WriteLiteral(@"tHeader(""Content-type"", ""application/json"");
                if (!contentType) {
                    req.overrideMimeType(""text/plain"");
                    req.setRequestHeader(""Content-type"", ""text/plain"");
                } else {
                    req.overrideMimeType(contentType);
                    req.setRequestHeader(""Content-type"", contentType);

                    if (contentType === ""application/octet-stream"") {
                        req.overrideMimeType(""text/plain; charset=x-user-defined"");
                        req.responseType = ""arrayBuffer"";
                    }
                }

                //req.timeout = 30000;
                if (type === 'GET') {
                    req.send();
                } else {
                    req.send(JSON.stringify(data));
                }

                // return the object
                return req;
            };
        };

        /*
        + OWF Functions
        */
        class OWFInterface {
        ");
                WriteLiteral(@"    constructor(interopInterface) {
                this.interopInterface = interopInterface;

                this.shared = interopInterface.shared;
                this.jsUtilities = interopInterface.jsUtilities;
                this.owfInterface = interopInterface.owfInterface;
            };

            GetUserUUID = function() {
                let self = this;
                OWF.Preferences.getUserPreference({
                    namespace: self.shared.namespace,
                    name: ""uuid"",
                    onSuccess: owfdojo.hitch(self, ""onGetUserUUIDSuccess""),
                    onFailure: owfdojo.hitch(self, ""onGetUserUUIDFailure"")
                });
            };

            onGetUserUUIDSuccess = function (pref) {
                let self = this;
                if (pref.value) {
                    self.shared.userProfile.uuid = JSON.parse(pref.value);
                    self.interopInterface.notifyDotnet(""owf.user.uuid"", self.shared.userProfile.uuid);
      ");
                WriteLiteral(@"          } else {
                    window.setTimeout(function() {
                        self.shared.userProfile.uuid = self.guid();
                        self.interopInterface.notifyDotnet(""owf.user.uuid"", self.shared.userProfile.uuid);

                        self.SetUserPreference(""uuid"", self.shared.userProfile.uuid);
                    }, 500);
                }
            };

            onGetUserUUIDFailure = function (error, status) {
                console.log(""!ERROR! - cannot retrieve user configuration/"" + status + ""/"" + error);

                // create uuid and store it
                let self = this;
                if (status !== 404) {
                    window.setTimeout(function() {
                        self.shared.userProfile.uuid = self.guid();
                        self.interopInterface.notifyDotnet(""owf.user.uuid"", self.shared.userProfile.uuid);

                        self.SetUserPreference(""uuid"", self.shared.userProfile.uuid);
                ");
                WriteLiteral(@"    }, 500);
                } else {
                    self.interopInterface.notifyDotnet(""owf.user.uuid"", ""!ERROR! - cannot retrieve user profile info/"" + status + ""/"" + error);
                }
            };

            GetUser = function() {
                let self = this;
                Ozone.pref.PrefServer.getCurrentUser({
                    onSuccess: owfdojo.hitch(self, ""onGetUserInfoSuccess""),
                    onFailure: owfdojo.hitch(self, ""onGetUserInfoFailure"")
                });
            };

            onGetUserInfoSuccess = function (userInfo) {
                let self = this;
                self.shared.userProfile.currentUserName = userInfo.currentUserName;
                self.shared.userProfile.currentUser = userInfo.currentUser;
                self.shared.userProfile.currentUserPrevLogin = userInfo.currentUserPrevLogin;
                self.shared.userProfile.currentId = userInfo.currentId;
                self.shared.userProfile.email = userInfo.email");
                WriteLiteral(@";

                self.interopInterface.notifyDotnet(""owf.user"", JSON.stringify(userInfo));
            };

            onGetUserInfoFailure = function (error, status) {
                let self = this;
                self.shared.userProfile.currentUserName = """";
                self.shared.userProfile.currentUser = """";
                self.shared.userProfile.currentUserPrevLogin = """";
                self.shared.userProfile.currentId = 0;
                self.shared.userProfile.email = """";

                console.log(""!ERROR! - cannot retrieve user profile info/"" + status + ""/"" + error);
                self.interopInterface.notifyDotnet(""owf.user"", ""!ERROR! - cannot retrieve user profile info/"" + status + ""/"" + error);
            };

            GetUserGroups = function() {
                let self = this;
                self.shared.jsUtilities.ajaxCall(self.shared.owfInstance + ""owf/group?user_id="" + self.shared.userProfile.currentId,
                    null,
                    ");
                WriteLiteral(@"owfdojo.hitch(self, ""onGetGroupSuccess""),
                    null,
                    null,
                    ""application/json"",
                    ""GROUPINFO"");
            };

            onGetGroupSuccess = function (groups) {
                let self = this;
                let payload = JSON.parse(groups.payload);
                payload.data.forEach((group) => {
                    if (group.status === ""active"") {
                        self.shared.userProfile.groups.push({
                            displayName: group.displayName,
                            id: group.id,
                            name: group.name
                        });
                    }
                });

                self.interopInterface.notifyDotnet(""owf.user.groups"", JSON.stringify(self.shared.userProfile.groups));
            };

            GetUserPreference = function (key) {
                let self = this;
                OWF.Preferences.getUserPreference({
                   ");
                WriteLiteral(@" namespace: self.shared.namespace,
                    name: key,
                    onSuccess: owfdojo.hitch(self, ""onGetUserPreferenceSuccess"", key),
                    onFailure: owfdojo.hitch(self, ""onGetUserPreferenceFailure"", key)
                });
            };

            onGetUserPreferenceSuccess = function (key, pref) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.get"", JSON.stringify(pref));
            };

            onGetUserPreferenceFailure = function (key, error, status) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.get"", ""!ERROR! - cannot get preference ("" + key + "")/"" + status + ""/"" + error);
            };

            SetUserPreference = function (key, value) {
                let self = this;
                OWF.Preferences.setUserPreference({
                    namespace: self.shared.namespace,
                    name: key,
                    val");
                WriteLiteral(@"ue: value,
                    onSuccess: owfdojo.hitch(self, ""onSetUserPreferenceSuccess"", key, value),
                    onFailure: owfdojo.hitch(self, ""onSetUserPreferenceFailure"", key, value)
                });
            };

            onSetUserPreferenceSuccess = function (key, value, payload) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.set"", JSON.stringify(payload));
            };

            onSetUserPreferenceFailure = function (key, value, error, status) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.set"", ""!ERROR! - cannot set preference ("" + key + "":"" + value + "")/"" + status + ""/"" + error);
            };

            DeleteUserPreference = function (key) {
                let self = this;
                OWF.Preferences.deleteUserPreference({
                    namespace: self.shared.namespace,
                    name: key,
                    onSuccess: o");
                WriteLiteral(@"wfdojo.hitch(self, ""onDeleteUserPreferenceSuccess"", key),
                    onFailure: owfdojo.hitch(self, ""onDeleteUserPreferenceFailure"", key)
                });
            };

            onDeleteUserPreferenceSuccess = function (key, payload) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.delete"", JSON.stringify(payload));
            };

            onDeleteUserPreferenceFailure = function (key, error, status) {
                let self = this;
                self.interopInterface.notifyDotnet(""owf.preference.delete"", ""!ERROR! - cannot get preference ("" + key + "")/"" + status + ""/"" + error);
            };
        };

        /*
        + MAP Functions
        */
        class CMAPIInterface {
            constructor(interopInterface) {
                this.interopInterface = interopInterface;

                this.shared = interopInterface.shared;
                this.jsUtilities = interopInterface.jsUtilities;
         ");
                WriteLiteral(@"       this.owfInterface = interopInterface.owfInterface;
            };

            ReceiveMapStatusView = function (sender, message) {
                let self = this;
                let senderId = JSON.parse(sender);
                if (senderId.id === OWF.getInstanceId()) {
                    return false;
                }

                self.interopInterface.notifyDotnet(""map.status.view"", message);
            };

            ReceiveMapViewClicked = function (sender, message) {
                let self = this;
                let senderId = JSON.parse(sender);
                if (senderId.id === OWF.getInstanceId()) {
                    return false;
                }

                self.interopInterface.notifyDotnet(""map.view.clicked"", message);
            };

            PlotKML = function (uuid, kml) {

            };

            PlotMarker = function (overlay, title, uuid, coordinates) {
                // format kml and cmapi message for marker and publish it");
                WriteLiteral(@"
                let payload = {
                    overlayId:overlay,
                    featureId:title.replace(/ /g, ""-""),
                    name:title,
                    format:""kml"",
                    params:{
                        serviceType:""feature"",
                        format:""image/png"",
                        refreshInterval:""30"",
                        zoom:""false"",
                        showLabels:""false"",
                        opacity:0.2,
                        transparent:""true"",
                        useProxy:""false"",
                        mode:""ondemand""
                    },
                    zoom:true,
                    mapId:1,
                    feature:""<?xml version=\""1.0\"" encoding=\""UTF-8\""?>\n"" +
                        ""<kml xmlns=\""http://www.opengis.net/kml/2.2\"" xmlns:gx=\""http://www.google.com/kml/ext/2.2\"" xmlns:kml=\""http://www.opengis.net/kml/2.2\"" xmlns:atom=\""http://www.w3.org/2005/Atom\"">\n"" +
                        ""<D");
                WriteLiteral(@"ocument>\n"" +
                        ""    <name>"" + overlay.replace(/ /g, ""-"") + ""_"" + title.replace(/ /g, ""-"") + "".kml</name>\n\n"" +
                        ""    <Placemark>\n"" +
                        ""        <id>"" + uuid + ""</id>\n\n"" +
                        ""        <name>"" + title + ""</name>\n\n"" +
                        ""        <Point>\n"" +
                        ""            <coordinates>"" + coordinates + ""</coordinates>\n"" +
                        ""        </Point>\n\n"" +
                        ""    </Placemark>\n\n"" +
                        ""</Document>\n"" +
                        ""</kml>""
                }

                OWF.Eventing.publish(""map.feature.plot"", JSON.stringify(payload));
            };

            PlotLineString = function (overlay, title, uuid, coordinates) {
                console.log(uuid, coordinates);
            };

            PlotPolygon = function (overlay, title, uuid, outerBoundary, innerBoundary = """") {
                console.log(uuid");
                WriteLiteral(@", outerBoundary, innerBoundary);
            };

            PlotServiceFeature = function (overlay, title, uuid, url, filter) {

            };

            PlotServiceMeasurement = function (message) {

            };

            PlotServiceGeocoding = function (message) {

            };
        };

        /*
        + interop channel controller
        */
        class INTEROPInterface {
            shared = {
                namespace: ""rescue21.uscg.mil"",
                owfInstance: ""https://localhost:8443/"",
                dotnetInstance: null,
                channels: {},
                userProfile: {
                    uuid: """",
                    currentUserName: """",
                    currentUser: """",
                    currentUserPrevLogin: """",
                    currentId: 0,
                    email: """",
                    groups: []
                }
            }

            constructor() {
                this.shared.jsUtilities = new JSUtili");
                WriteLiteral(@"ties();
                this.shared.owfInterface = new OWFInterface(this);
                this.shared.cmapiInterface = new CMAPIInterface(this);
                this.shared.interopInterface = this;
            };

            notifyDotnet = function(channel, message) {
                let self = this;
                if (self.shared.hasOwnProperty(""dotnetInstance"") && self.shared.dotnetInstance &&
                    (self.shared.channels.hasOwnProperty(channel))) {
                    let callback = self.shared.channels[channel].callback;
                    const result = self.shared.dotnetInstance.invokeMethodAsync(callback, message);
                }
            };

            INTEROPMessageHandler = {
                register: (objRef) => {
                    let self = this;
                    self.shared.dotnetInstance = objRef;
                },
                start: (channel, callback, execute, context, key, value) => {
                    let self = this;
               ");
                WriteLiteral(@"     let valid = self.shared.channels.hasOwnProperty(channel);
                    if (!valid) {
                        self.shared.channels[channel] = {
                            ""callback"": callback
                        }
                    }

                    if (execute) {
                        if (context.toLowerCase() === ""owf"") {
                            self.shared.jsUtilities.executeFunctionByName(callback, self.shared.owfInterface, key, value);
                        } else if (context.toLowerCase() === ""cmapi"") {
                            self.shared.jsUtilities.executeFunctionByName(callback, self.shared.cmapiInterface, key, value);
                        }
                    }
                },
                stop: (channel) => {
                    let self = this;
                    let valid = self.shared.channels.hasOwnProperty(channel);
                    if (valid) {
                        delete self.shared.channels[channel];
                   ");
                WriteLiteral(@" }
                },
                deregister: () => {
                    let self = this;
                    self.shared.channels = {};
                    self.shared.dotnetInstance = null;
                },
                broadcast: (channel, message, uuid) => {
                    if (!message && !uuid) {
                        OWF.Eventing.publish(channel, message, uuid);
                    } else if (!uuid) {
                        OWF.Eventing.publish(channel, message);
                    } else {
                        OWF.Eventing.publish(channel);
                    }
                }
            };

            /*
            + initial OWF setup and default channel activation (called from index.razor)
            */
            /*
            shutdownWidget = function() {
                // remove listener override to prevent looping
                self._WidgetStateController.removeStateEventOverrides({
                    events: ['beforeclose'],
          ");
                WriteLiteral(@"          callback: function () {
                        // unsubcribe the events
                        OWF.Eventing.unsubscribe(""map.status.view"");

                        self._WidgetStateController.closeWidget();
                    }
                });
            };
            */
            RegisterEvents = function() {
                let self = this;
                OWF.Eventing.subscribe(""map.status.view"", owfdojo.hitch(self.shared.cmapiInterface, ""ReceiveMapStatusView""));
                OWF.Eventing.subscribe(""map.view.clicked"", owfdojo.hitch(self.shared.cmapiInterface, ""ReceiveMapViewClicked""));
            };

            UnregisterEvents = function() {
                OWF.Eventing.unsubscribe(""map.status.view"");
            };

            AttachHandlers = () => {
                console.log("".. attaching handlers! (debug view trap; remove prior to publish for production)"");

                let self = this;
                OWF.relayFile = ""js/eventing/rpc_relay.unco");
                WriteLiteral(@"mpressed.html?deployVer=1.2.0"";
                owfdojo.config.dojoBlankHtmlUrl = ""js/dojo-1.5.0-windowname-only/dojo/resources/blank.html?deployVer=1.2.0"";
                /*
                self._WidgetStateController = Ozone.state.WidgetState.getInstance({
                    widgetEventingController: Ozone.eventing.Widget.getInstance(),
                    autoInit: true,

                    // this is fired on any event that you are registered for.
                    // the msg object tells us what event it was
                    onStateEventReceived: function (sender, msg) {
                        if (msg.eventName === ""beforeclose"") {
                            self.shutdownWidget(null, null);
                        }
                    }
                });
                self._WidgetStateController.addStateEventOverrides({
                    events: [""beforeclose""]
                });
                */
            };
        };

        var interopInterface = new INTER");
                WriteLiteral("OPInterface();\r\n        Blazor.start();\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages__Host> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages__Host>)PageContext?.ViewData;
        public Pages__Host Model => ViewData.Model;
    }
}
#pragma warning restore 1591
