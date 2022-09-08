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
	public class NullableInt32Formatter : IMessagePackFormatter<int?> // TypeDefIndex: 8229
	{
		// Fields
		public static readonly NullableInt32Formatter Instance; // 0x00
	
		// Constructors
		private NullableInt32Formatter() {} // 0x00000001856E8130-0x00000001856E8190
		static NullableInt32Formatter() {} // 0x00000001856E8070-0x00000001856E8130
	
		// Methods
		// [XID] // 0x000000018997F6D0-0x000000018997F6F0
		public int Serialize(ref byte[] bytes, int offset, int? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E7EF0-0x00000001856E8070
		// [XID] // 0x0000000189B85A40-0x0000000189B85A60
		public int? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E7D60-0x00000001856E7EF0
	}
}
