#pragma checksum "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5cec395e9d9e16dce361c3f79a662d83fbbb796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_SearchRestaurant), @"mvc.1.0.view", @"/Views/Restaurant/SearchRestaurant.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurant/SearchRestaurant.cshtml", typeof(AspNetCore.Views_Restaurant_SearchRestaurant))]
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
#line 1 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\_ViewImports.cshtml"
using RestaurantDeliveryOnline.Web;

#line default
#line hidden
#line 2 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\_ViewImports.cshtml"
using RestaurantDeliveryOnline.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5cec395e9d9e16dce361c3f79a662d83fbbb796", @"/Views/Restaurant/SearchRestaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2295bf9f48e281b66a2b765224ed4b746902fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_SearchRestaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RestaurantDeliveryOnline.Application.Restaurants.GetAllRestaurantsQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 101, true);
            WriteLiteral("<section class=\"main-block light-bg\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 5 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
             if (ViewBag.Restaurants != null)
            {
                

#line default
#line hidden
#line 7 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
                 foreach (var item in ViewBag.Restaurants)
                {

#line default
#line hidden
            BeginContext(334, 61, true);
            WriteLiteral("                    <div class=\"col-md-4 featured-responsive\"");
            EndContext();
            BeginWriteAttribute("asp-route-Id", " asp-route-Id=\"", 395, "\"", 418, 1);
#line 9 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
WriteAttributeValue("", 410, item.Id, 410, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 393, true);
            WriteLiteral(@">
                        <div class=""featured-place-wrap"">
                            <a href=""detail.html"">
                                <img src=""images/featured1.jpg"" class=""img-fluid"" alt=""#"">
                                <span class=""featured-rating-orange"">6.5</span>
                                <div class=""featured-title-box"">
                                    <h6>");
            EndContext();
            BeginContext(813, 9, false);
#line 15 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(822, 236, true);
            WriteLiteral("</h6>\r\n                                    <p>Restaurant </p>\r\n                                    <p>3 Reviews</p> <span> ??? </span>\r\n                                    <p><span>$$$</span>$$</p>\r\n                                    <p>");
            EndContext();
            BeginContext(1059, 16, false);
#line 19 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
                                  Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 472, true);
            WriteLiteral(@"</p>
                                    <div class=""bottom-icons"">
                                        <div class=""closed-now"">Menue</div>
                                        <span class=""ti-heart""></span>
                                        <span class=""ti-bookmark""></span>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
");
            EndContext();
#line 29 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"

                }

#line default
#line hidden
#line 30 "C:\Users\Noha\source\repos\RestaurantDeliveryOnline\RestaurantDeliveryOnline.Web\Views\Restaurant\SearchRestaurant.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1583, 310, true);
            WriteLiteral(@"

        </div>
        <div class=""row justify-content-center"">
            <div class=""col-md-4"">
                <div class=""featured-btn-wrap"">
                    <a href=""#"" class=""btn btn-danger"">VIEW ALL</a>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RestaurantDeliveryOnline.Application.Restaurants.GetAllRestaurantsQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
