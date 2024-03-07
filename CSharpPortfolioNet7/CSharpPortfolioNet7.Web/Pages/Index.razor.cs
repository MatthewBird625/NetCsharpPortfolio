using CSharpPortfolioNet7.UiLogic.Models;
using CSharpPortfolioNet7.UiLogic.ViewModels;
using Microsoft.AspNetCore.Components;

namespace CSharpPortfolioNet7.Web.Pages
{
    public partial class Index
    {
        [Inject]
        IHomeViewModel ViewModel { get; set; } = default!;

        private HomeModel Model { get { return ViewModel.Model; } }

        protected override void OnInitialized()
        {
            ViewModel.Initialise();
            base.OnInitialized();
        }
    }
}