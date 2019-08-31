using System;
using System.Configuration;
using System.Reflection;
using System.ServiceProcess;
using System.Web.Http;
using System.Web.Http.SelfHost;


namespace POSService
{
    public partial class ClientService : ServiceBase
    {
        public ClientService()
        {

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:" + GetPortNumber());

            config.Routes.MapHttpRoute(
                name: "API",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });


            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();

        }

        protected override void OnStop()
        {
        }


        public string GetPortNumber()
        {
            string serviceName = string.Empty;

            try
            {
                Assembly executingAssembly = Assembly.GetAssembly(typeof(POSServices));
                string targetDir = executingAssembly.Location;
                Configuration config = ConfigurationManager.OpenExeConfiguration(targetDir);
                serviceName = config.AppSettings.Settings["port"].Value.ToString();

                return serviceName;
            }
            catch (Exception)
            {
                return "1111";
            }
        }
    }
}
