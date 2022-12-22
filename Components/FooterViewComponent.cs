using Microsoft.AspNetCore.Mvc;

namespace EComStore.Site.Components;

[ViewComponent(Name = "Footer")]
public class FooterViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
