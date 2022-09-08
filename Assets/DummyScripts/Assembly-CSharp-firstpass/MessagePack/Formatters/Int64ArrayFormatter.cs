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
	public class Int64ArrayFormatter : IMessagePackFormatter<long[]> // TypeDefIndex: 8233
	{
		// Fields
		public static readonly Int64ArrayFormatter Instance; // 0x00
	
		// Constructors
		private Int64ArrayFormatter() {} // 0x00000001856D0EE0-0x00000001856D0F40
		static Int64ArrayFormatter() {} // 0x00000001856D0E20-0x00000001856D0EE0
	
		// Methods
		// [XID] // 0x0000000189BB8C00-0x0000000189BB8C20
		public int Serialize(ref byte[] bytes, int offset, long[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856D0C50-0x00000001856D0E20
		// [XID] // 0x0000000189BC05E0-0x0000000189BC0600
		public long[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D0A40-0x00000001856D0C50
	}
}
