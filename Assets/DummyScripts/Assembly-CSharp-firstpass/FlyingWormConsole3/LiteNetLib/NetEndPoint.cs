/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public sealed class NetEndPoint // TypeDefIndex: 6907
	{
		// Fields
		internal readonly IPEndPoint EndPoint; // 0x10
	
		// Properties
		public string Host { /* [XID] */ /* 0x00000001899FF090-0x00000001899FF0B0 */ get => default; } // 0x00000001863C27E0-0x00000001863C28B0 
		public int Port { /* [XID] */ /* 0x0000000189A460E0-0x0000000189A46100 */ get => default; } // 0x00000001863C28B0-0x00000001863C2960 
	
		// Constructors
		public NetEndPoint() {} // Dummy constructor
		internal NetEndPoint(IPEndPoint ipEndPoint) {} // 0x00000001863C2770-0x00000001863C27E0
		public NetEndPoint(string hostStr, int port) {} // 0x00000001863C2530-0x00000001863C2770
	
		// Methods
		// [XID] // 0x0000000189A0DF60-0x0000000189A0DF80
		public override bool Equals(object obj) => default; // 0x00000001863C1D90-0x00000001863C1EC0
		// [XID] // 0x0000000189A15550-0x0000000189A15570
		public override string ToString() => default; // 0x00000001863C2310-0x00000001863C23D0
		// [XID] // 0x000000018979A410-0x000000018979A430
		public override int GetHashCode() => default; // 0x00000001863C1EC0-0x00000001863C1F80
		// [XID] // 0x0000000189A24070-0x0000000189A24090
		private IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily) => default; // 0x00000001863C21A0-0x00000001863C2310
		// [XID] // 0x00000001897C88B0-0x00000001897C88D0
		internal long GetId() => default; // 0x00000001863C1F80-0x00000001863C21A0
	}
}
