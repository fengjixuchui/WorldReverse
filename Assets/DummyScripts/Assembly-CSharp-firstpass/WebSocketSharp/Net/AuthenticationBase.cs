/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal abstract class AuthenticationBase // TypeDefIndex: 10238
	{
		// Fields
		private AuthenticationSchemes _scheme; // 0x10
		internal NameValueCollection Parameters; // 0x18
	
		// Properties
		public string Algorithm { /* [XID] */ /* 0x00000001896301D0-0x00000001896301F0 */ get; } // 0x00000001866F6BC0-0x00000001866F6C80 
		public string Nonce { /* [XID] */ /* 0x00000001896A0C40-0x00000001896A0C60 */ get; } // 0x00000001866F6C80-0x00000001866F6D40 
		public string Opaque { /* [XID] */ /* 0x000000018963F0B0-0x000000018963F0D0 */ get; } // 0x00000001866F6D40-0x00000001866F6E00 
		public string Qop { /* [XID] */ /* 0x000000018973C760-0x000000018973C780 */ get; } // 0x00000001866F6E00-0x00000001866F6EC0 
		public string Realm { /* [XID] */ /* 0x00000001896EA6C0-0x00000001896EA6E0 */ get; } // 0x00000001866F6EC0-0x00000001866F6F80 
		public AuthenticationSchemes Scheme { /* [XID] */ /* 0x00000001896559F0-0x0000000189655A10 */ get; } // 0x00000001866F6F80-0x00000001866F7020 
	
		// Constructors
		protected AuthenticationBase() {} // Dummy constructor
		protected AuthenticationBase(AuthenticationSchemes scheme, NameValueCollection parameters) {} // 0x00000001866F6B40-0x00000001866F6BC0
	
		// Methods
		// [XID] // 0x000000018965D220-0x000000018965D240
		internal static string CreateNonceValue() => default; // 0x00000001866F6420-0x00000001866F65E0
		// [XID] // 0x0000000189664870-0x0000000189664890
		internal static NameValueCollection ParseParameters(string value) => default; // 0x00000001866F65E0-0x00000001866F69C0
		internal abstract string ToBasicString();
		internal abstract string ToDigestString();
		// [XID] // 0x0000000189B3C2B0-0x0000000189B3C2D0
		public override string ToString() => default; // 0x00000001866F69C0-0x00000001866F6AD0
	}
}
