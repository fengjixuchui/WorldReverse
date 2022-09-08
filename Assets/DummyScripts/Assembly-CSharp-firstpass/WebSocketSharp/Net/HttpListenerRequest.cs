/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerRequest // TypeDefIndex: 10263
	{
		// Fields
		private static readonly byte[] _100continue; // 0x00
		private string[] _acceptTypes; // 0x10
		private bool _chunked; // 0x18
		private HttpConnection _connection; // 0x20
		private Encoding _contentEncoding; // 0x28
		private long _contentLength; // 0x30
		private HttpListenerContext _context; // 0x38
		private CookieCollection _cookies; // 0x40
		private WebHeaderCollection _headers; // 0x48
		private string _httpMethod; // 0x50
		private Stream _inputStream; // 0x58
		private Version _protocolVersion; // 0x60
		private NameValueCollection _queryString; // 0x68
		private string _rawUrl; // 0x70
		private Guid _requestTraceIdentifier; // 0x78
		private Uri _url; // 0x88
		private Uri _urlReferrer; // 0x90
		private bool _urlSet; // 0x98
		private string _userHostName; // 0xA0
		private string[] _userLanguages; // 0xA8
	
		// Properties
		public string[] AcceptTypes { /* [XID] */ /* 0x00000001899F0160-0x00000001899F0180 */ get => default; } // 0x0000000187172A50-0x0000000187172C00 
		public int ClientCertificateError { /* [XID] */ /* 0x00000001899F7760-0x00000001899F7780 */ get => default; } // 0x0000000187172C00-0x0000000187172CC0 
		public Encoding ContentEncoding { /* [XID] */ /* 0x0000000189A4D930-0x0000000189A4D950 */ get => default; } // 0x0000000187172CC0-0x0000000187172DA0 
		public long ContentLength64 { /* [XID] */ /* 0x0000000189A55150-0x0000000189A55170 */ get => default; } // 0x0000000187172DA0-0x0000000187172E40 
		public string ContentType { /* [XID] */ /* 0x0000000189A6A3E0-0x0000000189A6A400 */ get => default; } // 0x0000000187172E40-0x0000000187172F00 
		public CookieCollection Cookies { /* [XID] */ /* 0x0000000189A64390-0x0000000189A643B0 */ get => default; } // 0x0000000187172F00-0x0000000187172FF0 
		public bool HasEntityBody { /* [XID] */ /* 0x0000000189A6BC80-0x0000000189A6BCA0 */ get => default; } // 0x0000000187172FF0-0x00000001871730A0 
		public NameValueCollection Headers { /* [XID] */ /* 0x0000000189A73400-0x0000000189A73420 */ get => default; } // 0x00000001871730A0-0x0000000187173140 
		public string HttpMethod { /* [XID] */ /* 0x00000001899C5910-0x00000001899C5930 */ get => default; } // 0x0000000187173140-0x00000001871731E0 
		public Stream InputStream { /* [XID] */ /* 0x0000000189BAB830-0x0000000189BAB850 */ get => default; } // 0x00000001871731E0-0x00000001871732D0 
		public bool IsAuthenticated { /* [XID] */ /* 0x0000000189ACD620-0x0000000189ACD640 */ get => default; } // 0x00000001871732D0-0x0000000187173390 
		public bool IsLocal { /* [XID] */ /* 0x0000000189ADCD50-0x0000000189ADCD70 */ get => default; } // 0x0000000187173390-0x0000000187173440 
		public bool IsSecureConnection { /* [XID] */ /* 0x0000000189A99160-0x0000000189A99180 */ get => default; } // 0x0000000187173440-0x00000001871734F0 
		public bool IsWebSocketRequest { /* [XID] */ /* 0x0000000189AA49C0-0x0000000189AA49E0 */ get => default; } // 0x00000001871734F0-0x0000000187173660 
		public bool KeepAlive { /* [XID] */ /* 0x0000000189BA4220-0x0000000189BA4240 */ get => default; } // 0x0000000187173660-0x0000000187173740 
		public IPEndPoint LocalEndPoint { /* [XID] */ /* 0x0000000189AAF310-0x0000000189AAF330 */ get => default; } // 0x0000000187173740-0x00000001871737F0 
		public Version ProtocolVersion { /* [XID] */ /* 0x0000000189AB6C30-0x0000000189AB6C50 */ get => default; } // 0x00000001871737F0-0x0000000187173890 
		public NameValueCollection QueryString { /* [XID] */ /* 0x0000000189ABE620-0x0000000189ABE640 */ get => default; } // 0x0000000187173890-0x00000001871739E0 
		public string RawUrl { /* [XID] */ /* 0x0000000189B37880-0x0000000189B378A0 */ get => default; } // 0x00000001871739E0-0x0000000187173A80 
		public IPEndPoint RemoteEndPoint { /* [XID] */ /* 0x0000000189AB6A30-0x0000000189AB6A50 */ get => default; } // 0x0000000187173A80-0x0000000187173B30 
		public Guid RequestTraceIdentifier { /* [XID] */ /* 0x0000000189B4E290-0x0000000189B4E2B0 */ get => default; } // 0x0000000187173B30-0x0000000187173C00 
		public Uri Url { /* [XID] */ /* 0x0000000189ADCEC0-0x0000000189ADCEE0 */ get => default; } // 0x0000000187173D60-0x0000000187173EB0 
		public Uri UrlReferrer { /* [XID] */ /* 0x0000000189B558A0-0x0000000189B558C0 */ get => default; } // 0x0000000187173C00-0x0000000187173D60 
		public string UserAgent { /* [XID] */ /* 0x0000000189B5D310-0x0000000189B5D330 */ get => default; } // 0x0000000187173EB0-0x0000000187173F70 
		public string UserHostAddress { /* [XID] */ /* 0x0000000189AF3840-0x0000000189AF3860 */ get => default; } // 0x0000000187173F70-0x0000000187174040 
		public string UserHostName { /* [XID] */ /* 0x0000000189AFB0E0-0x0000000189AFB100 */ get => default; } // 0x0000000187174040-0x00000001871740F0 
		public string[] UserLanguages { /* [XID] */ /* 0x0000000189B02720-0x0000000189B02740 */ get => default; } // 0x00000001871740F0-0x00000001871742B0 
	
		// Constructors
		public HttpListenerRequest() {} // Dummy constructor
		static HttpListenerRequest() {} // 0x0000000187172510-0x00000001871725C0
		internal HttpListenerRequest(HttpListenerContext context) {} // 0x00000001871725C0-0x00000001871726F0
	
		// Methods
		// [XID] // 0x0000000189B09D20-0x0000000189B09D40
		private void finishInitialization10() {} // 0x00000001871726F0-0x0000000187172870
		// [XID] // 0x0000000189B116C0-0x0000000189B116E0
		private Encoding getContentEncoding() => default; // 0x0000000187172870-0x0000000187172980
		// [XID] // 0x0000000189BB2DB0-0x0000000189BB2DD0
		private RequestStream getInputStream() => default; // 0x0000000187172980-0x0000000187172A50
		// [XID] // 0x0000000189B70830-0x0000000189B70850
		internal void AddHeader(string headerField) {} // 0x0000000187171210-0x0000000187171610
		// [XID] // 0x0000000189B276C0-0x0000000189B276E0
		internal void FinishInitialization() {} // 0x00000001871717E0-0x0000000187171B90
		// [XID] // 0x00000001898EA170-0x00000001898EA190
		internal bool FlushInput() => default; // 0x0000000187171B90-0x0000000187171E00
		// [XID] // 0x0000000189B360D0-0x0000000189B360F0
		internal bool IsUpgradeRequest(string protocol) => default; // 0x0000000187171ED0-0x0000000187171FB0
		// [XID] // 0x0000000189B3D6E0-0x0000000189B3D700
		internal void SetRequestLine(string requestLine) {} // 0x0000000187171FB0-0x0000000187172340
		// [XID] // 0x0000000189B45620-0x0000000189B45640
		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state) => default; // 0x0000000187171610-0x0000000187171700
		// [XID] // 0x0000000189BAE440-0x0000000189BAE460
		public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult) => default; // 0x0000000187171700-0x00000001871717E0
		// [XID] // 0x00000001896F48E0-0x00000001896F4900
		public X509Certificate2 GetClientCertificate() => default; // 0x0000000187171E00-0x0000000187171ED0
		// [XID] // 0x0000000189B5BE20-0x0000000189B5BE40
		public override string ToString() => default; // 0x0000000187172340-0x00000001871724A0
	}
}
