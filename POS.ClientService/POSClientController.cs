using System;
using System.Web.Http;

namespace POSService
{
    public class POSClientController : ApiController
    {
        public string GetComputerName()
        {
            return Environment.MachineName;
        }
    }
}
