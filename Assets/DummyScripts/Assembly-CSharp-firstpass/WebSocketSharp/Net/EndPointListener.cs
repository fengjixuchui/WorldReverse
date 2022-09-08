/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal sealed class EndPointListener // TypeDefIndex: 10249
	{
		// Fields
		private List<HttpListenerPrefix> _all; // 0x10
		private static readonly string _defaultCertFolderPath; // 0x00
		private IPEndPoint _endpoint; // 0x18
		private Dictionary<HttpListenerPrefix, HttpListener> _prefixes; // 0x20
		private bool _secure; // 0x28
		private Socket _socket; // 0x30
		private ServerSslConfiguration _sslConfig; // 0x38
		private List<HttpListenerPrefix> _unhandled; // 0x40
		private Dictionary<HttpConnection, HttpConnection> _unregistered; // 0x48
		private object _unregisteredSync; // 0x50
	
		// Properties
		public IPAddress Address { /* [XID] */ /* 0x000000018990BE80-0x000000018990BEA0 */ get => default; } // 0x00000001867066C0-0x0000000186706770 
		public bool IsSecure { /* [XID] */ /* 0x0000000189AF6680-0x0000000189AF66A0 */ get => default; } // 0x0000000186706770-0x0000000186706810 
		public int Port { /* [XID] */ /* 0x0000000189AFDCB0-0x0000000189AFDCD0 */ get => default; } // 0x0000000186706810-0x00000001867068C0 
		public ServerSslConfiguration SslConfiguration { /* [XID] */ /* 0x0000000189B05430-0x0000000189B05450 */ get => default; } // 0x00000001867068C0-0x0000000186706960 
	
		// Constructors
		public EndPointListener() {} // Dummy constructor
		static EndPointListener() {} // 0x0000000186705BF0-0x0000000186705C60
		internal EndPointListener(IPEndPoint endpoint, bool secure, string certificateFolderPath, ServerSslConfiguration sslConfig, bool reuseAddress) {} // 0x0000000186705C60-0x0000000186706010
	
		// Methods
		// [XID] // 0x0000000189B0CBC0-0x0000000189B0CBE0
		private static void addSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix) {} // 0x0000000186706010-0x0000000186706260
		// [XID] // 0x0000000189B14140-0x0000000189B14160
		private static RSACryptoServiceProvider createRSAFromFile(string filename) => default; // 0x0000000186706260-0x0000000186706450
		// [XID] // 0x0000000189B1B930-0x0000000189B1B950
		private static X509Certificate2 getCertificate(int port, string folderPath, X509Certificate2 defaultCertificate) => default; // 0x0000000186706450-0x00000001867066C0
		// [XID] // 0x0000000189B22ED0-0x0000000189B22EF0
		private void leaveIfNoPrefix() {} // 0x0000000186706960-0x0000000186706A80
		// [XID] // 0x00000001899B89E0-0x00000001899B8A00
		private static void onAccept(IAsyncResult asyncResult) {} // 0x0000000186706A80-0x0000000186706D10
		// [XID] // 0x0000000189B31AE0-0x0000000189B31B00
		private static void processAccepted(Socket socket, EndPointListener listener) {} // 0x0000000186706D10-0x0000000186706EE0
		// [XID] // 0x0000000189B38F90-0x0000000189B38FB0
		private static bool removeSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix) => default; // 0x0000000186706EE0-0x0000000186707070
		// [XID] // 0x0000000189675410-0x0000000189675430
		private static HttpListener searchHttpListenerFromSpecial(string path, List<HttpListenerPrefix> prefixes) => default; // 0x0000000186707070-0x0000000186707280
		// [XID] // 0x0000000189B483B0-0x0000000189B483D0
		internal static bool CertificateExists(int port, string folderPath) => default; // 0x0000000186704D20-0x0000000186704F00
		// [XID] // 0x0000000189B4FBF0-0x0000000189B4FC10
		internal void RemoveConnection(HttpConnection connection) {} // 0x0000000186705170-0x00000001867052B0
		// [XID] // 0x0000000189B57320-0x0000000189B57340
		internal bool TrySearchHttpListener(Uri uri, out HttpListener listener) {
			listener = default;
			return default;
		} // 0x00000001867055A0-0x0000000186705BF0
		// [XID] // 0x00000001899E3F60-0x00000001899E3F80
		public void AddPrefix(HttpListenerPrefix prefix, HttpListener listener) {} // 0x0000000186704960-0x0000000186704D20
		// [XID] // 0x0000000189A33F20-0x0000000189A33F40
		public void Close() {} // 0x0000000186704F00-0x0000000186705170
		// [XID] // 0x0000000189B6D930-0x0000000189B6D950
		public void RemovePrefix(HttpListenerPrefix prefix, HttpListener listener) {} // 0x00000001867052B0-0x00000001867055A0
	}
}
