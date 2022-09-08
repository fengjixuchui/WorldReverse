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
	public class UInt16Formatter : IMessagePackFormatter<ushort> // TypeDefIndex: 8234
	{
		// Fields
		public static readonly UInt16Formatter Instance; // 0x00
	
		// Constructors
		private UInt16Formatter() {} // 0x00000001856F1DA0-0x00000001856F1E00
		static UInt16Formatter() {} // 0x00000001856F1CE0-0x00000001856F1DA0
	
		// Methods
		// [XID] // 0x0000000189788CF0-0x0000000189788D10
		public int Serialize(ref byte[] bytes, int offset, ushort value, IFormatterResolver formatterResolver) => default; // 0x00000001856F1BC0-0x00000001856F1CE0
		// [XID] // 0x0000000189BCFBD0-0x0000000189BCFBF0
		public ushort Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F1AA0-0x00000001856F1BC0
	}
}
