﻿using System.Web.Mvc;

namespace Empresa.com.Areas.Painel
{
    public class PainelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Painel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Painel_default",
                "Painel/{controller}/{action}/{id}",
                new { controller="HomePainel", action = "_Painel", id = UrlParameter.Optional }
            );
        }
    }
}