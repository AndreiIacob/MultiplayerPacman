#pragma checksum "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1d457ffe5f49bf98f3f1876dd65af7fca7a358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Scores_Index), @"mvc.1.0.view", @"/Views/Scores/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Scores/Index.cshtml", typeof(AspNetCore.Views_Scores_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1d457ffe5f49bf98f3f1876dd65af7fca7a358", @"/Views/Scores/Index.cshtml")]
    public class Views_Scores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MultiplayerPacman.Data.Models.Score>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
  
    ViewData["Title"] = "LeaderBoard";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 132, true);
            WriteLiteral("\r\n<h1>LeaderBoard</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Rank\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(286, 41, false);
#line 16 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(371, 46, false);
#line 19 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ScoreValue));

#line default
#line hidden
            EndContext();
            BeginContext(417, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(461, 40, false);
#line 22 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(501, 47, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       int idx = 1; 

#line default
#line hidden
            BeginContext(571, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 27 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(608, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(645, 3, false);
#line 31 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(idx);

#line default
#line hidden
            EndContext();
            BeginContext(648, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(692, 40, false);
#line 34 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(732, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(776, 45, false);
#line 37 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ScoreValue));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(865, 32, false);
#line 40 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
       Write(item.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(897, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Views\Scores\Index.cshtml"
idx++;
}

#line default
#line hidden
            BeginContext(936, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MultiplayerPacman.Data.Models.Score>> Html { get; private set; }
    }
}
#pragma warning restore 1591
