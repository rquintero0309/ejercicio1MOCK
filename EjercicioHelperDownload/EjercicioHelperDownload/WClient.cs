using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace EjercicioHelperDownload
{
    public interface IwClient
    {
        void IwClient(WebClient w);

        public void DownloadFile(string url, string custName);
    }
}
