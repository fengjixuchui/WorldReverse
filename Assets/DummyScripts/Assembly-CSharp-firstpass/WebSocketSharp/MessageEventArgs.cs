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
	public class MessageEventArgs : EventArgs // TypeDefIndex: 10237
	{
		// Fields
		private string _data; // 0x10
		private bool _dataSet; // 0x18
		private Opcode _opcode; // 0x19
		private byte[] _rawData; // 0x20
	
		// Properties
		internal Opcode Opcode { /* [XID] */ /* 0x00000001895EFC00-0x00000001895EFC20 */ get => default; } // 0x00000001867152E0-0x0000000186715380 
		public string Data { /* [XID] */ /* 0x0000000189603500-0x0000000189603520 */ get => default; } // 0x0000000186715020-0x00000001867150D0 
		public bool IsBinary { /* [XID] */ /* 0x00000001895F97E0-0x00000001895F9800 */ get => default; } // 0x00000001867150D0-0x0000000186715180 
		public bool IsPing { /* [XID] */ /* 0x00000001897373E0-0x0000000189737400 */ get => default; } // 0x0000000186715180-0x0000000186715230 
		public bool IsText { /* [XID] */ /* 0x0000000189619C70-0x0000000189619C90 */ get => default; } // 0x0000000186715230-0x00000001867152E0 
		public byte[] RawData { /* [XID] */ /* 0x0000000189846AB0-0x0000000189846AD0 */ get => default; } // 0x0000000186715380-0x0000000186715430 
	
		// Constructors
		public MessageEventArgs() {} // Dummy constructor
		internal MessageEventArgs(WebSocketFrame frame) {} // 0x0000000186714F50-0x0000000186715020
		internal MessageEventArgs(Opcode opcode, byte[] rawData) {} // 0x0000000186714E20-0x0000000186714F50
	
		// Methods
		// [XID] // 0x0000000189628920-0x0000000189628940
		private void setData() {} // 0x0000000186715430-0x0000000186715530
	}
}
