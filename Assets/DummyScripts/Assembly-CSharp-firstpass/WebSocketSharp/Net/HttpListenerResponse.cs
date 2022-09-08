/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerResponse : IDisposable // TypeDefIndex: 10264
	{
		// Fields
		private bool _closeConnection; // 0x10
		private Encoding _contentEncoding; // 0x18
		private long _contentLength; // 0x20
		private string _contentType; // 0x28
		private HttpListenerContext _context; // 0x30
		private CookieCollection _cookies; // 0x38
		private bool _disposed; // 0x40
		private WebHeaderCollection _headers; // 0x48
		private bool _headersSent; // 0x50
		private bool _keepAlive; // 0x51
		private ResponseStream _outputStream; // 0x58
		private Uri _redirectLocation; // 0x60
		private bool _sendChunked; // 0x68
		private int _statusCode; // 0x6C
		private string _statusDescription; // 0x70
		private Version _version; // 0x78
	
		// Properties
		internal bool CloseConnection { /* [XID] */ /* 0x0000000189B9CB70-0x0000000189B9CB90 */ get => default; /* [XID] */ /* 0x0000000189B6AB90-0x0000000189B6ABB0 */ set {} } // 0x0000000187175800-0x00000001871758A0 0x0000000187176B70-0x0000000187176C20
		internal WebHeaderCollection FullHeaders { /* [XID] */ /* 0x0000000189B72340-0x0000000189B72360 */ get => default; } // 0x0000000187175B50-0x0000000187176140 
		internal bool HeadersSent { /* [XID] */ /* 0x0000000189B79770-0x0000000189B79790 */ get => default; /* [XID] */ /* 0x0000000189B80A90-0x0000000189B80AB0 */ set {} } // 0x0000000187176140-0x00000001871761E0 0x00000001871771C0-0x0000000187177270
		internal string StatusLine { /* [XID] */ /* 0x0000000189B2E840-0x0000000189B2E860 */ get => default; } // 0x0000000187176830-0x0000000187176950 
		public Encoding ContentEncoding { /* [XID] */ /* 0x0000000189B8F920-0x0000000189B8F940 */ get => default; /* [XID] */ /* 0x000000018971BA30-0x000000018971BA50 */ set {} } // 0x00000001871758A0-0x0000000187175940 0x0000000187176C20-0x0000000187176D70
		public long ContentLength64 { /* [XID] */ /* 0x0000000189B9E2F0-0x0000000189B9E310 */ get => default; /* [XID] */ /* 0x0000000189BA5CD0-0x0000000189BA5CF0 */ set {} } // 0x0000000187175940-0x00000001871759E0 0x0000000187176D70-0x0000000187176F10
		public string ContentType { /* [XID] */ /* 0x00000001896F9060-0x00000001896F9080 */ get => default; /* [XID] */ /* 0x0000000189890B80-0x0000000189890BA0 */ set {} } // 0x00000001871759E0-0x0000000187175A80 0x0000000187176F10-0x0000000187177110
		public CookieCollection Cookies { /* [XID] */ /* 0x0000000189BBBDF0-0x0000000189BBBE10 */ get => default; /* [XID] */ /* 0x0000000189BCECA0-0x0000000189BCECC0 */ set {} } // 0x0000000187175A80-0x0000000187175B50 0x0000000187177110-0x00000001871771C0
		public WebHeaderCollection Headers { /* [XID] */ /* 0x0000000189BCB440-0x0000000189BCB460 */ get => default; /* [XID] */ /* 0x00000001897FA350-0x00000001897FA370 */ set {} } // 0x00000001871761E0-0x00000001871762C0 0x0000000187177270-0x0000000187177380
		public bool KeepAlive { /* [XID] */ /* 0x000000018972F990-0x000000018972F9B0 */ get => default; /* [XID] */ /* 0x00000001895E6A50-0x00000001895E6A70 */ set {} } // 0x00000001871762C0-0x0000000187176360 0x0000000187177380-0x00000001871774D0
		public Stream OutputStream { /* [XID] */ /* 0x00000001895EE5F0-0x00000001895EE610 */ get => default; } // 0x0000000187176360-0x00000001871764B0 
		public Version ProtocolVersion { /* [XID] */ /* 0x00000001895F5DC0-0x00000001895F5DE0 */ get => default; /* [XID] */ /* 0x0000000189BBD350-0x0000000189BBD370 */ set {} } // 0x00000001871764B0-0x0000000187176550 0x00000001871774D0-0x0000000187177720
		public string RedirectLocation { /* [XID] */ /* 0x00000001896F1690-0x00000001896F16B0 */ get => default; /* [XID] */ /* 0x000000018960C440-0x000000018960C460 */ set {} } // 0x0000000187176550-0x0000000187176650 0x0000000187177720-0x0000000187177960
		public bool SendChunked { /* [XID] */ /* 0x0000000189613B00-0x0000000189613B20 */ get => default; /* [XID] */ /* 0x0000000189BCCA80-0x0000000189BCCAA0 */ set {} } // 0x0000000187176650-0x00000001871766F0 0x0000000187177960-0x0000000187177AB0
		public int StatusCode { /* [XID] */ /* 0x0000000189BD4130-0x0000000189BD4150 */ get => default; /* [XID] */ /* 0x00000001898DB460-0x00000001898DB480 */ set {} } // 0x00000001871766F0-0x0000000187176790 0x0000000187177AB0-0x0000000187177C70
		public string StatusDescription { /* [XID] */ /* 0x0000000189631940-0x0000000189631960 */ get => default; /* [XID] */ /* 0x0000000189786EC0-0x0000000189786EE0 */ set {} } // 0x0000000187176790-0x0000000187176830 0x0000000187177C70-0x0000000187177E90
	
		// Constructors
		public HttpListenerResponse() {} // Dummy constructor
		internal HttpListenerResponse(HttpListenerContext context) {} // 0x0000000187174FF0-0x00000001871750B0
	
		// Methods
		// [XID] // 0x00000001896408F0-0x0000000189640910
		private bool canSetCookie(Cookie cookie) => default; // 0x00000001871750B0-0x0000000187175310
		// [IDTag] // 0x0000000189648180-0x00000001896481C0
		// [XID] // 0x0000000189648180-0x00000001896481C0
		private void close(bool force) {} // 0x0000000187175310-0x00000001871753F0
		// [IDTag] // 0x0000000189652800-0x0000000189652840
		// [XID] // 0x0000000189652800-0x0000000189652840
		private void close(byte[] responseEntity, int bufferLength, bool willBlock) {} // 0x00000001871753F0-0x0000000187175590
		// [XID] // 0x000000018965D200-0x000000018965D220
		private static string createContentTypeHeaderText(string value, Encoding encoding) => default; // 0x0000000187175590-0x00000001871756D0
		[DebuggerHidden] // 0x0000000189664830-0x0000000189664870
		// [XID] // 0x0000000189664830-0x0000000189664870
		private IEnumerable<Cookie> findCookie(Cookie cookie) => default; // 0x00000001871756D0-0x0000000187175800
		// [XID] // 0x000000018966F240-0x000000018966F260
		private static bool isValidForContentType(string value) => default; // 0x0000000187176950-0x0000000187176A70
		// [XID] // 0x0000000189644730-0x0000000189644750
		private static bool isValidForStatusDescription(string value) => default; // 0x0000000187176A70-0x0000000187176B70
		// [XID] // 0x000000018967E3E0-0x000000018967E400
		public void Abort() {} // 0x00000001871742B0-0x0000000187174360
		// [XID] // 0x000000018962B710-0x000000018962B730
		public void AppendCookie(Cookie cookie) {} // 0x0000000187174360-0x0000000187174430
		// [XID] // 0x0000000189632F30-0x0000000189632F50
		public void AppendHeader(string name, string value) {} // 0x0000000187174430-0x0000000187174520
		// [IDTag] // 0x0000000189695140-0x0000000189695180
		// [XID] // 0x0000000189695140-0x0000000189695180
		public void Close() {} // 0x00000001871747F0-0x00000001871748A0
		// [IDTag] // 0x000000018969F7A0-0x000000018969F7E0
		// [XID] // 0x000000018969F7A0-0x000000018969F7E0
		public void Close(byte[] responseEntity, bool willBlock) {} // 0x0000000187174520-0x00000001871747F0
		// [XID] // 0x00000001896A9C30-0x00000001896A9C50
		public void CopyFrom(HttpListenerResponse templateResponse) {} // 0x00000001871748A0-0x0000000187174A00
		// [XID] // 0x0000000189642150-0x0000000189642170
		public void Redirect(string url) {} // 0x0000000187174A00-0x0000000187174C80
		// [XID] // 0x00000001896B8630-0x00000001896B8650
		public void SetCookie(Cookie cookie) {} // 0x0000000187174C80-0x0000000187174DE0
		// [XID] // 0x00000001896BF720-0x00000001896BF740
		public void SetHeader(string name, string value) {} // 0x0000000187174DE0-0x0000000187174ED0
		// [XID] // 0x00000001896C7190-0x00000001896C71B0
		void IDisposable.Dispose() {} // 0x0000000187174ED0-0x0000000187174F80
	}
}
