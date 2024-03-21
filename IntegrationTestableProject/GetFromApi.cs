using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestableProject
{
    public interface IGetFromApi
    {
        public string GetData();
    }

    public class GetFromApi
    {
        public string GetData()
        {
            using (WebClient client = new WebClient())
            {
                string downloadString = client.DownloadString("https://www.delfi.lt/");
                return downloadString;//gets from internet
            }

        }
    }
}
