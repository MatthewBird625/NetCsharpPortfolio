using CSharpPortfolioNet7.Data.Models;

namespace CSharpPortfolioNet7.UiLogic.Models
{
    public static class HeaderModelMap
    {
        public static HeaderModel Map(Header source)
        {
            return new HeaderModel()
            {
                Description = source.Description,
                GitHub = source.GitHub,
                Linkedin = source.Linkedin,
                Name = source.Name,
                Role = source.Role
            };
        }
    }
}
