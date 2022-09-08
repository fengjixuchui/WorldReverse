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
	public class CharFormatter : IMessagePackFormatter<char> // TypeDefIndex: 8257
	{
		// Fields
		public static readonly CharFormatter Instance; // 0x00
	
		// Constructors
		private CharFormatter() {} // 0x00000001856C8910-0x00000001856C8970
		static CharFormatter() {} // 0x00000001856C8850-0x00000001856C8910
	
		// Methods
		// [XID] // 0x0000000189724840-0x0000000189724860
		public int Serialize(ref byte[] bytes, int offset, char value, IFormatterResolver formatterResolver) => default; // 0x00000001856C8730-0x00000001856C8850
		// [XID] // 0x000000018972BFB0-0x000000018972BFD0
		public char Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C8610-0x00000001856C8730
	}
}
