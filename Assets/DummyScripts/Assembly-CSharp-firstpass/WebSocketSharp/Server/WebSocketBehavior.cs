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
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public abstract class WebSocketBehavior : IWebSocketSession // TypeDefIndex: 10298
	{
		// Fields
		private WebSocketContext _context; // 0x10
		private Func<CookieCollection, CookieCollection, bool> _cookiesValidator; // 0x18
		private bool _emitOnPing; // 0x20
		private string _id; // 0x28
		private bool _ignoreExtensions; // 0x30
		private Func<string, bool> _originValidator; // 0x38
		private string _protocol; // 0x40
		private WebSocketSessionManager _sessions; // 0x48
		private DateTime _startTime; // 0x50
		private WebSocket _websocket; // 0x60
	
		// Properties
		protected NameValueCollection Headers { /* [XID] */ /* 0x00000001899EE530-0x00000001899EE550 */ get; } // 0x00000001857DA8E0-0x00000001857DA9A0 
		[Obsolete] // 0x0000000189B08310-0x0000000189B08340
		protected Logger Log { /* [XID] */ /* 0x00000001896C85C0-0x00000001896C85E0 */ get; } // 0x00000001857DAAE0-0x00000001857DAB90 
		protected NameValueCollection QueryString { /* [XID] */ /* 0x00000001896CFFB0-0x00000001896CFFD0 */ get; } // 0x00000001857DAD20-0x00000001857DADE0 
		protected WebSocketSessionManager Sessions { /* [XID] */ /* 0x00000001896D73E0-0x00000001896D7400 */ get; } // 0x00000001857DADE0-0x00000001857DAE80 
		public WebSocketState ConnectionState { /* [XID] */ /* 0x00000001896DED30-0x00000001896DED50 */ get; } // 0x00000001857DA630-0x00000001857DA6F0 
		public WebSocketContext Context { /* [XID] */ /* 0x0000000189A1AE30-0x0000000189A1AE50 */ get; } // 0x00000001857DA6F0-0x00000001857DA790 
		public Func<CookieCollection, CookieCollection, bool> CookiesValidator { /* [XID] */ /* 0x0000000189A22750-0x0000000189A22770 */ get; /* [XID] */ /* 0x00000001896F4E40-0x00000001896F4E60 */ set; } // 0x00000001857DA790-0x00000001857DA830 0x00000001857DB360-0x00000001857DB410
		public bool EmitOnPing { /* [XID] */ /* 0x0000000189A30EE0-0x0000000189A30F00 */ get; /* [XID] */ /* 0x00000001898EECA0-0x00000001898EECC0 */ set; } // 0x00000001857DA830-0x00000001857DA8E0 0x00000001857DB410-0x00000001857DB4E0
		public string ID { /* [XID] */ /* 0x000000018970B2D0-0x000000018970B2F0 */ get; } // 0x00000001857DA9A0-0x00000001857DAA40 
		public bool IgnoreExtensions { /* [XID] */ /* 0x00000001897A77C0-0x00000001897A77E0 */ get; /* [XID] */ /* 0x0000000189789420-0x0000000189789440 */ set; } // 0x00000001857DAA40-0x00000001857DAAE0 0x00000001857DB4E0-0x00000001857DB590
		public Func<string, bool> OriginValidator { /* [XID] */ /* 0x0000000189721700-0x0000000189721720 */ get; /* [XID] */ /* 0x0000000189728D00-0x0000000189728D20 */ set; } // 0x00000001857DAB90-0x00000001857DAC30 0x00000001857DB590-0x00000001857DB640
		public string Protocol { /* [XID] */ /* 0x000000018976B880-0x000000018976B8A0 */ get; /* [XID] */ /* 0x0000000189737F90-0x0000000189737FB0 */ set; } // 0x00000001857DAC30-0x00000001857DAD20 0x00000001857DB640-0x00000001857DB7C0
		public DateTime StartTime { /* [XID] */ /* 0x000000018973FB20-0x000000018973FB40 */ get; } // 0x00000001857DAE80-0x00000001857DAF50 
	
		// Constructors
		protected WebSocketBehavior() {} // 0x00000001857DA400-0x00000001857DA4A0
	
		// Methods
		// [XID] // 0x0000000189A73540-0x0000000189A73560
		private string checkHandshakeRequest(WebSocketContext context) => default; // 0x00000001857DA4A0-0x00000001857DA630
		// [XID] // 0x000000018996F180-0x000000018996F1A0
		private void onClose(object sender, CloseEventArgs e) {} // 0x00000001857DAF50-0x00000001857DB050
		// [XID] // 0x00000001896DA3E0-0x00000001896DA400
		private void onError(object sender, ErrorEventArgs e) {} // 0x00000001857DB050-0x00000001857DB130
		// [XID] // 0x000000018975D180-0x000000018975D1A0
		private void onMessage(object sender, MessageEventArgs e) {} // 0x00000001857DB130-0x00000001857DB210
		// [XID] // 0x0000000189764900-0x0000000189764920
		private void onOpen(object sender, EventArgs e) {} // 0x00000001857DB210-0x00000001857DB360
		// [XID] // 0x0000000189BD0FD0-0x0000000189BD0FF0
		internal void Start(WebSocketContext context, WebSocketSessionManager sessions) {} // 0x00000001857DA020-0x00000001857DA400
		// [IDTag] // 0x0000000189773820-0x0000000189773860
		// [XID] // 0x0000000189773820-0x0000000189773860
		protected void Close() {} // 0x00000001857D9060-0x00000001857D9150
		// [IDTag] // 0x000000018977DF10-0x000000018977DF50
		// [XID] // 0x000000018977DF10-0x000000018977DF50
		protected void Close(ushort code, string reason) {} // 0x00000001857D9260-0x00000001857D9370
		// [IDTag] // 0x00000001897887C0-0x0000000189788800
		// [XID] // 0x00000001897887C0-0x0000000189788800
		protected void Close(CloseStatusCode code, string reason) {} // 0x00000001857D9150-0x00000001857D9260
		// [IDTag] // 0x0000000189792CB0-0x0000000189792CF0
		// [XID] // 0x0000000189792CB0-0x0000000189792CF0
		protected void CloseAsync() {} // 0x00000001857D8D50-0x00000001857D8E40
		// [IDTag] // 0x000000018979E010-0x000000018979E050
		// [XID] // 0x000000018979E010-0x000000018979E050
		protected void CloseAsync(ushort code, string reason) {} // 0x00000001857D8F50-0x00000001857D9060
		// [IDTag] // 0x00000001897A81F0-0x00000001897A8230
		// [XID] // 0x00000001897A81F0-0x00000001897A8230
		protected void CloseAsync(CloseStatusCode code, string reason) {} // 0x00000001857D8E40-0x00000001857D8F50
		[Obsolete] // 0x00000001897B2C90-0x00000001897B2CE0
		// [XID] // 0x00000001897B2C90-0x00000001897B2CE0
		protected void Error(string message, Exception exception) {} // 0x00000001857D9370-0x00000001857D9500
		// [XID] // 0x00000001896B56A0-0x00000001896B56C0
		protected virtual void OnClose(CloseEventArgs e) {} // 0x00000001857D9500-0x00000001857D95B0
		// [XID] // 0x00000001896A6940-0x00000001896A6960
		protected virtual void OnError(ErrorEventArgs e) {} // 0x00000001857D95B0-0x00000001857D9660
		// [XID] // 0x00000001897CCEE0-0x00000001897CCF00
		protected virtual void OnMessage(MessageEventArgs e) {} // 0x00000001857D9660-0x00000001857D9710
		// [XID] // 0x0000000189664650-0x0000000189664670
		protected virtual void OnOpen() {} // 0x00000001857D9710-0x00000001857D97B0
		// [IDTag] // 0x00000001897DBCF0-0x00000001897DBD30
		// [XID] // 0x00000001897DBCF0-0x00000001897DBD30
		protected void Send(byte[] data) {} // 0x00000001857D9F20-0x00000001857DA020
		// [IDTag] // 0x00000001897E6710-0x00000001897E6750
		// [XID] // 0x00000001897E6710-0x00000001897E6750
		protected void Send(FileInfo fileInfo) {} // 0x00000001857D9C10-0x00000001857D9D10
		// [IDTag] // 0x00000001897F1360-0x00000001897F13A0
		// [XID] // 0x00000001897F1360-0x00000001897F13A0
		protected void Send(string data) {} // 0x00000001857D9E20-0x00000001857D9F20
		// [IDTag] // 0x00000001897FBE20-0x00000001897FBE60
		// [XID] // 0x00000001897FBE20-0x00000001897FBE60
		protected void Send(Stream stream, int length) {} // 0x00000001857D9D10-0x00000001857D9E20
		// [IDTag] // 0x0000000189805DB0-0x0000000189805DF0
		// [XID] // 0x0000000189805DB0-0x0000000189805DF0
		protected void SendAsync(byte[] data, Action<bool> completed) {} // 0x00000001857D98C0-0x00000001857D99D0
		// [IDTag] // 0x00000001898107B0-0x00000001898107F0
		// [XID] // 0x00000001898107B0-0x00000001898107F0
		protected void SendAsync(FileInfo fileInfo, Action<bool> completed) {} // 0x00000001857D9B00-0x00000001857D9C10
		// [IDTag] // 0x000000018981AFD0-0x000000018981B010
		// [XID] // 0x000000018981AFD0-0x000000018981B010
		protected void SendAsync(string data, Action<bool> completed) {} // 0x00000001857D97B0-0x00000001857D98C0
		// [IDTag] // 0x0000000189825420-0x0000000189825460
		// [XID] // 0x0000000189825420-0x0000000189825460
		protected void SendAsync(Stream stream, int length, Action<bool> completed) {} // 0x00000001857D99D0-0x00000001857D9B00
	}
}
