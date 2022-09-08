/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using IFix.Core;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	public class WebSocket : IDisposable // TypeDefIndex: 10312
	{
		// Fields
		private AuthenticationChallenge _authChallenge; // 0x10
		private string _base64Key; // 0x18
		private bool _client; // 0x20
		private Action _closeContext; // 0x28
		private CompressionMethod _compression; // 0x30
		private WebSocketContext _context; // 0x38
		private CookieCollection _cookies; // 0x40
		private NetworkCredential _credentials; // 0x48
		private bool _emitOnPing; // 0x50
		private bool _enableRedirection; // 0x51
		private string _extensions; // 0x58
		private bool _extensionsRequested; // 0x60
		private object _forMessageEventQueue; // 0x68
		private object _forPing; // 0x70
		private object _forSend; // 0x78
		private object _forState; // 0x80
		private MemoryStream _fragmentsBuffer; // 0x88
		private bool _fragmentsCompressed; // 0x90
		private Opcode _fragmentsOpcode; // 0x91
		private const string _guid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11"; // Metadata: 0x00AE7502
		private Func<WebSocketContext, string> _handshakeRequestChecker; // 0x98
		private bool _ignoreExtensions; // 0xA0
		private bool _inContinuation; // 0xA1
		private bool _inMessage; // 0xA2
		private Logger _logger; // 0xA8
		private static readonly int _maxRetryCountForConnect; // 0x00
		private Action<MessageEventArgs> _message; // 0xB0
		private Queue<MessageEventArgs> _messageEventQueue; // 0xB8
		private uint _nonceCount; // 0xC0
		private string _origin; // 0xC8
		private ManualResetEvent _pongReceived; // 0xD0
		private bool _preAuth; // 0xD8
		private string _protocol; // 0xE0
		private string[] _protocols; // 0xE8
		private bool _protocolsRequested; // 0xF0
		private NetworkCredential _proxyCredentials; // 0xF8
		private Uri _proxyUri; // 0x100
		private WebSocketState _readyState; // 0x108
		private ManualResetEvent _receivingExited; // 0x110
		private int _retryCountForConnect; // 0x118
		private bool _secure; // 0x11C
		private ClientSslConfiguration _sslConfig; // 0x120
		private Stream _stream; // 0x128
		private TcpClient _tcpClient; // 0x130
		private Uri _uri; // 0x138
		private const string _version = "13"; // Metadata: 0x00AE752A
		private TimeSpan _waitTime; // 0x140
		internal static readonly byte[] EmptyBytes; // 0x08
		internal static readonly int FragmentLength; // 0x10
		internal static readonly RandomNumberGenerator RandomNumber; // 0x18
	
		// Properties
		internal CookieCollection CookieCollection { /* [XID] */ /* 0x000000018960ABC0-0x000000018960ABE0 */ get => default; } // 0x00000001857F3240-0x00000001857F32E0 
		internal Func<WebSocketContext, string> CustomHandshakeRequestChecker { /* [XID] */ /* 0x0000000189938D60-0x0000000189938D80 */ get => default; /* [XID] */ /* 0x0000000189612190-0x00000001896121B0 */ set {} } // 0x00000001857F3460-0x00000001857F3510 0x00000001857F8D90-0x00000001857F8E40
		internal bool HasMessage { /* [XID] */ /* 0x0000000189A1AD90-0x0000000189A1ADB0 */ get => default; } // 0x00000001857F3730-0x00000001857F3890 
		internal bool IgnoreExtensions { /* [XID] */ /* 0x00000001898B90E0-0x00000001898B9100 */ get => default; /* [XID] */ /* 0x0000000189850300-0x0000000189850320 */ set {} } // 0x00000001857F3890-0x00000001857F3940 0x00000001857F9100-0x00000001857F91B0
		internal bool IsConnected { /* [XID] */ /* 0x00000001898575A0-0x00000001898575C0 */ get => default; } // 0x00000001857F3A20-0x00000001857F3AF0 
		public CompressionMethod Compression { /* [XID] */ /* 0x000000018985E740-0x000000018985E760 */ get => default; /* [XID] */ /* 0x0000000189865FF0-0x0000000189866010 */ set {} } // 0x00000001857F31A0-0x00000001857F3240 0x00000001857F8B80-0x00000001857F8D90
		public IEnumerable<Cookie> Cookies { /* [XID] */ /* 0x0000000189A899B0-0x0000000189A899D0 */ get => default; } // 0x00000001857F32E0-0x00000001857F33C0 
		public NetworkCredential Credentials { /* [XID] */ /* 0x0000000189874BD0-0x0000000189874BF0 */ get => default; } // 0x00000001857F33C0-0x00000001857F3460 
		public bool EmitOnPing { /* [XID] */ /* 0x000000018987C710-0x000000018987C730 */ get => default; /* [XID] */ /* 0x0000000189619B10-0x0000000189619B30 */ set {} } // 0x00000001857F3510-0x00000001857F35B0 0x00000001857F8E40-0x00000001857F8EF0
		public bool EnableRedirection { /* [XID] */ /* 0x000000018988B010-0x000000018988B030 */ get => default; /* [XID] */ /* 0x0000000189A38070-0x0000000189A38090 */ set {} } // 0x00000001857F35B0-0x00000001857F3650 0x00000001857F8EF0-0x00000001857F9100
		public string Extensions { /* [XID] */ /* 0x0000000189899E10-0x0000000189899E30 */ get => default; } // 0x00000001857F3650-0x00000001857F3730 
		public bool IsAlive { /* [XID] */ /* 0x00000001898A1030-0x00000001898A1050 */ get => default; } // 0x00000001857F3940-0x00000001857F3A20 
		public bool IsSecure { /* [XID] */ /* 0x000000018998DBC0-0x000000018998DBE0 */ get => default; } // 0x00000001857F3AF0-0x00000001857F3BA0 
		public Logger Log { /* [XID] */ /* 0x00000001898B0110-0x00000001898B0130 */ get => default; /* [XID] */ /* 0x00000001898B7670-0x00000001898B7690 */ internal set {} } // 0x00000001857F3BA0-0x00000001857F3C50 0x00000001857F91B0-0x00000001857F9270
		public string Origin { /* [XID] */ /* 0x00000001898C7E60-0x00000001898C7E80 */ get => default; /* [XID] */ /* 0x00000001898CF680-0x00000001898CF6A0 */ set {} } // 0x00000001857F3C50-0x00000001857F3D00 0x00000001857F9270-0x00000001857F9630
		public string Protocol { /* [XID] */ /* 0x00000001898CDCD0-0x00000001898CDCF0 */ get => default; /* [XID] */ /* 0x00000001898D5710-0x00000001898D5730 */ internal set {} } // 0x00000001857F3D00-0x00000001857F3DE0 0x00000001857F9630-0x00000001857F96E0
		public WebSocketState ReadyState { /* [XID] */ /* 0x00000001898DD0B0-0x00000001898DD0D0 */ get => default; } // 0x00000001857F3DE0-0x00000001857F3E90 
		public ClientSslConfiguration SslConfiguration { /* [XID] */ /* 0x00000001898D6EB0-0x00000001898D6ED0 */ get => default; } // 0x00000001857F3E90-0x00000001857F3FD0 
		public Uri Url { /* [XID] */ /* 0x00000001898EC490-0x00000001898EC4B0 */ get => default; } // 0x00000001857F3FD0-0x00000001857F40A0 
		public TimeSpan WaitTime { /* [XID] */ /* 0x00000001898F3F20-0x00000001898F3F40 */ get => default; /* [XID] */ /* 0x00000001898FB350-0x00000001898FB370 */ set {} } // 0x00000001857F40A0-0x00000001857F4150 0x00000001857F96E0-0x00000001857F9930
	
		// Events
		public event EventHandler<CloseEventArgs> OnClose;
		public event EventHandler<ErrorEventArgs> OnError;
		public event EventHandler<MessageEventArgs> OnMessage;
		public event EventHandler OnOpen;
	
		// Constructors
		public WebSocket() {} // Dummy constructor
		static WebSocket() {} // 0x00000001857EEF90-0x00000001857EF070
		internal WebSocket(HttpListenerWebSocketContext context, string protocol) {} // 0x00000001857EF530-0x00000001857EF6B0
		internal WebSocket(TcpListenerWebSocketContext context, string protocol) {} // 0x00000001857EF3B0-0x00000001857EF530
		public WebSocket(string url, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] protocols) {} // 0x00000001857EF070-0x00000001857EF3B0
	
		// Methods
		// [XID] // 0x00000001899C1C20-0x00000001899C1C40
		private bool accept() => default; // 0x00000001857EF9A0-0x00000001857EFD60
		// [XID] // 0x00000001896E1A00-0x00000001896E1A20
		private bool acceptHandshake() => default; // 0x00000001857EF6B0-0x00000001857EF9A0
		// [XID] // 0x000000018994DC20-0x000000018994DC40
		private bool canSet(out string message) {
			message = default;
			return default;
		} // 0x00000001857F01E0-0x00000001857F02E0
		// [XID] // 0x00000001896E8F50-0x00000001896E8F70
		private bool checkHandshakeRequest(WebSocketContext context, out string message) {
			message = default;
			return default;
		} // 0x00000001857F02E0-0x00000001857F05B0
		// [XID] // 0x000000018995CA60-0x000000018995CA80
		private bool checkHandshakeResponse(HttpResponse response, out string message) {
			message = default;
			return default;
		} // 0x00000001857F05B0-0x00000001857F07E0
		// [XID] // 0x000000018970B670-0x000000018970B690
		private static bool checkProtocols(string[] protocols, out string message) {
			message = default;
			return default;
		} // 0x00000001857F07E0-0x00000001857F09F0
		// [XID] // 0x000000018996BA90-0x000000018996BAB0
		private bool checkReceivedFrame(WebSocketFrame frame, out string message) {
			message = default;
			return default;
		} // 0x00000001857F09F0-0x00000001857F0B90
		// [IDTag] // 0x00000001899734F0-0x0000000189973530
		// [XID] // 0x00000001899734F0-0x0000000189973530
		private void close(ushort code, string reason) {} // 0x00000001857F1410-0x00000001857F1640
		// [IDTag] // 0x000000018997D620-0x000000018997D660
		// [XID] // 0x000000018997D620-0x000000018997D660
		private void close(PayloadData payloadData, bool send, bool receive, bool received) {} // 0x00000001857F1640-0x00000001857F1A40
		// [IDTag] // 0x0000000189988330-0x0000000189988370
		// [XID] // 0x0000000189988330-0x0000000189988370
		private void closeAsync(ushort code, string reason) {} // 0x00000001857F0D40-0x00000001857F0F70
		// [IDTag] // 0x0000000189993240-0x0000000189993280
		// [XID] // 0x0000000189993240-0x0000000189993280
		private void closeAsync(PayloadData payloadData, bool send, bool receive, bool received) {} // 0x00000001857F0B90-0x00000001857F0D40
		// [IDTag] // 0x000000018999DAE0-0x000000018999DB20
		// [XID] // 0x000000018999DAE0-0x000000018999DB20
		private bool closeHandshake(byte[] frameAsBytes, bool receive, bool received) => default; // 0x00000001857F0F70-0x00000001857F1190
		// [IDTag] // 0x00000001899A85C0-0x00000001899A8600
		// [XID] // 0x00000001899A85C0-0x00000001899A8600
		private bool closeHandshake(PayloadData payloadData, bool send, bool receive, bool received) => default; // 0x00000001857F1190-0x00000001857F1410
		// [XID] // 0x00000001899B3030-0x00000001899B3050
		private bool connect() => default; // 0x00000001857F1A40-0x00000001857F1E10
		// [XID] // 0x0000000189A400C0-0x0000000189A400E0
		private string createExtensions() => default; // 0x00000001857F1E10-0x00000001857F2050
		// [XID] // 0x00000001895F4230-0x00000001895F4250
		private HttpResponse createHandshakeFailureResponse(HttpStatusCode code) => default; // 0x00000001857F2050-0x00000001857F2140
		// [XID] // 0x00000001899C91A0-0x00000001899C91C0
		private HttpRequest createHandshakeRequest() => default; // 0x00000001857F2140-0x00000001857F2440
		// [XID] // 0x0000000189754650-0x0000000189754670
		private HttpResponse createHandshakeResponse() => default; // 0x00000001857F2440-0x00000001857F25D0
		// [XID] // 0x00000001896F7A30-0x00000001896F7A50
		private bool customCheckHandshakeRequest(WebSocketContext context, out string message) {
			message = default;
			return default;
		} // 0x00000001857F25D0-0x00000001857F26C0
		// [XID] // 0x00000001899DF6C0-0x00000001899DF6E0
		private MessageEventArgs dequeueFromMessageEventQueue() => default; // 0x00000001857F26C0-0x00000001857F2830
		// [XID] // 0x00000001899E7290-0x00000001899E72B0
		private void doHandshake() {} // 0x00000001857F2830-0x00000001857F2A00
		// [XID] // 0x00000001899EE6D0-0x00000001899EE6F0
		private void enqueueToMessageEventQueue(MessageEventArgs e) {} // 0x00000001857F2A00-0x00000001857F2B40
		// [XID] // 0x000000018992B840-0x000000018992B860
		private void error(string message, Exception exception) {} // 0x00000001857F2B40-0x00000001857F2D00
		// [IDTag] // 0x00000001899FD610-0x00000001899FD650
		// [XID] // 0x00000001899FD610-0x00000001899FD650
		private void fatal(string message, Exception exception) {} // 0x00000001857F2E40-0x00000001857F2FC0
		// [IDTag] // 0x0000000189A07C10-0x0000000189A07C50
		// [XID] // 0x0000000189A07C10-0x0000000189A07C50
		private void fatal(string message, ushort code) {} // 0x00000001857F2D00-0x00000001857F2E40
		// [IDTag] // 0x0000000189A12440-0x0000000189A12480
		// [XID] // 0x0000000189A12440-0x0000000189A12480
		private void fatal(string message, CloseStatusCode code) {} // 0x00000001857F2FC0-0x00000001857F3090
		// [XID] // 0x00000001898E6370-0x00000001898E6390
		private ClientSslConfiguration getSslConfiguration() => default; // 0x00000001857F3090-0x00000001857F31A0
		// [XID] // 0x0000000189A23EB0-0x0000000189A23ED0
		private void init() {} // 0x00000001857F4150-0x00000001857F42D0
		// [XID] // 0x0000000189A37220-0x0000000189A37240
		private void message() {} // 0x00000001857F42D0-0x00000001857F44B0
		// [XID] // 0x0000000189A32830-0x0000000189A32850
		private void messagec(MessageEventArgs e) {} // 0x00000001857F44B0-0x00000001857F4730
		// [XID] // 0x0000000189A3A230-0x0000000189A3A250
		private void messages(MessageEventArgs e) {} // 0x00000001857F4730-0x00000001857F4A10
		// [XID] // 0x0000000189779860-0x0000000189779880
		private void open() {} // 0x00000001857F4A10-0x00000001857F4D10
		// [XID] // 0x0000000189A3EDC0-0x0000000189A3EDE0
		private bool ping(byte[] data) => default; // 0x00000001857F4D10-0x00000001857F4F00
		// [XID] // 0x000000018981F6D0-0x000000018981F6F0
		private bool processCloseFrame(WebSocketFrame frame) => default; // 0x00000001857F4F00-0x00000001857F5000
		// [XID] // 0x0000000189A57EA0-0x0000000189A57EC0
		private void processCookies(CookieCollection cookies) {} // 0x00000001857F5000-0x00000001857F50E0
		// [XID] // 0x00000001897FA330-0x00000001897FA350
		private bool processDataFrame(WebSocketFrame frame) => default; // 0x00000001857F50E0-0x00000001857F5290
		// [XID] // 0x0000000189A67470-0x0000000189A67490
		private bool processFragmentFrame(WebSocketFrame frame) => default; // 0x00000001857F5290-0x00000001857F5580
		// [XID] // 0x000000018984DE20-0x000000018984DE40
		private bool processPingFrame(WebSocketFrame frame) => default; // 0x00000001857F5580-0x00000001857F5870
		// [XID] // 0x0000000189810640-0x0000000189810660
		private bool processPongFrame(WebSocketFrame frame) => default; // 0x00000001857F5870-0x00000001857F5AB0
		// [XID] // 0x0000000189A7DCE0-0x0000000189A7DD00
		private bool processReceivedFrame(WebSocketFrame frame) => default; // 0x00000001857F5AB0-0x00000001857F5C80
		// [XID] // 0x0000000189A85570-0x0000000189A85590
		private void processSecWebSocketExtensionsClientHeader(string value) {} // 0x00000001857F5C80-0x00000001857F6060
		// [XID] // 0x0000000189A8CF00-0x0000000189A8CF20
		private void processSecWebSocketExtensionsServerHeader(string value) {} // 0x00000001857F6060-0x00000001857F6120
		// [XID] // 0x0000000189A942F0-0x0000000189A94310
		private void processSecWebSocketProtocolClientHeader(IEnumerable<string> values) {} // 0x00000001857F6120-0x00000001857F6250
		// [XID] // 0x0000000189A9BC60-0x0000000189A9BC80
		private bool processUnsupportedFrame(WebSocketFrame frame) => default; // 0x00000001857F6250-0x00000001857F63A0
		// [XID] // 0x0000000189AA31A0-0x0000000189AA31C0
		private void refuseHandshake(CloseStatusCode code, string reason) {} // 0x00000001857F63A0-0x00000001857F65C0
		// [XID] // 0x000000018965D0A0-0x000000018965D0C0
		private void releaseClientResources() {} // 0x00000001857F65C0-0x00000001857F66A0
		// [XID] // 0x0000000189B86EB0-0x0000000189B86ED0
		private void releaseCommonResources() {} // 0x00000001857F66A0-0x00000001857F67B0
		// [XID] // 0x00000001896558B0-0x00000001896558D0
		private void releaseResources() {} // 0x00000001857F67B0-0x00000001857F6870
		// [XID] // 0x0000000189AC1550-0x0000000189AC1570
		private void releaseServerResources() {} // 0x00000001857F6870-0x00000001857F6930
		// [IDTag] // 0x0000000189AC8DA0-0x0000000189AC8DE0
		// [XID] // 0x0000000189AC8DA0-0x0000000189AC8DE0
		private bool send(Opcode opcode, Stream stream) => default; // 0x00000001857F84E0-0x00000001857F87C0
		// [IDTag] // 0x0000000189AD3750-0x0000000189AD3790
		// [XID] // 0x0000000189AD3750-0x0000000189AD3790
		private bool send(Opcode opcode, Stream stream, bool compressed) => default; // 0x00000001857F8000-0x00000001857F84E0
		// [IDTag] // 0x0000000189ADE520-0x0000000189ADE560
		// [XID] // 0x0000000189ADE520-0x0000000189ADE560
		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed) => default; // 0x00000001857F7DE0-0x00000001857F8000
		// [XID] // 0x0000000189AE8B30-0x0000000189AE8B50
		private void sendAsync(Opcode opcode, Stream stream, Action<bool> completed) {} // 0x00000001857F6DB0-0x00000001857F6F50
		// [XID] // 0x0000000189B954C0-0x0000000189B954E0
		private bool sendBytes(byte[] bytes) => default; // 0x00000001857F6F50-0x00000001857F70F0
		// [XID] // 0x0000000189AF7F70-0x0000000189AF7F90
		private HttpResponse sendHandshakeRequest() => default; // 0x00000001857F70F0-0x00000001857F7670
		// [XID] // 0x0000000189947B90-0x0000000189947BB0
		private HttpResponse sendHttpRequest(HttpRequest request, int millisecondsTimeout) => default; // 0x00000001857F7670-0x00000001857F7840
		// [XID] // 0x00000001896031A0-0x00000001896031C0
		private bool sendHttpResponse(HttpResponse response) => default; // 0x00000001857F7840-0x00000001857F79B0
		// [XID] // 0x0000000189940510-0x0000000189940530
		private void sendProxyConnectRequest() {} // 0x00000001857F79B0-0x00000001857F7DE0
		// [XID] // 0x0000000189B15650-0x0000000189B15670
		private void setClientStream() {} // 0x00000001857F87C0-0x00000001857F8B80
		// [XID] // 0x0000000189B1D0F0-0x0000000189B1D110
		private void startReceiving() {} // 0x00000001857F9930-0x00000001857F9AE0
		// [XID] // 0x000000018994F250-0x000000018994F270
		private bool validateSecWebSocketAcceptHeader(string value) => default; // 0x00000001857F9AE0-0x00000001857F9C00
		// [XID] // 0x000000018990BE60-0x000000018990BE80
		private bool validateSecWebSocketExtensionsServerHeader(string value) => default; // 0x00000001857F9C00-0x00000001857FA0C0
		// [XID] // 0x000000018995E250-0x000000018995E270
		private bool validateSecWebSocketProtocolServerHeader(string value) => default; // 0x00000001857FA0C0-0x00000001857FA250
		// [XID] // 0x0000000189B3AB00-0x0000000189B3AB20
		private bool validateSecWebSocketVersionServerHeader(string value) => default; // 0x00000001857FA250-0x00000001857FA340
		// [IDTag] // 0x0000000189B42310-0x0000000189B42350
		// [XID] // 0x0000000189B42310-0x0000000189B42350
		internal void Close(HttpResponse response) {} // 0x00000001857EB820-0x00000001857EB900
		// [IDTag] // 0x0000000189B4CB90-0x0000000189B4CBD0
		// [XID] // 0x0000000189B4CB90-0x0000000189B4CBD0
		internal void Close(HttpStatusCode code) {} // 0x00000001857EB760-0x00000001857EB820
		// [IDTag] // 0x0000000189B572E0-0x0000000189B57320
		// [XID] // 0x0000000189B572E0-0x0000000189B57320
		internal void Close(PayloadData payloadData, byte[] frameAsBytes) {} // 0x00000001857EB0E0-0x00000001857EB560
		// [XID] // 0x0000000189B61880-0x0000000189B618A0
		internal static string CreateBase64Key() => default; // 0x00000001857EBDF0-0x00000001857EBF20
		// [XID] // 0x0000000189B69470-0x0000000189B69490
		internal static string CreateResponseKey(string base64Key) => default; // 0x00000001857EBF20-0x00000001857EC0B0
		// [XID] // 0x000000018969F580-0x000000018969F5A0
		internal void InternalAccept() {} // 0x00000001857EC0B0-0x00000001857EC230
		// [IDTag] // 0x0000000189B77E60-0x0000000189B77EA0
		// [XID] // 0x0000000189B77E60-0x0000000189B77EA0
		internal bool Ping(byte[] frameAsBytes, TimeSpan timeout) => default; // 0x00000001857EC230-0x00000001857EC4C0
		// [IDTag] // 0x0000000189B826B0-0x0000000189B826F0
		// [XID] // 0x0000000189B826B0-0x0000000189B826F0
		internal void Send(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache) {} // 0x00000001857ED4D0-0x00000001857ED7B0
		// [IDTag] // 0x0000000189B8C7B0-0x0000000189B8C7F0
		// [XID] // 0x0000000189B8C7B0-0x0000000189B8C7F0
		internal void Send(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache) {} // 0x00000001857EDC40-0x00000001857EDE40
		// [XID] // 0x0000000189B96E80-0x0000000189B96EA0
		public void Accept() {} // 0x00000001857E9CB0-0x00000001857E9E40
		// [XID] // 0x00000001897EA300-0x00000001897EA320
		public void AcceptAsync() {} // 0x00000001857E9A80-0x00000001857E9CB0
		// [IDTag] // 0x0000000189BA5C90-0x0000000189BA5CD0
		// [XID] // 0x0000000189BA5C90-0x0000000189BA5CD0
		public void Close() {} // 0x00000001857EB900-0x00000001857EB9E0
		// [IDTag] // 0x0000000189BAFD00-0x0000000189BAFD40
		// [XID] // 0x0000000189BAFD00-0x0000000189BAFD40
		public void Close(ushort code) {} // 0x00000001857EB560-0x00000001857EB760
		// [IDTag] // 0x0000000189BBA3C0-0x0000000189BBA400
		// [XID] // 0x0000000189BBA3C0-0x0000000189BBA400
		public void Close(CloseStatusCode code) {} // 0x00000001857EABF0-0x00000001857EAD80
		// [IDTag] // 0x0000000189BC5080-0x0000000189BC50C0
		// [XID] // 0x0000000189BC5080-0x0000000189BC50C0
		public void Close(ushort code, string reason) {} // 0x00000001857EAD80-0x00000001857EB0E0
		// [IDTag] // 0x0000000189BCFA50-0x0000000189BCFA90
		// [XID] // 0x0000000189BCFA50-0x0000000189BCFA90
		public void Close(CloseStatusCode code, string reason) {} // 0x00000001857EA900-0x00000001857EABF0
		// [IDTag] // 0x0000000189BD9FD0-0x0000000189BDA010
		// [XID] // 0x0000000189BD9FD0-0x0000000189BDA010
		public void CloseAsync() {} // 0x00000001857EA330-0x00000001857EA410
		// [IDTag] // 0x00000001895E9D00-0x00000001895E9D40
		// [XID] // 0x00000001895E9D00-0x00000001895E9D40
		public void CloseAsync(ushort code) {} // 0x00000001857EA410-0x00000001857EA610
		// [IDTag] // 0x00000001895F4470-0x00000001895F44B0
		// [XID] // 0x00000001895F4470-0x00000001895F44B0
		public void CloseAsync(CloseStatusCode code) {} // 0x00000001857EA1A0-0x00000001857EA330
		// [IDTag] // 0x00000001895FE9F0-0x00000001895FEA30
		// [XID] // 0x00000001895FE9F0-0x00000001895FEA30
		public void CloseAsync(ushort code, string reason) {} // 0x00000001857E9E40-0x00000001857EA1A0
		// [IDTag] // 0x0000000189609540-0x0000000189609580
		// [XID] // 0x0000000189609540-0x0000000189609580
		public void CloseAsync(CloseStatusCode code, string reason) {} // 0x00000001857EA610-0x00000001857EA900
		// [XID] // 0x0000000189A13C30-0x0000000189A13C50
		public void Connect() {} // 0x00000001857EBC30-0x00000001857EBDF0
		// [XID] // 0x000000018994B8E0-0x000000018994B900
		public void ConnectAsync() {} // 0x00000001857EB9E0-0x00000001857EBC30
		// [IDTag] // 0x0000000189622910-0x0000000189622950
		// [XID] // 0x0000000189622910-0x0000000189622950
		public bool Ping() => default; // 0x00000001857EC6C0-0x00000001857EC7A0
		// [IDTag] // 0x000000018962D0B0-0x000000018962D0F0
		// [XID] // 0x000000018962D0B0-0x000000018962D0F0
		public bool Ping(string message) => default; // 0x00000001857EC4C0-0x00000001857EC6C0
		// [IDTag] // 0x0000000189637F00-0x0000000189637F40
		// [XID] // 0x0000000189637F00-0x0000000189637F40
		public void Send(byte[] data) {} // 0x00000001857EDAD0-0x00000001857EDC40
		// [IDTag] // 0x0000000189642270-0x00000001896422B0
		// [XID] // 0x0000000189642270-0x00000001896422B0
		public void Send(FileInfo fileInfo) {} // 0x00000001857ED0C0-0x00000001857ED2E0
		// [IDTag] // 0x000000018964CCC0-0x000000018964CD00
		// [XID] // 0x000000018964CCC0-0x000000018964CD00
		public void Send(string data) {} // 0x00000001857ED2E0-0x00000001857ED4D0
		// [IDTag] // 0x0000000189657260-0x00000001896572A0
		// [XID] // 0x0000000189657260-0x00000001896572A0
		public void Send(Stream stream, int length) {} // 0x00000001857ED7B0-0x00000001857EDAD0
		// [IDTag] // 0x00000001896616C0-0x0000000189661700
		// [XID] // 0x00000001896616C0-0x0000000189661700
		public void SendAsync(byte[] data, Action<bool> completed) {} // 0x00000001857EC7A0-0x00000001857EC930
		// [IDTag] // 0x000000018966BE50-0x000000018966BE90
		// [XID] // 0x000000018966BE50-0x000000018966BE90
		public void SendAsync(FileInfo fileInfo, Action<bool> completed) {} // 0x00000001857EC930-0x00000001857ECB70
		// [IDTag] // 0x0000000189676C90-0x0000000189676CD0
		// [XID] // 0x0000000189676C90-0x0000000189676CD0
		public void SendAsync(string data, Action<bool> completed) {} // 0x00000001857ECB70-0x00000001857ECD80
		// [IDTag] // 0x0000000189681640-0x0000000189681680
		// [XID] // 0x0000000189681640-0x0000000189681680
		public void SendAsync(Stream stream, int length, Action<bool> completed) {} // 0x00000001857ECD80-0x00000001857ED0C0
		// [XID] // 0x0000000189786540-0x0000000189786560
		public void SetCookie(Cookie cookie) {} // 0x00000001857EDE40-0x00000001857EE120
		// [XID] // 0x0000000189A1AE10-0x0000000189A1AE30
		public void SetCredentials(string username, string password, bool preAuth) {} // 0x00000001857EE120-0x00000001857EE5C0
		// [XID] // 0x000000018969AF10-0x000000018969AF30
		public void SetProxy(string url, string username, string password) {} // 0x00000001857EE5C0-0x00000001857EECC0
		// [XID] // 0x00000001896A2900-0x00000001896A2920
		void IDisposable.Dispose() {} // 0x00000001857EECC0-0x00000001857EEDA0
	}
}
