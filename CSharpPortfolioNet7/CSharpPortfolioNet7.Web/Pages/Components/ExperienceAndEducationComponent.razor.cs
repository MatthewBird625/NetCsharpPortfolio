using CSharpPortfolioNet7.UiLogic.Models;
using Microsoft.AspNetCore.Components;

namespace CSharpPortfolioNet7.Web.Pages.Components
{
    public partial class ExperienceAndEducationComponent
    {
        [Parameter]
        public ExperienceAndEducationModel Model { get; set; } = new();
    }
}
