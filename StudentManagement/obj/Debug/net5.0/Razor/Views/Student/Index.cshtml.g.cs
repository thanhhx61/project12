#pragma checksum "E:\team-1\StudentManagement\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35d4d31f49375f7d6dccd27568dc3e69b23a5918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\team-1\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Comments;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d4d31f49375f7d6dccd27568dc3e69b23a5918", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec606ae895fe170cdcca74d87947f49addc84d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("red_  space-left space-right pg-2px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Name..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("red_ space-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-bottom:2px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "List Student";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"row\">\r\n                <div class=\"col-7\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d4d31f49375f7d6dccd27568dc3e69b23a59187749", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35d4d31f49375f7d6dccd27568dc3e69b23a59188031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d4d31f49375f7d6dccd27568dc3e69b23a59189911", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d4d31f49375f7d6dccd27568dc3e69b23a591810207", async() => {
                        WriteLiteral("学年");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 14 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SchoolYearId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SchoolYearId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d4d31f49375f7d6dccd27568dc3e69b23a591813413", async() => {
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 17 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ListEventId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <input class=""red_ space-right pg-2px"" placeholder=""#Skill..."" type=""text"">

                        <button class=""sizeIconSearch"">
                            <i class=""bi bi-search""></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <hr />
    <div class=""card-body"">
        <table class=""table table-bordered"" id=""mytbEvent"">
            <thead class=""thead-dark"" style=""background-color: #3e55df; color: white"">
                <tr>

                    <th class=""center"">
                        学生コード
                    </th>
                    <th class=""center"">
                        学生の名前
                    </th>
                    <th class=""center"">
                        学年
                    </th>
                    <th class=""center"">
                        イベント
                    </th>
                    <th class=""center"">
                        ハッシュタグ
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 53 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                 foreach (var item in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"dbclick\"");
            BeginWriteAttribute("id", " id=\"", 2060, "\"", 2073, 1);
#nullable restore
#line 55 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
WriteAttributeValue("", 2065, item.Id, 2065, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td class=\"center\">\r\n                            <p>");
#nullable restore
#line 57 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.StudentCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td class=\"center\" style=\"font-weight:600\">\r\n                            <p>");
#nullable restore
#line 60 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td class=\"center\">\r\n                            <p>\r\n                                ");
#nullable restore
#line 64 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserSchoolYears.OrderByDescending(u => u.SchoolYearId).FirstOrDefault(m => m.UserId == item.Id).SchoolYear.SchoolYearName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </td>\r\n                        <td>\r\n\r\n");
#nullable restore
#line 69 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                             if (item.Events.Count != 0)
                            {
                                var evtName = string.Empty;

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                 foreach (var evt in item.Events)
                                {
                                    if (!evtName.Contains(evt.ListEvent.ListEventName))
                                    {
                                        evtName += " " + evt.ListEvent.ListEventName;
                                    }

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                 

                                var listEvt = evtName.Split(" ").Skip(1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <strong>");
#nullable restore
#line 83 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                   Write(string.Join(", ", listEvt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 84 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 87 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                             if (item.Messages.Count() > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                 foreach (var mess in item.Messages.Where(i => i.SkillId != null))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p");
            BeginWriteAttribute("style", " style=\"", 3843, "\"", 3875, 3);
            WriteAttributeValue("", 3851, "color:", 3851, 6, true);
#nullable restore
#line 92 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
WriteAttributeValue("", 3857, mess.Skill.Style, 3857, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3874, ";", 3874, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                                                   Write(mess.Skill.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 93 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 99 "E:\team-1\StudentManagement\Views\Student\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('.dbclick').dblclick(function () {
            var stuId = $(this).attr('id');
            window.location.replace(`/Events/Index/${stuId}`);
            return false;
        });
        //datatb
            $(""#mytbEvent"").DataTable({
                ""searching"": false,
            ""ordering"": false,
            ""bLengthChange"": false,
            ""bInfo"": false,
            ""language"": {
                ""paginate"": {
                ""next"": ""»"",
            ""previous"": ""«""
                }
            },
            ""oLanguage"": {
                ""sEmptyTable"": ""テーブルにデータがありません""
            }
        });
            $(document).ready(function () {
                $('#mytbEvent').DataTable();
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
