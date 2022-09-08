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
	public class NullableInt64Formatter : IMessagePackFormatter<long?> // TypeDefIndex: 8232
	{
		// Fields
		public static readonly NullableInt64Formatter Instance; // 0x00
	
		// Constructors
		private NullableInt64Formatter() {} // 0x00000001856E8590-0x00000001856E85F0
		static NullableInt64Formatter() {} // 0x00000001856E84D0-0x00000001856E8590
	
		// Methods
		// [XID] // 0x0000000189BAA380-0x0000000189BAA3A0
		public int Serialize(ref byte[] bytes, int offset, long? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E8350-0x00000001856E84D0
		// [XID] // 0x0000000189BB1AE0-0x0000000189BB1B00
		public long? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E8190-0x00000001856E8350
	}
}
