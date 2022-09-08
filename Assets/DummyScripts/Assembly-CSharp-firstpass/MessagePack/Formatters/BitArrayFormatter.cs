/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class BitArrayFormatter : IMessagePackFormatter<BitArray> // TypeDefIndex: 8275
	{
		// Fields
		public static readonly IMessagePackFormatter<BitArray> Instance; // 0x00
	
		// Constructors
		private BitArrayFormatter() {} // 0x00000001856C5430-0x00000001856C5490
		static BitArrayFormatter() {} // 0x00000001856C5370-0x00000001856C5430
	
		// Methods
		// [XID] // 0x0000000189823D40-0x0000000189823D60
		public int Serialize(ref byte[] bytes, int offset, BitArray value, IFormatterResolver formatterResolver) => default; // 0x00000001856C51A0-0x00000001856C5370
		// [XID] // 0x000000018982B820-0x000000018982B840
		public BitArray Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C4F90-0x00000001856C51A0
	}
}
