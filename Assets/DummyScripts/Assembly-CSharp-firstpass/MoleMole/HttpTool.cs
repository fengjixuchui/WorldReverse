/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class HttpTool // TypeDefIndex: 10556
	{
		// Fields
		private static Dictionary<string, char> _entities; // 0x00
		private static char[] _hexChars; // 0x08
		private static object _sync; // 0x10
	
		// Constructors
		static HttpTool() {} // 0x0000000189BED720-0x0000000189BED7D0
		public HttpTool() {} // 0x0000000189BED7D0-0x0000000189BED830
	
		// Methods
		// [XID] // 0x00000001896A9BB0-0x00000001896A9BD0
		private static Dictionary<string, char> getEntities() => default; // 0x0000000189BED830-0x0000000189BEDA10
		// [IDTag] // 0x00000001896B0AE0-0x00000001896B0B20
		// [XID] // 0x00000001896B0AE0-0x00000001896B0B20
		private static int getNumber(char c) => default; // 0x0000000189BEDCA0-0x0000000189BEDD70
		// [IDTag] // 0x00000001896BB480-0x00000001896BB4C0
		// [XID] // 0x00000001896BB480-0x00000001896BB4C0
		private static int getNumber(byte[] bytes, int offset, int count) => default; // 0x0000000189BEDB50-0x0000000189BEDCA0
		// [IDTag] // 0x00000001896C5830-0x00000001896C5870
		// [XID] // 0x00000001896C5830-0x00000001896C5870
		private static int getNumber(string s, int offset, int count) => default; // 0x0000000189BEDA10-0x0000000189BEDB50
		// [XID] // 0x0000000189A5D300-0x0000000189A5D320
		private static string htmlDecode(string s) => default; // 0x0000000189BEDD70-0x0000000189BEE2E0
		// [XID] // 0x0000000189B46120-0x0000000189B46140
		private static string htmlEncode(string s, bool minimal) => default; // 0x0000000189BEE2E0-0x0000000189BEE500
		// [XID] // 0x00000001896DECD0-0x00000001896DECF0
		private static void initEntities() {} // 0x0000000189BEE500-0x0000000189BF1E00
		// [XID] // 0x0000000189B54ED0-0x0000000189B54EF0
		private static bool isAlphabet(char c) => default; // 0x0000000189BF1E00-0x0000000189BF1EC0
		// [XID] // 0x00000001896ED4A0-0x00000001896ED4C0
		private static bool isNumeric(char c) => default; // 0x0000000189BF1EC0-0x0000000189BF1F70
		// [XID] // 0x00000001896F4DE0-0x00000001896F4E00
		private static bool isUnreserved(char c) => default; // 0x0000000189BF2100-0x0000000189BF21C0
		// [XID] // 0x00000001896FC550-0x00000001896FC570
		private static bool isUnreservedInRfc2396(char c) => default; // 0x0000000189BF1F70-0x0000000189BF2040
		// [XID] // 0x0000000189703B20-0x0000000189703B40
		private static bool isUnreservedInRfc3986(char c) => default; // 0x0000000189BF2040-0x0000000189BF2100
		// [XID] // 0x0000000189837230-0x0000000189837250
		private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000189BF21C0-0x0000000189BF2450
		// [XID] // 0x00000001896C6FB0-0x00000001896C6FD0
		private static void urlEncode(byte b, Stream output) {} // 0x0000000189BF2650-0x0000000189BF2960
		// [XID] // 0x000000018971A420-0x000000018971A440
		private static byte[] urlEncodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000189BF2450-0x0000000189BF2650
		// [IDTag] // 0x00000001897216C0-0x0000000189721700
		// [XID] // 0x00000001897216C0-0x0000000189721700
		public static string HtmlAttributeEncode(string s) => default; // 0x0000000189BEB5C0-0x0000000189BEB6E0
		// [IDTag] // 0x000000018972BDA0-0x000000018972BDE0
		// [XID] // 0x000000018972BDA0-0x000000018972BDE0
		public static void HtmlAttributeEncode(string s, TextWriter output) {} // 0x0000000189BEB440-0x0000000189BEB5C0
		// [IDTag] // 0x0000000189736590-0x00000001897365D0
		// [XID] // 0x0000000189736590-0x00000001897365D0
		public static string HtmlDecode(string s) => default; // 0x0000000189BEB6E0-0x0000000189BEB800
		// [IDTag] // 0x0000000189741080-0x00000001897410C0
		// [XID] // 0x0000000189741080-0x00000001897410C0
		public static void HtmlDecode(string s, TextWriter output) {} // 0x0000000189BEB800-0x0000000189BEB980
		// [IDTag] // 0x000000018974B9C0-0x000000018974BA00
		// [XID] // 0x000000018974B9C0-0x000000018974BA00
		public static string HtmlEncode(string s) => default; // 0x0000000189BEB980-0x0000000189BEBAA0
		// [IDTag] // 0x0000000189755F10-0x0000000189755F50
		// [XID] // 0x0000000189755F10-0x0000000189755F50
		public static void HtmlEncode(string s, TextWriter output) {} // 0x0000000189BEBAA0-0x0000000189BEBC20
		// [IDTag] // 0x00000001897604B0-0x00000001897604F0
		// [XID] // 0x00000001897604B0-0x00000001897604F0
		public static string UrlDecode(string s) => default; // 0x0000000189BEC600-0x0000000189BEC700
		// [IDTag] // 0x000000018976AB70-0x000000018976ABB0
		// [XID] // 0x000000018976AB70-0x000000018976ABB0
		public static string UrlDecode(byte[] bytes, Encoding encoding) => default; // 0x0000000189BEC440-0x0000000189BEC600
		// [IDTag] // 0x0000000189774EC0-0x0000000189774F00
		// [XID] // 0x0000000189774EC0-0x0000000189774F00
		public static string UrlDecode(string s, Encoding encoding) => default; // 0x0000000189BEC700-0x0000000189BEC8F0
		// [IDTag] // 0x000000018977F620-0x000000018977F660
		// [XID] // 0x000000018977F620-0x000000018977F660
		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding) => default; // 0x0000000189BEC150-0x0000000189BEC440
		// [IDTag] // 0x0000000189789E50-0x0000000189789E90
		// [XID] // 0x0000000189789E50-0x0000000189789E90
		public static byte[] UrlDecodeToBytes(byte[] bytes) => default; // 0x0000000189BEC020-0x0000000189BEC150
		// [IDTag] // 0x0000000189794280-0x00000001897942C0
		// [XID] // 0x0000000189794280-0x00000001897942C0
		public static byte[] UrlDecodeToBytes(string s) => default; // 0x0000000189BEBC20-0x0000000189BEBDC0
		// [IDTag] // 0x000000018979F630-0x000000018979F670
		// [XID] // 0x000000018979F630-0x000000018979F670
		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000189BEBDC0-0x0000000189BEC020
		// [IDTag] // 0x00000001897A9A40-0x00000001897A9A80
		// [XID] // 0x00000001897A9A40-0x00000001897A9A80
		public static string UrlEncode(byte[] bytes) => default; // 0x0000000189BED560-0x0000000189BED720
		// [IDTag] // 0x00000001897B4920-0x00000001897B4960
		// [XID] // 0x00000001897B4920-0x00000001897B4960
		public static string UrlEncode(string s) => default; // 0x0000000189BED460-0x0000000189BED560
		// [IDTag] // 0x00000001897BF9D0-0x00000001897BFA10
		// [XID] // 0x00000001897BF9D0-0x00000001897BFA10
		public static string UrlEncode(string s, Encoding encoding) => default; // 0x0000000189BED210-0x0000000189BED460
		// [IDTag] // 0x00000001897C9D40-0x00000001897C9D80
		// [XID] // 0x00000001897C9D40-0x00000001897C9D80
		public static string UrlEncode(byte[] bytes, int offset, int count) => default; // 0x0000000189BECF40-0x0000000189BED210
		// [IDTag] // 0x00000001897D4500-0x00000001897D4540
		// [XID] // 0x00000001897D4500-0x00000001897D4540
		public static byte[] UrlEncodeToBytes(byte[] bytes) => default; // 0x0000000189BECAB0-0x0000000189BECBE0
		// [IDTag] // 0x00000001897DEC40-0x00000001897DEC80
		// [XID] // 0x00000001897DEC40-0x00000001897DEC80
		public static byte[] UrlEncodeToBytes(string s) => default; // 0x0000000189BECBE0-0x0000000189BECCE0
		// [IDTag] // 0x00000001897E9650-0x00000001897E9690
		// [XID] // 0x00000001897E9650-0x00000001897E9690
		public static byte[] UrlEncodeToBytes(string s, Encoding encoding) => default; // 0x0000000189BEC8F0-0x0000000189BECAB0
		// [IDTag] // 0x00000001897F42C0-0x00000001897F4300
		// [XID] // 0x00000001897F42C0-0x00000001897F4300
		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) => default; // 0x0000000189BECCE0-0x0000000189BECF40
	}
}
