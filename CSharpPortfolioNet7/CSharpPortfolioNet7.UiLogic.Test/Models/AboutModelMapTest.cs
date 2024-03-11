using CSharpPortfolioNet7.Data.Models;
using CSharpPortfolioNet7.UiLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpPortfolioNet7.UiLogic.Test.Models
{
    [TestClass]
    public class AboutModelMapTest
    {
        [TestMethod]
        public void Map() 
        {
            var model = new About()
            {
                AboutMe = "about",
                Address = "address",
                ContactTitle = "title",
                ContactUrl = "url",
            };

            var result = AboutModelMap.Map(model);

            Assert.AreEqual("about", result.AboutMe);
            Assert.AreEqual("address", result.Address);
            Assert.AreEqual("title", result.ContactTitle);
            Assert.AreEqual("url", result.ContactUrl);
        }
    }
}
