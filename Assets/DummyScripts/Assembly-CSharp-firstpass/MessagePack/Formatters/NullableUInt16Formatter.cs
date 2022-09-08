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
	public class NullableUInt16Formatter : IMessagePackFormatter<ushort?> // TypeDefIndex: 8235
	{
		// Fields
		public static readonly NullableUInt16Formatter Instance; // 0x00
	
		// Constructors
		private NullableUInt16Formatter() {} // 0x00000001856E9E00-0x00000001856E9E60
		static NullableUInt16Formatter() {} // 0x00000001856E9D40-0x00000001856E9E00
	
		// Methods
		// [XID] // 0x0000000189864EB0-0x0000000189864ED0
		public int Serialize(ref byte[] bytes, int offset, ushort? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E9BC0-0x00000001856E9D40
		// [XID] // 0x0000000189BDEC80-0x0000000189BDECA0
		public ushort? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E9A40-0x00000001856E9BC0
	}
}
