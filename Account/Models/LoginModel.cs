using Cheesse.Resources;
using System.ComponentModel.DataAnnotations;

namespace Cheesse.Account.Models
{
	public class LoginModel
	{
		[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(Resource.Required), ErrorMessageResourceType = typeof(Resource))]
		public string Login { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(Resource.Required), ErrorMessageResourceType = typeof(Resource))]
		public string Password { get; set; }
	}
}