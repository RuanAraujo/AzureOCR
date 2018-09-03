using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Plugin.Media.Abstractions;

namespace POGSC
{
    public class Service
    {
        HttpClient httpClient;


        private static readonly string subscriptionkey = "your subs key";
        private static readonly string url = "https://brazilsouth.api.cognitive.microsoft.com/vision/v1.0/ocr?";






        public async Task<Resposta> PostServicoAsync(MediaFile mediaFile)
        {
            httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionkey);

            var streamContent = new StreamContent(mediaFile.GetStream());

            streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["language"] = "pt";
            queryString["detectOrientation "] = "true";
            var novo = url + queryString;




            try
            {
                var response = await httpClient.PostAsync(novo, streamContent);

                var x = await response.Content.ReadAsStringAsync();

                var obj =  JsonConvert.DeserializeObject<Resposta>(x);


                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
