using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PubgNetTest
{
    [TestClass]
    public class PubgNetUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ClientConstructorBadKey()
        {
            PubgNet.PubgNetClient client = new PubgNet.PubgNetClient(null);
        }
    }
}
