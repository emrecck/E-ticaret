﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(E_ticaret_İleri_Seviye_.App_Start.IdentityConfig))]

namespace E_ticaret_İleri_Seviye_.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=316888 adresini ziyaret edin

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {

                AuthenticationType = "ApplicationCookie" ,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
