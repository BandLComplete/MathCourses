#pragma checksum "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cd572ee373ffd7fbd7a4506eb1aaf5d47454c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Course), @"mvc.1.0.view", @"/Views/Home/Course.cshtml")]
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
#line 1 "C:\Users\borov\Desktop\InProcess\Views\_ViewImports.cshtml"
using InProcess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\borov\Desktop\InProcess\Views\_ViewImports.cshtml"
using InProcess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
using InProcess.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cd572ee373ffd7fbd7a4506eb1aaf5d47454c8", @"/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e1cd3854655f5d576a7e2078f8eb8e66ab6701", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-courseAction", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-courseAction", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row col-12\">\r\n    <div class=\"col-8\">\r\n        <h3 class=\"row mb-0\" style=\"height: 100px\">");
#nullable restore
#line 6 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <div class=\"row  border-primary border-bottom align-items-end\" style=\"height: 50px\">");
#nullable restore
#line 7 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                                       Write(Model.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <p class=\"row\">");
#nullable restore
#line 8 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                  Write(Model.Feature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h3 class=\"row\">Материалы курса</h3>\r\n        <p class=\"row\">");
#nullable restore
#line 10 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                  Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        \r\n        <h3 class=\"row\">Рекомендуемые курсы</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
             foreach (var course in HomeController.Courses.Values.Skip(45).Take(3))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 pl-0\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-header border-bottom border-primary p-1\">\r\n                            ");
#nullable restore
#line 19 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                       Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body p-1\">\r\n                            <div class=\"row ml-0 mr-0\">\r\n                                <div class=\"col pl-0 pr-0 mr-1\">Компетенции: </div>\r\n");
#nullable restore
#line 24 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                 foreach (var c in course.Competences)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col mr-1 mt-1 badge badge-warning\" style=\"white-space: normal\">");
#nullable restore
#line 26 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                                                          Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 27 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                                            \r\n                            Формат: ");
#nullable restore
#line 30 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                               Write(course.Format.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                            Для кого: ");
#nullable restore
#line 31 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                 Write(course.Complexity.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                            Длительность: ");
#nullable restore
#line 32 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                     Write(course.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" часов<br/>\r\n                            Практика: ");
#nullable restore
#line 33 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                 Write(course.Practice.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                            Стоимость: ");
#nullable restore
#line 34 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                  Write(course.Free.ToCostString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                            \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17cd572ee373ffd7fbd7a4506eb1aaf5d47454c810259", async() => {
                WriteLiteral("\r\n                                Подробнее\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                             WriteLiteral(course.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        
        </div>
        
    </div>
    
    <div class=""col-4 pl-0 pr-0"">
        <div class=""card pl-0 pr-0"">
            <img src=""/course_bg.jpg"" class=""card-header border-bottom border-primary p-0"" style=""height: 149px"" alt=""course image"">
            <div class=""card-body p-1"">
                <div class=""row pl-3 mr-0"">
                    <div class=""col pl-0"">Компетенции: </div>
");
#nullable restore
#line 54 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                     foreach (var c in Model.Competences)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col mr-1 mb-1 badge badge-warning\" style=\"white-space: normal\">");
#nullable restore
#line 56 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                                              Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 57 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                \r\n                Формат: ");
#nullable restore
#line 60 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                   Write(Model.Format.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                Для кого: ");
#nullable restore
#line 61 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                     Write(Model.Complexity.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                Длительность: ");
#nullable restore
#line 62 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                         Write(Model.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" часов<br/>\r\n                Практика: ");
#nullable restore
#line 63 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                     Write(Model.Practice.ToCustomString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n                Стоимость: ");
#nullable restore
#line 64 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                      Write(Model.Free.ToCostString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3103, "\"", 3120, 1);
#nullable restore
#line 66 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
WriteAttributeValue("", 3110, Model.Url, 3110, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"width: 100%;\">\r\n                    Перейти на сайт курса\r\n                </a>\r\n\r\n");
#nullable restore
#line 70 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                 if (HomeController.CurrentUser != null)
                {
                    if (HomeController.CurrentUser.Courses.Contains(Model.Name))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17cd572ee373ffd7fbd7a4506eb1aaf5d47454c816649", async() => {
                WriteLiteral("\r\n                            Удалить из моих курсов\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                         WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseAction", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseAction"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17cd572ee373ffd7fbd7a4506eb1aaf5d47454c820066", async() => {
                WriteLiteral("\r\n                            Добавить в мои курсы\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                                                                         WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseAction", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseAction"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\borov\Desktop\InProcess\Views\Home\Course.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
