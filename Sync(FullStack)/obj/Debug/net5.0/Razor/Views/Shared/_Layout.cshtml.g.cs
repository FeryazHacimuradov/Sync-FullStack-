#pragma checksum "C:\Users\Fifi\Desktop\Sync(FullStack)\Sync(FullStack)\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a286ad9fe7a1dd26abedbf1dc375898fc8ab49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Fifi\Desktop\Sync(FullStack)\Sync(FullStack)\Views\_ViewImports.cshtml"
using Sync_FullStack_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fifi\Desktop\Sync(FullStack)\Sync(FullStack)\Views\_ViewImports.cshtml"
using Sync_FullStack_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a286ad9fe7a1dd26abedbf1dc375898fc8ab49", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fd4e5acbc1dc1ee3789eb46eade2c902c7f7b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a286ad9fe7a1dd26abedbf1dc375898fc8ab493280", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans:ital,wght@0,300;0,600;0,700;1,300;1,400&display=swap"" rel=""stylesheet"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""css/style.css"">
    <title>Sync</title>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a286ad9fe7a1dd26abedbf1dc375898fc8ab495018", async() => {
                WriteLiteral("\r\n\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg bg-light navbar-custom\">\r\n            <div class=\"container ms-auto\">\r\n                <a class=\"navbar-brand\" href=\"#\">\r\n                    <img src=\"assets/img/logo.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 1031, "\"", 1037, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""107"" height=""36"" class=""d-inline-block align-text-top"">
                </a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNav"">
                    <ul class=""navbar-nav ms-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" aria-current=""page"" href=""#"">DESCRIPTION</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">FEATURES</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">SCREENS</a>
                        </li>
                        <li class=""nav-item"">
           ");
                WriteLiteral(@"                 <a class=""nav-link"">EXTRA <i class=""fas fa-sort-down""></i></a>
                        </li>
                    </ul>
                    <span class=""nav-item"">
                        <button class=""btn btn-outline"" type=""submit"">Download</button>
                    </span>
                </div>
            </div>
        </nav>


        <div class=""container mt-5"">
            <div class=""row-1"">
                <div class=""text-container text-center"">
                    <h1>Mobile App Landing Page</h1>
                    <p class=""p-large p-heading fw-lighter fs-5"">
                        Start focusing on your goals and get more things done with Sync mobile application. It's the first app to harness the power of social connections to help you stay focused and get organized
                    </p>
                    <span class=""nav-item"">
                        <button class=""btn btn-outline"" type=""submit""><i class=""fab fa-apple""></i>Download</button>
      ");
                WriteLiteral(@"              </span>
                    <span class=""nav-item"">
                        <button class=""btn btn-outline"" type=""submit""><i class=""fab fa-google-play""></i>Download</button>
                    </span>
                    <!-- <a class=""btn-solid-lg"" href=""#""><i class=""fab fa-apple""></i>Download</a>
                    <a class=""btn-solid-lg"" href=""#""><i class=""fab fa-google-play""></i>Download</a> -->
                </div>
            </div>
            <div class=""row-2"">
                <div class=""col-lg-12"">
                    <div class=""image-container"">
                        <img class=""img-fluid"" src=""assets/img/header-iphone.png""");
                BeginWriteAttribute("alt", " alt=\"", 3761, "\"", 3767, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"deco-white-circle-1\">\r\n                <img src=\"assets/img/decorative-white-circle.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3957, "\"", 3963, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </div>
            <!-- <div class=""deco-white-circle-2"">
                <img src=""assets/img/decorative-white-circle.svg"" alt="""">
            </div> -->
            <div class=""deco-green-diamond"">
                <img src=""/assets/img/decorative-green-diamond.svg""");
                BeginWriteAttribute("alt", " alt=\"", 4251, "\"", 4257, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"deco-yellow-cicle\">\r\n                <img src=\"/assets/img/decorative-yellow-circle.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4393, "\"", 4399, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n            <div class=\"deco-blue-cicle\">\r\n                <img src=\"/assets/img/decorative-blue-circle.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4531, "\"", 4537, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </header>\r\n\r\n    ");
#nullable restore
#line 94 "C:\Users\Fifi\Desktop\Sync(FullStack)\Sync(FullStack)\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer>
        <div class=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""footer-col first"">
                            <h5>About Sync</h5>
                            <p class=""p-small"">Sync is a landing page HTML <br> template built with Bootstrap 4 <br> for presenting mobile apps</p>
                        </div>
                        <div class=""footer-col second"">
                            <h5>Contact Info</h5>
                            <ul class=""list-unstyled li-space-lg p-small"">
                                <li class=""media"">
                                    <i class=""fas fa-map-marker-alt""></i>
                                    <div class=""media-body"">22 Innovation Street, CA, US</div>
                                </li>
                                <li class=""media"">
                                    <i class=""fas fa-envelope""></i>
      ");
                WriteLiteral(@"                              <div class=""media-body""><a href=""https://www.free-css.com/free-css-templates"">office@domain.com</a></div>
                                </li>
                                <li class=""media"">
                                    <i class=""fas fa-phone-alt""></i>
                                    <div class=""media-body""><a href=""https://www.free-css.com/free-css-templates"">+44 376 945 23</a></div>
                                </li>
                            </ul>
                        </div>
                        <div class=""footer-col third"">
                            <h5>Value Links</h5>
                            <ul class=""list-unstyled li-space-lg p-small"">
                                <li><a href=""pages/terms-conditions.php"">Terms &amp; Conditions</a></li>
                                <li><a href=""pages/privacy-policy.php"">Privacy Policy</a></li>
                                <li><a href=""pages/article-details.php"">Article Details</a></li>");
                WriteLiteral(@"
                            </ul>
                        </div>
                        <div class=""footer-col fourth"">
                            <h5>Other Apps</h5>
                            <ul class=""list-unstyled li-space-lg p-small"">
                                <li><a href=""https://www.free-css.com/free-css-templates"">Scientific Calculator</a></li>
                                <li><a href=""https://www.free-css.com/free-css-templates"">Advanced Timer</a></li>
                                <li><a href=""https://www.free-css.com/free-css-templates"">Music Store</a></li>
                            </ul>
                        </div>
                        <div class=""footer-col fifth""><span class=""fa-stack""><a href=""https://www.free-css.com/free-css-templates""><i class=""fas fa-circle fa-stack-2x""></i> <i class=""fab fa-facebook-f fa-stack-1x""></i></a></span> <span class=""fa-stack""><a href=""https://www.free-css.com/free-css-templates""><i class=""fas fa-circle fa-stack-2x""></i> <i class");
                WriteLiteral(@"=""fab fa-twitter fa-stack-1x""></i></a></span>                            <span class=""fa-stack""><a href=""https://www.free-css.com/free-css-templates""><i class=""fas fa-circle fa-stack-2x""></i> <i class=""fab fa-pinterest-p fa-stack-1x""></i></a></span> <span class=""fa-stack""><a href=""https://www.free-css.com/free-css-templates""><i class=""fas fa-circle fa-stack-2x""></i> <i class=""fab fa-instagram fa-stack-1x""></i></a></span></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""copyright"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <p class=""p-small"">Copyright &copy; 2045 All rights reserved - By <a target=""_blank"" rel=""nofollow noopener"" href=""//inovatik.com"">Inovatik</a></p>
                    </div>
                </div>
            </div>
        </div>
    </footer>

    <script src=""https://kit.fontawesome.com/ac3d6c1b67.js"" crossorigin=""ano");
                WriteLiteral("nymous\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 8737, "\"", 8817, 2);
                WriteAttributeValue("", 8743, "https://cdn.jsdelivr.net/npm/", 8743, 29, true);
                WriteLiteral("@");
                WriteAttributeValue("", 8774, "popperjs/core@2.10.2/dist/umd/popper.min.js", 8774, 43, true);
                EndWriteAttribute();
                WriteLiteral(@" integrity=""sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js"" integrity=""sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
