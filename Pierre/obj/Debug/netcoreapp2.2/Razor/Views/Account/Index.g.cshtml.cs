#pragma checksum "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7788d7faa7690ded2fe7b4088c66da1f9044384e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 5 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7788d7faa7690ded2fe7b4088c66da1f9044384e", @"/Views/Account/Index.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 47, true);
            WriteLiteral("\n<h2>Authentication with Identity</h2>\n\n<hr/>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(144, 13, true);
            WriteLiteral("    <p>Hello ");
            EndContext();
            BeginContext(158, 18, false);
#line 13 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(176, 6, true);
            WriteLiteral("!</p>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
     using (Html.BeginForm("LogOff", "Account"))
    {

#line default
#line hidden
            BeginContext(237, 71, true);
            WriteLiteral("        <input type=\"submit\" class=\"btn btn-default\" value=\"Log Out\"/>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(314, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(322, 43, false);
#line 18 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Go home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(365, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(379, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(387, 39, false);
#line 22 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(426, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(439, 34, false);
#line 23 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
  Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
            EndContext();
            BeginContext(473, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Index.cshtml"
}

#line default
#line hidden
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
