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
	public class Int16Formatter : IMessagePackFormatter<short> // TypeDefIndex: 8225
	{
		// Fields
		public static readonly Int16Formatter Instance; // 0x00
	
		// Constructors
		private Int16Formatter() {} // 0x00000001856CF520-0x00000001856CF580
		static Int16Formatter() {} // 0x00000001856CF460-0x00000001856CF520
	
		// Methods
		// [XID] // 0x0000000189B42410-0x0000000189B42430
		public int Serialize(ref byte[] bytes, int offset, short value, IFormatterResolver formatterResolver) => default; // 0x00000001856CF340-0x00000001856CF460
		// [XID] // 0x0000000189B352A0-0x0000000189B352C0
		public short Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856CF220-0x00000001856CF340
	}
}
