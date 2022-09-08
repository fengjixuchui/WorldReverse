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
	public class NullableInt16Formatter : IMessagePackFormatter<short?> // TypeDefIndex: 8226
	{
		// Fields
		public static readonly NullableInt16Formatter Instance; // 0x00
	
		// Constructors
		private NullableInt16Formatter() {} // 0x00000001856E7D00-0x00000001856E7D60
		static NullableInt16Formatter() {} // 0x00000001856E7C40-0x00000001856E7D00
	
		// Methods
		// [XID] // 0x0000000189B044A0-0x0000000189B044C0
		public int Serialize(ref byte[] bytes, int offset, short? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E7AC0-0x00000001856E7C40
		// [XID] // 0x0000000189B58FC0-0x0000000189B58FE0
		public short? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E7940-0x00000001856E7AC0
	}
}
