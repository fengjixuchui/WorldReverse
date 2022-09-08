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
	public class ByteArrayFormatter : IMessagePackFormatter<byte[]> // TypeDefIndex: 8264
	{
		// Fields
		public static readonly ByteArrayFormatter Instance; // 0x00
	
		// Constructors
		private ByteArrayFormatter() {} // 0x00000001856C78B0-0x00000001856C7910
		static ByteArrayFormatter() {} // 0x00000001856C77F0-0x00000001856C78B0
	
		// Methods
		// [XID] // 0x00000001897E0AB0-0x00000001897E0AD0
		public int Serialize(ref byte[] bytes, int offset, byte[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856C76D0-0x00000001856C77F0
		// [XID] // 0x00000001896A1920-0x00000001896A1940
		public byte[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C75B0-0x00000001856C76D0
	}
}
