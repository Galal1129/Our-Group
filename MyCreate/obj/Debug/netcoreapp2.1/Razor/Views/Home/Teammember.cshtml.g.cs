#pragma checksum "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b7c2c096be5392f7782e42907d244b9fae581e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teammember), @"mvc.1.0.view", @"/Views/Home/Teammember.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Teammember.cshtml", typeof(AspNetCore.Views_Home_Teammember))]
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
#line 1 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\_ViewImports.cshtml"
using MyCreate;

#line default
#line hidden
#line 2 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\_ViewImports.cshtml"
using MyCreate.model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b7c2c096be5392f7782e42907d244b9fae581e", @"/Views/Home/Teammember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a464be36d847ed30dd62ab4636f424ea3d05bc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teammember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teammember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("640"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("640"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(118, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 5 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
  
    ViewData["Title"] = "Teammember";

#line default
#line hidden
            BeginContext(187, 249, true);
            WriteLiteral("\n<section id=\"doctors\" class=\"doctors section-bg\">\n    <div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\n\n        <div class=\"section-title\">\n            <h2>Takım üyeleri</h2>\n          \n        </div>\n     \n        <div class=\"row\">\n");
            EndContext();
#line 19 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(491, 332, true);
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" style=""width:100%"">

                    <div class=""member aos-init aos-animate"" data-aos=""fade-up"" data-aos-delay=""200"">
                        <div class=""member-img"">
                             
                           
                            ");
            EndContext();
            BeginContext(823, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae828e7757664472b49f8e7e157c0a09", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 833, "~/img/news/", 833, 11, true);
#line 27 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
AddHtmlAttributeValue("", 844, item.Image, 844, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(901, 84, true);
            WriteLiteral("\n                            <div class=\"social\">\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 985, "\"", 1005, 1);
#line 29 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
WriteAttributeValue("", 992, item.twitter, 992, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1006, 71, true);
            WriteLiteral("><i class=\"icofont-twitter\"></i></a>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1098, 1);
#line 30 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
WriteAttributeValue("", 1084, item.Facebook, 1084, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1099, 72, true);
            WriteLiteral("><i class=\"icofont-facebook\"></i></a>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1193, 1);
#line 31 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
WriteAttributeValue("", 1178, item.instagram, 1178, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 73, true);
            WriteLiteral("><i class=\"icofont-instagram\"></i></a>\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1267, "\"", 1288, 1);
#line 32 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
WriteAttributeValue("", 1274, item.whatsapp, 1274, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1289, 186, true);
            WriteLiteral("><i class=\"fab fa-whatsapp\"></i></a>\n                            </div>\n                        </div>\n                        <div class=\"member-info\">\n\n                            <h4>");
            EndContext();
            BeginContext(1476, 9, false);
#line 37 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 40, true);
            WriteLiteral("</h4>\n                            <span>");
            EndContext();
            BeginContext(1526, 8, false);
#line 38 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
                             Write(item.Jop);

#line default
#line hidden
            EndContext();
            BeginContext(1534, 91, true);
            WriteLiteral("</span>\n\n\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 44 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Views\Home\Teammember.cshtml"
            }

#line default
#line hidden
            BeginContext(1639, 52, true);
            WriteLiteral("\n\n        </div>\n    </div>\n\n   \n\n    \n</section>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teammember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
