#pragma checksum "C:\Users\basil\source\repos\CarRentalPortal\CarRentalPortal\Views\Home\OrderSuccessfull.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5477d2b1d443223227802c661e8416e4602f8982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderSuccessfull), @"mvc.1.0.view", @"/Views/Home/OrderSuccessfull.cshtml")]
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
#line 1 "C:\Users\basil\source\repos\CarRentalPortal\CarRentalPortal\Views\_ViewImports.cshtml"
using CarRentalPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basil\source\repos\CarRentalPortal\CarRentalPortal\Views\_ViewImports.cshtml"
using CarRentalPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5477d2b1d443223227802c661e8416e4602f8982", @"/Views/Home/OrderSuccessfull.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75032d6b42beb35b56e3f4b3d9f7cd6f887be7e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderSuccessfull : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 7 "C:\Users\basil\source\repos\CarRentalPortal\CarRentalPortal\Views\Home\OrderSuccessfull.cshtml"
Write(Html.Partial("_NavBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""jumbotron text-center fullScreen"">
    <h1 class=""display-3"">Thank You!</h1>
    <p class=""lead""><strong>Please visit our nearest store</strong> for further instructions on how to complete your car rental.</p>
    <hr>
    <p class=""lead"">
        <button class=""btn btn-primary btn-sm""");
            BeginWriteAttribute("onclick", " onclick=\"", 478, "\"", 551, 4);
            WriteAttributeValue("", 488, "location.href=\'", 488, 15, true);
#nullable restore
#line 14 "C:\Users\basil\source\repos\CarRentalPortal\CarRentalPortal\Views\Home\OrderSuccessfull.cshtml"
WriteAttributeValue("", 503, Url.Action("UserPortal", "home"), 503, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 536, "\';return", 536, 8, true);
            WriteAttributeValue(" ", 544, "false;", 545, 7, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Back to homepage</button>\r\n    </p>\r\n</div>");
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