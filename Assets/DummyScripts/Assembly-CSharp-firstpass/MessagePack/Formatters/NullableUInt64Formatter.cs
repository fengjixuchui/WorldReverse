/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class NullableUInt64Formatter : IMessagePackFormatter<ulong?> // TypeDefIndex: 8241
	{
		// Fields
		public static readonly NullableUInt64Formatter Instance; // 0x00
	
		// Constructors
		private NullableUInt64Formatter() {} // 0x00000001856EA690-0x00000001856EA6F0
		static NullableUInt64Formatter() {} // 0x00000001856EA5D0-0x00000001856EA690
	
		// Methods
		// [XID] // 0x0000000189636720-0x0000000189636740
		public int Serialize(ref byte[] bytes, int offset, ulong? value, IFormatterResolver formatterResolver) => default; // 0x00000001856EA450-0x00000001856EA5D0
		// [XID] // 0x00000001898C5520-0x00000001898C5540
		public ulong? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856EA290-0x00000001856EA450
	}
}
