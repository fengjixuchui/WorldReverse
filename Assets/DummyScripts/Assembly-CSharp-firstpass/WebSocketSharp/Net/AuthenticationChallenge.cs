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
	internal class AuthenticationChallenge : AuthenticationBase // TypeDefIndex: 10239
	{
		// Properties
		public string Domain { /* [XID] */ /* 0x0000000189B52C90-0x0000000189B52CB0 */ get => default; } // 0x00000001866F79A0-0x00000001866F7A60 
		public string Stale { /* [XID] */ /* 0x000000018967B380-0x000000018967B3A0 */ get => default; } // 0x00000001866F7A60-0x00000001866F7B20 
	
		// Constructors
		public AuthenticationChallenge() {} // Dummy constructor
		private AuthenticationChallenge(AuthenticationSchemes scheme, NameValueCollection parameters) {} // 0x00000001866F77E0-0x00000001866F7860
		internal AuthenticationChallenge(AuthenticationSchemes scheme, string realm) {} // 0x00000001866F7860-0x00000001866F79A0
	
		// Methods
		// [XID] // 0x000000018991C970-0x000000018991C990
		internal static AuthenticationChallenge CreateBasicChallenge(string realm) => default; // 0x00000001866F7020-0x00000001866F70F0
		// [XID] // 0x00000001898D0E20-0x00000001898D0E40
		internal static AuthenticationChallenge CreateDigestChallenge(string realm) => default; // 0x00000001866F70F0-0x00000001866F71C0
		// [XID] // 0x0000000189692530-0x0000000189692550
		internal static AuthenticationChallenge Parse(string value) => default; // 0x00000001866F71C0-0x00000001866F7420
		// [XID] // 0x0000000189905C00-0x0000000189905C20
		internal override string ToBasicString() => default; // 0x00000001866F7420-0x00000001866F7510
		// [XID] // 0x0000000189603160-0x0000000189603180
		internal override string ToDigestString() => default; // 0x00000001866F7510-0x00000001866F77E0
	}
}
