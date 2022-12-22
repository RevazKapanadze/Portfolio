using Microsoft.AspNetCore.Mvc;

namespace EComStore.Site.Components;

    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
