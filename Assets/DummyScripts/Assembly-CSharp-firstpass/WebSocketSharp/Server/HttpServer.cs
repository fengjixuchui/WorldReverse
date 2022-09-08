/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
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
	public class HttpServer // TypeDefIndex: 10294
	{
		// Fields
		private IPAddress _address; // 0x10
		private string _docRootPath; // 0x18
		private string _hostname; // 0x20
		private WebSocketSharp.Net.HttpListener _listener; // 0x28
		private Logger _log; // 0x30
		private int _port; // 0x38
		private Thread _receiveThread; // 0x40
		private bool _secure; // 0x48
		private WebSocketServiceManager _services; // 0x50
		private ServerState _state; // 0x58
		private object _sync; // 0x60
	
		// Properties
		public IPAddress Address { /* [XID] */ /* 0x0000000189A70160-0x0000000189A70180 */ get => default; } // 0x00000001857D0C70-0x00000001857D0D10 
		public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes { /* [XID] */ /* 0x000000018977A500-0x000000018977A520 */ get => default; /* [XID] */ /* 0x00000001897894A0-0x00000001897894C0 */ set {} } // 0x00000001857D0D10-0x00000001857D0DC0 0x00000001857D2920-0x00000001857D2AE0
		public string DocumentRootPath { /* [XID] */ /* 0x0000000189B408F0-0x0000000189B40910 */ get => default; /* [XID] */ /* 0x0000000189AF9920-0x0000000189AF9940 */ set {} } // 0x00000001857D0DC0-0x00000001857D0E60 0x00000001857D2AE0-0x00000001857D3010
		public bool IsListening { /* [XID] */ /* 0x0000000189A77980-0x0000000189A779A0 */ get => default; } // 0x00000001857D0E60-0x00000001857D0F10 
		public bool IsSecure { /* [XID] */ /* 0x0000000189B08340-0x0000000189B08360 */ get => default; } // 0x00000001857D0F10-0x00000001857D0FB0 
		public bool KeepClean { /* [XID] */ /* 0x0000000189B0FBF0-0x0000000189B0FC10 */ get => default; /* [XID] */ /* 0x0000000189B16DA0-0x0000000189B16DC0 */ set {} } // 0x00000001857D0FB0-0x00000001857D1060 0x00000001857D3010-0x00000001857D30E0
		public Logger Log { /* [XID] */ /* 0x0000000189BA8BF0-0x0000000189BA8C10 */ get => default; } // 0x00000001857D1060-0x00000001857D1100 
		public int Port { /* [XID] */ /* 0x0000000189BB0320-0x0000000189BB0340 */ get => default; } // 0x00000001857D1100-0x00000001857D11A0 
		public string Realm { /* [XID] */ /* 0x0000000189B2D1D0-0x0000000189B2D1F0 */ get => default; /* [XID] */ /* 0x0000000189B44FF0-0x0000000189B45010 */ set {} } // 0x00000001857D11A0-0x00000001857D1250 0x00000001857D30E0-0x00000001857D32A0
		public bool ReuseAddress { /* [XID] */ /* 0x00000001895EA250-0x00000001895EA270 */ get => default; /* [XID] */ /* 0x00000001895F9130-0x00000001895F9150 */ set {} } // 0x00000001857D1250-0x00000001857D1300 0x00000001857D32A0-0x00000001857D3460
		public ServerSslConfiguration SslConfiguration { /* [XID] */ /* 0x0000000189B4B1A0-0x0000000189B4B1C0 */ get => default; } // 0x00000001857D1300-0x00000001857D1400 
		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder { /* [XID] */ /* 0x0000000189B529A0-0x0000000189B529C0 */ get => default; /* [XID] */ /* 0x0000000189B5A3E0-0x0000000189B5A400 */ set {} } // 0x00000001857D1400-0x00000001857D14B0 0x00000001857D3460-0x00000001857D3620
		public TimeSpan WaitTime { /* [XID] */ /* 0x0000000189731C40-0x0000000189731C60 */ get => default; /* [XID] */ /* 0x0000000189B694B0-0x0000000189B694D0 */ set {} } // 0x00000001857D14B0-0x00000001857D1560 0x00000001857D3620-0x00000001857D36E0
		public WebSocketServiceManager WebSocketServices { /* [XID] */ /* 0x0000000189B30090-0x0000000189B300B0 */ get => default; } // 0x00000001857D1560-0x00000001857D1600 
	
		// Events
		public event EventHandler<HttpRequestEventArgs> OnConnect;
		public event EventHandler<HttpRequestEventArgs> OnDelete;
		public event EventHandler<HttpRequestEventArgs> OnGet;
		public event EventHandler<HttpRequestEventArgs> OnHead;
		public event EventHandler<HttpRequestEventArgs> OnOptions;
		public event EventHandler<HttpRequestEventArgs> OnPost;
		public event EventHandler<HttpRequestEventArgs> OnPut;
		public event EventHandler<HttpRequestEventArgs> OnTrace;
	
		// Constructors
		public HttpServer() {} // 0x00000001857CF950-0x00000001857CFA10
		public HttpServer(int port) {} // 0x00000001857CF8D0-0x00000001857CF950
		public HttpServer(string url) {} // 0x00000001857CF3D0-0x00000001857CF6E0
		public HttpServer(int port, bool secure) {} // 0x00000001857CFA10-0x00000001857CFB50
		public HttpServer(IPAddress address, int port) {} // 0x00000001857CF330-0x00000001857CF3D0
		public HttpServer(IPAddress address, int port, bool secure) {} // 0x00000001857CF6E0-0x00000001857CF8D0
	
		// Methods
		// [XID] // 0x0000000189B9CB50-0x0000000189B9CB70
		private void abort() {} // 0x00000001857CFB50-0x00000001857CFD70
		// [XID] // 0x0000000189B48270-0x0000000189B48290
		private bool canSet(out string message) {
			message = default;
			return default;
		} // 0x00000001857D0670-0x00000001857D0770
		// [XID] // 0x0000000189B528E0-0x0000000189B52900
		private bool checkCertificate(out string message) {
			message = default;
			return default;
		} // 0x00000001857D0770-0x00000001857D0900
		// [XID] // 0x000000018960ADE0-0x000000018960AE00
		private string createFilePath(string childPath) => default; // 0x00000001857D0900-0x00000001857D0AE0
		// [XID] // 0x0000000189809B10-0x0000000189809B30
		private static WebSocketSharp.Net.HttpListener createListener(string hostname, int port, bool secure) => default; // 0x00000001857D0AE0-0x00000001857D0C70
		// [XID] // 0x00000001898B22D0-0x00000001898B22F0
		private void init(string hostname, IPAddress address, int port, bool secure) {} // 0x00000001857D1600-0x00000001857D1770
		// [IDTag] // 0x0000000189621090-0x00000001896210D0
		// [XID] // 0x0000000189621090-0x00000001896210D0
		private void processRequest(WebSocketSharp.Net.HttpListenerContext context) {} // 0x00000001857D1A00-0x00000001857D1D80
		// [IDTag] // 0x000000018962B890-0x000000018962B8D0
		// [XID] // 0x000000018962B890-0x000000018962B8D0
		private void processRequest(HttpListenerWebSocketContext context) {} // 0x00000001857D1770-0x00000001857D1A00
		// [XID] // 0x0000000189636560-0x0000000189636580
		private void receiveRequest() {} // 0x00000001857D1D80-0x00000001857D2020
		// [XID] // 0x000000018963DBD0-0x000000018963DBF0
		private void start() {} // 0x00000001857D3860-0x00000001857D3B00
		// [XID] // 0x0000000189645160-0x0000000189645180
		private void startReceiving() {} // 0x00000001857D36E0-0x00000001857D3860
		// [XID] // 0x0000000189958510-0x0000000189958530
		private void stop(ushort code, string reason) {} // 0x00000001857D3BE0-0x00000001857D3F20
		// [XID] // 0x0000000189654070-0x0000000189654090
		private void stopReceiving(int millisecondsTimeout) {} // 0x00000001857D3B00-0x00000001857D3BE0
		// [XID] // 0x000000018995FB70-0x000000018995FB90
		private static bool tryCreateUri(string uriString, out Uri result, out string message) {
			result = default;
			message = default;
			return default;
		} // 0x00000001857D3F20-0x00000001857D41D0
		[Obsolete] // 0x0000000189662D90-0x0000000189662DC0
		public void AddWebSocketService<TBehavior>(string path, Func<TBehavior> creator)
			where TBehavior : WebSocketBehavior {}
		public void AddWebSocketService<TBehaviorWithNew>(string path)
			where TBehaviorWithNew : WebSocketBehavior, new() {}
		public void AddWebSocketService<TBehaviorWithNew>(string path, Action<TBehaviorWithNew> initializer)
			where TBehaviorWithNew : WebSocketBehavior, new() {}
		[Obsolete] // 0x000000018966BE90-0x000000018966BEE0
		// [XID] // 0x000000018966BE90-0x000000018966BEE0
		public byte[] GetFile(string path) => default; // 0x00000001857CE960-0x00000001857CEB20
		// [XID] // 0x0000000189676CD0-0x0000000189676CF0
		public bool RemoveWebSocketService(string path) => default; // 0x00000001857CEB20-0x00000001857CEBF0
		// [XID] // 0x000000018967E3C0-0x000000018967E3E0
		public void Start() {} // 0x00000001857CEBF0-0x00000001857CED00
		// [IDTag] // 0x0000000189685B50-0x0000000189685B90
		// [XID] // 0x0000000189685B50-0x0000000189685B90
		public void Stop() {} // 0x00000001857CEF70-0x00000001857CF050
		// [IDTag] // 0x0000000189690B40-0x0000000189690BA0
		[Obsolete] // 0x0000000189690B40-0x0000000189690BA0
		// [XID] // 0x0000000189690B40-0x0000000189690BA0
		public void Stop(ushort code, string reason) {} // 0x00000001857CF050-0x00000001857CF330
		// [IDTag] // 0x000000018969E200-0x000000018969E260
		[Obsolete] // 0x000000018969E200-0x000000018969E260
		// [XID] // 0x000000018969E200-0x000000018969E260
		public void Stop(CloseStatusCode code, string reason) {} // 0x00000001857CED00-0x00000001857CEF70
	}
}
