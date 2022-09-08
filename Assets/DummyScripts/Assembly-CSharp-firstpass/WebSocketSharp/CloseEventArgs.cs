/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs // TypeDefIndex: 10214
	{
		// Fields
		private bool _clean; // 0x10
		private PayloadData _payloadData; // 0x18
	
		// Properties
		public ushort Code { /* [XID] */ /* 0x00000001897C56F0-0x00000001897C5710 */ get => default; } // 0x0000000186E943E0-0x0000000186E94490 
		public string Reason { /* [XID] */ /* 0x00000001899FD670-0x00000001899FD690 */ get => default; } // 0x0000000186E94490-0x0000000186E94540 
		public bool WasClean { /* [XID] */ /* 0x0000000189810660-0x0000000189810680 */ get => default; } // 0x0000000186E94540-0x0000000186E945E0 
	
		// Constructors
		public CloseEventArgs() {} // Dummy constructor
		internal CloseEventArgs(PayloadData payloadData, bool clean) {} // 0x0000000186E94270-0x0000000186E94310
		internal CloseEventArgs(ushort code, string reason, bool clean) {} // 0x0000000186E94310-0x0000000186E943E0
	}
}
