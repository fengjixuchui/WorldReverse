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
using System.Security.Principal;
using IFix.Core;
using WebSocketSharp;
using WebSocketSharp.Net;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net.WebSockets
{
	public class HttpListenerWebSocketContext : WebSocketContext // TypeDefIndex: 10283
	{
		// Fields
		private WebSocketSharp.Net.HttpListenerContext _context; // 0x10
		private WebSocket _websocket; // 0x18
	
		// Properties
		internal Logger Log { /* [XID] */ /* 0x000000018977F660-0x000000018977F680 */ get => default; } // 0x00000001871787F0-0x00000001871788C0 
		internal Stream Stream { /* [XID] */ /* 0x0000000189787020-0x0000000189787040 */ get => default; } // 0x0000000187178EE0-0x0000000187178FB0 
		public override WebSocketSharp.Net.CookieCollection CookieCollection { /* [XID] */ /* 0x000000018978E680-0x000000018978E6A0 */ get => default; } // 0x0000000187178240-0x0000000187178310 
		public override NameValueCollection Headers { /* [XID] */ /* 0x000000018960B220-0x000000018960B240 */ get => default; } // 0x0000000187178310-0x00000001871783E0 
		public override string Host { /* [XID] */ /* 0x00000001895E5700-0x00000001895E5720 */ get => default; } // 0x00000001871783E0-0x00000001871784B0 
		public override bool IsAuthenticated { /* [XID] */ /* 0x00000001897A55B0-0x00000001897A55D0 */ get => default; } // 0x00000001871784B0-0x0000000187178580 
		public override bool IsLocal { /* [XID] */ /* 0x00000001897ACBA0-0x00000001897ACBC0 */ get => default; } // 0x0000000187178580-0x0000000187178650 
		public override bool IsSecureConnection { /* [XID] */ /* 0x00000001897B4960-0x00000001897B4980 */ get => default; } // 0x0000000187178650-0x0000000187178720 
		public override bool IsWebSocketRequest { /* [XID] */ /* 0x00000001897BC890-0x00000001897BC8B0 */ get => default; } // 0x0000000187178720-0x00000001871787F0 
		public override string Origin { /* [XID] */ /* 0x00000001897C3CF0-0x00000001897C3D10 */ get => default; } // 0x00000001871788C0-0x00000001871789B0 
		public override NameValueCollection QueryString { /* [XID] */ /* 0x00000001897CB5C0-0x00000001897CB5E0 */ get => default; } // 0x00000001871789B0-0x0000000187178A80 
		public override Uri RequestUri { /* [XID] */ /* 0x00000001897D2DA0-0x00000001897D2DC0 */ get => default; } // 0x0000000187178A80-0x0000000187178B50 
		public override string SecWebSocketKey { /* [XID] */ /* 0x00000001897DAA80-0x00000001897DAAA0 */ get => default; } // 0x0000000187178B50-0x0000000187178C40 
		public override IEnumerable<string> SecWebSocketProtocols { /* [XID] */ /* 0x00000001898F7D90-0x00000001898F7DB0 */ get => default; } // 0x0000000187178C40-0x0000000187178D20 
		public override string SecWebSocketVersion { /* [XID] */ /* 0x00000001897E9690-0x00000001897E96B0 */ get => default; } // 0x0000000187178D20-0x0000000187178E10 
		public override IPEndPoint ServerEndPoint { /* [XID] */ /* 0x0000000189858FF0-0x0000000189859010 */ get => default; } // 0x0000000187178E10-0x0000000187178EE0 
		public override IPrincipal User { /* [XID] */ /* 0x00000001897F8A60-0x00000001897F8A80 */ get => default; } // 0x0000000187179080-0x0000000187179130 
		public override IPEndPoint UserEndPoint { /* [XID] */ /* 0x00000001898678B0-0x00000001898678D0 */ get => default; } // 0x0000000187178FB0-0x0000000187179080 
		public override WebSocket WebSocket { /* [XID] */ /* 0x000000018986EFC0-0x000000018986EFE0 */ get => default; } // 0x0000000187179130-0x00000001871791D0 
	
		// Constructors
		public HttpListenerWebSocketContext() {} // Dummy constructor
		internal HttpListenerWebSocketContext(WebSocketSharp.Net.HttpListenerContext context, string protocol) {} // 0x0000000187178190-0x0000000187178240
	
		// Methods
		// [IDTag] // 0x000000018980EF60-0x000000018980EFA0
		// [XID] // 0x000000018980EF60-0x000000018980EFA0
		internal void Close() {} // 0x0000000187177E90-0x0000000187177F60
		// [IDTag] // 0x0000000189819AD0-0x0000000189819B10
		// [XID] // 0x0000000189819AD0-0x0000000189819B10
		internal void Close(WebSocketSharp.Net.HttpStatusCode code) {} // 0x0000000187177F60-0x0000000187178050
		// [XID] // 0x0000000189823C20-0x0000000189823C40
		public override string ToString() => default; // 0x0000000187178050-0x0000000187178120
	}
}
