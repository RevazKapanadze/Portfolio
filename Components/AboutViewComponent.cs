using Microsoft.AspNetCore.Mvc;

namespace EComStore.Site.Components;

[ViewComponent(Name = "About")]
public class AboutViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
