using Microsoft.AspNetCore.Components;
using NetCSharpPortfolio.UiLogic.Models;
using NetCSharpPortfolio.UiLogic.ViewModels;

namespace NetCSharpPortfolio.Web.Components.Pages
{
    public partial class Home
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
