#pragma checksum "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df8b6ffd1242535a5da3b005ba663fceaff7bc8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Create), @"mvc.1.0.view", @"/Views/Treats/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Create.cshtml", typeof(AspNetCore.Views_Treats_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8b6ffd1242535a5da3b005ba663fceaff7bc8b", @"/Views/Treats/Create.cshtml")]
    public class Views_Treats_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 26, true);
            WriteLiteral("\n<h4>Add a new treat</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(114, 34, false);
#line 10 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(154, 36, false);
#line 11 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(191, 50, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new treat\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
}

#line default
#line hidden
            BeginContext(243, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(247, 43, false);
#line 14 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Create.cshtml"
Write(Html.ActionLink("Show all treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(290, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
