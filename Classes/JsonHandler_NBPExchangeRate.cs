using System;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EconomicCalc
{
    class JsonHandler_NBPExchangeRate
    {
        /**
         * An instance of this class is a handle to the json file from NBP api
         * 
         * @author Patryk Kazimierowski
         */
        private List<RootObject> List;
        private string BaseAddr = "http://api.nbp.pl/api/exchangerates/tables/c/";

        /**
         * Method to convert Json file to List type
         */
        public async Task ConverJsonToList()
        {
            try
            {
                List = JsonConvert.DeserializeObject<List<RootObject>>(await TestGet());
            }
            catch (Exception e)
            {
                var a = e.Message.ToString();
            }
        }
        /**
         * Method to connect to the NbP api and download json file 
         * @return testrequest
         *      String wiht Json file
         */
        private async Task<string> TestGet()
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

        /**
         * @return List
         *      converted Json file to List
         */
        public List<RootObject> GetRootObjects()
        {
            return List;
        }
    }
}