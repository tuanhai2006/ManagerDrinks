#pragma checksum "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b939c9a2288792bd467e7a63b5eefb47a9e5ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_WatchOrderDetail), @"mvc.1.0.view", @"/Views/Order/WatchOrderDetail.cshtml")]
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
#line 1 "C:\CNTT\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CNTT\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CNTT\DrinkAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CNTT\DrinkAndGo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b939c9a2288792bd467e7a63b5eefb47a9e5ae3", @"/Views/Order/WatchOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d913a4be49cd035bc3ce229d5170ae01eaff701f", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_WatchOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderDetailViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
  
    ViewData["Title"] = "Watch Order Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Watch Order Detail</h1>\r\n");
#nullable restore
#line 8 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">STT</th>
                <th scope=""col"">DrinkID</th>
                <th scope=""col"">Amount</th>
                <th scope=""col"">Price</th>
               
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 24 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 25 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
                   Write(Model[i].DrinkId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n                    <td>");
#nullable restore
#line 26 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
                   Write(Model[i].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
                   Write(Model[i].Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   \r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 35 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> There are no detail of this order</p>\r\n");
#nullable restore
#line 39 "C:\CNTT\DrinkAndGo\Views\Order\WatchOrderDetail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
