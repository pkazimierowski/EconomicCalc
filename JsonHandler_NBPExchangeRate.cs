using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace wymiana
{
    class JsonHandler_NBPExchangeRate
    {
        private string BaseAddr = "http://api.nbp.pl/api/exchangerates/tables/c/";
        public async Task MakeStringGA()
        {
            try
            {
                var getData = JsonConvert.DeserializeObject<List<RootObject>>(await TestGet());
            }
            catch (Exception e)
            {
                var a = e.Message.ToString();
            }
        }
        public async Task<string> TestGet()
        {
            String testrequest = "";
            try
            {
                var request = HttpWebRequest.CreateHttp(BaseAddr);
                request.Method = WebRequestMethods.Http.Get;
                request.ContentType = "application/json; charset:utf8";
                await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null).ContinueWith(task =>
                {
                    var response = (HttpWebResponse)task.Result;
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader responseReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        String responseData = responseReader.ReadToEnd();
                        testrequest = responseData.ToString();
                        responseReader.Close();
                    }
                    response.Close();
                });
            }
            catch (Exception e)
            {
                var a = e.Message.ToString();
            }
            return testrequest;
        }
    }
}
