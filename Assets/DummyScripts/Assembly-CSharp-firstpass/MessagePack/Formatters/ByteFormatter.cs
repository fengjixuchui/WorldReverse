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
	public class ByteFormatter : IMessagePackFormatter<byte> // TypeDefIndex: 8252
	{
		// Fields
		public static readonly ByteFormatter Instance; // 0x00
	
		// Constructors
		private ByteFormatter() {} // 0x00000001856C80B0-0x00000001856C8110
		static ByteFormatter() {} // 0x00000001856C7FF0-0x00000001856C80B0
	
		// Methods
		// [XID] // 0x0000000189975590-0x00000001899755B0
		public int Serialize(ref byte[] bytes, int offset, byte value, IFormatterResolver formatterResolver) => default; // 0x00000001856C7ED0-0x00000001856C7FF0
		// [XID] // 0x0000000189A6AD20-0x0000000189A6AD40
		public byte Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C7DB0-0x00000001856C7ED0
	}
}
