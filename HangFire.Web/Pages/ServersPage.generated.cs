﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\ServersPage.cshtml"
    using HangFire.Web.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ServersPage : WebTemplateBase
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("              \r\n");


            
            #line 5 "..\..\Pages\ServersPage.cshtml"
  
    Layout = new LayoutPage()
        {
            Context = Context,
            Title = "Servers"
        };


            
            #line default
            #line hidden
WriteLiteral(@"
<div class=""alert alert-info"">
    <p>
        Этот список показывает запущенные сервера: обрабатывающие задания. При запуске
        каждый сервер самостоятельно регистрирует себя: и начинает отображаться в этом
        списке. При корректной остановке он так же убирает себя из этого списка.
    </p>
    <p>
        Если остановка сервера не была произведена корректно, например, если процесс
        сервера был убит, либо на момент отключения отсутствовала связь с Redis,
        то он останется в этом списке до его следующего корректного отключения.
    </p>
</div>

");


            
            #line 26 "..\..\Pages\ServersPage.cshtml"
  
    var servers = Storage.Servers();


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 30 "..\..\Pages\ServersPage.cshtml"
 if (servers.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-warning\">\r\n        Список серверов пуст. Фоновые зада" +
"ния не будут обрабатываться.\r\n    </div>\r\n");


            
            #line 35 "..\..\Pages\ServersPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th" +
">Name</th>\r\n                <th>Queue</th>\r\n                <th>Concurrency</th>" +
"\r\n                <th>Started at</th>\r\n            </tr>\r\n        </thead>\r\n    " +
"    <tbody>\r\n");


            
            #line 48 "..\..\Pages\ServersPage.cshtml"
             foreach (var server in servers)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");


            
            #line 51 "..\..\Pages\ServersPage.cshtml"
                   Write(server.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td><span class=\"label label-primary\">");


            
            #line 52 "..\..\Pages\ServersPage.cshtml"
                                                     Write(server.Queue);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                    <td>");


            
            #line 53 "..\..\Pages\ServersPage.cshtml"
                   Write(server.Concurrency);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");


            
            #line 54 "..\..\Pages\ServersPage.cshtml"
                   Write(server.StartedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");


            
            #line 56 "..\..\Pages\ServersPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 59 "..\..\Pages\ServersPage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
