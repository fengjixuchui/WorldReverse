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
	public class Int32Formatter : IMessagePackFormatter<int> // TypeDefIndex: 8228
	{
		// Fields
		public static readonly Int32Formatter Instance; // 0x00
	
		// Constructors
		private Int32Formatter() {} // 0x00000001856D0480-0x00000001856D04E0
		static Int32Formatter() {} // 0x00000001856D03C0-0x00000001856D0480
	
		// Methods
		// [XID] // 0x0000000189B6F120-0x0000000189B6F140
		public int Serialize(ref byte[] bytes, int offset, int value, IFormatterResolver formatterResolver) => default; // 0x00000001856D02A0-0x00000001856D03C0
		// [XID] // 0x0000000189B767A0-0x0000000189B767C0
		public int Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856D0180-0x00000001856D02A0
	}
}
