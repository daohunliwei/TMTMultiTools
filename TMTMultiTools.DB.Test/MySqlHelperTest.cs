using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMTMultiTools.Model.DBModel;

namespace TMTMultiTools.DB.Test
{
    [TestClass]
    public class MySqlHelperTest
    {
        [TestMethod]
        public void TestGet()
        {
            var helper = new MySqlHelper("Server=120.92.80.131;Database=myowntoolsdb;Uid=root;Pwd=doyouloveme123!;");
            var resr = helper.Get<Extendconfig>();
            Assert.IsNotNull(resr);
        }
    }
}
