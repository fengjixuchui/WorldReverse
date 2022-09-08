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
	public class TimeSpanFormatter : IMessagePackFormatter<TimeSpan> // TypeDefIndex: 8268
	{
		// Fields
		public static readonly IMessagePackFormatter<TimeSpan> Instance; // 0x00
	
		// Constructors
		private TimeSpanFormatter() {} // 0x00000001856F1380-0x00000001856F13E0
		static TimeSpanFormatter() {} // 0x00000001856F12C0-0x00000001856F1380
	
		// Methods
		// [XID] // 0x0000000189A1B770-0x0000000189A1B790
		public int Serialize(ref byte[] bytes, int offset, TimeSpan value, IFormatterResolver formatterResolver) => default; // 0x00000001856F1190-0x00000001856F12C0
		// [XID] // 0x00000001897D1560-0x00000001897D1580
		public TimeSpan Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F1050-0x00000001856F1190
	}
}
