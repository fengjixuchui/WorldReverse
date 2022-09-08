/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal static class HttpUtility // TypeDefIndex: 10271
	{
		// Fields
		private static Dictionary<string, char> _entities; // 0x00
		private static char[] _hexChars; // 0x08
		private static object _sync; // 0x10
	
		// Constructors
		static HttpUtility() {} // 0x000000018717CE20-0x000000018717CED0
	
		// Methods
		// [XID] // 0x0000000189695000-0x0000000189695020
		private static Dictionary<string, char> getEntities() => default; // 0x000000018717CED0-0x000000018717D0B0
		// [IDTag] // 0x00000001897D7710-0x00000001897D7750
		// [XID] // 0x00000001897D7710-0x00000001897D7750
		private static int getNumber(char c) => default; // 0x000000018717D1F0-0x000000018717D2C0
		// [IDTag] // 0x00000001897E1EE0-0x00000001897E1F20
		// [XID] // 0x00000001897E1EE0-0x00000001897E1F20
		private static int getNumber(byte[] bytes, int offset, int count) => default; // 0x000000018717D2C0-0x000000018717D410
		// [IDTag] // 0x00000001897ECA50-0x00000001897ECA90
		// [XID] // 0x00000001897ECA50-0x00000001897ECA90
		private static int getNumber(string s, int offset, int count) => default; // 0x000000018717D0B0-0x000000018717D1F0
		// [XID] // 0x00000001897F7020-0x00000001897F7040
		private static string htmlDecode(string s) => default; // 0x000000018717D410-0x000000018717D980
		// [XID] // 0x00000001897FE660-0x00000001897FE680
		private static string htmlEncode(string s, bool minimal) => default; // 0x000000018717D980-0x000000018717DBA0
		// [XID] // 0x0000000189805DF0-0x0000000189805E10
		private static void initEntities() {} // 0x000000018717DBA0-0x00000001871814A0
		// [XID] // 0x00000001899199C0-0x00000001899199E0
		private static bool isAlphabet(char c) => default; // 0x00000001871814A0-0x0000000187181560
		// [XID] // 0x0000000189814BF0-0x0000000189814C10
		private static bool isNumeric(char c) => default; // 0x0000000187181560-0x0000000187181610
		// [XID] // 0x00000001898F0D80-0x00000001898F0DA0
		private static bool isUnreserved(char c) => default; // 0x00000001871817A0-0x0000000187181860
		// [XID] // 0x0000000189823C40-0x0000000189823C60
		private static bool isUnreservedInRfc2396(char c) => default; // 0x0000000187181610-0x00000001871816E0
		// [XID] // 0x00000001895FA140-0x00000001895FA160
		private static bool isUnreservedInRfc3986(char c) => default; // 0x00000001871816E0-0x00000001871817A0
		// [XID] // 0x00000001899F6670-0x00000001899F6690
		private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000187181860-0x0000000187181AF0
		// [XID] // 0x000000018983A0D0-0x000000018983A0F0
		private static void urlEncode(byte b, Stream output) {} // 0x0000000187181CF0-0x0000000187182000
		// [XID] // 0x00000001897CA030-0x00000001897CA050
		private static byte[] urlEncodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000187181AF0-0x0000000187181CF0
		// [XID] // 0x0000000189848A60-0x0000000189848A80
		internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure) => default; // 0x0000000187179F90-0x000000018717A3F0
		// [XID] // 0x00000001899D44F0-0x00000001899D4510
		internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func<IIdentity, NetworkCredential> credentialsFinder) => default; // 0x000000018717A3F0-0x000000018717A750
		// [XID] // 0x0000000189A066C0-0x0000000189A066E0
		internal static Encoding GetEncoding(string contentType) => default; // 0x000000018717A750-0x000000018717AA50
		// [XID] // 0x000000018985E760-0x000000018985E780
		internal static bool TryGetEncoding(string contentType, out Encoding result) {
			result = default;
			return default;
		} // 0x000000018717B230-0x000000018717B320
		// [IDTag] // 0x0000000189866010-0x0000000189866050
		// [XID] // 0x0000000189866010-0x0000000189866050
		public static string HtmlAttributeEncode(string s) => default; // 0x000000018717ABD0-0x000000018717ACF0
		// [IDTag] // 0x0000000189870590-0x00000001898705D0
		// [XID] // 0x0000000189870590-0x00000001898705D0
		public static void HtmlAttributeEncode(string s, TextWriter output) {} // 0x000000018717AA50-0x000000018717ABD0
		// [IDTag] // 0x000000018987B0E0-0x000000018987B120
		// [XID] // 0x000000018987B0E0-0x000000018987B120
		public static string HtmlDecode(string s) => default; // 0x000000018717ACF0-0x000000018717AE10
		// [IDTag] // 0x00000001898852D0-0x0000000189885310
		// [XID] // 0x00000001898852D0-0x0000000189885310
		public static void HtmlDecode(string s, TextWriter output) {} // 0x000000018717AE10-0x000000018717AF90
		// [IDTag] // 0x000000018988F6A0-0x000000018988F6E0
		// [XID] // 0x000000018988F6A0-0x000000018988F6E0
		public static string HtmlEncode(string s) => default; // 0x000000018717AF90-0x000000018717B0B0
		// [IDTag] // 0x0000000189899E30-0x0000000189899E70
		// [XID] // 0x0000000189899E30-0x0000000189899E70
		public static void HtmlEncode(string s, TextWriter output) {} // 0x000000018717B0B0-0x000000018717B230
		// [IDTag] // 0x00000001898A42C0-0x00000001898A4300
		// [XID] // 0x00000001898A42C0-0x00000001898A4300
		public static string UrlDecode(string s) => default; // 0x000000018717BC00-0x000000018717BD00
		// [IDTag] // 0x00000001898AEA60-0x00000001898AEAA0
		// [XID] // 0x00000001898AEA60-0x00000001898AEAA0
		public static string UrlDecode(byte[] bytes, Encoding encoding) => default; // 0x000000018717B850-0x000000018717BA10
		// [IDTag] // 0x00000001898B92C0-0x00000001898B9300
		// [XID] // 0x00000001898B92C0-0x00000001898B9300
		public static string UrlDecode(string s, Encoding encoding) => default; // 0x000000018717BA10-0x000000018717BC00
		// [IDTag] // 0x00000001898C3650-0x00000001898C3690
		// [XID] // 0x00000001898C3650-0x00000001898C3690
		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding) => default; // 0x000000018717BD00-0x000000018717BFF0
		// [IDTag] // 0x00000001898CDCF0-0x00000001898CDD30
		// [XID] // 0x00000001898CDCF0-0x00000001898CDD30
		public static byte[] UrlDecodeToBytes(byte[] bytes) => default; // 0x000000018717B4C0-0x000000018717B5F0
		// [IDTag] // 0x00000001898D8660-0x00000001898D86A0
		// [XID] // 0x00000001898D8660-0x00000001898D86A0
		public static byte[] UrlDecodeToBytes(string s) => default; // 0x000000018717B320-0x000000018717B4C0
		// [IDTag] // 0x00000001898E3280-0x00000001898E32C0
		// [XID] // 0x00000001898E3280-0x00000001898E32C0
		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count) => default; // 0x000000018717B5F0-0x000000018717B850
		// [IDTag] // 0x00000001898EDDF0-0x00000001898EDE30
		// [XID] // 0x00000001898EDDF0-0x00000001898EDE30
		public static string UrlEncode(byte[] bytes) => default; // 0x000000018717CC60-0x000000018717CE20
		// [IDTag] // 0x00000001898F8840-0x00000001898F8880
		// [XID] // 0x00000001898F8840-0x00000001898F8880
		public static string UrlEncode(string s) => default; // 0x000000018717C640-0x000000018717C740
		// [IDTag] // 0x0000000189902F80-0x0000000189902FC0
		// [XID] // 0x0000000189902F80-0x0000000189902FC0
		public static string UrlEncode(string s, Encoding encoding) => default; // 0x000000018717C740-0x000000018717C990
		// [IDTag] // 0x000000018990D8E0-0x000000018990D920
		// [XID] // 0x000000018990D8E0-0x000000018990D920
		public static string UrlEncode(byte[] bytes, int offset, int count) => default; // 0x000000018717C990-0x000000018717CC60
		// [IDTag] // 0x0000000189918080-0x00000001899180C0
		// [XID] // 0x0000000189918080-0x00000001899180C0
		public static byte[] UrlEncodeToBytes(byte[] bytes) => default; // 0x000000018717C510-0x000000018717C640
		// [IDTag] // 0x0000000189922870-0x00000001899228B0
		// [XID] // 0x0000000189922870-0x00000001899228B0
		public static byte[] UrlEncodeToBytes(string s) => default; // 0x000000018717C410-0x000000018717C510
		// [IDTag] // 0x000000018992CEB0-0x000000018992CEF0
		// [XID] // 0x000000018992CEB0-0x000000018992CEF0
		public static byte[] UrlEncodeToBytes(string s, Encoding encoding) => default; // 0x000000018717BFF0-0x000000018717C1B0
		// [IDTag] // 0x0000000189937350-0x0000000189937390
		// [XID] // 0x0000000189937350-0x0000000189937390
		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) => default; // 0x000000018717C1B0-0x000000018717C410
	}
}
