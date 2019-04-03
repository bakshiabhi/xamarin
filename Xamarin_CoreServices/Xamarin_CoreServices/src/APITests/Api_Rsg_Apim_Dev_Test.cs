using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Xamarin_CoreServices.APITests
{
    [TestFixture]
    class Api_Rsg_Apim_Dev_Test
    {

        [Test]
        public void GetKeyRequest()
        {

         const  string APIMSUBSCIPTIONKEY = "d76396cf094a41de989b9d19104b608d";
            using (var client = new HttpClient())

            {
              
                const string uri = "https://rmgmsft-services-dev-apim.azure-api.net/dso/v1/.well-known/openid-configuration";

                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);
                httpRequestMessage.Headers.Add("Ocp-Apim-Subscription-Key", APIMSUBSCIPTIONKEY);

                var res = client.SendAsync(httpRequestMessage).Result;
                var json = res.Content.ReadAsStringAsync().Result;

                Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
            }

        }
        [Test]
        public void GetJwks()
        {
            const string APIMSUBSCIPTIONKEY = "d76396cf094a41de989b9d19104b608d";
            using (var client = new HttpClient())
            {
                const string uri = "https://rmgmsft-services-dev-apim.azure-api.net/dso/v1/certs";
             
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);                
                httpRequestMessage.Headers.Add("Ocp-Apim-Subscription-Key", APIMSUBSCIPTIONKEY);

                var res = client.SendAsync(httpRequestMessage).Result;
                var json = res.Content.ReadAsStringAsync().Result;

                Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
            }
        }

        [Test]
        public void GetJwks2()
        {
            string APIMSUBSCIPTIONKEY = "d76396cf094a41de989b9d19104b608d";
            using (var client = new HttpClient())
            {
                var uri = "https://rmgmsft-services-dev-apim.azure-api.net/dso/v1/certs";              
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", APIMSUBSCIPTIONKEY);
                var res = client.GetAsync(uri).Result;
                var json = res.Content.ReadAsStringAsync().Result;

                Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
            }
        }
    }

}
