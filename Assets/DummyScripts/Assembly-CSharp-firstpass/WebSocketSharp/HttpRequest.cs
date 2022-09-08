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
	internal class HttpRequest : HttpBase // TypeDefIndex: 10231
	{
		// Fields
		private CookieCollection _cookies; // 0x28
		private string _method; // 0x30
		private string _uri; // 0x38
	
		// Properties
		public AuthenticationResponse AuthenticationResponse { /* [XID] */ /* 0x00000001895FBA80-0x00000001895FBAA0 */ get => default; } // 0x0000000186711530-0x0000000186711620 
		public CookieCollection Cookies { /* [XID] */ /* 0x0000000189A88540-0x0000000189A88560 */ get => default; } // 0x0000000186711620-0x0000000186711710 
		public string HttpMethod { /* [XID] */ /* 0x0000000189A8FE90-0x0000000189A8FEB0 */ get => default; } // 0x0000000186711710-0x00000001867117B0 
		public bool IsWebSocketRequest { /* [XID] */ /* 0x0000000189A975F0-0x0000000189A97610 */ get => default; } // 0x00000001867117B0-0x0000000186711930 
		public string RequestUri { /* [XID] */ /* 0x00000001896121D0-0x00000001896121F0 */ get => default; } // 0x0000000186711930-0x00000001867119D0 
	
		// Constructors
		public HttpRequest() {} // Dummy constructor
		private HttpRequest(string method, string uri, Version version, NameValueCollection headers) {} // 0x00000001867114A0-0x0000000186711530
		internal HttpRequest(string method, string uri) {} // 0x0000000186711380-0x00000001867114A0
	
		// Methods
		// [XID] // 0x00000001897603B0-0x00000001897603D0
		internal static HttpRequest CreateConnectRequest(Uri uri) => default; // 0x00000001867102D0-0x0000000186710470
		// [XID] // 0x0000000189AAD860-0x0000000189AAD880
		internal static HttpRequest CreateWebSocketRequest(Uri uri) => default; // 0x0000000186710470-0x0000000186710690
		// [XID] // 0x0000000189AB5130-0x0000000189AB5150
		internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout) => default; // 0x0000000186710690-0x0000000186710830
		// [XID] // 0x0000000189628760-0x0000000189628780
		internal static HttpRequest Parse(string[] headerParts) => default; // 0x0000000186710830-0x0000000186710BC0
		// [XID] // 0x0000000189AC4710-0x0000000189AC4730
		internal static HttpRequest Read(Stream stream, int millisecondsTimeout) => default; // 0x0000000186710BC0-0x0000000186710D00
		// [XID] // 0x0000000189ACBDC0-0x0000000189ACBDE0
		public void SetCookies(CookieCollection cookies) {} // 0x0000000186710D00-0x0000000186710FA0
		// [XID] // 0x00000001899E0E70-0x00000001899E0E90
		public override string ToString() => default; // 0x0000000186710FA0-0x0000000186711310
	}
}
