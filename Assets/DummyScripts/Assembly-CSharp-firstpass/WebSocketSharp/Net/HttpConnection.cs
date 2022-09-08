/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal sealed class HttpConnection // TypeDefIndex: 10252
	{
		// Fields
		private byte[] _buffer; // 0x10
		private const int _bufferLength = 8192; // Metadata: 0x00AE72AE
		private HttpListenerContext _context; // 0x18
		private bool _contextRegistered; // 0x20
		private StringBuilder _currentLine; // 0x28
		private InputState _inputState; // 0x30
		private RequestStream _inputStream; // 0x38
		private HttpListener _lastListener; // 0x40
		private LineState _lineState; // 0x48
		private EndPointListener _listener; // 0x50
		private EndPoint _localEndPoint; // 0x58
		private ResponseStream _outputStream; // 0x60
		private int _position; // 0x68
		private EndPoint _remoteEndPoint; // 0x70
		private MemoryStream _requestBuffer; // 0x78
		private int _reuses; // 0x80
		private bool _secure; // 0x84
		private Socket _socket; // 0x88
		private Stream _stream; // 0x90
		private object _sync; // 0x98
		private int _timeout; // 0xA0
		private Dictionary<int, bool> _timeoutCanceled; // 0xA8
		private Timer _timer; // 0xB0
	
		// Properties
		public bool IsClosed { /* [XID] */ /* 0x0000000189A359A0-0x0000000189A359C0 */ get => default; } // 0x000000018670AA50-0x000000018670AB00 
		public bool IsLocal { /* [XID] */ /* 0x0000000189A4A6B0-0x0000000189A4A6D0 */ get => default; } // 0x000000018670AB00-0x000000018670AC00 
		public bool IsSecure { /* [XID] */ /* 0x0000000189BDD2B0-0x0000000189BDD2D0 */ get => default; } // 0x000000018670AC00-0x000000018670ACB0 
		public IPEndPoint LocalEndPoint { /* [XID] */ /* 0x0000000189A9D2C0-0x0000000189A9D2E0 */ get => default; } // 0x000000018670ACB0-0x000000018670AD60 
		public IPEndPoint RemoteEndPoint { /* [XID] */ /* 0x00000001895F1320-0x00000001895F1340 */ get => default; } // 0x000000018670AD60-0x000000018670AE10 
		public int Reuses { /* [XID] */ /* 0x0000000189999E50-0x0000000189999E70 */ get => default; } // 0x000000018670AE10-0x000000018670AEB0 
		public Stream Stream { /* [XID] */ /* 0x0000000189600210-0x0000000189600230 */ get => default; } // 0x000000018670AEB0-0x000000018670AF60 
	
		// Constructors
		public HttpConnection() {} // Dummy constructor
		internal HttpConnection(Socket socket, EndPointListener listener) {} // 0x000000018670A2A0-0x000000018670A560
	
		// Methods
		// [XID] // 0x000000018997A190-0x000000018997A1B0
		private void close() {} // 0x000000018670A650-0x000000018670A7D0
		// [XID] // 0x00000001898423C0-0x00000001898423E0
		private void closeSocket() {} // 0x000000018670A560-0x000000018670A650
		// [XID] // 0x00000001899B6510-0x00000001899B6530
		private void disposeRequestBuffer() {} // 0x000000018670A7D0-0x000000018670A880
		// [XID] // 0x0000000189850FF0-0x0000000189851010
		private void disposeStream() {} // 0x000000018670A880-0x000000018670A950
		// [XID] // 0x0000000189625850-0x0000000189625870
		private void disposeTimer() {} // 0x000000018670A950-0x000000018670AA50
		// [XID] // 0x0000000189B8E080-0x0000000189B8E0A0
		private void init() {} // 0x000000018670AF60-0x000000018670B050
		// [XID] // 0x0000000189634C40-0x0000000189634C60
		private static void onRead(IAsyncResult asyncResult) {} // 0x000000018670B050-0x000000018670B640
		// [XID] // 0x00000001897545B0-0x00000001897545D0
		private static void onTimeout(object state) {} // 0x000000018670B640-0x000000018670B800
		// [XID] // 0x0000000189B617A0-0x0000000189B617C0
		private bool processInput(byte[] data, int length) => default; // 0x000000018670B800-0x000000018670BA90
		// [XID] // 0x000000018964B040-0x000000018964B060
		private string readLineFrom(byte[] buffer, int offset, int length, out int read) {
			read = default;
			return default;
		} // 0x000000018670BA90-0x000000018670BC50
		// [XID] // 0x0000000189652840-0x0000000189652860
		private void removeConnection() {} // 0x000000018670BC50-0x000000018670BD20
		// [XID] // 0x0000000189659FD0-0x0000000189659FF0
		private void unregisterContext() {} // 0x000000018670BD20-0x000000018670BDE0
		// [IDTag] // 0x0000000189661700-0x0000000189661740
		// [XID] // 0x0000000189661700-0x0000000189661740
		internal void Close(bool force) {} // 0x0000000186709720-0x0000000186709980
		// [XID] // 0x000000018966BEE0-0x000000018966BF00
		public void BeginReadRequest() {} // 0x0000000186709520-0x0000000186709720
		// [IDTag] // 0x0000000189673C50-0x0000000189673C90
		// [XID] // 0x0000000189673C50-0x0000000189673C90
		public void Close() {} // 0x0000000186709980-0x0000000186709A20
		// [XID] // 0x0000000189B5A300-0x0000000189B5A320
		public RequestStream GetRequestStream(long contentLength, bool chunked) => default; // 0x0000000186709A20-0x0000000186709C90
		// [XID] // 0x0000000189685B90-0x0000000189685BB0
		public ResponseStream GetResponseStream() => default; // 0x0000000186709C90-0x0000000186709EA0
		// [IDTag] // 0x000000018968D4B0-0x000000018968D4F0
		// [XID] // 0x000000018968D4B0-0x000000018968D4F0
		public void SendError() {} // 0x000000018670A1C0-0x000000018670A2A0
		// [IDTag] // 0x0000000189698440-0x0000000189698480
		// [XID] // 0x0000000189698440-0x0000000189698480
		public void SendError(string message, int status) {} // 0x0000000186709EA0-0x000000018670A1C0
	}
}
