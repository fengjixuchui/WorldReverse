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
	public class NullableByteFormatter : IMessagePackFormatter<byte?> // TypeDefIndex: 8253
	{
		// Fields
		public static readonly NullableByteFormatter Instance; // 0x00
	
		// Constructors
		private NullableByteFormatter() {} // 0x00000001856E6A10-0x00000001856E6A70
		static NullableByteFormatter() {} // 0x00000001856E6950-0x00000001856E6A10
	
		// Methods
		// [XID] // 0x00000001896E92E0-0x00000001896E9300
		public int Serialize(ref byte[] bytes, int offset, byte? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E67D0-0x00000001856E6950
		// [XID] // 0x0000000189BD30D0-0x0000000189BD30F0
		public byte? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E6640-0x00000001856E67D0
	}
}
