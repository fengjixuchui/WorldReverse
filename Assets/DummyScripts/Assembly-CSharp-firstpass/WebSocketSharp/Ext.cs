/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	public static class Ext // TypeDefIndex: 10218
	{
		// Fields
		private static readonly byte[] _last; // 0x00
		private static readonly int _retry; // 0x08
		private const string _tspecials = "()<>@,;:\\\"/[]?={} \t"; // Metadata: 0x00AE725D
	
		// Constructors
		static Ext() {} // 0x0000000186E9DED0-0x0000000186E9DF70
	
		// Extension methods
		// [IDTag] // 0x0000000189A228C0-0x0000000189A22910
		// [XID] // 0x0000000189A228C0-0x0000000189A22910
		private static byte[] compress(this byte[] data) => default; // 0x0000000186E9E370-0x0000000186E9E510
		// [IDTag] // 0x0000000189A2FA70-0x0000000189A2FAC0
		// [XID] // 0x0000000189A2FA70-0x0000000189A2FAC0
		private static MemoryStream compress(this Stream stream) => default; // 0x0000000186E9E110-0x0000000186E9E370
		// [XID] // 0x0000000189A3D0B0-0x0000000189A3D0F0
		private static byte[] compressToArray(this Stream stream) => default; // 0x0000000186E9DF70-0x0000000186E9E110
		// [IDTag] // 0x0000000189A478E0-0x0000000189A47930
		// [XID] // 0x0000000189A478E0-0x0000000189A47930
		private static byte[] decompress(this byte[] data) => default; // 0x0000000186E9E8B0-0x0000000186E9EA50
		// [IDTag] // 0x0000000189A55170-0x0000000189A551C0
		// [XID] // 0x0000000189A55170-0x0000000189A551C0
		private static MemoryStream decompress(this Stream stream) => default; // 0x0000000186E9E6B0-0x0000000186E9E8B0
		// [XID] // 0x0000000189A62700-0x0000000189A62740
		private static byte[] decompressToArray(this Stream stream) => default; // 0x0000000186E9E510-0x0000000186E9E6B0
		// [XID] // 0x0000000189A6D190-0x0000000189A6D1D0
		private static bool isHttpMethod(this string value) => default; // 0x0000000186E9EBA0-0x0000000186E9EE10
		// [XID] // 0x0000000189A77B00-0x0000000189A77B40
		private static bool isHttpMethod10(this string value) => default; // 0x0000000186E9EA50-0x0000000186E9EBA0
		// [XID] // 0x0000000189A82580-0x0000000189A825C0
		internal static byte[] Append(this ushort code, string reason) => default; // 0x0000000186E96E30-0x0000000186E96FD0
		// [XID] // 0x0000000189A8CF20-0x0000000189A8CF60
		internal static void Close(this WebSocketSharp.Net.HttpListenerResponse response, WebSocketSharp.Net.HttpStatusCode code) {} // 0x0000000186E970F0-0x0000000186E971E0
		// [XID] // 0x0000000189A97610-0x0000000189A97650
		internal static void CloseWithAuthChallenge(this WebSocketSharp.Net.HttpListenerResponse response, string challenge) {} // 0x0000000186E96FD0-0x0000000186E970F0
		// [IDTag] // 0x0000000189AA1840-0x0000000189AA1890
		// [XID] // 0x0000000189AA1840-0x0000000189AA1890
		internal static byte[] Compress(this byte[] data, CompressionMethod method) => default; // 0x0000000186E973D0-0x0000000186E974B0
		// [IDTag] // 0x0000000189AAF330-0x0000000189AAF380
		// [XID] // 0x0000000189AAF330-0x0000000189AAF380
		internal static Stream Compress(this Stream stream, CompressionMethod method) => default; // 0x0000000186E972F0-0x0000000186E973D0
		// [XID] // 0x0000000189ABCD80-0x0000000189ABCDC0
		internal static byte[] CompressToArray(this Stream stream, CompressionMethod method) => default; // 0x0000000186E971E0-0x0000000186E972F0
		// [IDTag] // 0x0000000189AC77B0-0x0000000189AC7800
		// [XID] // 0x0000000189AC77B0-0x0000000189AC7800
		internal static bool Contains(this string value, params /* 0x000000018989F6F0-0x000000018989F700 */ char[] anyOf) => default; // 0x0000000186E97600-0x0000000186E976E0
		// [IDTag] // 0x0000000189ADCEE0-0x0000000189ADCF30
		// [XID] // 0x0000000189ADCEE0-0x0000000189ADCF30
		internal static bool Contains(this NameValueCollection collection, string name) => default; // 0x0000000186E978C0-0x0000000186E97990
		// [IDTag] // 0x0000000189AEA4D0-0x0000000189AEA520
		// [XID] // 0x0000000189AEA4D0-0x0000000189AEA520
		internal static bool Contains(this NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue) => default; // 0x0000000186E976E0-0x0000000186E978C0
		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition) => default;
		// [XID] // 0x0000000189AFF550-0x0000000189AFF590
		internal static bool ContainsTwice(this string[] values) => default; // 0x0000000186E974B0-0x0000000186E97600
		internal static T[] Copy<T>(this T[] source, int length) => default;
		internal static T[] Copy<T>(this T[] source, long length) => default;
		// [XID] // 0x0000000189B18910-0x0000000189B18950
		internal static void CopyTo(this Stream source, Stream destination, int bufferLength) {} // 0x0000000186E97B90-0x0000000186E97CE0
		// [XID] // 0x0000000189B22EF0-0x0000000189B22F30
		internal static void CopyToAsync(this Stream source, Stream destination, int bufferLength, Action completed, Action<Exception> error) {} // 0x0000000186E97990-0x0000000186E97B90
		// [IDTag] // 0x0000000189B2D210-0x0000000189B2D260
		// [XID] // 0x0000000189B2D210-0x0000000189B2D260
		internal static byte[] Decompress(this byte[] data, CompressionMethod method) => default; // 0x0000000186E97DF0-0x0000000186E97ED0
		// [IDTag] // 0x0000000189B3AB20-0x0000000189B3AB70
		// [XID] // 0x0000000189B3AB20-0x0000000189B3AB70
		internal static Stream Decompress(this Stream stream, CompressionMethod method) => default; // 0x0000000186E97ED0-0x0000000186E97FB0
		// [XID] // 0x0000000189B483D0-0x0000000189B48410
		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method) => default; // 0x0000000186E97CE0-0x0000000186E97DF0
		// [XID] // 0x0000000189B52A00-0x0000000189B52A40
		internal static void Emit(this EventHandler eventHandler, object sender, EventArgs e) {} // 0x0000000186E97FB0-0x0000000186E98090
		internal static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e)
			where TEventArgs : EventArgs {}
		// [XID] // 0x0000000189B64B50-0x0000000189B64B90
		internal static bool EqualsWith(this int value, char c, Action<int> action) => default; // 0x0000000186E98090-0x0000000186E98180
		// [XID] // 0x0000000189B6EF30-0x0000000189B6EF70
		internal static string GetAbsolutePath(this Uri uri) => default; // 0x0000000186E98180-0x0000000186E98310
		// [XID] // 0x0000000189B79790-0x0000000189B797D0
		internal static WebSocketSharp.Net.CookieCollection GetCookies(this NameValueCollection headers, bool response) => default; // 0x0000000186E98310-0x0000000186E98420
		// [XID] // 0x0000000189B84000-0x0000000189B84040
		internal static string GetDnsSafeHost(this Uri uri, bool bracketIPv6) => default; // 0x0000000186E984F0-0x0000000186E985E0
		// [XID] // 0x0000000189B8E1C0-0x0000000189B8E200
		internal static string GetMessage(this CloseStatusCode code) => default; // 0x0000000186E985E0-0x0000000186E98770
		// [XID] // 0x0000000189B98650-0x0000000189B98690
		internal static string GetName(this string nameAndValue, char separator) => default; // 0x0000000186E98770-0x0000000186E98870
		// [XID] // 0x0000000189BA2E70-0x0000000189BA2EB0
		internal static string GetUTF8DecodedString(this byte[] bytes) => default; // 0x0000000186E98CB0-0x0000000186E98DA0
		// [XID] // 0x0000000189BACFE0-0x0000000189BAD020
		internal static byte[] GetUTF8EncodedBytes(this string s) => default; // 0x0000000186E98DA0-0x0000000186E98E90
		// [IDTag] // 0x0000000189BB7400-0x0000000189BB7450
		// [XID] // 0x0000000189BB7400-0x0000000189BB7450
		internal static string GetValue(this string nameAndValue, char separator) => default; // 0x0000000186E98E90-0x0000000186E98F80
		// [IDTag] // 0x0000000189BC50C0-0x0000000189BC5110
		// [XID] // 0x0000000189BC50C0-0x0000000189BC5110
		internal static string GetValue(this string nameAndValue, char separator, bool unquote) => default; // 0x0000000186E98F80-0x0000000186E990E0
		// [IDTag] // 0x0000000189BD2950-0x0000000189BD29A0
		// [XID] // 0x0000000189BD2950-0x0000000189BD29A0
		internal static byte[] InternalToByteArray(this ushort value, ByteOrder order) => default; // 0x0000000186E99200-0x0000000186E99320
		// [IDTag] // 0x0000000189BDFF80-0x0000000189BDFFD0
		// [XID] // 0x0000000189BDFF80-0x0000000189BDFFD0
		internal static byte[] InternalToByteArray(this ulong value, ByteOrder order) => default; // 0x0000000186E990E0-0x0000000186E99200
		// [XID] // 0x00000001895F2A00-0x00000001895F2A40
		internal static bool IsCompressionExtension(this string value, CompressionMethod method) => default; // 0x0000000186E993E0-0x0000000186E99500
		// [IDTag] // 0x00000001895FD2D0-0x00000001895FD320
		// [XID] // 0x00000001895FD2D0-0x00000001895FD320
		internal static bool IsControl(this byte opcode) => default; // 0x0000000186E995A0-0x0000000186E99650
		// [IDTag] // 0x000000018960AE20-0x000000018960AE70
		// [XID] // 0x000000018960AE20-0x000000018960AE70
		internal static bool IsControl(this Opcode opcode) => default; // 0x0000000186E99500-0x0000000186E995A0
		// [IDTag] // 0x0000000189618070-0x00000001896180C0
		// [XID] // 0x0000000189618070-0x00000001896180C0
		internal static bool IsData(this byte opcode) => default; // 0x0000000186E99650-0x0000000186E99700
		// [IDTag] // 0x0000000189625870-0x00000001896258C0
		// [XID] // 0x0000000189625870-0x00000001896258C0
		internal static bool IsData(this Opcode opcode) => default; // 0x0000000186E99700-0x0000000186E997B0
		// [XID] // 0x00000001896331D0-0x0000000189633210
		internal static bool IsHttpMethod(this string value, Version version) => default; // 0x0000000186E99990-0x0000000186E99AE0
		// [XID] // 0x000000018963DBF0-0x000000018963DC30
		internal static bool IsPortNumber(this int value) => default; // 0x0000000186E99E90-0x0000000186E99F40
		// [IDTag] // 0x00000001896481C0-0x0000000189648210
		// [XID] // 0x00000001896481C0-0x0000000189648210
		internal static bool IsReserved(this ushort code) => default; // 0x0000000186E9A390-0x0000000186E9A450
		// [IDTag] // 0x0000000189655A10-0x0000000189655A60
		// [XID] // 0x0000000189655A10-0x0000000189655A60
		internal static bool IsReserved(this CloseStatusCode code) => default; // 0x0000000186E9A2D0-0x0000000186E9A390
		// [XID] // 0x0000000189662DC0-0x0000000189662E00
		internal static bool IsSupported(this byte opcode) => default; // 0x0000000186E9A450-0x0000000186E9A580
		// [XID] // 0x000000018966D6C0-0x000000018966D700
		internal static bool IsText(this string value) => default; // 0x0000000186E9A580-0x0000000186E9A6F0
		// [XID] // 0x0000000189678490-0x00000001896784D0
		internal static bool IsToken(this string value) => default; // 0x0000000186E9A6F0-0x0000000186E9A810
		// [XID] // 0x0000000189682B80-0x0000000189682BC0
		internal static bool KeepsAlive(this NameValueCollection headers, Version version) => default; // 0x0000000186E9A810-0x0000000186E9A9A0
		// [XID] // 0x000000018968D4F0-0x000000018968D530
		internal static string Quote(this string value) => default; // 0x0000000186E9AAB0-0x0000000186E9ABB0
		// [IDTag] // 0x0000000189698480-0x00000001896984D0
		// [XID] // 0x0000000189698480-0x00000001896984D0
		internal static byte[] ReadBytes(this Stream stream, int length) => default; // 0x0000000186E9B240-0x0000000186E9B3E0
		// [IDTag] // 0x00000001896A52F0-0x00000001896A5340
		// [XID] // 0x00000001896A52F0-0x00000001896A5340
		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength) => default; // 0x0000000186E9AFB0-0x0000000186E9B240
		// [IDTag] // 0x00000001896B2340-0x00000001896B2390
		// [XID] // 0x00000001896B2340-0x00000001896B2390
		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error) {} // 0x0000000186E9ADC0-0x0000000186E9AFB0
		// [IDTag] // 0x00000001896BF760-0x00000001896BF7B0
		// [XID] // 0x00000001896BF760-0x00000001896BF7B0
		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error) {} // 0x0000000186E9ABB0-0x0000000186E9ADC0
		internal static T[] Reverse<T>(this T[] array) => default;
		[DebuggerHidden] // 0x00000001896D4280-0x00000001896D42C0
		// [XID] // 0x00000001896D4280-0x00000001896D42C0
		internal static IEnumerable<string> SplitHeaderValue(this string value, params /* 0x000000018989F6F0-0x000000018989F700 */ char[] separators) => default; // 0x0000000186E9B3E0-0x0000000186E9B4D0
		// [XID] // 0x00000001896E9150-0x00000001896E9190
		internal static byte[] ToByteArray(this Stream stream) => default; // 0x0000000186E9BB70-0x0000000186E9BD50
		// [XID] // 0x00000001896F35D0-0x00000001896F3610
		internal static CompressionMethod ToCompressionMethod(this string value) => default; // 0x0000000186E9BD50-0x0000000186E9C030
		// [XID] // 0x00000001896FDE50-0x00000001896FDE90
		internal static string ToExtensionString(this CompressionMethod method, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] parameters) => default; // 0x0000000186E9C030-0x0000000186E9C250
		// [XID] // 0x000000018970FCF0-0x000000018970FD30
		internal static IPAddress ToIPAddress(this string value) => default; // 0x0000000186E9C3A0-0x0000000186E9C500
		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source) => default;
		// [XID] // 0x0000000189721720-0x0000000189721760
		internal static string ToString(this IPAddress address, bool bracketIPv6) => default; // 0x0000000186E9C500-0x0000000186E9C640
		// [XID] // 0x000000018972BE20-0x000000018972BE60
		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder) => default; // 0x0000000186E9C640-0x0000000186E9C750
		// [XID] // 0x0000000189736630-0x0000000189736670
		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder) => default; // 0x0000000186E9C750-0x0000000186E9C860
		[DebuggerHidden] // 0x00000001897410E0-0x0000000189741120
		// [XID] // 0x00000001897410E0-0x0000000189741120
		internal static IEnumerable<string> Trim(this IEnumerable<string> source) => default; // 0x0000000186E9CC20-0x0000000186E9CD00
		// [XID] // 0x000000018974E7B0-0x000000018974E7F0
		internal static string TrimSlashFromEnd(this string value) => default; // 0x0000000186E9C980-0x0000000186E9CAB0
		// [XID] // 0x0000000189758810-0x0000000189758850
		internal static string TrimSlashOrBackslashFromEnd(this string value) => default; // 0x0000000186E9CAB0-0x0000000186E9CC20
		// [XID] // 0x0000000189763400-0x0000000189763440
		internal static bool TryCreateVersion(this string versionString, out Version result) {
			result = default;
			return default;
		} // 0x0000000186E9CD00-0x0000000186E9CDF0
		// [XID] // 0x000000018976DA60-0x000000018976DAA0
		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message) {
			result = default;
			message = default;
			return default;
		} // 0x0000000186E9CDF0-0x0000000186E9D1F0
		// [XID] // 0x00000001897780F0-0x0000000189778130
		internal static bool TryGetUTF8DecodedString(this byte[] bytes, out string s) {
			s = default;
			return default;
		} // 0x0000000186E9D1F0-0x0000000186E9D300
		// [XID] // 0x0000000189782BC0-0x0000000189782C00
		internal static bool TryGetUTF8EncodedBytes(this string s, out byte[] bytes) {
			bytes = default;
			return default;
		} // 0x0000000186E9D300-0x0000000186E9D410
		// [XID] // 0x000000018978CE30-0x000000018978CE70
		internal static bool TryOpenRead(this FileInfo fileInfo, out FileStream fileStream) {
			fileStream = default;
			return default;
		} // 0x0000000186E9D410-0x0000000186E9D4F0
		// [XID] // 0x00000001897976F0-0x0000000189797730
		internal static string Unquote(this string value) => default; // 0x0000000186E9D4F0-0x0000000186E9D650
		// [XID] // 0x00000001897A2370-0x00000001897A23B0
		internal static bool Upgrades(this NameValueCollection headers, string protocol) => default; // 0x0000000186E9D650-0x0000000186E9D7A0
		// [XID] // 0x00000001897ACBC0-0x00000001897ACC00
		internal static string UrlDecode(this string value, Encoding encoding) => default; // 0x0000000186E9D7A0-0x0000000186E9D880
		// [XID] // 0x00000001897B79F0-0x00000001897B7A30
		internal static string UrlEncode(this string value, Encoding encoding) => default; // 0x0000000186E9D880-0x0000000186E9D960
		// [XID] // 0x00000001897C2540-0x00000001897C2580
		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength) {} // 0x0000000186E9DB50-0x0000000186E9DCD0
		// [XID] // 0x00000001897CCF00-0x00000001897CCF40
		internal static void WriteBytesAsync(this Stream stream, byte[] bytes, int bufferLength, Action completed, Action<Exception> error) {} // 0x0000000186E9D960-0x0000000186E9DB50
		// [XID] // 0x00000001897D7750-0x00000001897D7790
		public static string GetDescription(this WebSocketSharp.Net.HttpStatusCode code) => default; // 0x0000000186E98420-0x0000000186E984F0
		// [XID] // 0x00000001897E1F40-0x00000001897E1F80
		public static string GetStatusDescription(this int code) => default; // 0x0000000186E98870-0x0000000186E98CB0
		// [XID] // 0x00000001897ECA90-0x00000001897ECAD0
		public static bool IsCloseStatusCode(this ushort value) => default; // 0x0000000186E99320-0x0000000186E993E0
		// [XID] // 0x00000001897F7040-0x00000001897F7080
		public static bool IsEnclosedIn(this string value, char c) => default; // 0x0000000186E997B0-0x0000000186E998B0
		// [XID] // 0x0000000189801A90-0x0000000189801AD0
		public static bool IsHostOrder(this ByteOrder order) => default; // 0x0000000186E998B0-0x0000000186E99990
		// [XID] // 0x000000018980BC80-0x000000018980BCC0
		public static bool IsLocal(this IPAddress address) => default; // 0x0000000186E99AE0-0x0000000186E99DD0
		// [XID] // 0x0000000189816600-0x0000000189816640
		public static bool IsNullOrEmpty(this string value) => default; // 0x0000000186E99DD0-0x0000000186E99E90
		// [XID] // 0x0000000189821280-0x00000001898212C0
		public static bool IsPredefinedScheme(this string value) => default; // 0x0000000186E99F40-0x0000000186E9A2D0
		// [XID] // 0x000000018982B650-0x000000018982B690
		public static bool MaybeUri(this string value) => default; // 0x0000000186E9A9A0-0x0000000186E9AAB0
		public static T[] SubArray<T>(this T[] array, int startIndex, int length) => default;
		public static T[] SubArray<T>(this T[] array, long startIndex, long length) => default;
		// [IDTag] // 0x00000001898449F0-0x0000000189844A40
		// [XID] // 0x00000001898449F0-0x0000000189844A40
		public static void Times(this int n, Action action) {} // 0x0000000186E9B4D0-0x0000000186E9B590
		// [IDTag] // 0x00000001898519B0-0x0000000189851A00
		// [XID] // 0x00000001898519B0-0x0000000189851A00
		public static void Times(this long n, Action action) {} // 0x0000000186E9B750-0x0000000186E9B820
		// [IDTag] // 0x000000018985E780-0x000000018985E7D0
		// [XID] // 0x000000018985E780-0x000000018985E7D0
		public static void Times(this uint n, Action action) {} // 0x0000000186E9BAB0-0x0000000186E9BB70
		// [IDTag] // 0x000000018986C170-0x000000018986C1C0
		// [XID] // 0x000000018986C170-0x000000018986C1C0
		public static void Times(this ulong n, Action action) {} // 0x0000000186E9B9E0-0x0000000186E9BAB0
		// [IDTag] // 0x0000000189879750-0x00000001898797A0
		// [XID] // 0x0000000189879750-0x00000001898797A0
		public static void Times(this int n, Action<int> action) {} // 0x0000000186E9B900-0x0000000186E9B9E0
		// [IDTag] // 0x0000000189886B40-0x0000000189886B90
		// [XID] // 0x0000000189886B40-0x0000000189886B90
		public static void Times(this long n, Action<long> action) {} // 0x0000000186E9B820-0x0000000186E9B900
		// [IDTag] // 0x0000000189893D10-0x0000000189893D60
		// [XID] // 0x0000000189893D10-0x0000000189893D60
		public static void Times(this uint n, Action<uint> action) {} // 0x0000000186E9B590-0x0000000186E9B670
		// [IDTag] // 0x00000001898A1050-0x00000001898A10A0
		// [XID] // 0x00000001898A1050-0x00000001898A10A0
		public static void Times(this ulong n, Action<ulong> action) {} // 0x0000000186E9B670-0x0000000186E9B750
		[Obsolete] // 0x00000001898AEAA0-0x00000001898AEAE0
		public static T To<T>(this byte[] source, ByteOrder sourceOrder)
			where T : struct => default;
		[Obsolete] // 0x00000001898BAC20-0x00000001898BAC70
		public static byte[] ToByteArray<T>(this T value, ByteOrder order)
			where T : struct => default;
		// [XID] // 0x00000001898C5020-0x00000001898C5060
		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder) => default; // 0x0000000186E9C250-0x0000000186E9C3A0
		public static string ToString<T>(this T[] array, string separator) => default;
		// [XID] // 0x00000001898D70F0-0x00000001898D7130
		public static Uri ToUri(this string value) => default; // 0x0000000186E9C860-0x0000000186E9C980
		[Obsolete] // 0x00000001898E1CC0-0x00000001898E1D20
		// [XID] // 0x00000001898E1CC0-0x00000001898E1D20
		public static void WriteContent(this WebSocketSharp.Net.HttpListenerResponse response, byte[] content) {} // 0x0000000186E9DCD0-0x0000000186E9DED0
	}
}
