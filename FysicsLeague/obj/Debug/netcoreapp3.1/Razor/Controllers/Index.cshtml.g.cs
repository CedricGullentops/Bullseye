#pragma checksum "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9459ee7de246fcb2550bfda91118a8ca5e255e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Index), @"mvc.1.0.razor-page", @"/Controllers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9459ee7de246fcb2550bfda91118a8ca5e255e", @"/Controllers/Index.cshtml")]
    public class Controllers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prefix[0].Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
 foreach (var item in Model.Prefix) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 591, "\"", 616, 1);
#nullable restore
#line 29 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
WriteAttributeValue("", 606, item.Name, 606, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 669, "\"", 694, 1);
#nullable restore
#line 30 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
WriteAttributeValue("", 684, item.Name, 684, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 749, "\"", 774, 1);
#nullable restore
#line 31 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
WriteAttributeValue("", 764, item.Name, 764, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "E:\Bullseye Project\Bullseye\FysicsLeague\Controllers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FysicsLeague.Controllers.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FysicsLeague.Controllers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FysicsLeague.Controllers.IndexModel>)PageContext?.ViewData;
        public FysicsLeague.Controllers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
