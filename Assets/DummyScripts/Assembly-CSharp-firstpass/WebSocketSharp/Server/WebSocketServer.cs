/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using IFix.Core;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Server
{
	public class WebSocketServer // TypeDefIndex: 10299
	{
		// Fields
		private IPAddress _address; // 0x10
		private bool _allowForwardedRequest; // 0x18
		private WebSocketSharp.Net.AuthenticationSchemes _authSchemes; // 0x1C
		private static readonly string _defaultRealm; // 0x00
		private bool _dnsStyle; // 0x20
		private string _hostname; // 0x28
		private TcpListener _listener; // 0x30
		private Logger _log; // 0x38
		private int _port; // 0x40
		private string _realm; // 0x48
		private string _realmInUse; // 0x50
		private Thread _receiveThread; // 0x58
		private bool _reuseAddress; // 0x60
		private bool _secure; // 0x61
		private WebSocketServiceManager _services; // 0x68
		private ServerSslConfiguration _sslConfig; // 0x70
		private ServerSslConfiguration _sslConfigInUse; // 0x78
		private ServerState _state; // 0x80
		private object _sync; // 0x88
		private Func<IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder; // 0x90
	
		// Properties
		public IPAddress Address { /* [XID] */ /* 0x0000000189838A20-0x0000000189838A40 */ get => default; } // 0x00000001857DD140-0x00000001857DD1E0 
		public bool AllowForwardedRequest { /* [XID] */ /* 0x000000018983FF60-0x000000018983FF80 */ get => default; /* [XID] */ /* 0x00000001898475A0-0x00000001898475C0 */ set {} } // 0x00000001857DD1E0-0x00000001857DD280 0x00000001857DE240-0x00000001857DE3F0
		public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes { /* [XID] */ /* 0x0000000189B37860-0x0000000189B37880 */ get => default; /* [XID] */ /* 0x0000000189855E90-0x0000000189855EB0 */ set {} } // 0x00000001857DD280-0x00000001857DD320 0x00000001857DE3F0-0x00000001857DE5A0
		public bool IsListening { /* [XID] */ /* 0x000000018985D120-0x000000018985D140 */ get => default; } // 0x00000001857DD320-0x00000001857DD3D0 
		public bool IsSecure { /* [XID] */ /* 0x0000000189B46AA0-0x0000000189B46AC0 */ get => default; } // 0x00000001857DD3D0-0x00000001857DD470 
		public bool KeepClean { /* [XID] */ /* 0x0000000189B4E270-0x0000000189B4E290 */ get => default; /* [XID] */ /* 0x0000000189873690-0x00000001898736B0 */ set {} } // 0x00000001857DD470-0x00000001857DD520 0x00000001857DE5A0-0x00000001857DE670
		public Logger Log { /* [XID] */ /* 0x0000000189B824F0-0x0000000189B82510 */ get => default; } // 0x00000001857DD520-0x00000001857DD5C0 
		public int Port { /* [XID] */ /* 0x00000001898821A0-0x00000001898821C0 */ get => default; } // 0x00000001857DD5C0-0x00000001857DD660 
		public string Realm { /* [XID] */ /* 0x0000000189889810-0x0000000189889830 */ get => default; /* [XID] */ /* 0x0000000189B64AB0-0x0000000189B64AD0 */ set {} } // 0x00000001857DD660-0x00000001857DD700 0x00000001857DE670-0x00000001857DE820
		public bool ReuseAddress { /* [XID] */ /* 0x0000000189898320-0x0000000189898340 */ get => default; /* [XID] */ /* 0x000000018989F540-0x000000018989F560 */ set {} } // 0x00000001857DD700-0x00000001857DD7A0 0x00000001857DE820-0x00000001857DE9D0
		public ServerSslConfiguration SslConfiguration { /* [XID] */ /* 0x00000001898A70E0-0x00000001898A7100 */ get => default; } // 0x00000001857DD7A0-0x00000001857DD890 
		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder { /* [XID] */ /* 0x00000001898AEA40-0x00000001898AEA60 */ get => default; /* [XID] */ /* 0x00000001898B5D90-0x00000001898B5DB0 */ set {} } // 0x00000001857DD890-0x00000001857DD940 0x00000001857DE9D0-0x00000001857DEB80
		public TimeSpan WaitTime { /* [XID] */ /* 0x0000000189B9B5B0-0x0000000189B9B5D0 */ get => default; /* [XID] */ /* 0x00000001898C4FE0-0x00000001898C5000 */ set {} } // 0x00000001857DD940-0x00000001857DD9F0 0x00000001857DEB80-0x00000001857DEC40
		public WebSocketServiceManager WebSocketServices { /* [XID] */ /* 0x0000000189BAA140-0x0000000189BAA160 */ get => default; } // 0x00000001857DD9F0-0x00000001857DDA90 
	
		// Constructors
		static WebSocketServer() {} // 0x00000001857DC090-0x00000001857DC100
		public WebSocketServer() {} // 0x00000001857DC4D0-0x00000001857DC5B0
		public WebSocketServer(int port) {} // 0x00000001857DC8F0-0x00000001857DC970
		public WebSocketServer(string url) {} // 0x00000001857DC5B0-0x00000001857DC8F0
		public WebSocketServer(int port, bool secure) {} // 0x00000001857DC100-0x00000001857DC260
		public WebSocketServer(IPAddress address, int port) {} // 0x00000001857DC430-0x00000001857DC4D0
		public WebSocketServer(IPAddress address, int port, bool secure) {} // 0x00000001857DC260-0x00000001857DC430
	
		// Methods
		// [XID] // 0x0000000189BB1960-0x0000000189BB1980
		private void abort() {} // 0x00000001857DC970-0x00000001857DCB90
		// [XID] // 0x00000001898DB670-0x00000001898DB690
		private bool authenticateClient(TcpListenerWebSocketContext context) => default; // 0x00000001857DCB90-0x00000001857DCC80
		// [XID] // 0x0000000189B300B0-0x0000000189B300D0
		private bool canSet(out string message) {
			message = default;
			return default;
		} // 0x00000001857DCC80-0x00000001857DCD80
		// [XID] // 0x0000000189BC0320-0x0000000189BC0340
		private bool checkHostNameForRequest(string name) => default; // 0x00000001857DCD80-0x00000001857DCEA0
		// [XID] // 0x0000000189BCF8B0-0x0000000189BCF8D0
		private static bool checkSslConfiguration(ServerSslConfiguration configuration, out string message) {
			message = default;
			return default;
		} // 0x00000001857DCEA0-0x00000001857DCF80
		// [XID] // 0x0000000189BC7D20-0x0000000189BC7D40
		private string getRealm() => default; // 0x00000001857DCF80-0x00000001857DD070
		// [XID] // 0x0000000189901880-0x00000001899018A0
		private ServerSslConfiguration getSslConfiguration() => default; // 0x00000001857DD070-0x00000001857DD140
		// [XID] // 0x0000000189A483F0-0x0000000189A48410
		private void init(string hostname, IPAddress address, int port, bool secure) {} // 0x00000001857DDA90-0x00000001857DDC40
		// [XID] // 0x00000001899104F0-0x0000000189910510
		private void processRequest(TcpListenerWebSocketContext context) {} // 0x00000001857DDC40-0x00000001857DDF50
		// [XID] // 0x0000000189918060-0x0000000189918080
		private void receiveRequest() {} // 0x00000001857DDF50-0x00000001857DE240
		// [XID] // 0x000000018991F7B0-0x000000018991F7D0
		private void start(ServerSslConfiguration sslConfig) {} // 0x00000001857DEE10-0x00000001857DF0E0
		// [XID] // 0x0000000189617EB0-0x0000000189617ED0
		private void startReceiving() {} // 0x00000001857DEC40-0x00000001857DEE10
		// [XID] // 0x000000018992E950-0x000000018992E970
		private void stop(ushort code, string reason) {} // 0x00000001857DF200-0x00000001857DF570
		// [XID] // 0x0000000189935C80-0x0000000189935CA0
		private void stopReceiving(int millisecondsTimeout) {} // 0x00000001857DF0E0-0x00000001857DF200
		// [XID] // 0x00000001898425E0-0x0000000189842600
		private static bool tryCreateUri(string uriString, out Uri result, out string message) {
			result = default;
			message = default;
			return default;
		} // 0x00000001857DF570-0x00000001857DF6E0
		[Obsolete] // 0x0000000189662D90-0x0000000189662DC0
		public void AddWebSocketService<TBehavior>(string path, Func<TBehavior> creator)
			where TBehavior : WebSocketBehavior {}
		public void AddWebSocketService<TBehaviorWithNew>(string path)
			where TBehaviorWithNew : WebSocketBehavior, new() {}
		public void AddWebSocketService<TBehaviorWithNew>(string path, Action<TBehaviorWithNew> initializer)
			where TBehaviorWithNew : WebSocketBehavior, new() {}
		// [XID] // 0x000000018994C3C0-0x000000018994C3E0
		public bool RemoveWebSocketService(string path) => default; // 0x00000001857DB820-0x00000001857DB8F0
		// [XID] // 0x0000000189688F40-0x0000000189688F60
		public void Start() {} // 0x00000001857DB8F0-0x00000001857DBA60
		// [IDTag] // 0x000000018995B290-0x000000018995B2D0
		// [XID] // 0x000000018995B290-0x000000018995B2D0
		public void Stop() {} // 0x00000001857DBFB0-0x00000001857DC090
		// [IDTag] // 0x0000000189965C20-0x0000000189965C80
		[Obsolete] // 0x0000000189965C20-0x0000000189965C80
		// [XID] // 0x0000000189965C20-0x0000000189965C80
		public void Stop(ushort code, string reason) {} // 0x00000001857DBCD0-0x00000001857DBFB0
		// [IDTag] // 0x0000000189973530-0x00000001899735A0
		[Obsolete] // 0x0000000189973530-0x00000001899735A0
		// [XID] // 0x0000000189973530-0x00000001899735A0
		public void Stop(CloseStatusCode code, string reason) {} // 0x00000001857DBA60-0x00000001857DBCD0
	}
}
