/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public class NetworkCredential // TypeDefIndex: 10276
	{
		// Fields
		private string _domain; // 0x10
		private static readonly string[] _noRoles; // 0x00
		private string _password; // 0x18
		private string[] _roles; // 0x20
		private string _username; // 0x28
	
		// Properties
		public string Domain { /* [XID] */ /* 0x00000001899495B0-0x00000001899495D0 */ get => default; /* [XID] */ /* 0x00000001898618B0-0x00000001898618D0 */ internal set {} } // 0x0000000187182350-0x0000000187182430 0x0000000187182690-0x0000000187182740
		public string Password { /* [XID] */ /* 0x0000000189958570-0x0000000189958590 */ get => default; /* [XID] */ /* 0x00000001898691F0-0x0000000189869210 */ internal set {} } // 0x0000000187182430-0x0000000187182510 0x0000000187182740-0x00000001871827F0
		public string[] Roles { /* [XID] */ /* 0x00000001895ECC00-0x00000001895ECC20 */ get => default; /* [XID] */ /* 0x000000018996E780-0x000000018996E7A0 */ internal set {} } // 0x0000000187182510-0x00000001871825F0 0x00000001871827F0-0x00000001871828A0
		public string Username { /* [XID] */ /* 0x0000000189976390-0x00000001899763B0 */ get => default; /* [XID] */ /* 0x000000018997D660-0x000000018997D680 */ internal set {} } // 0x00000001871825F0-0x0000000187182690 0x00000001871828A0-0x0000000187182950
	
		// Constructors
		public NetworkCredential() {} // Dummy constructor
		static NetworkCredential() {} // 0x0000000187182120-0x00000001871821A0
		public NetworkCredential(string username, string password) {} // 0x00000001871822C0-0x0000000187182350
		public NetworkCredential(string username, string password, string domain, params /* 0x000000018989F6F0-0x000000018989F700 */ string[] roles) {} // 0x00000001871821A0-0x00000001871822C0
	}
}
