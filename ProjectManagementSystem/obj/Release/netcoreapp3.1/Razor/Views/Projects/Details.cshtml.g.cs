#pragma checksum "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a354e2bd40039d56cf83fc9f0838f01b911da90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\_ViewImports.cshtml"
using ProjectManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
using ProjectManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
using ProjectManagementSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a354e2bd40039d56cf83fc9f0838f01b911da90", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d859d2befe7314297517f7cc2ff7e48d506275", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagementSystem.ViewModels.ProjectDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("k-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
   ViewData["Title"] = $"{@Model.Name} Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""k-content"">
    <div id=""tabStrip"">
        <ul>
            <li class=""k-state-active"">
                General Information
            </li>
            <li>
                Team Members
            </li>
            <li>
                Risks
            </li>
            <li>
                Requirements
            </li>
            <li>
                Monitoring And Tracking
            </li>
        </ul>
        <div id=""generalInformationTab"">
            <p class=""label"">
                ");
#nullable restore
#line 30 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
           Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <ul>\r\n                <li class=\"field\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
               Write(Html.DisplayTextFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n            <p class=\"label\">\r\n                ");
#nullable restore
#line 38 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
           Write(Html.LabelFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <ul>\r\n                <li class=\"field\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.OwnerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n            <p class=\"label\">\r\n                ");
#nullable restore
#line 46 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
           Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <ul>\r\n                <li class=\"field\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a354e2bd40039d56cf83fc9f0838f01b911da907990", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a354e2bd40039d56cf83fc9f0838f01b911da9010260", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 58 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
        Write(Html.Kendo().Grid<TeamMember>(Model.TeamMembers)
                .Name("teamMemberGrid")
                .Columns(columns =>
                {
                    columns.Bound(teamMember => teamMember.FirstName);
                    columns.Bound(teamMember => teamMember.LastName);
                })
                .Navigatable()
                .Sortable()
                .Scrollable()
                .Pageable(pageable => pageable
                    .Input(true)
                    .Numeric(false)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 73 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
        Write(Html.Kendo().Grid<Risk>(Model.Risks)
                .Name("riskGrid")
                .Columns(columns =>
                {
                    columns.Bound(risk => risk.RiskName);
                    columns.Bound(risk => risk.RiskStatus);
                })
                .Navigatable()
                .Sortable()
                .Scrollable()
                .Pageable(pageable => pageable
                    .Input(true)
                    .Numeric(false)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 88 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
        Write(Html.Kendo().Grid<RequirementViewModel>(Model.Requirements)
                .Name("requirementGrid")
                .Columns(columns =>
                {
                    columns.Bound(p => p.RequirementName);
                    columns.Bound(p => p.Description);
                    columns.Bound(p => p.RequirementType.DisplayName);
                })
                .Navigatable()
                .Sortable()
                .Scrollable()
                .Pageable(pageable => pageable
                    .Input(true)
                    .Numeric(false)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <div id=\"effortButtonBox\">\r\n                ");
#nullable restore
#line 105 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
            Write(Html.Kendo().Button()
                    .Name("viewProjectAnalysisButton")
                    .HtmlAttributes(new { type = "button" })
                    .Content("Analyze Project Status"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            ");
#nullable restore
#line 111 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
        Write(Html.Kendo().Grid<RequirementEffortViewModel>(Model.RequirementEfforts)
                .Name("requirementEffortGrid")
                .Columns(columns =>
                {
                    columns.Bound(p => p.Requirement.RequirementName);
                    columns.Bound(p => p.RequirementEffortType.DisplayName);
                    columns.Bound(p => p.TeamMember.FullName).Title("Team Member");
                    columns.Bound(p => p.TimeFrame.DisplayName);
                    columns.Bound(p => p.DateFrom).ClientTemplate("#= kendo.toString(DateFrom, 'MM/dd/yyyy') #");
                    columns.Bound(p => p.DateTo).ClientTemplate("#= kendo.toString(DateTo, 'MM/dd/yyyy') #");
                    columns.Bound(p => p.TimeExpended);
                })
                .Navigatable()
                .Pageable(pageable => pageable
                    .Input(true)
                    .Numeric(false))
                .Sortable()
                .Scrollable());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div style=\"display: none\">\r\n    ");
#nullable restore
#line 134 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Details.cshtml"
Write(Html.Kendo().Window()
        .Name("viewProjectAnalysisWindow")
        .Title($"{@Model.Name} Status")
        .Modal(true)
        .Visible(false)
        .Content("loading...")
        .Resizable()
        .Draggable()
        .LoadContentFrom("ProjectStatusPopUp", "Projects", new { IdProject = Model.Id })
        .Actions(actions => actions
            .Close())
        );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>
    $(document).ready(function() {

        $(""#tabStrip"").kendoTabStrip({
            animation: {
                open: {
                    effects: ""fadeIn""
                }
            }
        });

        $(""#viewProjectAnalysisButton"").bind(""click"",
            function () {
                $(""#viewProjectAnalysisWindow"").data(""kendoWindow"").maximize().open();
            });
    });

</script>

<style>

    p.label {
        margin: 0 0 0em;
        padding: 0;
        display: block;
        font-weight: bold;
    }

    li.field {
        margin: 0 0 0em;
        padding: 0;
        width: 100%;
    }
    
    #tabStrip > .k-content {
        overflow: visible;
    }

    #effortButtonBox {
        padding-bottom: 10px
    }

    .k-grid .k-grid-header .k-header .k-link {
        height: auto;
    }

    .k-grid .k-grid-header .k-header {
        white-space: normal;
    }

</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagementSystem.ViewModels.ProjectDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591