#pragma checksum "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5977e4edcc07adaa30c7ea35cdd71df65f13cacc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Delete), @"mvc.1.0.view", @"/Views/Treats/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Delete.cshtml", typeof(AspNetCore.Views_Treats_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5977e4edcc07adaa30c7ea35cdd71df65f13cacc", @"/Views/Treats/Delete.cshtml")]
    public class Views_Treats_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 55, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this Treat?</h2>\n\n");
            EndContext();
            BeginContext(111, 40, false);
#line 9 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(151, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(154, 36, false);
#line 9 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(219, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(265, 40, false);
#line 14 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Treats/Delete.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
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