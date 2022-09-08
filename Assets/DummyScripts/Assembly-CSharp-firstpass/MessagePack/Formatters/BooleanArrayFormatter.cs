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
	public class BooleanArrayFormatter : IMessagePackFormatter<bool[]> // TypeDefIndex: 8251
	{
		// Fields
		public static readonly BooleanArrayFormatter Instance; // 0x00
	
		// Constructors
		private BooleanArrayFormatter() {} // 0x00000001856C5930-0x00000001856C5990
		static BooleanArrayFormatter() {} // 0x00000001856C5870-0x00000001856C5930
	
		// Methods
		// [XID] // 0x00000001896CB5C0-0x00000001896CB5E0
		public int Serialize(ref byte[] bytes, int offset, bool[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856C56A0-0x00000001856C5870
		// [XID] // 0x00000001897FAB90-0x00000001897FABB0
		public bool[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C5490-0x00000001856C56A0
	}
}
