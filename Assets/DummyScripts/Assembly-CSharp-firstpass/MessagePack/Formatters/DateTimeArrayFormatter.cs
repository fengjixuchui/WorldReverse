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
	public class DateTimeArrayFormatter : IMessagePackFormatter<DateTime[]> // TypeDefIndex: 8262
	{
		// Fields
		public static readonly DateTimeArrayFormatter Instance; // 0x00
	
		// Constructors
		private DateTimeArrayFormatter() {} // 0x00000001856C8E20-0x00000001856C8E80
		static DateTimeArrayFormatter() {} // 0x00000001856C8D60-0x00000001856C8E20
	
		// Methods
		// [XID] // 0x000000018976F120-0x000000018976F140
		public int Serialize(ref byte[] bytes, int offset, DateTime[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856C8B90-0x00000001856C8D60
		// [XID] // 0x0000000189776C20-0x0000000189776C40
		public DateTime[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C8970-0x00000001856C8B90
	}
}
