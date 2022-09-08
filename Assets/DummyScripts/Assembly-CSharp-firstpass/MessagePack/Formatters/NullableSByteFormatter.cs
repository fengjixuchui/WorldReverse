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
	public class NullableSByteFormatter : IMessagePackFormatter<sbyte?> // TypeDefIndex: 8255
	{
		// Fields
		public static readonly NullableSByteFormatter Instance; // 0x00
	
		// Constructors
		private NullableSByteFormatter() {} // 0x00000001856E8D30-0x00000001856E8D90
		static NullableSByteFormatter() {} // 0x00000001856E8C70-0x00000001856E8D30
	
		// Methods
		// [XID] // 0x0000000189706AE0-0x0000000189706B00
		public int Serialize(ref byte[] bytes, int offset, sbyte? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E8AF0-0x00000001856E8C70
		// [XID] // 0x000000018970E490-0x000000018970E4B0
		public sbyte? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E8960-0x00000001856E8AF0
	}
}
