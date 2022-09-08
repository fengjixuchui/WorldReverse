/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public class HttpDigestIdentity : GenericIdentity // TypeDefIndex: 10253
	{
		// Fields
		private NameValueCollection _parameters; // 0x20
	
		// Properties
		public string Algorithm { /* [XID] */ /* 0x00000001896A2920-0x00000001896A2940 */ get => default; } // 0x000000018670C060-0x000000018670C120 
		public string Cnonce { /* [XID] */ /* 0x00000001896A9C50-0x00000001896A9C70 */ get => default; } // 0x000000018670C120-0x000000018670C1E0 
		public string Nc { /* [XID] */ /* 0x00000001896B0B20-0x00000001896B0B40 */ get => default; } // 0x000000018670C1E0-0x000000018670C2A0 
		public string Nonce { /* [XID] */ /* 0x00000001896B8650-0x00000001896B8670 */ get => default; } // 0x000000018670C2A0-0x000000018670C360 
		public string Opaque { /* [XID] */ /* 0x00000001896BF740-0x00000001896BF760 */ get => default; } // 0x000000018670C360-0x000000018670C420 
		public string Qop { /* [XID] */ /* 0x00000001896C71B0-0x00000001896C71D0 */ get => default; } // 0x000000018670C420-0x000000018670C4E0 
		public string Realm { /* [XID] */ /* 0x000000018972ECD0-0x000000018972ECF0 */ get => default; } // 0x000000018670C4E0-0x000000018670C5A0 
		public string Response { /* [XID] */ /* 0x000000018974D070-0x000000018974D090 */ get => default; } // 0x000000018670C5A0-0x000000018670C660 
		public string Uri { /* [XID] */ /* 0x0000000189A3CF70-0x0000000189A3CF90 */ get => default; } // 0x000000018670C660-0x000000018670C720 
	
		// Constructors
		public HttpDigestIdentity() {} // Dummy constructor
		internal HttpDigestIdentity(NameValueCollection parameters) {} // 0x000000018670BFC0-0x000000018670C060
	
		// Methods
		// [XID] // 0x00000001895F4270-0x00000001895F4290
		internal bool IsValid(string password, string realm, string method, string entity) => default; // 0x000000018670BDE0-0x000000018670BFC0
	}
}
