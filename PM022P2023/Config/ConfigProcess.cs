using System;
using System.Collections.Generic;
using System.Text;

namespace PM022P2023.Config
{
    public static class ConfigProcess
    {
        // Web Api http
        public static String ipaddress = "192.168.1.3";
        public static string webapi = "PM023PCRUD";

        //Rauting METHOD POST
        public static string postRaute = "AlumnCreate.php";
        //Rauting METHOD GET
        public static string getRaute = "AlumnGetList.php";

        //Format URL
        public static string formaturl = "http://{0}/{1}/{2}";

        // URL Endpoint
        public static string ApiGET = string.Format(formaturl, ipaddress, webapi, getRaute);
        public static string ApiPOST = string.Format(formaturl, ipaddress, webapi, postRaute);
    }
}
