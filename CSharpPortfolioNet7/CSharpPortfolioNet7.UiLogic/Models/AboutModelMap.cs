using CSharpPortfolioNet7.Data.Models;
using System.Text.Encodings.Web;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpPortfolioNet7.UiLogic.Models
{
    public static class AboutModelMap
    {
        public static AboutModel Map(About source)
        {
            return new AboutModel()
            {
                AboutMe = source.AboutMe,
                Address = source.Address,
                ContactTitle = source.ContactTitle,
                ContactUrl = source.ContactUrl
            };
        }
    }
}


