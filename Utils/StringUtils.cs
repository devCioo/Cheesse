using System.Security.Cryptography;
using System.Text;

namespace Cheesse.Utils
{
	public static class StringUtils
	{
		public static string GetMD5Hash(string input)
		{
			using MD5 md5 = MD5.Create();

			byte[] inputByte = Encoding.UTF8.GetBytes(input);
			byte[] hashBytes = md5.ComputeHash(inputByte);

			StringBuilder sb = new StringBuilder();
			foreach (byte b in hashBytes)
			{
				sb.Append(b.ToString("X2"));
			}

			return sb.ToString();
		}
	}
}