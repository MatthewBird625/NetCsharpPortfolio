using CSharpPortfolioNet7.UiLogic.Models;
using Microsoft.AspNetCore.Components;

namespace CSharpPortfolioNet7.Web.Pages.Components
{
    public partial class AboutComponent
    {
        [Parameter]
        public AboutModel Model { get; set; } = new();
    }
}
