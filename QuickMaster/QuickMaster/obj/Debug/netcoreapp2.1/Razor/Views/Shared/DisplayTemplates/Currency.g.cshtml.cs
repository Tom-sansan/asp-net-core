#pragma checksum "C:\Users\tmsiw\Documents\Project\ASPNET_Core\asp-net-core\QuickMaster\QuickMaster\Views\Shared\DisplayTemplates\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "855068e3003953b9c666da623211111d529b9b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_Currency), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/Currency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/Currency.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_Currency))]
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
#line 1 "C:\Users\tmsiw\Documents\Project\ASPNET_Core\asp-net-core\QuickMaster\QuickMaster\Views\_ViewImports.cshtml"
using QuickMaster;

#line default
#line hidden
#line 2 "C:\Users\tmsiw\Documents\Project\ASPNET_Core\asp-net-core\QuickMaster\QuickMaster\Views\_ViewImports.cshtml"
using QuickMaster.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"855068e3003953b9c666da623211111d529b9b20", @"/Views/Shared/DisplayTemplates/Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8164bf216da33cfe9d72908f38122be779b15605", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Int32>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 32, false);
#line 2 "C:\Users\tmsiw\Documents\Project\ASPNET_Core\asp-net-core\QuickMaster\QuickMaster\Views\Shared\DisplayTemplates\Currency.cshtml"
Write(String.Format("${0:n0}", @Model));

#line default
#line hidden
            EndContext();
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Int32> Html { get; private set; }
    }
}
#pragma warning restore 1591
