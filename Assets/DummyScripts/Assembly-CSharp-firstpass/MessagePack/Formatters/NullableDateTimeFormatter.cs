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
	public class NullableDateTimeFormatter : IMessagePackFormatter<DateTime?> // TypeDefIndex: 8261
	{
		// Fields
		public static readonly NullableDateTimeFormatter Instance; // 0x00
	
		// Constructors
		private NullableDateTimeFormatter() {} // 0x00000001856E7470-0x00000001856E74D0
		static NullableDateTimeFormatter() {} // 0x00000001856E73B0-0x00000001856E7470
	
		// Methods
		// [XID] // 0x0000000189760750-0x0000000189760770
		public int Serialize(ref byte[] bytes, int offset, DateTime? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E7200-0x00000001856E73B0
		// [XID] // 0x0000000189767A70-0x0000000189767A90
		public DateTime? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E6E90-0x00000001856E7200
	}
}
