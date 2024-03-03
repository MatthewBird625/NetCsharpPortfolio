using NetCSharpPortfolio.UiLogic.Models;

namespace NetCSharpPortfolio.UiLogic.ViewModels
{
    public interface IHomeViewModel
    {
        HomeModel Model { get; set; }

        void Initialise();
    }
}
