﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using OficioMVC.Libraries.Login;
using OficioMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OficioMVC.Libraries.Filtro
{
    public class UsuarioAutorizacao: Attribute, IAuthorizationFilter
    {
        LoginUser _loginUser;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginUser = (LoginUser)context.HttpContext.RequestServices.GetService(typeof(LoginUser));
            Siga_profs User = _loginUser.GetUser();
            if(User == null)
            {
                context.Result = new RedirectToActionResult("AcessoNegado","Home", new { area = "" });
            }
        }
    }
}
