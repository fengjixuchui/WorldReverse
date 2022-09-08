/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase // TypeDefIndex: 10232
	{
		// Fields
		private string _code; // 0x28
		private string _reason; // 0x30
	
		// Properties
		public CookieCollection Cookies { /* [XID] */ /* 0x0000000189AE2A20-0x0000000189AE2A40 */ get => default; } // 0x00000001867129C0-0x0000000186712AA0 
		public bool HasConnectionClose { /* [XID] */ /* 0x000000018963EF90-0x000000018963EFB0 */ get => default; } // 0x0000000186712AA0-0x0000000186712B90 
		public bool IsProxyAuthenticationRequired { /* [XID] */ /* 0x0000000189A41940-0x0000000189A41960 */ get => default; } // 0x0000000186712B90-0x0000000186712C60 
		public bool IsRedirect { /* [XID] */ /* 0x00000001899BBA50-0x00000001899BBA70 */ get => default; } // 0x0000000186712C60-0x0000000186712D90 
		public bool IsUnauthorized { /* [XID] */ /* 0x0000000189991690-0x00000001899916B0 */ get => default; } // 0x0000000186712D90-0x0000000186712E60 
		public bool IsWebSocketResponse { /* [XID] */ /* 0x00000001896468C0-0x00000001896468E0 */ get => default; } // 0x0000000186712E60-0x0000000186712FE0 
		public string Reason { /* [XID] */ /* 0x0000000189B0FC30-0x0000000189B0FC50 */ get => default; } // 0x0000000186712FE0-0x0000000186713080 
		public string StatusCode { /* [XID] */ /* 0x00000001899D9880-0x00000001899D98A0 */ get => default; } // 0x0000000186713080-0x0000000186713120 
	
		// Constructors
		public HttpResponse() {} // Dummy constructor
		private HttpResponse(string code, string reason, Version version, NameValueCollection headers) {} // 0x0000000186712770-0x0000000186712800
		internal HttpResponse(HttpStatusCode code) {} // 0x0000000186712800-0x00000001867128A0
		internal HttpResponse(HttpStatusCode code, string reason) {} // 0x00000001867128A0-0x00000001867129C0
	
		// Methods
		// [XID] // 0x0000000189B1E620-0x0000000189B1E640
		internal static HttpResponse CreateCloseResponse(HttpStatusCode code) => default; // 0x00000001867119D0-0x0000000186711AD0
		// [XID] // 0x0000000189B25FA0-0x0000000189B25FC0
		internal static HttpResponse CreateUnauthorizedResponse(string challenge) => default; // 0x0000000186711AD0-0x0000000186711BD0
		// [XID] // 0x0000000189A4FB00-0x0000000189A4FB20
		internal static HttpResponse CreateWebSocketResponse() => default; // 0x0000000186711BD0-0x0000000186711CE0
		// [XID] // 0x0000000189619B50-0x0000000189619B70
		internal static HttpResponse Parse(string[] headerParts) => default; // 0x0000000186711CE0-0x0000000186712070
		// [XID] // 0x0000000189B3BFB0-0x0000000189B3BFD0
		internal static HttpResponse Read(Stream stream, int millisecondsTimeout) => default; // 0x0000000186712070-0x00000001867121B0
		// [XID] // 0x0000000189B43C30-0x0000000189B43C50
		public void SetCookies(CookieCollection cookies) {} // 0x00000001867121B0-0x0000000186712390
		// [XID] // 0x00000001897676E0-0x0000000189767700
		public override string ToString() => default; // 0x0000000186712390-0x0000000186712700
	}
}
