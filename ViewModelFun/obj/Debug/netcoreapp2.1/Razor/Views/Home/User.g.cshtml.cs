#pragma checksum "/Users/andrewnwachuku/Desktop/code/C#/ASP_MVC2/ViewModelFun/Views/Home/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffbbb5dca17bfd93c7584fbe1e356e8d6d1bce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/User.cshtml", typeof(AspNetCore.Views_Home_User))]
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
#line 1 "/Users/andrewnwachuku/Desktop/code/C#/ASP_MVC2/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 1 "/Users/andrewnwachuku/Desktop/code/C#/ASP_MVC2/ViewModelFun/Views/Home/User.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffbbb5dca17bfd93c7584fbe1e356e8d6d1bce0", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 30, true);
            WriteLiteral("\n<h2>Here is a User!</h2>\n<h3>");
            EndContext();
            BeginContext(72, 15, false);
#line 5 "/Users/andrewnwachuku/Desktop/code/C#/ASP_MVC2/ViewModelFun/Views/Home/User.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(87, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(89, 14, false);
#line 5 "/Users/andrewnwachuku/Desktop/code/C#/ASP_MVC2/ViewModelFun/Views/Home/User.cshtml"
                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(103, 6, true);
            WriteLiteral("</h3>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591