#pragma checksum "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "597c2344eb4392129cd542665f0bde97c04497cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cinema.Pages.Admin.Pages_Admin_AdminPage), @"mvc.1.0.razor-page", @"/Pages/Admin/AdminPage.cshtml")]
namespace Cinema.Pages.Admin
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
#line 1 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\_ViewImports.cshtml"
using Cinema;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597c2344eb4392129cd542665f0bde97c04497cb", @"/Pages/Admin/AdminPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb35413e8995f63b08d552fb6647493c37b8788e", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_AdminPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
  
    ViewData["Title"] = "Quản lý";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    th, td {
        padding: 10px;
        padding-right: 50px;
    }

    table {
        margin: 0 auto;
    }

    h1 {
        width: fit-content;
        margin: 0 auto;
        margin-bottom: 30px;
    }

    p a {
        width: fit-content;
        margin-left: 50px;
    }

    .placeholders {
        margin-bottom: 30px;
        text-align: center;
    }

        .placeholders h4 {
            margin-bottom: 0;
        }

    .placeholder {
        margin-bottom: 20px;
    }

        .placeholder img {
            width: 150px;
            height: 150px;
            border-radius: 50%;
        }
</style>
<div class=""container"">
    <div class=""page"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""breadcrumbs"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "597c2344eb4392129cd542665f0bde97c04497cb5575", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span>Quản lý</span>
                </div>
            </div>
            <div class=""col-md-6"">
                <a href=""https://localhost:44320/Admin/RateManagement/Index"">Quản lý đánh giá</a> -
                <a href=""https://localhost:44320/Admin/MovieManagement/Index"">Quản lý phim</a> -
                <a href=""https://localhost:44320/Admin/MemberManagement/Index"">Quản lý thành viên</a> -
                <a href=""https://localhost:44320/Admin/GenreManagement/Index"">Quản lý thể loại</a>
            </div>
            <div class=""col-md-2"">
                <div class=""breadcrumbs"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "597c2344eb4392129cd542665f0bde97c04497cb7389", async() => {
                WriteLiteral("Đăng xuất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <h1 class=""page-header"">Dashboard</h1>

        <div class=""row placeholders"">
            <div class=""col-xs-6 col-sm-3 placeholder"">
                <img src=""https://cdn.pixabay.com/photo/2019/11/22/10/02/rate-4644521_1280.png"" width=""200"" height=""200"" class=""img-responsive"" alt=""Generic placeholder thumbnail"">
                <h4>Số lượt vote</h4>
                <span class=""text-muted"">");
#nullable restore
#line 73 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                                    Write(Model.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""col-xs-6 col-sm-3 placeholder"">
                <img src=""https://www.tethys.org/wp-content/uploads/2019/02/icon-members.png"" width=""200"" height=""200"" class=""img-responsive"" alt=""Generic placeholder thumbnail"">
                <h4>Số thành viên</h4>
                <span class=""text-muted"">");
#nullable restore
#line 78 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                                    Write(Model.mem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""col-xs-6 col-sm-3 placeholder"">
                <img src=""https://icon-library.com/images/movie-icon-png/movie-icon-png-2.jpg"" width=""200"" height=""200"" class=""img-responsive"" alt=""Generic placeholder thumbnail"">
                <h4>Số lượng phim</h4>
                <span class=""text-muted"">");
#nullable restore
#line 83 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                                    Write(Model.movie);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <div class=""col-xs-6 col-sm-3 placeholder"">
                <img src=""https://static.thenounproject.com/png/2351449-200.png"" width=""200"" height=""200"" class=""img-responsive"" alt=""Generic placeholder thumbnail"">
                <h4>Số lượng thể loại</h4>
                <span class=""text-muted"">");
#nullable restore
#line 88 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                                    Write(Model.genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>

        <h2 class=""sub-header"">Top 10 phim được yêu thích</h2>
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Tiêu đề</th>
                        <th>Lịch chiếu</th>
                        <th>Ảnh</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 104 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                     foreach (var item in Model.movies)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 107 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                           Write(item.MovieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 108 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 109 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                           Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 4038, "\"", 4055, 1);
#nullable restore
#line 110 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
WriteAttributeValue("", 4044, item.Image, 4044, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:150px\" /></td>\r\n                        </tr>\r\n");
#nullable restore
#line 112 "F:\Ki 7\C# Ki7\Cinema\Cinema\Pages\Admin\AdminPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Pages.Admin.AdminPageModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cinema.Pages.Admin.AdminPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cinema.Pages.Admin.AdminPageModel>)PageContext?.ViewData;
        public Cinema.Pages.Admin.AdminPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
