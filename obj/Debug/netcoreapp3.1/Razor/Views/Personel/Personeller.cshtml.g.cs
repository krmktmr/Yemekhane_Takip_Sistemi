#pragma checksum "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339c25a970fbcbacd2ba23316dd42085f552616e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Personeller), @"mvc.1.0.view", @"/Views/Personel/Personeller.cshtml")]
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
#line 1 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\_ViewImports.cshtml"
using YemekHaneTakipOtomasyonu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
using YemekHaneTakipOtomasyonu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339c25a970fbcbacd2ba23316dd42085f552616e", @"/Views/Personel/Personeller.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5eecd753f8a1c40d918967f3bd2ba90bc9ea317", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Personeller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<personel_kartlari>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "339c25a970fbcbacd2ba23316dd42085f552616e4404", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "339c25a970fbcbacd2ba23316dd42085f552616e5522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""container index"">
        <h2>Personel Listesi</h2>
        <div class=""table-wrapper"">
            <table class=""fl-table"">
                <thead>
                    <tr>
                        <th>Kart No</th>
                        <th>AdıSoyadı</th>
                        <th>Soyadı</th>
                        <th>Sirket</th>
                        <th>Departman</th>
                        <th>Bolum</th>
                        <th>Ünvanı</th>
                        <th>Kontör</th>
                        <th>Giriş Tarihi</th>
                        <th>Düzenle</th>
                        <th>Sil</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 26 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                      
                        foreach (var x in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.kartno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.soyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.sirket.aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.departman.aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.bolum.aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.unvani);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(x.kalankontor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                               Write(String.Format("{0:dd/MM/yyyy}", x.giristarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1656, "\"", 1698, 2);
            WriteAttributeValue("", 1663, "/Personel/PersonelDuzenle/", 1663, 26, true);
#nullable restore
#line 40 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
WriteAttributeValue("", 1689, x.kartno, 1689, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1780, "\"", 1818, 2);
            WriteAttributeValue("", 1787, "/Personel/PersonelSil/", 1787, 22, true);
#nullable restore
#line 41 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
WriteAttributeValue("", 1809, x.kartno, 1809, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\kerem\Desktop\193601053_KeremKatmer_YemekHaneTakipSistemi\Proje\YemekHaneTakipOtomasyonu\Views\Personel\Personeller.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"11\" rowspan=\"2\"><a href=\"/Personel/PersonelEkle\" class=\"btn btn-info\">Personel Ekle</a></td>\r\n                        </tr>\r\n");
            WriteLiteral("                </tbody>\r\n</table>\r\n        </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<personel_kartlari>> Html { get; private set; }
    }
}
#pragma warning restore 1591