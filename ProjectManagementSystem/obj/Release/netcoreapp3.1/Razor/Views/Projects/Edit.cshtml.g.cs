#pragma checksum "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e04d5054d3440a52adfc2e35d3b6cc2f2bb561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
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
#line 1 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
using ProjectManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
using ProjectManagementSystem.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e04d5054d3440a52adfc2e35d3b6cc2f2bb561", @"/Views/Projects/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4d859d2befe7314297517f7cc2ff7e48d506275", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagementSystem.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("k-textbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("k-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("projectForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
   ViewData["Title"] = $"Edit {@Model.Name}"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"k-content\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb5616386", async() => {
                WriteLiteral(@"
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
                <ul id=""fieldlist"">
                    <li>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb5617279", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 32 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb5618818", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb56110495", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 36 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OwnerName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb56112040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 37 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OwnerName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb56113723", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 40 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Description, new { id = "editProjectDescription", @class = "k-textbox", style = "height:100px; width: 100%;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n                    <li class=\"actions\">\r\n                        <button type=\"submit\" data-role=\"button\" data-icon=\"check\">Update Project</button> |\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e04d5054d3440a52adfc2e35d3b6cc2f2bb56115877", async() => {
                    WriteLiteral("<span class=\"k-icon k-i-undo\"></span>Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 50 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
            Write(Html.Kendo().Grid<TeamMemberViewModel>()
                    .Name("teamMemberGrid")
                    .Columns(columns =>
                    {
                        columns.Bound(teamMember => teamMember.FirstName);
                        columns.Bound(teamMember => teamMember.LastName);
                        columns.Command(command => { command.Destroy(); }).Width(150);
                    })
                    .ToolBar(toolbar =>
                    {
                        toolbar.Create().Text("Add New Team Member");
                        toolbar.Save();
                    })
                    .Editable(editable => editable.Mode(GridEditMode.InCell))
                    .Navigatable()
                    .Sortable()
                    .Scrollable()
                    .Pageable(pageable => pageable
                        .Input(true)
                        .Numeric(false))
                    .DataSource(dataSource => dataSource
                        .Ajax()
                        .Events((builder) =>
                        {
                            builder.Sync("teamdatasource_change");
                        })
                        .Batch(true)
                        .PageSize(10)
                        .ServerOperation(false)
                        .Model(model => model.Id(teamMember => teamMember.Id))
                        .Read(read =>
                        {
                            read.Type(HttpVerbs.Get);
                            read.Action("Grid_Read", "TeamMembers", new { IdProject = Model.Id });
                        })
                        .Create(create =>
                        {
                            create.Type(HttpVerbs.Post);
                            create.Action("Grid_Create", "TeamMembers", new { IdProject = Model.Id });
                        })
                        .Update(update =>
                        {
                            update.Type(HttpVerbs.Put);
                            update.Action("Grid_Update", "TeamMembers", new { IdProject = Model.Id });
                        })
                        .Destroy(destroy =>
                        {
                            destroy.Type(HttpVerbs.Delete);
                            destroy.Action("Grid_Destroy", "TeamMembers", new { IdProject = Model.Id });
                        })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 102 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
            Write(Html.Kendo().Grid<Risk>()
                    .Name("riskGrid")
                    .Columns(columns =>
                    {
                        columns.Bound(risk => risk.RiskName);
                        columns.Bound(risk => risk.RiskStatus);
                        columns.Command(command => { command.Destroy(); }).Width(150);
                    })
                    .ToolBar(toolbar =>
                    {
                        toolbar.Create().Text("Add New Risk");
                        toolbar.Save();
                    })
                    .Editable(editable => editable.Mode(GridEditMode.InCell))
                    .Navigatable()
                    .Sortable()
                    .Scrollable()
                    .Pageable(pageable => pageable
                        .Input(true)
                        .Numeric(false))
                    .DataSource(dataSource => dataSource
                        .Ajax()
                        .Events((builder) =>
                        {
                            builder.Sync("datasource_change");
                        })
                        .Batch(true)
                        .PageSize(10)
                        .ServerOperation(false)
                        .Model(model => model.Id(risk => risk.Id))
                        .Read(read =>
                        {
                            read.Type(HttpVerbs.Get);
                            read.Action("Grid_Read", "Risks", new { IdProject = Model.Id });
                        })
                        .Create(create =>
                        {
                            create.Type(HttpVerbs.Post);
                            create.Action("Grid_Create", "Risks", new { IdProject = Model.Id });
                        })
                        .Update(update =>
                        {
                            update.Type(HttpVerbs.Put);
                            update.Action("Grid_Update", "Risks", new { IdProject = Model.Id });
                        })
                        .Destroy(destroy =>
                        {
                            destroy.Type(HttpVerbs.Delete);
                            destroy.Action("Grid_Destroy", "Risks", new { IdProject = Model.Id });
                        })));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 154 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
            Write(Html.Kendo().Grid<RequirementViewModel>()
                    .Name("requirementGrid")
                    .Columns(columns =>
                    {
                        columns.Bound(p => p.RequirementName);
                        columns.Bound(p => p.Description);
                        columns.Bound(p => p.RequirementType).ClientTemplate("#=RequirementType.DisplayName#");
                        columns.Command(command =>
                        {
                            command.Destroy();
                        }).Width(100);
                    })
                    .ToolBar(toolbar =>
                    {
                        toolbar.Create().Text("Add New Requirement");
                        toolbar.Save();
                    })
                    .Editable(editable => editable.Mode(GridEditMode.InCell))
                    .Navigatable()
                    .Pageable(pageable => pageable
                        .Input(true)
                        .Numeric(false))
                    .Sortable()
                    .Scrollable()
                    .DataSource(dataSource =>
                    {
                        dataSource.Ajax()
                            .Events((builder) =>
                            {
                                builder.Sync("requirementdatasource_change");
                            })
                            .Batch(true)
                            .PageSize(10)
                            .ServerOperation(false)
                            .Model(model =>
                            {
                                model.Id(p => p.Id);
                                model.Field(p => p.RequirementType).DefaultValue(ViewData["defaultRequirementType"] as RequirementType);
                            })
                            .Read(read =>
                            {
                                read.Type(HttpVerbs.Get);
                                read.Action("Grid_Read", "Requirements", new { IdProject = Model.Id });
                            })
                            .Create(create =>
                            {
                                create.Type(HttpVerbs.Post);
                                create.Action("Grid_Create", "Requirements", new { IdProject = Model.Id });
                            })
                            .Update(update =>
                            {
                                update.Type(HttpVerbs.Put);
                                update.Action("Grid_Update", "Requirements", new { IdProject = Model.Id });
                            })
                            .Destroy(destroy =>
                            {
                                destroy.Type(HttpVerbs.Delete);
                                destroy.Action("Grid_Destroy", "Requirements", new { IdProject = Model.Id });
                            });
                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <div id=\"effortButtonBox\">\r\n                    <button id=\"addRequirmentEffortButton\" type=\"button\" data-role=\"button\" data-icon=\"plus\">Add Effort</button> | \r\n                    ");
#nullable restore
#line 218 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
                Write(Html.Kendo().Button()
                        .Name("viewProjectAnalysisButton")
                        .HtmlAttributes(new { type = "button" }).IconClass("k-icon k-i-graph")
                        .Content("Analyze Project Status"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                ");
#nullable restore
#line 224 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
            Write(Html.Kendo().Grid<RequirementEffortViewModel>()
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
                        columns.Command(command =>
                        {
                            command.Custom("Edit").IconClass("k-icon k-i-edit").Click("EditRequirementEffort");
                        }).Width(100);
                        columns.Command(command =>
                        {
                            command.Destroy();
                        }).Width(100);
                    })
                    .Navigatable()
                    .Pageable(pageable => pageable
                        .Input(true)
                        .Numeric(false))
                    .Sortable()
                    .Scrollable()
                    .DataSource(dataSource =>
                    {
                        dataSource.Ajax()
                            .Events((builder) =>
                            {
                                builder.Sync("datasource_change");
                            })
                            .Batch(false)
                            .AutoSync(true)
                            .PageSize(10)
                            .ServerOperation(false)
                            .Model(model =>
                            {
                                model.Id(p => p.Id);
                                model.Field(p => p.RequirementEffort);
                                model.Field(p => p.Requirement);
                                model.Field(p => p.RequirementEffortType);
                                model.Field(p => p.TeamMember);
                                model.Field(p => p.TimeFrame);
                            })
                            .Read(read =>
                            {
                                read.Type(HttpVerbs.Get);
                                read.Action("Grid_Read", "RequirementEfforts", new {IdProject = Model.Id});
                            })
                            .Destroy(destroy =>
                            {
                                destroy.Type(HttpVerbs.Delete);
                                destroy.Action("Grid_Destroy", "RequirementEfforts", new { IdProject = Model.Id });
                            });

                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"display: none\">\r\n    ");
#nullable restore
#line 288 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
Write(Html.Kendo().Window()
        .Name("addRequirmentEffortWindow")
        .Title("Add Effort")
        .Modal(true)
        .Visible(false)
        .Content("loading...")
        .Resizable()
        .Draggable()
        .MinHeight(320)
        .MinWidth(500)
        .LoadContentFrom("CreatePopUp", "RequirementEfforts", new { IdProject = Model.Id })
        .Events(e =>
        {
            e.Close("addRequirmentEffortWindowClose");
        })
        .Actions(actions => actions
            .Maximize()
            .Close())
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"display: none\">\r\n    ");
#nullable restore
#line 310 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
Write(Html.Kendo().Window()
        .Name("editRequirementEffortWindow")
        .Title("Edit Effort")
        .Modal(true)
        .Visible(false)
        .Content("loading...")
        .Resizable()
        .Draggable()
        .MinHeight(400)
        .MinWidth(500)
        .Events(e =>
        {
            e.Close("editRequirementEffortWindowClose");
        })
        .Actions(actions => actions
            .Maximize()
            .Close())
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"display: none\">\r\n    ");
#nullable restore
#line 331 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
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
    $(document).ready(function () {

        var container = $(""#projectForm"");
        kendo.init(container);

        $(""#projectForm"").kendoValidator({
            // You can define your custom rules here:
            //rules: {}

        });

        $(""#tabStrip"").kendoTabStrip({
            animation: {
                open: {
                    effects: ""fadeIn""
                }
            }
        });

        $(""#addRequirmentEffortButton"").bind(""click"",
            function () {
                $(""#addRequirmentEffortWindow"").data(""kendoWindow"").refresh();
                $(""#addRequirmentEffortWindow"").data(""kendoWindow"").center().open();
            });

        $(""#viewProjectAnalysisButton"").bind(""click"",
            function () {
                $(""#viewProjectAnalysisWindow"").data(""kendoWindow"").refresh();
                $(""#viewProjectAnalysisWindow"").data(""kendoWindow"").maximize().open();
            });

    });

    function datas");
            WriteLiteral(@"ource_change(e) {
        this.read();
    }

    function requirementdatasource_change(e) {
        this.read();
        $(""#requirementEffortGrid"").data(""kendoGrid"").dataSource.read();
    }

    function teamdatasource_change(e) {
        this.read();
        $(""#requirementEffortGrid"").data(""kendoGrid"").dataSource.read();
    }

    function addRequirmentEffortWindowClose() {
        $(""#createPopUpDateTo"").data(""kendoDatePicker"").enable(false);
        $(""#requirementEffortGrid"").data(""kendoGrid"").dataSource.read();
    }

    function createOnSelect(e) {
        if (e.sender.dataItem(e.item)[e.sender.options.dataTextField] == e.sender.options.optionLabel) {
            $(""#createPopUpDateFrom"").data(""kendoDatePicker"").enable(false);
            $(""#createPopUpDateFrom"").data(""kendoDatePicker"").value(null);
            createPopUpDateFromChange();
        } else {
            $(""#createPopUpDateFrom"").data(""kendoDatePicker"").enable(true);
            createPopUpDateFromChange();");
            WriteLiteral(@"
        }
    }

    function createPopUpDateFromChange() {
        var dateFrom = $(""#createPopUpDateFrom"").data(""kendoDatePicker"").value();
        var timeFrame = $(""#createPopUpTimeFrame"").data(""kendoDropDownList"").text();
        var dateToPicker = $(""#createPopUpDateTo"").data(""kendoDatePicker"");

        if (dateFrom) {
            if (timeFrame == ""Daily"") {
                dateToPicker.value(dateFrom);
            } else if (timeFrame == ""Weekly"") {
                var dateTo = new Date(dateFrom);
                dateTo.setDate(dateTo.getDate() + 7);
                dateToPicker.value(dateTo);
            }
        }
        else {
            dateToPicker.value(null);
        }
    }

    function EditRequirementEffort(e) {
        e.preventDefault();

        var dataItem = this.dataItem($(e.currentTarget).closest(""tr""));
        $(""#editRequirementEffortWindow"").data(""kendoWindow"").refresh({
            url: ""/RequirementEfforts/EditPopUp/"",
            data: { IdProje");
            WriteLiteral("ct: ");
#nullable restore
#line 434 "C:\Users\premiere\source\repos\ProjectManagementSystem\ProjectManagementSystem\Views\Projects\Edit.cshtml"
                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", IdRequirementEffort: dataItem.Id }
        });
        $(""#editRequirementEffortWindow"").data(""kendoWindow"").center().open();
    }

    function editRequirementEffortWindowClose() {
        $(""#editPopUpDateTo"").data(""kendoDatePicker"").enable(false);
        $(""#requirementEffortGrid"").data(""kendoGrid"").dataSource.read();
    }

    function editOnSelect(e) {
        if (e.sender.dataItem(e.item)[e.sender.options.dataTextField] == e.sender.options.optionLabel) {
            $(""#editPopUpDateFrom"").data(""kendoDatePicker"").enable(false);
            $(""#editPopUpDateFrom"").data(""kendoDatePicker"").value(null);
            editPopUpDateFromChange();
        } else {
            $(""#editPopUpDateFrom"").data(""kendoDatePicker"").enable(true);
            editPopUpDateFromChange();
        }
    }

    function editPopUpDateFromChange() {
        var dateFrom = $(""#editPopUpDateFrom"").data(""kendoDatePicker"").value();
        var timeFrame = $(""#editPopUpTimeFrame"").data(""kendoDropDownList"").t");
            WriteLiteral(@"ext();
        var dateToPicker = $(""#editPopUpDateTo"").data(""kendoDatePicker"");

        if (dateFrom) {
            if (timeFrame == ""Daily"") {
                dateToPicker.value(dateFrom);
            } else if (timeFrame == ""Weekly"") {
                var dateTo = new Date(dateFrom);
                dateTo.setDate(dateTo.getDate() + 7);
                dateToPicker.value(dateTo);
            }
        }
        else {
            dateToPicker.value(null);
        }
    }

</script>

<style>

    #fieldlist {
        margin: 0 0 -2em;
        padding: 0;
    }

    #fieldlist li {
        list-style: none;
        padding-bottom: 1em;
    }

    #fieldlist label {
        display: block;
        font-weight: bold;
    }

    #tabStrip > .k-content {
        overflow: visible;
    }

    #fieldlist input {
        width: 100%;
    }

    #generalInformationTab {
        padding-bottom: 35px
    }

    #effortButtonBox {
        padding-bottom: 10px
    }

");
            WriteLiteral(@"    .k-grid  .k-grid-header  .k-header  .k-link {
        height: auto;
    }
  
    .k-grid  .k-grid-header  .k-header {
        white-space: normal;
    }

    .k-i-edit{
        margin-right: .2em;
    }

    .k-i-undo{
        margin-right: .3em;
    }

</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagementSystem.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
