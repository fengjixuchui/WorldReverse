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
	public class UInt32Formatter : IMessagePackFormatter<uint> // TypeDefIndex: 8237
	{
		// Fields
		public static readonly UInt32Formatter Instance; // 0x00
	
		// Constructors
		private UInt32Formatter() {} // 0x00000001856F3490-0x00000001856F34F0
		static UInt32Formatter() {} // 0x00000001856F33D0-0x00000001856F3490
	
		// Methods
		// [XID] // 0x00000001895FA460-0x00000001895FA480
		public int Serialize(ref byte[] bytes, int offset, uint value, IFormatterResolver formatterResolver) => default; // 0x00000001856F32B0-0x00000001856F33D0
		// [XID] // 0x00000001895F0340-0x00000001895F0360
		public uint Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F3190-0x00000001856F32B0
	}
}
