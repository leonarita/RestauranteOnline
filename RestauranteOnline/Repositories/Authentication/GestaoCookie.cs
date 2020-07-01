using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Repositories.Authentication
{
    public class GestaoCookie
    {
        public static void CriarCookie(int IDUsuario)
        {
            HttpCookie cookieUsuario = new HttpCookie("CookieUsuario");
            cookieUsuario.Values["IDUsuario"] = IDUsuario.ToString();
            cookieUsuario.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(cookieUsuario);
        }

        public static bool ApagarCookie()
        {
            HttpCookie cookiUsuario = HttpContext.Current.Request.Cookies["CookieUsuario"];

            if (cookiUsuario == null)
                return false;
            else
            {
                HttpContext.Current.Response.Cookies[cookiUsuario.Name].Expires = DateTime.Now.AddDays(-1);
                return true;
            }
        }
    }
}