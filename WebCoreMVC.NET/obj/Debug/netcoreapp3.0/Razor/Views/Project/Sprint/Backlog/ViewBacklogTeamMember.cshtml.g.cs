#pragma checksum "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68cc9243a838094d0ad9ebacf034a584ea9ff74e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Sprint_Backlog_ViewBacklogTeamMember), @"mvc.1.0.view", @"/Views/Project/Sprint/Backlog/ViewBacklogTeamMember.cshtml")]
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
#line 1 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\_ViewImports.cshtml"
using WebCoreMVC.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\_ViewImports.cshtml"
using WebCoreMVC.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cc9243a838094d0ad9ebacf034a584ea9ff74e", @"/Views/Project/Sprint/Backlog/ViewBacklogTeamMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"095334c964c978378f687075dd67b876345a8e20", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Sprint_Backlog_ViewBacklogTeamMember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContainerForListAndId<SprintUserStory>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
  
    ViewData["Title"] = "Sprint Backlog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68cc9243a838094d0ad9ebacf034a584ea9ff74e3849", async() => {
                WriteLiteral("\r\n    <title>Product Backlog</title>\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/custom.css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68cc9243a838094d0ad9ebacf034a584ea9ff74e4929", async() => {
                WriteLiteral(@"
    <button class=""btn btn-primary"" onclick=""goToPreviousWebsite()"">< Back</button>
    <br />
    <br />
    <h1>User Stories</h1>
    <h6 id=""sprintBacklogError"" class=""text-danger""></h6>
    <div class=""row"">
        <div class=""structure"">
            <ul id=""listOfSprinttUserStories"">
");
#nullable restore
#line 23 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
                 foreach (var item in Model.accessList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"flex-row\">\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
                      Write(item.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p class=\"text-info padding-left-30px\">Priority: ");
#nullable restore
#line 27 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
                                                                    Write(item.priority);

#line default
#line hidden
#nullable disable
                WriteLiteral(", Difficulty: ");
#nullable restore
#line 27 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
                                                                                                Write(item.difficulty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <button class=\"btn btn-warning margin-left-80px\"");
                BeginWriteAttribute("onclick", " onclick=\"", 920, "\"", 969, 3);
                WriteAttributeValue("", 930, "openTasksModal(", 930, 15, true);
#nullable restore
#line 28 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
WriteAttributeValue("", 945, item.sprintUserStoryId, 945, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 968, ")", 968, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Tasks</button>\r\n                    </li>\r\n");
#nullable restore
#line 30 "C:\Users\VALERA\source\repos\Prebiusta\Semester_Project_3\SEP3_Client\WebCoreMVC.NET\Views\Project\Sprint\Backlog\ViewBacklogTeamMember.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </ul>
        </div>
    </div>

    <!-- Modal for assigning user story to the sprint -->
    <div class=""modal fade"" id=""assignUserStoryToSprintModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div id=""listOfProjectUserStoriesInsideSprint""></div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </d");
                WriteLiteral(@"iv>
        </div>
    </div>
    <!-- Modal for displaying tasks assigned to the user story -->
    <div class=""modal fade"" id=""userStoryTasks"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div id=""listOfTasksForTheUserStory""></div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>");
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContainerForListAndId<SprintUserStory>> Html { get; private set; }
    }
}
#pragma warning restore 1591