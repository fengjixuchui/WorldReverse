/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp
{
	internal class PayloadData : IEnumerable<byte> // TypeDefIndex: 10290
	{
		// Fields
		private byte[] _data; // 0x10
		private long _extDataLength; // 0x18
		private long _length; // 0x20
		public static readonly PayloadData Empty; // 0x00
		public static readonly ulong MaxLength; // 0x08
	
		// Properties
		internal ushort Code { /* [XID] */ /* 0x00000001899AB6D0-0x00000001899AB6F0 */ get => default; } // 0x00000001857D4AF0-0x00000001857D4BF0 
		internal long ExtensionDataLength { /* [XID] */ /* 0x00000001899B3050-0x00000001899B3070 */ get => default; /* [XID] */ /* 0x000000018996A0F0-0x000000018996A110 */ set {} } // 0x00000001857D4BF0-0x00000001857D4C90 0x00000001857D5090-0x00000001857D5140
		internal bool HasReservedCode { /* [XID] */ /* 0x00000001899881D0-0x00000001899881F0 */ get => default; } // 0x00000001857D4DB0-0x00000001857D4EA0 
		internal string Reason { /* [XID] */ /* 0x00000001899C91C0-0x00000001899C91E0 */ get => default; } // 0x00000001857D4F40-0x00000001857D5090 
		public byte[] ApplicationData { /* [XID] */ /* 0x00000001899A6AB0-0x00000001899A6AD0 */ get => default; } // 0x00000001857D49E0-0x00000001857D4AF0 
		public byte[] ExtensionData { /* [XID] */ /* 0x0000000189662C70-0x0000000189662C90 */ get => default; } // 0x00000001857D4C90-0x00000001857D4DB0 
		public ulong Length { /* [XID] */ /* 0x00000001899DF6E0-0x00000001899DF700 */ get => default; } // 0x00000001857D4EA0-0x00000001857D4F40 
	
		// Constructors
		public PayloadData() {} // Dummy constructor
		static PayloadData() {} // 0x00000001857D46D0-0x00000001857D47F0
		internal PayloadData(byte[] data) {} // 0x00000001857D4880-0x00000001857D4910
		internal PayloadData(byte[] data, long length) {} // 0x00000001857D47F0-0x00000001857D4880
		internal PayloadData(ushort code, string reason) {} // 0x00000001857D4910-0x00000001857D49E0
	
		// Methods
		// [XID] // 0x00000001899E72B0-0x00000001899E72D0
		internal void Mask(byte[] key) {} // 0x00000001857D42E0-0x00000001857D4440
		[DebuggerHidden] // 0x00000001899EE6F0-0x00000001899EE730
		// [XID] // 0x00000001899EE6F0-0x00000001899EE730
		public IEnumerator<byte> GetEnumerator() => default; // 0x00000001857D41D0-0x00000001857D42E0
		// [XID] // 0x00000001899F8F10-0x00000001899F8F30
		public byte[] ToArray() => default; // 0x00000001857D44F0-0x00000001857D4590
		// [XID] // 0x00000001899F8D90-0x00000001899F8DB0
		public override string ToString() => default; // 0x00000001857D4590-0x00000001857D4660
		// [XID] // 0x00000001896249B0-0x00000001896249D0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001857D4440-0x00000001857D44F0
	}
}
