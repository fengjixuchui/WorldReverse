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
	public class UInt16ArrayFormatter : IMessagePackFormatter<ushort[]> // TypeDefIndex: 8236
	{
		// Fields
		public static readonly UInt16ArrayFormatter Instance; // 0x00
	
		// Constructors
		private UInt16ArrayFormatter() {} // 0x00000001856F1A40-0x00000001856F1AA0
		static UInt16ArrayFormatter() {} // 0x00000001856F1980-0x00000001856F1A40
	
		// Methods
		// [XID] // 0x00000001895EB790-0x00000001895EB7B0
		public int Serialize(ref byte[] bytes, int offset, ushort[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856F17B0-0x00000001856F1980
		// [XID] // 0x00000001895F2B70-0x00000001895F2B90
		public ushort[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F15A0-0x00000001856F17B0
	}
}
