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
	public class UInt64ArrayFormatter : IMessagePackFormatter<ulong[]> // TypeDefIndex: 8242
	{
		// Fields
		public static readonly UInt64ArrayFormatter Instance; // 0x00
	
		// Constructors
		private UInt64ArrayFormatter() {} // 0x00000001856F4560-0x00000001856F45C0
		static UInt64ArrayFormatter() {} // 0x00000001856F44A0-0x00000001856F4560
	
		// Methods
		// [XID] // 0x00000001899545E0-0x0000000189954600
		public int Serialize(ref byte[] bytes, int offset, ulong[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856F42D0-0x00000001856F44A0
		// [XID] // 0x000000018964CE10-0x000000018964CE30
		public ulong[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F40C0-0x00000001856F42D0
	}
}
