using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTORAD.Controllers
{
    public class Configuracion
    {
        private static string RestApiUrl = "http://{0}/{1}/{2}";

        private static String ipaddress = "192.168.101.49";
        private static String RestApi = "PROYECTORAD";
        //--------------------------------------------------------
        private static String EndpointList = "AlumnGetList.php";
        private static String EndpointCreate = "AlumnCreate.php";

        // Microservicios Crud
        public static String GetServiceList = String.Format(RestApiUrl, ipaddress, RestApi, EndpointList);
    }
}
