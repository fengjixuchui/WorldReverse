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
	public class DateTimeOffsetFormatter : IMessagePackFormatter<DateTimeOffset> // TypeDefIndex: 8269
	{
		// Fields
		public static readonly IMessagePackFormatter<DateTimeOffset> Instance; // 0x00
	
		// Constructors
		private DateTimeOffsetFormatter() {} // 0x00000001856C9B40-0x00000001856C9BA0
		static DateTimeOffsetFormatter() {} // 0x00000001856C9A80-0x00000001856C9B40
	
		// Methods
		// [XID] // 0x00000001897D9420-0x00000001897D9440
		public int Serialize(ref byte[] bytes, int offset, DateTimeOffset value, IFormatterResolver formatterResolver) => default; // 0x00000001856C98A0-0x00000001856C9A80
		// [XID] // 0x0000000189B32500-0x0000000189B32520
		public DateTimeOffset Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C9480-0x00000001856C98A0
	}
}
