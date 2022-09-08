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
	public class GuidFormatter : IMessagePackFormatter<Guid> // TypeDefIndex: 8270
	{
		// Fields
		public static readonly IMessagePackFormatter<Guid> Instance; // 0x00
	
		// Constructors
		private GuidFormatter() {} // 0x00000001856CC960-0x00000001856CC9C0
		static GuidFormatter() {} // 0x00000001856CC8A0-0x00000001856CC960
	
		// Methods
		// [XID] // 0x0000000189805890-0x00000001898058B0
		public int Serialize(ref byte[] bytes, int offset, Guid value, IFormatterResolver formatterResolver) => default; // 0x00000001856CC770-0x00000001856CC8A0
		// [XID] // 0x00000001897EFB00-0x00000001897EFB20
		public Guid Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856CC610-0x00000001856CC770
	}
}
