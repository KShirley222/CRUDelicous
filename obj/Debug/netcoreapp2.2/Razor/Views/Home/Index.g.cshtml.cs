#pragma checksum "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be6ffb1020cff440b3c3ccb28046d774d5547588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\_ViewImports.cshtml"
using CRUDelicous;

#line default
#line hidden
#line 2 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\_ViewImports.cshtml"
using CRUDelicous.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6ffb1020cff440b3c3ccb28046d774d5547588", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d9c59b2edf24413e9b9d8c1401b0b4b9b9a8a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 396, true);
            WriteLiteral(@"<div class=""jumbotron"">
    <h1>Welcome to CRUDelicous</h1>
</div>
<div class=""container"">
    <div class=""row"">
        <p class = ""col-sm"">Check out some recent dishes!</p>
        <a href=""/create"" class= ""col-sm"">Add A Dish!</a>
    </div>
    <table class= ""table"">
        <thead>
            <th>Dish Name</th>
            <th>Chef Name</th>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
             foreach(Dish d in Model)
            {

#line default
#line hidden
            BeginContext(514, 48, true);
            WriteLiteral("                <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 562, "\"", 579, 2);
            WriteAttributeValue("", 569, "/", 569, 1, true);
#line 22 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
WriteAttributeValue("", 570, d.DishId, 570, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(580, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(582, 6, false);
#line 22 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
                                        Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(588, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(624, 6, false);
#line 23 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
                   Write(d.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(630, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\Kyle Shirley\Desktop\codingDojo\c#\EntityFrameworkCore\CRUDelicous\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(675, 54, true);
            WriteLiteral("        </tbody>\r\n\r\n    </table>    \r\n    \r\n\r\n</div>\r\n");
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
