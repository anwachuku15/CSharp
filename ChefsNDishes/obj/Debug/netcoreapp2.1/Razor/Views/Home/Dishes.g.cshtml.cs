#pragma checksum "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05c724ae5434d656559a1f3ce6ac867750b7187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 2 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 1 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05c724ae5434d656559a1f3ce6ac867750b7187", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 332, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1><a href=""/"">Chefs</a> | Dishes</h1>
    <h4><a href=""dishes/new"">Add a Dish</a></h4>
</div>

<h2>Yum, take a look at our tasty dishes!</h2>
<hr>

<table class=""table table-striped"">
    <tr>
        <th>Name</th>
        <th>Chef</th>
        <th>Tastiness</th>
        <th>Calories</th>
    </tr>

");
            EndContext();
#line 21 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
     foreach(var dish in Model)
    {

#line default
#line hidden
            BeginContext(437, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(467, 9, false);
#line 24 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(476, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(499, 22, false);
#line 25 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(521, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(523, 21, false);
#line 25 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
                                   Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(544, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(567, 14, false);
#line 26 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(581, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(604, 13, false);
#line 27 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(617, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 29 "/Users/andrewnwachuku/Desktop/code/C#/Entity/ChefsNDishes/Views/Home/Dishes.cshtml"
    }

#line default
#line hidden
            BeginContext(643, 10, true);
            WriteLiteral("\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
