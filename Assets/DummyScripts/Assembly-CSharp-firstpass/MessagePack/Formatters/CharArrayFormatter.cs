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
	public class CharArrayFormatter : IMessagePackFormatter<char[]> // TypeDefIndex: 8259
	{
		// Fields
		public static readonly CharArrayFormatter Instance; // 0x00
	
		// Constructors
		private CharArrayFormatter() {} // 0x00000001856C85B0-0x00000001856C8610
		static CharArrayFormatter() {} // 0x00000001856C84F0-0x00000001856C85B0
	
		// Methods
		// [XID] // 0x000000018973C220-0x000000018973C240
		public int Serialize(ref byte[] bytes, int offset, char[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856C8320-0x00000001856C84F0
		// [XID] // 0x000000018974A270-0x000000018974A290
		public char[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C8110-0x00000001856C8320
	}
}
