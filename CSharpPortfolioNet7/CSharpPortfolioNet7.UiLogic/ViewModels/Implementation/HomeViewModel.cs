using CSharpPortfolioNet7.Data.Services;
using CSharpPortfolioNet7.UiLogic.Models;
using System.Reflection;

namespace CSharpPortfolioNet7.UiLogic.ViewModels.Implementation
{
    public class HomeViewModel :IHomeViewModel
    {
        readonly IPortfolioDataService _portfolioService;

        public HomeViewModel(IPortfolioDataService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public HomeModel Model { get; set; } = new();

        public void Initialise()
        {
            var portfolioData =  _portfolioService.GetPortfolioData();

            Model.About = AboutModelMap.Map(portfolioData.About);
            Model.Header = HeaderModelMap.Map(portfolioData.Header); 
        }
    }
}
