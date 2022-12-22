using Microsoft.AspNetCore.Mvc;

namespace EComStore.Site.Components;

[ViewComponent(Name = "Portfolio")]
public class PortfolioViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
