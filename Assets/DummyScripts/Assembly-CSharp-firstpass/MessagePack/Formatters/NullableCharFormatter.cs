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
	public class NullableCharFormatter : IMessagePackFormatter<char?> // TypeDefIndex: 8258
	{
		// Fields
		public static readonly NullableCharFormatter Instance; // 0x00
	
		// Constructors
		private NullableCharFormatter() {} // 0x00000001856E6E30-0x00000001856E6E90
		static NullableCharFormatter() {} // 0x00000001856E6D70-0x00000001856E6E30
	
		// Methods
		// [XID] // 0x0000000189733600-0x0000000189733620
		public int Serialize(ref byte[] bytes, int offset, char? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E6BF0-0x00000001856E6D70
		// [XID] // 0x000000018973AE90-0x000000018973AEB0
		public char? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E6A70-0x00000001856E6BF0
	}
}
