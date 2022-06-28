using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace EjemploWebASPNET
{
    public class Connection
    {

        public ServiceReference1.Service1Client CrearConexion()
        {
            WSHttpBinding basicHtt = new WSHttpBinding();
            basicHtt.Security.Mode = SecurityMode.None;
            basicHtt.Name = "MetadataExchangeHttpBinding_IService1";
            EndpointAddress endpoint = new EndpointAddress("http://localhost/Service1.svc/mex");
            return new ServiceReference1.Service1Client(basicHtt, endpoint);

        } 
    }
}