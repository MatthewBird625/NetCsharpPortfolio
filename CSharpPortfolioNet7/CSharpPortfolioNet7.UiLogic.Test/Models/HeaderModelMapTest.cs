using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpPortfolioNet7.Data.Models;
using CSharpPortfolioNet7.UiLogic.Models;

namespace CSharpPortfolioNet7.UiLogic.Test.Models
{
    [TestClass]
    public class HeaderModelMapTest
    {
        [TestMethod]
        public void Map() 
        {
            var model = new Header()
            {
                Description = "Description",
                GitHub = "GitHub",
                Linkedin = "Link",
                Name = "Name",
                Role = "Role"
            };

            var result = HeaderModelMap.Map(model);

            Assert.AreEqual("Description", result.Description);
            Assert.AreEqual("GitHub", result.GitHub);
            Assert.AreEqual("Link", result.Linkedin);
            Assert.AreEqual("Name", result.Name);
            Assert.AreEqual("Role", result.Role);
        }
    }
}
