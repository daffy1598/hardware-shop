#pragma checksum "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b949ea8fd8f33fefbaf1d1d885f330e481c8554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Register.cshtml")]
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
#line 1 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\_ViewImports.cshtml"
using HardwareShopRole.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\_ViewImports.cshtml"
using HardwareShopRole.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\_ViewImports.cshtml"
using HardwareShopRole.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HardwareShopRole.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b949ea8fd8f33fefbaf1d1d885f330e481c8554", @"/Areas/Identity/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6c7d2fca8b2d26e01479d4fd5460a2bda86aee", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4862b4dc3c1624a1388eb6819aa7fc907962e7a8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 166, "\"", 204, 1);
#nullable restore
#line 11 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue("", 188, Model.ReturnUrl, 188, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" method=""post"">
            <h4>Create a new account.</h4>
            <hr />
            <div asp-validation-summary=""All"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Input.Email""></label>
                <input asp-for=""Input.Email"" class=""form-control"" />
                <span asp-validation-for=""Input.Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.Password""></label>
                <input asp-for=""Input.Password"" class=""form-control"" />
                <span asp-validation-for=""Input.Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.ConfirmPassword""></label>
                <input asp-for=""Input.ConfirmPassword"" class=""form-control"" />
                <span asp-validation-for=""Input.ConfirmPassword"" class=""text-danger""></span>
            </div>
            <button type=""sub");
            WriteLiteral("mit\" class=\"btn btn-primary\">Register</button>\r\n        </form>\r\n    </div>\r\n    <div class=\"col-md-6 col-md-offset-2\">\r\n        <section>\r\n            <h4>Use another service to register.</h4>\r\n            <hr />\r\n");
#nullable restore
#line 37 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
#nullable restore
#line 46 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <form id=\"external-account\" asp-page=\"./ExternalLogin\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 2079, "\"", 2117, 1);
#nullable restore
#line 49 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue("", 2101, Model.ReturnUrl, 2101, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" class=\"form-horizontal\">\r\n                        <div>\r\n                            <p>\r\n");
#nullable restore
#line 52 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
            BeginWriteAttribute("value", " value=\"", 2436, "\"", 2458, 1);
#nullable restore
#line 54 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue("", 2444, provider.Name, 2444, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2459, "\"", 2514, 6);
            WriteAttributeValue("", 2467, "Log", 2467, 3, true);
            WriteAttributeValue(" ", 2470, "in", 2471, 3, true);
            WriteAttributeValue(" ", 2473, "using", 2474, 6, true);
            WriteAttributeValue(" ", 2479, "your", 2480, 5, true);
#nullable restore
#line 54 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue(" ", 2484, provider.DisplayName, 2485, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2506, "account", 2507, 8, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
                                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 55 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                        </div>\r\n                    </form>\r\n");
#nullable restore
#line 59 "C:\Users\fafi_\Desktop\HardwareShop\Areas\Identity\Pages\Account\Register.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
