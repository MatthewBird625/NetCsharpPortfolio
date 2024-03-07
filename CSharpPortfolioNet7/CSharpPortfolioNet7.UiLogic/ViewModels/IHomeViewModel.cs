using CSharpPortfolioNet7.UiLogic.Models;

namespace CSharpPortfolioNet7.UiLogic.ViewModels
{
    public interface IHomeViewModel
    {
        HomeModel Model { get; set; }

        void Initialise();
    }
}
