#pragma checksum "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e07e2d35241534a8bd45b082f181d806f3c277f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MultiplayerPacman.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MultiplayerPacman.Pages.Pages_Index), null)]
namespace MultiplayerPacman.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Pages\_ViewImports.cshtml"
using MultiplayerPacman;

#line default
#line hidden
#line 3 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Pages\_ViewImports.cshtml"
using MultiplayerPacman.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e07e2d35241534a8bd45b082f181d806f3c277f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dcbc13539e92b913367560476925381f9b7012a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-buzz.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/game.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tools.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/board.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/paths.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bubbles.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/fruits.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pacman.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ghosts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sound.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Andrei\source\repos\MultiplayerPacman\MultiplayerPacman\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 60, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        ");
            EndContext();
            BeginContext(131, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f8522", async() => {
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
            EndContext();
            BeginContext(192, 93, true);
            WriteLiteral("\r\n        <!--<script type=\"text/javascript\" src=\"js/jquery-mobile.js\"></script>-->\r\n        ");
            EndContext();
            BeginContext(285, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f9880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(351, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(363, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f11153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(422, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(432, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f12423", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(492, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(502, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f13693", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(562, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(572, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f14963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(632, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(642, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f16233", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(714, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f17503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(775, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(785, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f18773", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(856, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f20043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(917, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(927, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f21314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(986, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(996, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f22585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 9651, true);
            WriteLiteral(@"

        <script type=""text/javascript"">

            function simulateKeyup(code) {
                var e = jQuery.Event(""keyup"");
                e.keyCode = code;
                jQuery('body').trigger(e);
            }
            function simulateKeydown(code) {
                var e = jQuery.Event(""keydown"");
                e.keyCode = code;
                jQuery('body').trigger(e);
            }

            $(document).ready(function () {
                //$.mobile.loading().hide();
                loadAllSound();

                HELP_TIMER = setInterval('blinkHelp()', HELP_DELAY);

                initHome();

                $("".sound"").click(function (e) {
                    e.stopPropagation();

                    var sound = $(this).attr(""data-sound"");
                    if (sound === ""on"") {
                        $("".sound"").attr(""data-sound"", ""off"");
                        $("".sound"").find(""img"").attr(""src"", ""img/sound-off.png"");
                        G");
            WriteLiteral(@"ROUP_SOUND.mute();
                    } else {
                        $("".sound"").attr(""data-sound"", ""on"");
                        $("".sound"").find(""img"").attr(""src"", ""img/sound-on.png"");
                        GROUP_SOUND.unmute();
                    }
                });

                $("".help-button, #help"").click(function (e) {
                    e.stopPropagation();
                    if (!PACMAN_DEAD && !LOCK && !GAMEOVER) {
                        if ($('#help').css(""display"") === ""none"") {
                            $('#help').fadeIn(""slow"");
                            $("".help-button"").hide();
                            if ($(""#panel"").css(""display"") !== ""none"") {
                                pauseGame();
                            }
                        } else {
                            $('#help').fadeOut(""slow"");
                            $("".help-button"").show();
                        }
                    }
                });

                $(");
            WriteLiteral(@""".github,.putchu"").click(function (e) {
                    e.stopPropagation();
                });

                $(""#home"").on(""click touchstart"", function (e) {
                    if ($('#help').css(""display"") === ""none"") {
                        e.preventDefault();
                        simulateKeydown(13);
                    }
                });
                $(""#control-up, #control-up-second, #control-up-big"").on(""mousedown touchstart"", function (e) {
                    e.preventDefault();
                    simulateKeydown(38);
                    simulateKeyup(13);
                });
                $(""#control-down, #control-down-second, #control-down-big"").on(""mousedown touchstart"", function (e) {
                    e.preventDefault();
                    simulateKeydown(40);
                    simulateKeyup(13);
                });
                $(""#control-left, #control-left-big"").on(""mousedown touchstart"", function (e) {
                    e.preventDefaul");
            WriteLiteral(@"t();
                    simulateKeydown(37);
                    simulateKeyup(13);
                });
                $(""#control-right, #control-right-big"").on(""mousedown touchstart"", function (e) {
                    e.preventDefault();
                    simulateKeydown(39);
                    simulateKeyup(13);
                });


                $(""body"").keyup(function (e) {
                    KEYDOWN = false;
                });

                $(""body"").keydown(function (e) {

                    if (HOME) {

                        initGame(true);

                    } else {
                        //if (!KEYDOWN) {
                        KEYDOWN = true;
                        if (PACMAN_DEAD && !LOCK) {
                            erasePacman();
                            resetPacman();
                            drawPacman();

                            eraseGhosts();
                            resetGhosts();
                            drawGhosts();");
            WriteLiteral(@"
                            moveGhosts();

                            blinkSuperBubbles();

                        } else if (e.keyCode >= 37 && e.keyCode <= 40 && !PAUSE && !PACMAN_DEAD && !LOCK) {
                            if (e.keyCode === 39) {
                                movePacman(1);
                            } else if (e.keyCode === 40) {
                                movePacman(2);
                            } else if (e.keyCode === 37) {
                                movePacman(3);
                            } else if (e.keyCode === 38) {
                                movePacman(4);
                            }
                        } else if (e.keyCode === 68 && !PAUSE) {
                            /*if ( $(""#canvas-paths"").css(""display"") === ""none"" ) {
                                $(""#canvas-paths"").show();
                            } else {
                                $(""#canvas-paths"").hide();
                            }*/
                  ");
            WriteLiteral(@"      } else if (e.keyCode === 80 && !PACMAN_DEAD && !LOCK) {
                            if (PAUSE) {
                                resumeGame();
                            } else {
                                pauseGame();
                            }
                        } else if (GAMEOVER) {
                            initHome();
                        }
                        //}

                        setPacmenVars(PLAYER_NUM);
                        try {
                            if (gameId)
                                sendState();
                        }
                        catch (err) {
                        }

                    }
                });
            });
        </script>

        <div id=""sound""></div>

        <div id=""help"">
            <h2>Help</h2>
            <table align=""center"" border=""0"" cellPadding=""2"" cellSpacing=""0"">
                <tbody>
                    <tr><td>Arrow Left : </td><td>Move Left</td></tr>
  ");
            WriteLiteral(@"                  <tr><td>Arrow Right : </td><td>Move Right</td></tr>
                    <tr><td>Arrow Down : </td><td>Move Down</td></tr>
                    <tr><td>Arrow Up : </td><td>Move Up</td></tr>
                    <tr><td colspan=""2"">&nbsp;</td></tr>
                    <tr><td>P : </td><td>PAUSE</td></tr>
                </tbody>
            </table>
        </div>

        <div id=""home"">
            <h1>pac-man</h1>
            <canvas id=""canvas-home-title-pacman""></canvas>
            <div id=""presentation"">
                <div id=""presentation-titles"">character &nbsp;/&nbsp; nickname</div>
                <canvas id=""canvas-presentation-blinky""></canvas><div id=""presentation-character-blinky"">- shadow</div><div id=""presentation-name-blinky"">""blinky""</div>
                <canvas id=""canvas-presentation-pinky""></canvas><div id=""presentation-character-pinky"">- speedy</div><div id=""presentation-name-pinky"">""pinky""</div>
                <canvas id=""canvas-presentation-inky""></ca");
            WriteLiteral(@"nvas><div id=""presentation-character-inky"">- bashful</div><div id=""presentation-name-inky"">""inky""</div>
                <canvas id=""canvas-presentation-clyde""></canvas><div id=""presentation-character-clyde"">- pokey</div><div id=""presentation-name-clyde"">""clyde""</div>
            </div>
            <canvas id=""trailer""></canvas>
            <div class=""help-button"">- help -</div>
            <a class=""sound"" href=""javascript:void(0);"" data-sound=""on""><img src=""img/sound-on.png"" alt="""" border=""0""></a>
        </div>

        <div id=""panel"">
            <h1>pac-man</h1>
            <canvas id=""canvas-panel-title-pacman"" style=""display:none""></canvas>
            <div id=""score""><h2>1UP</h2><span>00</span></div>
            <div id=""highscore""><h2>High Score</h2><span>00</span></div>
            <div id=""bestscore""><h2>Best Score</h2><span>00</span></div>
            <div id=""board"" style=""padding-top : 70px"" >
                <canvas id=""canvas-board""></canvas>
                <canvas id=""canvas");
            WriteLiteral(@"-paths""></canvas>
                <canvas id=""canvas-bubbles""></canvas>
                <canvas id=""canvas-fruits""></canvas>
                <canvas id=""canvas-pacman""></canvas>
                <canvas id=""canvas-ghost-blinky""></canvas>
                <canvas id=""canvas-ghost-pinky""></canvas>
                <canvas id=""canvas-ghost-inky""></canvas>
                <canvas id=""canvas-ghost-clyde""></canvas>
                <div id=""control-up-big""></div>
                <div id=""control-down-big""></div>
                <div id=""control-left-big""></div>
                <div id=""control-right-big""></div>
            </div>
            <div id=""control"">
                <div id=""control-up""></div>
                <div id=""control-up-second""></div>
                <div id=""control-down""></div>
                <div id=""control-down-second""></div>
                <div id=""control-left""></div>
                <div id=""control-right""></div>
            </div>
            <canvas id=""canvas-lifes"" ");
            WriteLiteral(@"style=""padding-top : 10px""></canvas>
            <canvas id=""canvas-level-fruits""></canvas>
            <div id=""message""></div>
            <div class=""help-button"">- help -</div>
            <a class=""sound"" href=""javascript:void(0);"" data-sound=""on""><img src=""img/sound-on.png"" alt="""" border=""0""></a>
        </div>


    </div>

    <div class=""row"" style=""padding-top : 800px"">
        <div class=""col-6"">
            ");
            EndContext();
            BeginContext(10707, 396, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e07e2d35241534a8bd45b082f181d806f3c277f34044", async() => {
                BeginContext(10713, 383, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""messageInput"">Message</label>
                    <input type=""text"" class=""form-control"" id=""messageInput"" aria-describedby=""messageHelp"" placeholder=""Enter Message"">
                </div>
                <button type=""button"" id=""sendButton"" class=""btn btn-primary"">Send Message</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11103, 133, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <ul id=\"messagesList\"></ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 11236, "\"", 11321, 3);
            WriteAttributeValue("", 11242, "https://cdn.jsdelivr.net/npm/", 11242, 29, true);
            WriteAttributeValue("", 11271, "@", 11271, 1, true);
            WriteAttributeValue("", 11273, "aspnet/signalr@1.0.0/dist/browser/signalr.min.js", 11273, 48, true);
            EndWriteAttribute();
            BeginContext(11322, 1614, true);
            WriteLiteral(@"></script>

<script>
    const msgConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/chathub"")
        .configureLogging(signalR.LogLevel.Trace)
        .build();

    msgConnection.on(""ReceiveMessage"", (user, message) => {
        const li = document.createElement(""li"");
        li.textContent = user + "" says "" + message;
        document.getElementById(""messagesList"").appendChild(li);
    });

    msgConnection.start().catch(err => console.error(err.toString()));

    document.getElementById(""sendButton"").addEventListener(""click"", event => {
        const message = document.getElementById(""messageInput"").value;
        msgConnection.invoke(""SendMessage"", message).catch(err => console.error(err.toString()));
        event.preventDefault();
    });
</script>

<script>
    var gameId;
    const gameStateConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/pacman"")
        .configureLogging(signalR.LogLevel.Trace)
        .build();

    gameStateConnec");
            WriteLiteral(@"tion.on(""ReceiveState"", (props) => {
        console.log(props);
        //setPacmenByProps(props);
        //eraseBubbles();
    });

    gameStateConnection.on(""ReceiveGameId"", (recGameId) => {
        console.log(""recGameId"", recGameId);
        gameId = recGameId;
    });
    
    gameStateConnection.start().catch(err => console.error(err.toString()));

    function sendState() {
        var state = getPacmenObj();
        state[""gameId""] = gameId;
        gameStateConnection.invoke(""SendState"", state).catch(err => console.error(err.toString()));
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591