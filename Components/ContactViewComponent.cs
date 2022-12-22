using Microsoft.AspNetCore.Mvc;

namespace EComStore.Site.Components;

[ViewComponent(Name = "Contact")]
public class ContactViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
