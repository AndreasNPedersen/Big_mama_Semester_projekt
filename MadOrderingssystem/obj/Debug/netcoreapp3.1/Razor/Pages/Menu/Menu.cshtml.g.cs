#pragma checksum "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e0f05b6bdf07eb105a300fbd6a868ee8003b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MadOrderingssystem.Pages.Menu.Pages_Menu_Menu), @"mvc.1.0.razor-page", @"/Pages/Menu/Menu.cshtml")]
namespace MadOrderingssystem.Pages.Menu
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
#line 1 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\_ViewImports.cshtml"
using MadOrderingssystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
using static MadOrderingssystem.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
using MadOrderingssystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
using MadOrderingssystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e0f05b6bdf07eb105a300fbd6a868ee8003b82", @"/Pages/Menu/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71eb8fd009691008332d95b2b2663f10064e33c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <h2 class=\"text-center\">test</h2>\r\n    <div class=\"border\"></div>\r\n\r\n    <h1>Menu</h1>\r\n\r\n\r\n    <h4 style=\"color:blue\"> List of Products</h4>\r\n    <div class=\"card-deck\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 20 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
         foreach (Product product in MenuModel.dicC.Values)
        {

            //if (product.Id.ToLower().Contains(filter.ToLower()))
            //{
            //    dicC.Add(product.Id, product);
            //}


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card m-3\" style=\"min-width: 18rem; max-width:30.5%; height:100%\">\r\n                <div class=\"card-header\">\r\n                    <p>id: ");
#nullable restore
#line 30 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
                      Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>-->\r\n                    <p>Name:");
#nullable restore
#line 31 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"
                       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n           </div>\r\n");
#nullable restore
#line 34 "D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Pages\Menu\Menu.cshtml"

         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>




        <div class=""card-footer text-center"">
            <a href=""#"" class=""btn btn-primary m-1"">View</a>
            <a href=""#"" class=""btn btn-primary m-1"">Edit</a>
            <a href=""#"" class=""btn btn-danger m-1"">Delete</a>
        </div>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MadOrderingssystem.Pages.Menu.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Menu.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.Menu.MenuModel>)PageContext?.ViewData;
        public MadOrderingssystem.Pages.Menu.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591