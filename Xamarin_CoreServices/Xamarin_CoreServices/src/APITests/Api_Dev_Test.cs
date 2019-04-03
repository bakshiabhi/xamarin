﻿using System;
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
    class Api_Dev_Test
    {
        [Test]
        public void PostToken()
        {
            string USERNAME = "paas.test.1@royalmail.com";
            string PASSWORD = "P44stest";
            string CLIENTID = "c21fbf50-0de6-0137-acc6-06f7df4813c636886";
            string SUBSCRIPTION_KEY = "d76396cf094a41de989b9d19104b608d";

            using (var client = new HttpClient())

            {
                client.DefaultRequestHeaders.Add("X-Message-Id", "45735473");
                client.DefaultRequestHeaders.Add("X-Device-Id", "jcvsouc");
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SUBSCRIPTION_KEY);
                var formData = new FormUrlEncodedContent(new[]
                {
              new KeyValuePair<string, string>("username", USERNAME),
              new KeyValuePair<string, string>("password", PASSWORD),
              new KeyValuePair<string, string>("client_id",CLIENTID ),
              new KeyValuePair<string, string>("grant_type", "password"),
              new KeyValuePair<string, string>("scope", "openid profile email")
               });

                var uri = "https://rmgmsft-services-dev-apim.azure-api.net/dso/v1/connect/token";

                var res = client.PostAsync(uri, formData).Result;
                var json = res.Content.ReadAsStringAsync().Result;

                Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
            }


        }
        /*    [Test]
            public void RefreshPostToken()
            {
                string REFRESHTOKEN = "MTZmODVmODItYjM2My00NGU3LWFlYzQtOTJmYjY2YzA4OGE1lU2MTzFClRPSG7QUIP5bGi0GJIFuqC0MzRe4R_Tu49mCXcX_LOl3CqdYfyHALUX3Abk8r2fnvGNFZxxF02D9_A";
                string CLIENTID = "c21fbf50-0de6-0137-acc6-06f7df4813c636886";
                string CLIENTSECRET = "12f4ad3063a3a77be228725b298bec0756a39ae3af9f69a504ada5b965e06bfb";

                using (var client = new HttpClient())

                {
                    var formData = new FormUrlEncodedContent(new[]
                    {
                  new KeyValuePair<string, string>("refresh_token", REFRESHTOKEN),
                  new KeyValuePair<string, string>("grant_type", "refresh_token"),
                  new KeyValuePair<string, string>("client_id",CLIENTID),
                  new KeyValuePair<string, string>("client_secret",CLIENTSECRET)
                   });

                    var uri = "http://rmg-pda-coreservices-sso-identityproxy-dev.azurewebsites.net/api/v1/connect/token";

                    var res = client.PostAsync(uri, formData).Result;
                    var json = res.Content.ReadAsStringAsync().Result;

                    Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
                }

            }*/

        /*
    [Test]
    public void PostRevocation()
    {
        string TOKEN = "OTk3YzdjMmUtZGJmZi00M2IzLWIyMmUtMDVjY2Y5MTIwZWY5n4Cp4_R5zGw7gLNGq2m2UE-tuWF4rXz9eMSrLMniLYRLUvbAPAUQwzw6CZ7vV3_l--5cnsiJxUe6fgptEVLsOA";
        string CLIENTID = "c21fbf50-0de6-0137-acc6-06f7df4813c636886";
        string CLIENTSECRET = "12f4ad3063a3a77be228725b298bec0756a39ae3af9f69a504ada5b965e06bfb";

        using (var client = new HttpClient())

        {
            client.DefaultRequestHeaders.Add("X-Message-Id", "45735473");
            client.DefaultRequestHeaders.Add("X-Device-Id", "jcvsouc");
            var formData = new FormUrlEncodedContent(new[]
            {
          new KeyValuePair<string, string>("token",TOKEN),
          new KeyValuePair<string, string>("token_type_hint", "access_token"),
          new KeyValuePair<string, string>("client_id",CLIENTID),
          new KeyValuePair<string, string>("client_secret",CLIENTSECRET)
           });

            var uri = "http://rmg-pda-coreservices-sso-identityproxy-dev.azurewebsites.net/api/v1/connect/Revocation";

            var res = client.PostAsync(uri, formData).Result;
            var json = res.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
        }
    }

    [Test]
    public void PostIntrospection()
    {
        string TOKEN = "ZjQ1YzZiNTgtZjVjZC00YjdlLWFkYTYtZWI0ZTBmYjA4OTVk_NKOA6rwp9QoEbYwwP3GZmsdBMATGrnDNOzuAUZJoaeW-b1GRjy1Yn4pnV7enucLDdePENHL86dHouLtCtUJkQ";
        string CLIENTID = "c21fbf50-0de6-0137-acc6-06f7df4813c636886";
        string CLIENTSECRET = "12f4ad3063a3a77be228725b298bec0756a39ae3af9f69a504ada5b965e06bfb";

        using (var client = new HttpClient())

        {
            client.DefaultRequestHeaders.Add("X-Message-Id", "45735473");
            client.DefaultRequestHeaders.Add("X-Device-Id", "jcvsouc");
            var formData = new FormUrlEncodedContent(new[]
            {
          new KeyValuePair<string, string>("token",TOKEN),
          new KeyValuePair<string, string>("token_type_hint", "access_token"),
          new KeyValuePair<string, string>("client_id",CLIENTID),
          new KeyValuePair<string, string>("client_secret",CLIENTSECRET)
           });

            var uri = "http://rmg-pda-coreservices-sso-identityproxy-dev.azurewebsites.net/api/v1/connect/Introspection";

            var res = client.PostAsync(uri, formData).Result;
            var json = res.Content.ReadAsStringAsync().Result;

            Assert.AreEqual(HttpStatusCode.OK, res.StatusCode);
        }
    }*/
    }
 }
