#pragma checksum "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efaeb789e7982b0a76c700ec241c3629b6e95279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Delete), @"mvc.1.0.view", @"/Views/Customer/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Delete.cshtml", typeof(AspNetCore.Views_Customer_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efaeb789e7982b0a76c700ec241c3629b6e95279", @"/Views/Customer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed9f1afc7e0d962efda10520344f1c1fc5f929c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POS.DTO.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(69, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(239, 40, false);
#line 15 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 36, false);
#line 18 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(403, 40, false);
#line 21 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(487, 36, false);
#line 24 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(567, 43, false);
#line 27 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(610, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(654, 39, false);
#line 30 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(737, 41, false);
#line 33 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(778, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(822, 37, false);
#line 36 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(859, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(903, 40, false);
#line 39 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel1));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(987, 36, false);
#line 42 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tel1));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1067, 40, false);
#line 45 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tel2));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1151, 36, false);
#line 48 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tel2));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1231, 43, false);
#line 51 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile1));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1318, 39, false);
#line 54 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mobile1));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1401, 43, false);
#line 57 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile2));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1488, 39, false);
#line 60 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mobile2));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1571, 41, false);
#line 63 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1656, 37, false);
#line 66 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1737, 39, false);
#line 69 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Vat));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1820, 35, false);
#line 72 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Vat));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1899, 39, false);
#line 75 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1982, 35, false);
#line 78 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2061, 42, false);
#line 81 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Po_Box));

#line default
#line hidden
            EndContext();
            BeginContext(2103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2147, 38, false);
#line 84 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Po_Box));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2229, 40, false);
#line 87 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2313, 36, false);
#line 90 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2393, 48, false);
#line 93 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Credit_Limit));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2485, 44, false);
#line 96 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Credit_Limit));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2573, 46, false);
#line 99 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Credit_Day));

#line default
#line hidden
            EndContext();
            BeginContext(2619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2663, 42, false);
#line 102 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Credit_Day));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2749, 51, false);
#line 105 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Is_Sale_Refused));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2844, 47, false);
#line 108 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Is_Sale_Refused));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2935, 45, false);
#line 111 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Is_Member));

#line default
#line hidden
            EndContext();
            BeginContext(2980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3024, 41, false);
#line 114 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Is_Member));

#line default
#line hidden
            EndContext();
            BeginContext(3065, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3109, 45, false);
#line 117 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Member_Id));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3198, 41, false);
#line 120 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Member_Id));

#line default
#line hidden
            EndContext();
            BeginContext(3239, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3283, 43, false);
#line 123 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Barcode));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3370, 39, false);
#line 126 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Barcode));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3453, 39, false);
#line 129 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(3492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3536, 35, false);
#line 132 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(3571, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3615, 42, false);
#line 135 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dob_Bs));

#line default
#line hidden
            EndContext();
            BeginContext(3657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3701, 38, false);
#line 138 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dob_Bs));

#line default
#line hidden
            EndContext();
            BeginContext(3739, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3783, 48, false);
#line 141 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Wedding_Date));

#line default
#line hidden
            EndContext();
            BeginContext(3831, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3875, 44, false);
#line 144 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Wedding_Date));

#line default
#line hidden
            EndContext();
            BeginContext(3919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3963, 53, false);
#line 147 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Family_Member_Int));

#line default
#line hidden
            EndContext();
            BeginContext(4016, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4060, 49, false);
#line 150 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Family_Member_Int));

#line default
#line hidden
            EndContext();
            BeginContext(4109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4153, 46, false);
#line 153 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(4199, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4243, 42, false);
#line 156 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(4285, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4329, 47, false);
#line 159 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Office_Name));

#line default
#line hidden
            EndContext();
            BeginContext(4376, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4420, 43, false);
#line 162 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Office_Name));

#line default
#line hidden
            EndContext();
            BeginContext(4463, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4507, 50, false);
#line 165 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Office_Address));

#line default
#line hidden
            EndContext();
            BeginContext(4557, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4601, 46, false);
#line 168 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Office_Address));

#line default
#line hidden
            EndContext();
            BeginContext(4647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4691, 47, false);
#line 171 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(4738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4782, 43, false);
#line 174 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(4825, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4869, 53, false);
#line 177 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Registration_Date));

#line default
#line hidden
            EndContext();
            BeginContext(4922, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4966, 49, false);
#line 180 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Registration_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5059, 51, false);
#line 183 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Validity_Period));

#line default
#line hidden
            EndContext();
            BeginContext(5110, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5154, 47, false);
#line 186 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Validity_Period));

#line default
#line hidden
            EndContext();
            BeginContext(5201, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5245, 49, false);
#line 189 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Validity_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5338, 45, false);
#line 192 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Validity_Date));

#line default
#line hidden
            EndContext();
            BeginContext(5383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5427, 53, false);
#line 195 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Membership_Scheme));

#line default
#line hidden
            EndContext();
            BeginContext(5480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5524, 49, false);
#line 198 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Membership_Scheme));

#line default
#line hidden
            EndContext();
            BeginContext(5573, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5617, 48, false);
#line 201 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Reference_By));

#line default
#line hidden
            EndContext();
            BeginContext(5665, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5709, 44, false);
#line 204 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Reference_By));

#line default
#line hidden
            EndContext();
            BeginContext(5753, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5797, 46, false);
#line 207 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created_By));

#line default
#line hidden
            EndContext();
            BeginContext(5843, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5887, 42, false);
#line 210 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created_By));

#line default
#line hidden
            EndContext();
            BeginContext(5929, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5973, 48, false);
#line 213 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created_Date));

#line default
#line hidden
            EndContext();
            BeginContext(6021, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6065, 44, false);
#line 216 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created_Date));

#line default
#line hidden
            EndContext();
            BeginContext(6109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6153, 43, false);
#line 219 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(6196, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6240, 39, false);
#line 222 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(6279, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6317, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727ec8264bbf4b0188abc41430f3f92d", async() => {
                BeginContext(6343, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6353, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1856f510826c4e7190566dde19398eed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 227 "E:\Projects\POS\POS.UI\Views\Customer\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6389, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(6473, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a15d744671a4706bc8b1a021511860e", async() => {
                    BeginContext(6495, 12, true);
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
                BeginContext(6511, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6524, 10, true);
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
