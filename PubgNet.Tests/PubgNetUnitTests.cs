using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace PubgNetTest
{
    [TestClass]
    public class PubgNetUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public async Task HttpClientUnauthorized()
        {
            PubgNet.Http.HttpHandler client = new PubgNet.Http.HttpHandler("https://api.pubg.com/","api-key-invalid", "application/vnd.api+json");
            client.SetHandleExceptions(false);
            await client.RequestAsync("/status");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public async Task HttpClientNotFound()
        {
            PubgNet.Http.HttpHandler client = new PubgNet.Http.HttpHandler("https://api.pubg.com/", "api-key-here", "application/vnd.api+json");
            client.SetHandleExceptions(false);
            await client.RequestAsync("/endpoint-invalid");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ClientConstructorInvalidKey()
        {
            PubgNet.PubgNetClient client = new PubgNet.PubgNetClient(null);
        }
    }
}
