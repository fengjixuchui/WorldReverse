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
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using IFix.Core;
using WebSocketSharp;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net.WebSockets
{
	internal class TcpListenerWebSocketContext : WebSocketContext // TypeDefIndex: 10285
	{
		// Fields
		private Logger _log; // 0x10
		private NameValueCollection _queryString; // 0x18
		private HttpRequest _request; // 0x20
		private Uri _requestUri; // 0x28
		private bool _secure; // 0x30
		private EndPoint _serverEndPoint; // 0x38
		private Stream _stream; // 0x40
		private TcpClient _tcpClient; // 0x48
		private IPrincipal _user; // 0x50
		private EndPoint _userEndPoint; // 0x58
		private WebSocket _websocket; // 0x60
	
		// Properties
		internal Logger Log { /* [XID] */ /* 0x00000001898821C0-0x00000001898821E0 */ get => default; } // 0x00000001857D5DD0-0x00000001857D5E70 
		internal Stream Stream { /* [XID] */ /* 0x0000000189889830-0x0000000189889850 */ get => default; } // 0x00000001857D65C0-0x00000001857D6660 
		public override WebSocketSharp.Net.CookieCollection CookieCollection { /* [XID] */ /* 0x0000000189890D60-0x0000000189890D80 */ get => default; } // 0x00000001857D58B0-0x00000001857D5960 
		public override NameValueCollection Headers { /* [XID] */ /* 0x0000000189898340-0x0000000189898360 */ get => default; } // 0x00000001857D5960-0x00000001857D5A10 
		public override string Host { /* [XID] */ /* 0x000000018989F560-0x000000018989F580 */ get => default; } // 0x00000001857D5A10-0x00000001857D5AE0 
		public override bool IsAuthenticated { /* [XID] */ /* 0x00000001899199A0-0x00000001899199C0 */ get => default; } // 0x00000001857D5AE0-0x00000001857D5B90 
		public override bool IsLocal { /* [XID] */ /* 0x0000000189935B20-0x0000000189935B40 */ get => default; } // 0x00000001857D5B90-0x00000001857D5C80 
		public override bool IsSecureConnection { /* [XID] */ /* 0x0000000189710A30-0x0000000189710A50 */ get => default; } // 0x00000001857D5C80-0x00000001857D5D20 
		public override bool IsWebSocketRequest { /* [XID] */ /* 0x00000001898BD6A0-0x00000001898BD6C0 */ get => default; } // 0x00000001857D5D20-0x00000001857D5DD0 
		public override string Origin { /* [XID] */ /* 0x00000001898C5000-0x00000001898C5020 */ get => default; } // 0x00000001857D5E70-0x00000001857D5F40 
		public override NameValueCollection QueryString { /* [XID] */ /* 0x00000001898CC440-0x00000001898CC460 */ get => default; } // 0x00000001857D5F40-0x00000001857D60A0 
		public override Uri RequestUri { /* [XID] */ /* 0x00000001898D3E70-0x00000001898D3E90 */ get => default; } // 0x00000001857D60A0-0x00000001857D6250 
		public override string SecWebSocketKey { /* [XID] */ /* 0x0000000189790B90-0x0000000189790BB0 */ get => default; } // 0x00000001857D6250-0x00000001857D6320 
		public override IEnumerable<string> SecWebSocketProtocols { /* [XID] */ /* 0x00000001898E3260-0x00000001898E3280 */ get => default; } // 0x00000001857D6320-0x00000001857D6440 
		public override string SecWebSocketVersion { /* [XID] */ /* 0x00000001898EAE90-0x00000001898EAEB0 */ get => default; } // 0x00000001857D6440-0x00000001857D6510 
		public override IPEndPoint ServerEndPoint { /* [XID] */ /* 0x00000001898F2680-0x00000001898F26A0 */ get => default; } // 0x00000001857D6510-0x00000001857D65C0 
		public override IPrincipal User { /* [XID] */ /* 0x00000001898F9DC0-0x00000001898F9DE0 */ get => default; } // 0x00000001857D6710-0x00000001857D67B0 
		public override IPEndPoint UserEndPoint { /* [XID] */ /* 0x00000001899018A0-0x00000001899018C0 */ get => default; } // 0x00000001857D6660-0x00000001857D6710 
		public override WebSocket WebSocket { /* [XID] */ /* 0x0000000189A68EB0-0x0000000189A68ED0 */ get => default; } // 0x00000001857D67B0-0x00000001857D6850 
	
		// Constructors
		public TcpListenerWebSocketContext() {} // Dummy constructor
		internal TcpListenerWebSocketContext(TcpClient tcpClient, string protocol, bool secure, ServerSslConfiguration sslConfig, Logger log) {} // 0x00000001857D5670-0x00000001857D58B0
	
		// Methods
		// [XID] // 0x0000000189606C80-0x0000000189606CA0
		private HttpRequest sendAuthenticationChallenge(string challenge) => default; // 0x00000001857D6850-0x00000001857D6970
		// [XID] // 0x0000000189A2C8E0-0x0000000189A2C900
		internal bool Authenticate(WebSocketSharp.Net.AuthenticationSchemes scheme, string realm, Func<IIdentity, WebSocketSharp.Net.NetworkCredential> credentialsFinder) => default; // 0x00000001857D5140-0x00000001857D5330
		// [IDTag] // 0x000000018991F7D0-0x000000018991F810
		// [XID] // 0x000000018991F7D0-0x000000018991F810
		internal void Close() {} // 0x00000001857D5470-0x00000001857D5540
		// [IDTag] // 0x000000018992A0E0-0x000000018992A120
		// [XID] // 0x000000018992A0E0-0x000000018992A120
		internal void Close(WebSocketSharp.Net.HttpStatusCode code) {} // 0x00000001857D5330-0x00000001857D5470
		// [XID] // 0x0000000189B57160-0x0000000189B57180
		public override string ToString() => default; // 0x00000001857D5540-0x00000001857D5600
	}
}
