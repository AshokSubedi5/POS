#pragma checksum "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edbc64266854c49194825e2a56c370370aa7fe6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Details.cshtml", typeof(AspNetCore.Views_Customer_Details))]
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
#line 1 "E:\Projects\POS\POS.UI\Views\_ViewImports.cshtml"
using POS.UI;

#line default
#line hidden
#line 2 "E:\Projects\POS\POS.UI\Views\_ViewImports.cshtml"
using POS.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbc64266854c49194825e2a56c370370aa7fe6b", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed9f1afc7e0d962efda10520344f1c1fc5f929c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POS.DTO.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(70, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(193, 40, false);
#line 14 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(233, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(277, 36, false);
#line 17 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(313, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(357, 40, false);
#line 20 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(441, 36, false);
#line 23 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(477, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(521, 43, false);
#line 26 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(564, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(608, 39, false);
#line 29 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(691, 41, false);
#line 32 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(732, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(776, 37, false);
#line 35 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(857, 40, false);
#line 38 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel1));

#line default
#line hidden
            EndContext();
            BeginContext(897, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(941, 36, false);
#line 41 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tel1));

#line default
#line hidden
            EndContext();
            BeginContext(977, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1021, 40, false);
#line 44 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel2));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1105, 36, false);
#line 47 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tel2));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1185, 43, false);
#line 50 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile1));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1272, 39, false);
#line 53 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile1));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1355, 43, false);
#line 56 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile2));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1442, 39, false);
#line 59 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile2));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1525, 41, false);
#line 62 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1610, 37, false);
#line 65 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1691, 39, false);
#line 68 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vat));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1774, 35, false);
#line 71 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vat));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1853, 39, false);
#line 74 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1936, 35, false);
#line 77 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2015, 42, false);
#line 80 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Po_Box));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2101, 38, false);
#line 83 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Po_Box));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2183, 40, false);
#line 86 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2267, 36, false);
#line 89 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2347, 48, false);
#line 92 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Credit_Limit));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2439, 44, false);
#line 95 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Credit_Limit));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2527, 46, false);
#line 98 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Credit_Day));

#line default
#line hidden
            EndContext();
            BeginContext(2573, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2617, 42, false);
#line 101 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Credit_Day));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2703, 51, false);
#line 104 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Is_Sale_Refused));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2798, 47, false);
#line 107 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Is_Sale_Refused));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2889, 45, false);
#line 110 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Is_Member));

#line default
#line hidden
            EndContext();
            BeginContext(2934, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2978, 41, false);
#line 113 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Is_Member));

#line default
#line hidden
            EndContext();
            BeginContext(3019, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3063, 45, false);
#line 116 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Member_Id));

#line default
#line hidden
            EndContext();
            BeginContext(3108, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3152, 41, false);
#line 119 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member_Id));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3237, 43, false);
#line 122 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Barcode));

#line default
#line hidden
            EndContext();
            BeginContext(3280, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3324, 39, false);
#line 125 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Barcode));

#line default
#line hidden
            EndContext();
            BeginContext(3363, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3407, 39, false);
#line 128 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(3446, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3490, 35, false);
#line 131 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(3525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3569, 42, false);
#line 134 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob_Bs));

#line default
#line hidden
            EndContext();
            BeginContext(3611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3655, 38, false);
#line 137 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dob_Bs));

#line default
#line hidden
            EndContext();
            BeginContext(3693, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3737, 48, false);
#line 140 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wedding_Date));

#line default
#line hidden
            EndContext();
            BeginContext(3785, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3829, 44, false);
#line 143 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wedding_Date));

#line default
#line hidden
            EndContext();
            BeginContext(3873, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3917, 53, false);
#line 146 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Family_Member_Int));

#line default
#line hidden
            EndContext();
            BeginContext(3970, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4014, 49, false);
#line 149 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Family_Member_Int));

#line default
#line hidden
            EndContext();
            BeginContext(4063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4107, 46, false);
#line 152 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(4153, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4197, 42, false);
#line 155 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(4239, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4283, 47, false);
#line 158 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Office_Name));

#line default
#line hidden
            EndContext();
            BeginContext(4330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4374, 43, false);
#line 161 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Office_Name));

#line default
#line hidden
            EndContext();
            BeginContext(4417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4461, 50, false);
#line 164 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Office_Address));

#line default
#line hidden
            EndContext();
            BeginContext(4511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4555, 46, false);
#line 167 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Office_Address));

#line default
#line hidden
            EndContext();
            BeginContext(4601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4645, 47, false);
#line 170 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(4692, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4736, 43, false);
#line 173 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(4779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4823, 53, false);
#line 176 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Registration_Date));

#line default
#line hidden
            EndContext();
            BeginContext(4876, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4920, 49, false);
#line 179 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Registration_Date));

#line default
#line hidden
            EndContext();
            BeginContext(4969, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5013, 51, false);
#line 182 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Validity_Period));

#line default
#line hidden
            EndContext();
            BeginContext(5064, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5108, 47, false);
#line 185 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Validity_Period));

#line default
#line hidden
            EndContext();
            BeginContext(5155, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5199, 49, false);
#line 188 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Validity_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5292, 45, false);
#line 191 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Validity_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5337, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5381, 53, false);
#line 194 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Membership_Scheme));

#line default
#line hidden
            EndContext();
            BeginContext(5434, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5478, 49, false);
#line 197 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Membership_Scheme));

#line default
#line hidden
            EndContext();
            BeginContext(5527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5571, 48, false);
#line 200 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reference_By));

#line default
#line hidden
            EndContext();
            BeginContext(5619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5663, 44, false);
#line 203 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reference_By));

#line default
#line hidden
            EndContext();
            BeginContext(5707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5751, 46, false);
#line 206 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Created_By));

#line default
#line hidden
            EndContext();
            BeginContext(5797, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5841, 42, false);
#line 209 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Created_By));

#line default
#line hidden
            EndContext();
            BeginContext(5883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5927, 48, false);
#line 212 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Created_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5975, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6019, 44, false);
#line 215 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Created_Date));

#line default
#line hidden
            EndContext();
            BeginContext(6063, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6107, 43, false);
#line 218 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(6150, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6194, 39, false);
#line 221 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(6233, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6280, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e13ff6502b445ab9d6f1028383b0144", async() => {
                BeginContext(6326, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 226 "E:\Projects\POS\POS.UI\Views\Customer\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(6334, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6342, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d9a2151f5742b080942a3dc6d431d7", async() => {
                BeginContext(6364, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6380, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POS.DTO.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
