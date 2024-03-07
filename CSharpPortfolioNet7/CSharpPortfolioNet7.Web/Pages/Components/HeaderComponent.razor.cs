using CSharpPortfolioNet7.UiLogic.Models;
using Microsoft.AspNetCore.Components;

namespace CSharpPortfolioNet7.Web.Pages.Components
{
    public partial class HeaderComponent
    {
        [Parameter]
        public HeaderModel Model { get; set; } = new();
    }
}
