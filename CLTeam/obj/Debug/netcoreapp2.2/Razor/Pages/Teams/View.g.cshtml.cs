#pragma checksum "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5325658ff297dc01f7033ea27613ac936bf7f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CLTeam.Pages.Teams.Pages_Teams_View), @"mvc.1.0.razor-page", @"/Pages/Teams/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Teams/View.cshtml", typeof(CLTeam.Pages.Teams.Pages_Teams_View), @"{id:int}")]
namespace CLTeam.Pages.Teams
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/_ViewImports.cshtml"
using CLTeam;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5325658ff297dc01f7033ea27613ac936bf7f7", @"/Pages/Teams/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"289e0dd2b24752a1da86739906a6e68cdcd61edf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Teams_View : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(73, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(98, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5325658ff297dc01f7033ea27613ac936bf7f74178", async() => {
                BeginContext(104, 12, true);
                WriteLiteral("\n    <title>");
                EndContext();
                BeginContext(117, 15, false);
#line 12 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
      Write(Model.Team.Name);

#line default
#line hidden
                EndContext();
                BeginContext(132, 9, true);
                WriteLiteral("</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(148, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(149, 534, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5325658ff297dc01f7033ea27613ac936bf7f75670", async() => {
                BeginContext(155, 15, true);
                WriteLiteral("\n<div>\n    <h1>");
                EndContext();
                BeginContext(171, 13, false);
#line 16 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
   Write(Model.Team.Id);

#line default
#line hidden
                EndContext();
                BeginContext(184, 14, true);
                WriteLiteral("</h1>\n    <h1>");
                EndContext();
                BeginContext(199, 15, false);
#line 17 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
   Write(Model.Team.Name);

#line default
#line hidden
                EndContext();
                BeginContext(214, 15, true);
                WriteLiteral("</h1>\n    <ul>\n");
                EndContext();
#line 19 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
         foreach (var player in Model.Players)
        {

#line default
#line hidden
                BeginContext(286, 16, true);
                WriteLiteral("            <li>");
                EndContext();
                BeginContext(304, 38, false);
#line 21 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
            Write($"Id: {player.Id} Name: {player.Name}");

#line default
#line hidden
                EndContext();
                BeginContext(343, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 22 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
        }

#line default
#line hidden
                BeginContext(359, 46, true);
                WriteLiteral("    </ul>\n    <h2>Add Player to team</h2>\n    ");
                EndContext();
                BeginContext(405, 263, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5325658ff297dc01f7033ea27613ac936bf7f77609", async() => {
                    BeginContext(425, 32, true);
                    WriteLiteral("\n        <select name=\"player\">\n");
                    EndContext();
#line 27 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
         foreach (var player in Model.PlayersNotOnTeam)
        {

#line default
#line hidden
                    BeginContext(523, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                    BeginContext(535, 48, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5325658ff297dc01f7033ea27613ac936bf7f78336", async() => {
                        BeginContext(563, 11, false);
#line 29 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
                                  Write(player.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 29 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
               WriteLiteral(player.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(583, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 30 "/Users/mdurham/Source/CLTeam/CLTeam/Pages/Teams/View.cshtml"
        }

#line default
#line hidden
                    BeginContext(594, 67, true);
                    WriteLiteral("        </select>\n        <input type=\"submit\" value=\"Submit\">\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(668, 8, true);
                WriteLiteral("\n</div>\n");
                EndContext();
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
            EndContext();
            BeginContext(683, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CLTeam.Pages.Teams.View> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CLTeam.Pages.Teams.View> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CLTeam.Pages.Teams.View>)PageContext?.ViewData;
        public CLTeam.Pages.Teams.View Model => ViewData.Model;
    }
}
#pragma warning restore 1591
