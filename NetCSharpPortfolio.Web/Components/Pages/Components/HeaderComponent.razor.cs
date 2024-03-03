using Microsoft.AspNetCore.Components;
using NetCSharpPortfolio.UiLogic.Models;
using NetCSharpPortfolio.UiLogic.ViewModels;

namespace NetCSharpPortfolio.Web.Components.Pages.Components
{
    public partial class HeaderComponent
    {
        [Parameter]
        public HeaderModel Model { get; set; } = new();
    }
}
