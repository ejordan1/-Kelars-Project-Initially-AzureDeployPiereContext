#pragma checksum "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0eed3f38b6e1a7afda79264488bdfc98699930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Create.cshtml", typeof(AspNetCore.Views_Flavors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0eed3f38b6e1a7afda79264488bdfc98699930", @"/Views/Flavors/Create.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 38, true);
            WriteLiteral("\n<h2>Create a new flavor</h2>\n<hr />\n\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(99, 41, false);
#line 8 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(146, 42, false);
#line 9 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(195, 26, false);
#line 11 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
Write(Html.Label("Select treat"));

#line default
#line hidden
            EndContext();
            BeginContext(227, 28, false);
#line 12 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
Write(Html.DropDownList("TreatId"));

#line default
#line hidden
            EndContext();
            BeginContext(257, 67, true);
            WriteLiteral("    <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(326, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(328, 44, false);
#line 17 "/Users/Guest/Desktop/PierresSweets/Pierre/Views/Flavors/Create.cshtml"
Write(Html.ActionLink("Show all flavors", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
