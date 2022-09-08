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
	public class SByteFormatter : IMessagePackFormatter<sbyte> // TypeDefIndex: 8254
	{
		// Fields
		public static readonly SByteFormatter Instance; // 0x00
	
		// Constructors
		private SByteFormatter() {} // 0x00000001856EFAF0-0x00000001856EFB50
		static SByteFormatter() {} // 0x00000001856EFA30-0x00000001856EFAF0
	
		// Methods
		// [XID] // 0x0000000189A5BAD0-0x0000000189A5BAF0
		public int Serialize(ref byte[] bytes, int offset, sbyte value, IFormatterResolver formatterResolver) => default; // 0x00000001856EF910-0x00000001856EFA30
		// [XID] // 0x00000001896FF730-0x00000001896FF750
		public sbyte Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856EF7F0-0x00000001856EF910
	}
}
