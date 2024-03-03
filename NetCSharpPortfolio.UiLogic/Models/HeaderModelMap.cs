using NetCSharpPortfolio.Data.Models;

namespace NetCSharpPortfolio.UiLogic.Models
{
    public static class HeaderModelMap
    {
        public static HeaderModel Map(Header source)
        {
            return new HeaderModel()
            {
                Linkedin = source.Linkedin,
                Name = source.Name,
                Role = source.Role
            };
        }
    }
}
