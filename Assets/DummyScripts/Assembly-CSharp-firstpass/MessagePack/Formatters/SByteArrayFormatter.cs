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
	public class SByteArrayFormatter : IMessagePackFormatter<sbyte[]> // TypeDefIndex: 8256
	{
		// Fields
		public static readonly SByteArrayFormatter Instance; // 0x00
	
		// Constructors
		private SByteArrayFormatter() {} // 0x00000001856EF790-0x00000001856EF7F0
		static SByteArrayFormatter() {} // 0x00000001856EF6D0-0x00000001856EF790
	
		// Methods
		// [XID] // 0x0000000189715950-0x0000000189715970
		public int Serialize(ref byte[] bytes, int offset, sbyte[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856EF500-0x00000001856EF6D0
		// [XID] // 0x000000018993E010-0x000000018993E030
		public sbyte[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856EF2F0-0x00000001856EF500
	}
}
