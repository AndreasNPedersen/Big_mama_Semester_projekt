#pragma checksum "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e5fd80e297bbecf5cc108a901b04921f077485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MadOrderingssystem.Pages.MenuPage.Pages_MenuPage_MenuTable), @"mvc.1.0.razor-page", @"/Pages/MenuPage/MenuTable.cshtml")]
namespace MadOrderingssystem.Pages.MenuPage
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
#line 1 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\_ViewImports.cshtml"
using MadOrderingssystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
using MadOrderingssystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e5fd80e297bbecf5cc108a901b04921f077485", @"/Pages/MenuPage/MenuTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71eb8fd009691008332d95b2b2663f10064e33c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MenuPage_MenuTable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "DeletePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditPizza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditAccessory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
  
    ViewData["Title"] = "MenuTable";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Menu Tabel</h1>
<p class=""text-center""></p>
<h3>Menuer</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Navn
            </th>
            <th>
                Pris
            </th>
            <th>
                Pizzaer
            </th>
            <th>
                Tilbehør
            </th>
            <th>
                Kontrol
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 36 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
         foreach (Menu menu in Model.DicMenu.Values)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(menu.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(menu.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(menu.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 49 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                     foreach (Pizza pizza in menu.Pizzas)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                   Write(pizza.ProductName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                          
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 55 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                     foreach (Accessory accessory in menu.Accesories)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                   Write(accessory.ProductName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                </td>\r\n                <td>\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f0774858935", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                 WriteLiteral(menu.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f07748511185", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                   WriteLiteral(menu.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>
<br />
<h3>Pizzaer</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Navn
            </th>
            <th>
                Pris
            </th>
            <th>
                Size
            </th>
            <th>
                Ingedienser
            </th>
            <th>
                Kontrol
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 98 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
         foreach (Pizza pizza in Model.DicPizza.Values)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(pizza.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(pizza.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(pizza.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(pizza.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   ");
#nullable restore
#line 114 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
              Write(pizza.Ingrediense);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f07748516556", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                  WriteLiteral(pizza.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f07748518810", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                   WriteLiteral(pizza.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 123 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>

</table>
<br />

<h3>Tilbehør</h3>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Navn
            </th>
            <th>
                Pris
            </th>
            <th>
                Kontrol
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 149 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
         foreach (Accessory accessory in Model.DicAccessories.Values)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 153 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(accessory.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 156 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(accessory.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 159 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
               Write(accessory.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f07748523344", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                      WriteLiteral(accessory.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e5fd80e297bbecf5cc108a901b04921f07748525606", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 164 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
                                                   WriteLiteral(accessory.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 168 "C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Pages\MenuPage\MenuTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MadOrderingssystem.Pages.MenuPage.MenuTableModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.MenuPage.MenuTableModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MadOrderingssystem.Pages.MenuPage.MenuTableModel>)PageContext?.ViewData;
        public MadOrderingssystem.Pages.MenuPage.MenuTableModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
