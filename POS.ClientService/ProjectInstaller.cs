using System.ComponentModel;

namespace POSService
{
    [RunInstaller(true)]
    public partial class POSServices : System.Configuration.Install.Installer
    {
        public POSServices()
        {
            InitializeComponent();
        }
    }
}
