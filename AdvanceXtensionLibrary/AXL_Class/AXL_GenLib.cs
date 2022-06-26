using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary.AXL_Class
{
    public class AXL_GenLib
    {
		public static string Encode(Guid guid)
		{
			string encoded = Convert.ToBase64String(guid.ToByteArray());
			encoded = encoded.Replace("/", "_").Replace("+", "-");
			string salt = AXL_Security.axl_guard.generateSalt(4);// WHY 4? BECAUSE IT'S MY BIRTHMONTH 
			return encoded.Substring(0, 22) + salt; //WHY 22? BECAUSE BASE64 SHOULD BE MULTIPLE OF 4 AND Byte array for GUID must be exactly 16 bytes long. 22 is safe because we will add two equal at the end to become 24 characters.
		}

		public static Guid Decode(string value)
		{
			string removeExcess = value.Remove(22);
			value = removeExcess.Replace("_", "/").Replace("-", "+");
			byte[] buffer = Convert.FromBase64String(value + "==");
			return new Guid(buffer);
		}
	}
}
