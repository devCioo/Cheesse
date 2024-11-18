using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Cheesse.Controllers
{
	[Route("[controller]/[action]")]
	public class PreferenceController : Controller
	{
		public IActionResult Set(string culture, string redirectUri)
		{
			if (culture != null)
			{
				var requestCulture = new RequestCulture(culture, culture);
				var cookieName = CookieRequestCultureProvider.DefaultCookieName;
				var cookieValue = CookieRequestCultureProvider.MakeCookieValue(requestCulture);

				HttpContext.Response.Cookies.Append(cookieName, cookieValue);
			}

			return LocalRedirect(redirectUri);
		}
	}
}