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
	public class DateTimeFormatter : IMessagePackFormatter<DateTime> // TypeDefIndex: 8260
	{
		// Fields
		public static readonly DateTimeFormatter Instance; // 0x00
	
		// Constructors
		private DateTimeFormatter() {} // 0x00000001856C9420-0x00000001856C9480
		static DateTimeFormatter() {} // 0x00000001856C9360-0x00000001856C9420
	
		// Methods
		// [XID] // 0x0000000189AA2130-0x0000000189AA2150
		public int Serialize(ref byte[] bytes, int offset, DateTime value, IFormatterResolver formatterResolver) => default; // 0x00000001856C9220-0x00000001856C9360
		// [XID] // 0x0000000189758A10-0x0000000189758A30
		public DateTime Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C8F30-0x00000001856C9220
	}
}
