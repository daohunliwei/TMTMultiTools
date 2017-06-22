using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMTMultiTools.Model.DBModel;
using TMTMultiTools;
namespace TMTMultiTools.DB.Test
{
    [TestClass]
    public class MySqlHelperTest
    {
        [TestMethod]
        public void TestGet()
        { 
            var resr = MySqlHelper.Instance.Get<Extendconfig>();
            Assert.IsNotNull(resr);
        }
    }
}
