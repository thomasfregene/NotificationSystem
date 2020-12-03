#pragma checksum "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc161958bed5fa80bc34404b90c965a5f33f712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\_ViewImports.cshtml"
using Notification.Api;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\_ViewImports.cshtml"
using Notification.Api.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc161958bed5fa80bc34404b90c965a5f33f712", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94b0adc7a7b4f3c164db135010efdf7d25ca286", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccc161958bed5fa80bc34404b90c965a5f33f7123317", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Notification.Api</title>\r\n    <link href=\"css/app.css\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccc161958bed5fa80bc34404b90c965a5f33f7124740", async() => {
                WriteLiteral(@"

    <div class=""wrapper"">
        <nav id=""sidebar"" class=""sidebar"">
            <div class=""sidebar-content js-simplebar"">
                <a class=""sidebar-brand"" href=""index.html"">
                    <span class=""align-middle"">AdminE2E</span>
                </a>

                <ul class=""sidebar-nav"">
                    <li class=""sidebar-item"">
                        <a class=""sidebar-link"" href=""index.html"">
                            <i class=""align-middle"" data-feather=""sliders""></i> <span class=""align-middle"">Dashboard</span>
                        </a>
                    </li>



                    <li class=""sidebar-item active"">
                        <a class=""sidebar-link"" href=""pages-blank.html"">
                            <i class=""align-middle"" data-feather=""book""></i> <span class=""align-middle"">Setup</span>
                        </a>
                    </li>

                    <li class=""sidebar-item"">
                        <a data-target=""#forms""");
                WriteLiteral(@" data-toggle=""collapse"" class=""sidebar-link collapsed"">
                            <i class=""align-middle"" data-feather=""check-circle""></i> <span class=""align-middle"">Notification</span>
                        </a>
                        <ul id=""forms"" class=""sidebar-dropdown list-unstyled collapse "" data-parent=""#sidebar"">
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Notification Type</a></li>
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Notification Channel</a></li>
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Notification Template</a></li>
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Email Notification </a></li>
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">SMS Notification</a></li>
                        </ul");
                WriteLiteral(@">
                    </li>

                    <li class=""sidebar-item"">
                        <a data-target=""#logs"" data-toggle=""collapse"" class=""sidebar-link collapsed"">
                            <i class=""align-middle"" data-feather=""check-circle""></i> <span class=""align-middle"">Logs</span>
                        </a>
                        <ul id=""logs"" class=""sidebar-dropdown list-unstyled collapse "" data-parent=""#sidebar"">
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Exception Log</a></li>
                            <li class=""sidebar-item""><a class=""sidebar-link"" href=""forms-layouts.html"">Activity Log </a></li>
                        </ul>
                    </li>

                </ul>

                <div class=""sidebar-cta"">
                    <div class=""sidebar-cta-content"">

                    </div>
                </div>
            </div>
        </nav>
        <div class=""main"">
            <nav cla");
                WriteLiteral(@"ss=""navbar navbar-expand navbar-light navbar-bg"">
                <a class=""sidebar-toggle d-flex"">
                    <i class=""hamburger align-self-center""></i>
                </a>

                <div class=""navbar-collapse collapse"">
                    <ul class=""navbar-nav navbar-align"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-icon dropdown-toggle"" href=""#"" id=""alertsDropdown"" data-toggle=""dropdown"">
                                <div class=""position-relative"">
                                    <i class=""align-middle"" data-feather=""bell""></i>
                                    <span class=""indicator"">4</span>
                                </div>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right py-0"" aria-labelledby=""alertsDropdown"">
                                <div class=""dropdown-menu-header"">
                                    4 New Notifica");
                WriteLiteral(@"tions
                                </div>
                                <div class=""list-group"">
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <i class=""text-danger"" data-feather=""alert-circle""></i>
                                            </div>
                                            <div class=""col-10"">
                                                <div class=""text-dark"">Update completed</div>
                                                <div class=""text-muted small mt-1"">Restart server 12 to complete the update.</div>
                                                <div class=""text-muted small mt-1"">30m ago</div>
                                            </div>
                                        </div>
                                    </a>
        ");
                WriteLiteral(@"                            <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <i class=""text-warning"" data-feather=""bell""></i>
                                            </div>
                                            <div class=""col-10"">
                                                <div class=""text-dark"">Lorem ipsum</div>
                                                <div class=""text-muted small mt-1"">Aliquam ex eros, imperdiet vulputate hendrerit et.</div>
                                                <div class=""text-muted small mt-1"">2h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=");
                WriteLiteral(@"""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <i class=""text-primary"" data-feather=""home""></i>
                                            </div>
                                            <div class=""col-10"">
                                                <div class=""text-dark"">Login from 192.186.1.8</div>
                                                <div class=""text-muted small mt-1"">5h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <i class=""text-success"" data-feather=""user-plus""></i>
                                            </di");
                WriteLiteral(@"v>
                                            <div class=""col-10"">
                                                <div class=""text-dark"">New connection</div>
                                                <div class=""text-muted small mt-1"">Christina accepted your request.</div>
                                                <div class=""text-muted small mt-1"">14h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                                <div class=""dropdown-menu-footer"">
                                    <a href=""#"" class=""text-muted"">Show all notifications</a>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-icon dropdown-toggle"" href=""#"" id=""messagesDropdown"" data-toggle=""dropdown"">
            ");
                WriteLiteral(@"                    <div class=""position-relative"">
                                    <i class=""align-middle"" data-feather=""message-square""></i>
                                </div>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right py-0"" aria-labelledby=""messagesDropdown"">
                                <div class=""dropdown-menu-header"">
                                    <div class=""position-relative"">
                                        4 New Messages
                                    </div>
                                </div>
                                <div class=""list-group"">
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <img src=""img/avatars/avatar-5.jpg"" class=""avatar img-fluid rou");
                WriteLiteral(@"nded-circle"" alt=""Vanessa Tucker"">
                                            </div>
                                            <div class=""col-10 pl-2"">
                                                <div class=""text-dark"">Vanessa Tucker</div>
                                                <div class=""text-muted small mt-1"">Nam pretium turpis et arcu. Duis arcu tortor.</div>
                                                <div class=""text-muted small mt-1"">15m ago</div>
                                            </div>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <img src=""img/avatars/avatar-2.jpg"" class=""avatar img-fluid rounded-circle"" alt=""William Harris"">
                            ");
                WriteLiteral(@"                </div>
                                            <div class=""col-10 pl-2"">
                                                <div class=""text-dark"">William Harris</div>
                                                <div class=""text-muted small mt-1"">Curabitur ligula sapien euismod vitae.</div>
                                                <div class=""text-muted small mt-1"">2h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <img src=""img/avatars/avatar-4.jpg"" class=""avatar img-fluid rounded-circle"" alt=""Christina Mason"">
                                            </div>
                                            <di");
                WriteLiteral(@"v class=""col-10 pl-2"">
                                                <div class=""text-dark"">Christina Mason</div>
                                                <div class=""text-muted small mt-1"">Pellentesque auctor neque nec urna.</div>
                                                <div class=""text-muted small mt-1"">4h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""list-group-item"">
                                        <div class=""row g-0 align-items-center"">
                                            <div class=""col-2"">
                                                <img src=""img/avatars/avatar-3.jpg"" class=""avatar img-fluid rounded-circle"" alt=""Sharon Lessman"">
                                            </div>
                                            <div class=""col-10 pl-2"">
                                                <d");
                WriteLiteral(@"iv class=""text-dark"">Sharon Lessman</div>
                                                <div class=""text-muted small mt-1"">Aenean tellus metus, bibendum sed, posuere ac, mattis non.</div>
                                                <div class=""text-muted small mt-1"">5h ago</div>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                                <div class=""dropdown-menu-footer"">
                                    <a href=""#"" class=""text-muted"">Show all messages</a>
                                </div>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-icon dropdown-toggle d-inline-block d-sm-none"" href=""#"" data-toggle=""dropdown"">
                                <i class=""align-middle"" data-feather=""settings""></i>
                       ");
                WriteLiteral(@"     </a>

                            <a class=""nav-link dropdown-toggle d-none d-sm-inline-block"" href=""#"" data-toggle=""dropdown"">
                                <img src=""img/avatars/avatar.jpg"" class=""avatar img-fluid rounded mr-1"" alt=""Charles Hall"" /> <span class=""text-dark"">Charles Hall</span>
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right"">
                                <a class=""dropdown-item"" href=""pages-profile.html""><i class=""align-middle mr-1"" data-feather=""user""></i> Profile</a>
                                <a class=""dropdown-item"" href=""#""><i class=""align-middle mr-1"" data-feather=""pie-chart""></i> Analytics</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""pages-settings.html""><i class=""align-middle mr-1"" data-feather=""settings""></i> Settings & Privacy</a>
                                <a class=""dropdown-item"" href=""#""><i class=""alig");
                WriteLiteral(@"n-middle mr-1"" data-feather=""help-circle""></i> Help Center</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Log out</a>
                            </div>
                        </li>
                    </ul>
                </div>
            </nav>
            ");
#nullable restore
#line 226 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <footer class=""footer"">
                <div class=""container-fluid"">
                    <div class=""row text-muted"">
                        <div class=""col-6 text-left"">
                            <p class=""mb-0"">
                                <a href=""index.html"" class=""text-muted""><strong>AdminKit Demo</strong></a> &copy;
                            </p>
                        </div>
                        <div class=""col-6 text-right"">
                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                                    <a class=""text-muted"" href=""#"">Support</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a class=""text-muted"" href=""#"">Help Center</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a class=""text-muted"" href=""#");
                WriteLiteral(@""">Privacy</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a class=""text-muted"" href=""#"">Terms</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </footer>
        </div>


    </div>
    <script src=""js/app.js""></script>
    ");
#nullable restore
#line 259 "C:\Projects\NotificationSystem\NotificationSystem\Notification.Api\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
