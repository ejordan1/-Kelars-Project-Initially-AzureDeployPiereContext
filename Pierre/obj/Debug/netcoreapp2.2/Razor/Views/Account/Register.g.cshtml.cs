#pragma checksum "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a833588fb46943bc855a6c5386d41d28bd739c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 5 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
using Pierre.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a833588fb46943bc855a6c5386d41d28bd739c5", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(78, 37, true);
            WriteLiteral("<h2>Register a new user</h2>\n\n<hr/>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(186, 33, false);
#line 13 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(225, 35, false);
#line 14 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.TextBoxFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(267, 36, false);
#line 16 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(309, 39, false);
#line 17 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user => user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(356, 42, false);
#line 19 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(404, 45, false);
#line 20 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(451, 44, true);
            WriteLiteral("    <input type=\"Submit\" value=\"Register\"/>\n");
            EndContext();
#line 23 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Account/Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
