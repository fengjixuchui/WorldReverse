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
	internal class AuthenticationResponse : AuthenticationBase // TypeDefIndex: 10240
	{
		// Fields
		private uint _nonceCount; // 0x20
	
		// Properties
		internal uint NonceCount { /* [XID] */ /* 0x00000001896AF660-0x00000001896AF680 */ get => default; } // 0x00000001866F9620-0x00000001866F96D0 
		public string Cnonce { /* [XID] */ /* 0x00000001896B6E10-0x00000001896B6E30 */ get => default; } // 0x00000001866F94A0-0x00000001866F9560 
		public string Nc { /* [XID] */ /* 0x000000018964DFA0-0x000000018964DFC0 */ get => default; } // 0x00000001866F9560-0x00000001866F9620 
		public string Password { /* [XID] */ /* 0x00000001896C5870-0x00000001896C5890 */ get => default; } // 0x00000001866F96D0-0x00000001866F9790 
		public string Response { /* [XID] */ /* 0x00000001896CCF00-0x00000001896CCF20 */ get => default; } // 0x00000001866F9790-0x00000001866F9850 
		public string Uri { /* [XID] */ /* 0x00000001896D4260-0x00000001896D4280 */ get => default; } // 0x00000001866F9850-0x00000001866F9910 
		public string UserName { /* [XID] */ /* 0x00000001896DBAA0-0x00000001896DBAC0 */ get => default; } // 0x00000001866F9910-0x00000001866F99D0 
	
		// Constructors
		public AuthenticationResponse() {} // Dummy constructor
		private AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters) {} // 0x00000001866F8F20-0x00000001866F8FA0
		internal AuthenticationResponse(NetworkCredential credentials) {} // 0x00000001866F8FA0-0x00000001866F9050
		internal AuthenticationResponse(AuthenticationChallenge challenge, NetworkCredential credentials, uint nonceCount) {} // 0x00000001866F8D20-0x00000001866F8DE0
		internal AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters, NetworkCredential credentials, uint nonceCount) {} // 0x00000001866F8DE0-0x00000001866F8F20
	
		// Methods
		// [IDTag] // 0x00000001896E3220-0x00000001896E3260
		// [XID] // 0x00000001896E3220-0x00000001896E3260
		private static string createA1(string username, string password, string realm) => default; // 0x00000001866F9050-0x00000001866F9150
		// [IDTag] // 0x00000001896ED4E0-0x00000001896ED520
		// [XID] // 0x00000001896ED4E0-0x00000001896ED520
		private static string createA1(string username, string password, string realm, string nonce, string cnonce) => default; // 0x00000001866F9150-0x00000001866F92A0
		// [IDTag] // 0x00000001896F7AF0-0x00000001896F7B30
		// [XID] // 0x00000001896F7AF0-0x00000001896F7B30
		private static string createA2(string method, string uri) => default; // 0x00000001866F93B0-0x00000001866F94A0
		// [IDTag] // 0x0000000189702340-0x0000000189702380
		// [XID] // 0x0000000189702340-0x0000000189702380
		private static string createA2(string method, string uri, string entity) => default; // 0x00000001866F92A0-0x00000001866F93B0
		// [XID] // 0x000000018970C8A0-0x000000018970C8C0
		private static string hash(string value) => default; // 0x00000001866F99D0-0x00000001866F9BB0
		// [XID] // 0x00000001898C1BB0-0x00000001898C1BD0
		private void initAsDigest() {} // 0x00000001866F9BB0-0x00000001866F9EC0
		// [XID] // 0x0000000189919940-0x0000000189919960
		internal static string CreateRequestDigest(NameValueCollection parameters) => default; // 0x00000001866F7B20-0x00000001866F8060
		// [XID] // 0x00000001898DA860-0x00000001898DA880
		internal static AuthenticationResponse Parse(string value) => default; // 0x00000001866F82A0-0x00000001866F8500
		// [XID] // 0x000000018972A5F0-0x000000018972A610
		internal static NameValueCollection ParseBasicCredentials(string value) => default; // 0x00000001866F8060-0x00000001866F82A0
		// [XID] // 0x0000000189A76C20-0x0000000189A76C40
		internal override string ToBasicString() => default; // 0x00000001866F8500-0x00000001866F86C0
		// [XID] // 0x0000000189739380-0x00000001897393A0
		internal override string ToDigestString() => default; // 0x00000001866F86C0-0x00000001866F8B00
		// [XID] // 0x00000001897410C0-0x00000001897410E0
		public IIdentity ToIdentity() => default; // 0x00000001866F8B00-0x00000001866F8C60
	}
}
