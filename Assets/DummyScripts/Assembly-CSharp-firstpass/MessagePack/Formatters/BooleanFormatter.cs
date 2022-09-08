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
	public class BooleanFormatter : IMessagePackFormatter<bool> // TypeDefIndex: 8249
	{
		// Fields
		public static readonly BooleanFormatter Instance; // 0x00
	
		// Constructors
		private BooleanFormatter() {} // 0x00000001856C5C90-0x00000001856C5CF0
		static BooleanFormatter() {} // 0x00000001856C5BD0-0x00000001856C5C90
	
		// Methods
		// [XID] // 0x00000001896AE270-0x00000001896AE290
		public int Serialize(ref byte[] bytes, int offset, bool value, IFormatterResolver formatterResolver) => default; // 0x00000001856C5AB0-0x00000001856C5BD0
		// [XID] // 0x00000001897A72B0-0x00000001897A72D0
		public bool Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C5990-0x00000001856C5AB0
	}
}
