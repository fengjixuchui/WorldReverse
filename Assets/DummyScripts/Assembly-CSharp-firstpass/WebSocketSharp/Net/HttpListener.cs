/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using IFix.Core;
using WebSocketSharp;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public sealed class HttpListener : IDisposable // TypeDefIndex: 10256
	{
		// Fields
		private AuthenticationSchemes _authSchemes; // 0x10
		private Func<HttpListenerRequest, AuthenticationSchemes> _authSchemeSelector; // 0x18
		private string _certFolderPath; // 0x20
		private Dictionary<HttpConnection, HttpConnection> _connections; // 0x28
		private object _connectionsSync; // 0x30
		private List<HttpListenerContext> _ctxQueue; // 0x38
		private object _ctxQueueSync; // 0x40
		private Dictionary<HttpListenerContext, HttpListenerContext> _ctxRegistry; // 0x48
		private object _ctxRegistrySync; // 0x50
		private static readonly string _defaultRealm; // 0x00
		private bool _disposed; // 0x58
		private bool _ignoreWriteExceptions; // 0x59
		private bool _listening; // 0x5A
		private Logger _logger; // 0x60
		private HttpListenerPrefixCollection _prefixes; // 0x68
		private string _realm; // 0x70
		private bool _reuseAddress; // 0x78
		private ServerSslConfiguration _sslConfig; // 0x80
		private Func<IIdentity, NetworkCredential> _userCredFinder; // 0x88
		private List<HttpListenerAsyncResult> _waitQueue; // 0x90
		private object _waitQueueSync; // 0x98
	
		// Properties
		internal bool IsDisposed { /* [XID] */ /* 0x0000000189A44850-0x0000000189A44870 */ get => default; } // 0x000000018670F520-0x000000018670F5C0 
		internal bool ReuseAddress { /* [XID] */ /* 0x0000000189736610-0x0000000189736630 */ get => default; /* [XID] */ /* 0x000000018973E400-0x000000018973E420 */ set {} } // 0x000000018670F910-0x000000018670F9B0 0x000000018670FFD0-0x0000000186710080
		public AuthenticationSchemes AuthenticationSchemes { /* [XID] */ /* 0x0000000189745690-0x00000001897456B0 */ get => default; /* [XID] */ /* 0x00000001897B62B0-0x00000001897B62D0 */ set {} } // 0x000000018670F310-0x000000018670F3C0 0x000000018670FCD0-0x000000018670FD90
		public Func<HttpListenerRequest, AuthenticationSchemes> AuthenticationSchemeSelector { /* [XID] */ /* 0x00000001897547F0-0x0000000189754810 */ get => default; /* [XID] */ /* 0x000000018975BA90-0x000000018975BAB0 */ set {} } // 0x000000018670F260-0x000000018670F310 0x000000018670FC10-0x000000018670FCD0
		public string CertificateFolderPath { /* [XID] */ /* 0x0000000189A97410-0x0000000189A97430 */ get => default; /* [XID] */ /* 0x000000018976ABB0-0x000000018976ABD0 */ set {} } // 0x000000018670F3C0-0x000000018670F470 0x000000018670FD90-0x000000018670FE50
		public bool IgnoreWriteExceptions { /* [XID] */ /* 0x0000000189772190-0x00000001897721B0 */ get => default; /* [XID] */ /* 0x0000000189A625E0-0x0000000189A62600 */ set {} } // 0x000000018670F470-0x000000018670F520 0x000000018670FE50-0x000000018670FF10
		public bool IsListening { /* [XID] */ /* 0x00000001897812C0-0x00000001897812E0 */ get => default; } // 0x000000018670F5C0-0x000000018670F670 
		public static bool IsSupported { /* [XID] */ /* 0x0000000189788800-0x0000000189788820 */ get => default; } // 0x000000018670F670-0x000000018670F710 
		public Logger Log { /* [XID] */ /* 0x000000018978FEA0-0x000000018978FEC0 */ get => default; } // 0x000000018670F710-0x000000018670F7B0 
		public HttpListenerPrefixCollection Prefixes { /* [XID] */ /* 0x00000001897976D0-0x00000001897976F0 */ get => default; } // 0x000000018670F7B0-0x000000018670F860 
		public string Realm { /* [XID] */ /* 0x000000018979F6B0-0x000000018979F6D0 */ get => default; /* [XID] */ /* 0x0000000189AE8A30-0x0000000189AE8A50 */ set {} } // 0x000000018670F860-0x000000018670F910 0x000000018670FF10-0x000000018670FFD0
		public ServerSslConfiguration SslConfiguration { /* [XID] */ /* 0x0000000189A26AB0-0x0000000189A26AD0 */ get => default; /* [XID] */ /* 0x0000000189B2E820-0x0000000189B2E840 */ set {} } // 0x000000018670F9B0-0x000000018670FA90 0x0000000186710080-0x0000000186710140
		public bool UnsafeConnectionNtlmAuthentication { /* [XID] */ /* 0x00000001897BE1C0-0x00000001897BE1E0 */ get => default; /* [XID] */ /* 0x00000001897C58B0-0x00000001897C58D0 */ set {} } // 0x000000018670FA90-0x000000018670FB60 0x0000000186710140-0x0000000186710210
		public Func<IIdentity, NetworkCredential> UserCredentialsFinder { /* [XID] */ /* 0x0000000189BC22A0-0x0000000189BC22C0 */ get => default; /* [XID] */ /* 0x00000001897D4560-0x00000001897D4580 */ set {} } // 0x000000018670FB60-0x000000018670FC10 0x0000000186710210-0x00000001867102D0
	
		// Constructors
		static HttpListener() {} // 0x000000018670E2C0-0x000000018670E330
		public HttpListener() {} // 0x000000018670E330-0x000000018670E560
	
		// Methods
		// [XID] // 0x0000000189BD8620-0x0000000189BD8640
		private void cleanupConnections() {} // 0x000000018670E560-0x000000018670E7B0
		// [XID] // 0x00000001897E3770-0x00000001897E3790
		private void cleanupContextQueue(bool sendServiceUnavailable) {} // 0x000000018670E7B0-0x000000018670E9E0
		// [XID] // 0x00000001897EAF00-0x00000001897EAF20
		private void cleanupContextRegistry() {} // 0x000000018670E9E0-0x000000018670EC40
		// [XID] // 0x000000018967E2E0-0x000000018967E300
		private void cleanupWaitQueue(Exception exception) {} // 0x000000018670EC40-0x000000018670EE50
		// [XID] // 0x00000001897FA4D0-0x00000001897FA4F0
		private void close(bool force) {} // 0x000000018670EE50-0x000000018670F040
		// [XID] // 0x0000000189801A70-0x0000000189801A90
		private HttpListenerAsyncResult getAsyncResultFromQueue() => default; // 0x000000018670F040-0x000000018670F150
		// [XID] // 0x0000000189808EB0-0x0000000189808ED0
		private HttpListenerContext getContextFromQueue() => default; // 0x000000018670F150-0x000000018670F260
		// [XID] // 0x00000001898107F0-0x0000000189810810
		internal bool AddConnection(HttpConnection connection) => default; // 0x000000018670CE00-0x000000018670CFA0
		// [IDTag] // 0x0000000189817EA0-0x0000000189817EE0
		// [XID] // 0x0000000189817EA0-0x0000000189817EE0
		internal HttpListenerAsyncResult BeginGetContext(HttpListenerAsyncResult asyncResult) => default; // 0x000000018670CFA0-0x000000018670D160
		// [XID] // 0x0000000189822690-0x00000001898226B0
		internal void CheckDisposed() {} // 0x000000018670D300-0x000000018670D410
		// [XID] // 0x0000000189602600-0x0000000189602620
		internal string GetRealm() => default; // 0x000000018670D880-0x000000018670D970
		// [XID] // 0x0000000189BAAD00-0x0000000189BAAD20
		internal Func<IIdentity, NetworkCredential> GetUserCredentialsFinder() => default; // 0x000000018670D970-0x000000018670DA20
		// [XID] // 0x0000000189977DE0-0x0000000189977E00
		internal bool RegisterContext(HttpListenerContext context) => default; // 0x000000018670DA20-0x000000018670DBF0
		// [XID] // 0x000000018983FF80-0x000000018983FFA0
		internal void RemoveConnection(HttpConnection connection) {} // 0x000000018670DBF0-0x000000018670DD30
		// [XID] // 0x0000000189609E70-0x0000000189609E90
		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerRequest request) => default; // 0x000000018670DD30-0x000000018670DE10
		// [XID] // 0x000000018984EDC0-0x000000018984EDE0
		internal void UnregisterContext(HttpListenerContext context) {} // 0x000000018670E180-0x000000018670E2C0
		// [XID] // 0x0000000189855EB0-0x0000000189855ED0
		public void Abort() {} // 0x000000018670CD50-0x000000018670CE00
		// [IDTag] // 0x000000018985D140-0x000000018985D180
		// [XID] // 0x000000018985D140-0x000000018985D180
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state) => default; // 0x000000018670D160-0x000000018670D300
		// [XID] // 0x00000001898679D0-0x00000001898679F0
		public void Close() {} // 0x000000018670D410-0x000000018670D4C0
		// [XID] // 0x000000018986F120-0x000000018986F140
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult) => default; // 0x000000018670D4C0-0x000000018670D6D0
		// [XID] // 0x00000001898765B0-0x00000001898765D0
		public HttpListenerContext GetContext() => default; // 0x000000018670D6D0-0x000000018670D880
		// [XID] // 0x000000018987E2F0-0x000000018987E310
		public void Start() {} // 0x000000018670DE10-0x000000018670DF00
		// [XID] // 0x00000001897CE600-0x00000001897CE620
		public void Stop() {} // 0x000000018670DF00-0x000000018670E0D0
		// [XID] // 0x000000018988C840-0x000000018988C860
		void IDisposable.Dispose() {} // 0x000000018670E0D0-0x000000018670E180
	}
}
