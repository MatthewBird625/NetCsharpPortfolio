using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCSharpPortfolio.Data.Models;
using NetCSharpPortfolio.UiLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCSharpPortfolio.UiLogic.Test.Models
{
    [TestClass]
    public class HeaderModelMapTest
    {
        [TestMethod]
        public void Map() 
        {
            var model = new Header()
            {
                Linkedin = "Link",
                Name = "Name",
                Role = "Role"
            };

            var result = HeaderModelMap.Map(model);

            Assert.AreEqual("Link", result.Linkedin);
            Assert.AreEqual("Name", result.Name);
            Assert.AreEqual("Role", result.Role);
        }
    }
}
