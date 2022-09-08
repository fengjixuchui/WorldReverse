/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using WebSocketSharp;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net.WebSockets
{
	public abstract class WebSocketContext // TypeDefIndex: 10288
	{
		// Properties
		public abstract WebSocketSharp.Net.CookieCollection CookieCollection { get; }
		public abstract NameValueCollection Headers { get; }
		public abstract string Host { get; }
		public abstract bool IsAuthenticated { get; }
		public abstract bool IsLocal { get; }
		public abstract bool IsSecureConnection { get; }
		public abstract bool IsWebSocketRequest { get; }
		public abstract string Origin { get; }
		public abstract NameValueCollection QueryString { get; }
		public abstract Uri RequestUri { get; }
		public abstract string SecWebSocketKey { get; }
		public abstract IEnumerable<string> SecWebSocketProtocols { get; }
		public abstract string SecWebSocketVersion { get; }
		public abstract IPEndPoint ServerEndPoint { get; }
		public abstract IPrincipal User { get; }
		public abstract IPEndPoint UserEndPoint { get; }
		public abstract WebSocket WebSocket { get; }
	
		// Constructors
		protected WebSocketContext() {} // 0x00000001857DB7C0-0x00000001857DB820
	}
}
