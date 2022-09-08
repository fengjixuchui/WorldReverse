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
	public class ByteArraySegmentFormatter : IMessagePackFormatter<ArraySegment<byte>> // TypeDefIndex: 8193
	{
		// Fields
		public static readonly ByteArraySegmentFormatter Instance; // 0x00
	
		// Constructors
		private ByteArraySegmentFormatter() {} // 0x00000001856C7D50-0x00000001856C7DB0
		static ByteArraySegmentFormatter() {} // 0x00000001856C7C90-0x00000001856C7D50
	
		// Methods
		// [XID] // 0x0000000189B2BCA0-0x0000000189B2BCC0
		public int Serialize(ref byte[] bytes, int offset, ArraySegment<byte> value, IFormatterResolver formatterResolver) => default; // 0x00000001856C7AE0-0x00000001856C7C90
		// [XID] // 0x0000000189B33160-0x0000000189B33180
		public ArraySegment<byte> Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C7910-0x00000001856C7AE0
	}
}
