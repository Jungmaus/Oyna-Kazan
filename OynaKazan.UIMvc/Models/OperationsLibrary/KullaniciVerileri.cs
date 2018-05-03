using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OynaKazan.UIMvc.Models.OperationsLibrary
{
    public class KullaniciVerileri
    {

        static string GetUserIp()
        {
            var ipAddress = string.Empty;
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else if (HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"] != null && HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"].Length != 0)
                ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"];
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
                ipAddress = HttpContext.Current.Request.UserHostName;
            return ipAddress;
        }

        public string GetIp()
        {
            string ip = GetUserIp();
            return ip;
        }


    }
}