using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMTMultiTools.Common.Providers;

namespace TMTMultiTools.Common.Test
{
    [TestClass]
    public class WeiboProviderTest
    {
        [TestMethod]
        public void TestGetPage()
        {
            WeiboProvider.SearchWeibo();
        }
    }
}
