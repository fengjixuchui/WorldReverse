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
	public class UInt64Formatter : IMessagePackFormatter<ulong> // TypeDefIndex: 8240
	{
		// Fields
		public static readonly UInt64Formatter Instance; // 0x00
	
		// Constructors
		private UInt64Formatter() {} // 0x00000001856F48C0-0x00000001856F4920
		static UInt64Formatter() {} // 0x00000001856F4800-0x00000001856F48C0
	
		// Methods
		// [XID] // 0x0000000189627150-0x0000000189627170
		public int Serialize(ref byte[] bytes, int offset, ulong value, IFormatterResolver formatterResolver) => default; // 0x00000001856F46E0-0x00000001856F4800
		// [XID] // 0x000000018962EA10-0x000000018962EA30
		public ulong Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F45C0-0x00000001856F46E0
	}
}
