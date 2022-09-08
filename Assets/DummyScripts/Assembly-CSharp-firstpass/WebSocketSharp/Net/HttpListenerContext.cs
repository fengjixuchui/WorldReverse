/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using IFix.Core;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerContext // TypeDefIndex: 10259
	{
		// Fields
		private HttpConnection _connection; // 0x10
		private string _error; // 0x18
		private int _errorStatus; // 0x20
		private HttpListener _listener; // 0x28
		private HttpListenerRequest _request; // 0x30
		private HttpListenerResponse _response; // 0x38
		private IPrincipal _user; // 0x40
		private HttpListenerWebSocketContext _websocketContext; // 0x48
	
		// Properties
		internal HttpConnection Connection { /* [XID] */ /* 0x00000001897CCD00-0x00000001897CCD20 */ get => default; } // 0x000000018716EC70-0x000000018716ED10 
		internal string ErrorMessage { /* [XID] */ /* 0x000000018991CBA0-0x000000018991CBC0 */ get => default; /* [XID] */ /* 0x0000000189B69390-0x0000000189B693B0 */ set {} } // 0x000000018716ED10-0x000000018716EDB0 0x000000018716F180-0x000000018716F230
		internal int ErrorStatus { /* [XID] */ /* 0x0000000189AFA3E0-0x0000000189AFA400 */ get => default; /* [XID] */ /* 0x00000001899330A0-0x00000001899330C0 */ set {} } // 0x000000018716EDB0-0x000000018716EE50 0x000000018716F230-0x000000018716F2E0
		internal bool HasError { /* [XID] */ /* 0x000000018993A980-0x000000018993A9A0 */ get => default; } // 0x000000018716EE50-0x000000018716EF00 
		internal HttpListener Listener { /* [XID] */ /* 0x0000000189941A90-0x0000000189941AB0 */ get => default; /* [XID] */ /* 0x00000001899495D0-0x00000001899495F0 */ set {} } // 0x000000018716EF00-0x000000018716EFA0 0x000000018716F2E0-0x000000018716F390
		public HttpListenerRequest Request { /* [XID] */ /* 0x0000000189950E30-0x0000000189950E50 */ get => default; } // 0x000000018716EFA0-0x000000018716F040 
		public HttpListenerResponse Response { /* [XID] */ /* 0x00000001897E7C50-0x00000001897E7C70 */ get => default; } // 0x000000018716F040-0x000000018716F0E0 
		public IPrincipal User { /* [XID] */ /* 0x000000018995FC50-0x000000018995FC70 */ get => default; } // 0x000000018716F0E0-0x000000018716F180 
	
		// Constructors
		public HttpListenerContext() {} // Dummy constructor
		internal HttpListenerContext(HttpConnection connection) {} // 0x000000018716EBB0-0x000000018716EC70
	
		// Methods
		// [XID] // 0x000000018968D3D0-0x000000018968D3F0
		internal bool Authenticate() => default; // 0x000000018716E770-0x000000018716EA40
		// [XID] // 0x000000018996E7A0-0x000000018996E7C0
		internal bool Register() => default; // 0x000000018716EA40-0x000000018716EB00
		// [XID] // 0x000000018985F4F0-0x000000018985F510
		internal void Unregister() {} // 0x000000018716EB00-0x000000018716EBB0
		// [XID] // 0x000000018997D680-0x000000018997D6A0
		public HttpListenerWebSocketContext AcceptWebSocket(string protocol) => default; // 0x000000018716E590-0x000000018716E770
	}
}
