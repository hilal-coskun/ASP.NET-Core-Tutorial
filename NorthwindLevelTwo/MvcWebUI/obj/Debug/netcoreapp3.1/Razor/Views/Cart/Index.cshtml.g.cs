#pragma checksum "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc423132f77c0704a99fd7a8daec6a4b9d3547d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc423132f77c0704a99fd7a8daec6a4b9d3547d6", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90fbe64bce36a3ccac09ea850cf7cd992ce84ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
         if (Model.Cart.CartLines.Count > 0) { 
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2>Ürünler</h2>
            <table class=""table table-responsive"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Ürün Adı</th>
                        <th>Açıklama</th>
                        <th>Stok Adedi</th>
                        <th>Fiyat</th>
                        <th>Satış Adedi</th>
                    </tr>
                </thead>
");
#nullable restore
#line 20 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                  foreach (var cartLine in Model.Cart.CartLines)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Product.QuantityPerUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                               Write(cartLine.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc423132f77c0704a99fd7a8daec6a4b9d3547d67088", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
                                                                                                                                WriteLiteral(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n");
#nullable restore
#line 34 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"

                    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>          \r\n");
#nullable restore
#line 41 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
         }
         else
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"badge badge-danger\">Sepetiniz Boş</h2>\r\n");
#nullable restore
#line 45 "C:\Users\USER\Source\Repos\ASP.NET-Core\NorthwindLevelTwo\MvcWebUI\Views\Cart\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
