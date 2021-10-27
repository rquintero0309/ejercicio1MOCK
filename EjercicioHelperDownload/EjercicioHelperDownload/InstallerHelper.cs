using System;
using System.Net;

namespace EjercicioHelperDownload
{
    public class InstallerHelper 
    {
        private string _setupDestinationFile;

        readonly IwClient client;

        public InstallerHelper(IwClient w)
        {
            client = w;
        }

        public bool DownloadInstaller(string customerName, string installerName)
        {
            //var client = new WebClient();
            try
            {
                client.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
