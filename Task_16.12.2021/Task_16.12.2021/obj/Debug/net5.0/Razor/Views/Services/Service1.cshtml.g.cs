#pragma checksum "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67c8b132a306dcf02d4249128aefbd6865d5d70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Service1), @"mvc.1.0.view", @"/Views/Services/Service1.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\_ViewImports.cshtml"
using Task_16._12._2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\_ViewImports.cshtml"
using Task_16._12._2021.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\_ViewImports.cshtml"
using Task_16._12._2021.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b67c8b132a306dcf02d4249128aefbd6865d5d70", @"/Views/Services/Service1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd039b948d8c5061c47a32a98e764ab5be94bc7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Service1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmService>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/quote-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
  
    ViewData["Title"] = "Service1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <!-- Page title -->\r\n    <section class=\"page-title\"");
            BeginWriteAttribute("style", " style=\"", 173, "\"", 241, 3);
            WriteAttributeValue("", 181, "background-image:url(/images/background/", 181, 40, true);
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue("", 221, Model.Banner.Image, 221, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 240, ")", 240, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"outer-box\">\r\n                <h1>");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
               Write(Model.Banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <ul class=\"bread-crumb clearfix\">\r\n                    <li><a href=\"index.html\">Home</a></li>\r\n                    <li class=\"active\">");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                  Write(Model.Banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            WriteLiteral(@"<!-- Services section three -->
<section class=""services-section-one sp-two"">
    <div class=""container"">
        <div class=""sec-title centered"">
            <h1>We Provide Wide Range of <br>Business Services</h1>
        </div>
        <div class=""row"">
            <!-- Service block three -->
");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
              
                foreach (var item in Model.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"services-block-three col-lg-4\">\r\n                        <div class=\"inner-box hvr-float-shadow\">\r\n                            <div class=\"image\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b67c8b132a306dcf02d4249128aefbd6865d5d706738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1199, "~/images/resource/", 1199, 18, true);
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
AddHtmlAttributeValue("", 1217, item.Image, 1217, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                            <div class=\"lower-content\">\r\n                                <div class=\"icon\"><span");
            BeginWriteAttribute("class", " class=\"", 1357, "\"", 1375, 1);
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue("", 1365, item.Icon, 1365, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span></div>\r\n                                <h4>");
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div class=\"text\">");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                              Write(item.Text.Length>57? item.Text.Substring(0, 57)+"..." : item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"read-more-btn\"><a href=\"#\" class=\"theme-btn\">Read More <span class=\"icon-right-arrow2\"></span></a></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- End block -->
        </div>
    </div>
</section>

<!--Project Section-->
<section class=""project-section sp-four grey-bg"">

    <!--Porfolio Tabs-->
    <div class=""project-tab"">
        <div class=""container"">
            <!--Top content-->
            <div class=""top-content"">
                <div class=""row m-0 justify-content-md-between align-items-center"">
                    <div class=""sec-title"">
                        <h1>We’ve Done Lot’s of Work, Let’s <br>Check Some From Here</h1>
                    </div>
                    <div class=""tab-btns-box"">
                        <!--Tabs Header-->
                        <div class=""tabs-header"">
                            <ul class=""product-tab-btns clearfix"">
");
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                  
                                    foreach (var item in Model.WorkTags)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 2818, "\"", 2878, 2);
            WriteAttributeValue("", 2826, "p-tab-btn", 2826, 9, true);
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue(" ", 2835, item.TagName=="All" ? "active-btn" : "", 2836, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-tab=\"#p-tab-");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                                                               Write(item.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 73 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!--Tabs Content-->
        <div class=""p-tabs-content"">
            <!--Portfolio Tab / Active Tab-->
");
#nullable restore
#line 86 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
              
                int count = 0;
                foreach (var wt in Model.WorkTags)
                {
                    count++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 3449, "\"", 3494, 2);
            WriteAttributeValue("", 3457, "p-tab", 3457, 5, true);
#nullable restore
#line 92 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue(" ", 3462, count==1 ? "active-tab" : "", 3463, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3495, "\"", 3512, 2);
            WriteAttributeValue("", 3500, "p-tab-", 3500, 6, true);
#nullable restore
#line 92 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue("", 3506, wt.Id, 3506, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                       \r\n                        <div class=\"project-carousel owl-theme owl-carousel\">\r\n\r\n");
#nullable restore
#line 96 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                              
                                foreach (var ow in Model.OurWorks)
                                {
                                    foreach (var tw in ow.TagToWorks)
                                    {
                                        if (tw.WorkTagId == wt.Id)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <!--Gallery Block-->
                                            <div class=""gallery-block"">
                                                <div class=""inner-box"">
                                                    <figure class=""image-box"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b67c8b132a306dcf02d4249128aefbd6865d5d7015358", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4336, "~/images/gallery/", 4336, 17, true);
#nullable restore
#line 107 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
AddHtmlAttributeValue("", 4353, ow.Image, 4353, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        <!--Overlay Box-->
                                                        <div class=""overlay-box"">
                                                            <div class=""overlay-inner"">
                                                                <div class=""content"">
                                                                    <div class=""content-text"">
                                                                        <div class=""category"">");
#nullable restore
#line 113 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                         Write(ow.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                                        <h3><a href=\"projects-detail.html\">");
#nullable restore
#line 114 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                                      Write(ow.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                                                        <div class=\"text\">");
#nullable restore
#line 115 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                     Write(ow.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                                        <div class=""link-btn""><a href=""#"" class=""theme-btn btn-style-two small-btn"">Read More</a></div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </figure>
                                                </div>
                                            </div>
");
#nullable restore
#line 124 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                        }
                                    }







                                }



                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 144 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            

        </div>

    </div>



</section>
<!--End Project Section-->
<!-- Testimonial Section -->
<section class=""testimonial-section-two sp-one"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""content-wrapper wow fadeInUp"" data-wow-duration=""1.2s"">
                    <div class=""sec-title"">
                        <h1>What Our Clients <br>Are Saying</h1>
                    </div>
                    <ul class=""bxslider "">
");
#nullable restore
#line 169 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                          
                            foreach (var item in Model.Testimonials)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <div class=\"testimonial-block-two\">\r\n                                        <div class=\"inner-box\">\r\n                                            <div class=\"quote\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b67c8b132a306dcf02d4249128aefbd6865d5d7021167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                            <div class=\"text\">");
#nullable restore
#line 176 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                         Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <h4>");
#nullable restore
#line 177 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 181 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                    <div class=""slider-pager slide-nav"">
                        <ul class=""nav-link list-inline"">
                            <li id=""slider-prev""></li>
                            <li id=""slider-next""></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""slider-pager"">
                    <ul class=""list-inline thumb-box"">
");
#nullable restore
#line 197 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                          
                            for (int i = 0; i < Model.Testimonials.Count; i++)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 8089, "\"", 8127, 2);
#nullable restore
#line 202 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
WriteAttributeValue("", 8097, i==1 ? "active" : "", 8097, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 8120, "active", 8121, 7, true);
            EndWriteAttribute();
            WriteLiteral(" data-slide-index=\"");
#nullable restore
#line 202 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b67c8b132a306dcf02d4249128aefbd6865d5d7025186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8170, "~/images/resource/", 8170, 18, true);
#nullable restore
#line 202 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
AddHtmlAttributeValue("", 8188, Model.Testimonials[i].Image, 8188, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 204 "C:\Users\ASUS\Desktop\New folder (2)\Task_16.12.2021\Task_16.12.2021\Views\Services\Service1.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmService> Html { get; private set; }
    }
}
#pragma warning restore 1591