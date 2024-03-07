namespace CSharpPortfolioNet7.Web.Shared
{
    public partial class NavMenu
    {
        public bool NavMenuExpanded { get; set; } = false;

        public void NavMenuToggled() 
        {
            NavMenuExpanded = !NavMenuExpanded;
        }
    }
}
