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
	public class Int64Formatter : IMessagePackFormatter<long> // TypeDefIndex: 8231
	{
		// Fields
		public static readonly Int64Formatter Instance; // 0x00
	
		// Constructors
		private Int64Formatter() {} // 0x00000001856D1240-0x00000001856D12A0
		static Int64Formatter() {} // 0x00000001856D1180-0x00000001856D1240
	
		// Methods
		// [XID] // 0x0000000189B9B8C0-0x0000000189B9B8E0
		public int Serialize(ref byte[] bytes, int offset, long value, IFormatterResolver formatterResolver) => default; // 0x00000001856D1060-0x00000001856D1180
		// [XID] // 0x0000000189BA30E0-0x0000000189BA3100
		public long Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D0F40-0x00000001856D1060
	}
}
