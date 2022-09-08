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
	public class NullableDoubleFormatter : IMessagePackFormatter<double?> // TypeDefIndex: 8247
	{
		// Fields
		public static readonly NullableDoubleFormatter Instance; // 0x00
	
		// Constructors
		private NullableDoubleFormatter() {} // 0x00000001856E78E0-0x00000001856E7940
		static NullableDoubleFormatter() {} // 0x00000001856E7820-0x00000001856E78E0
	
		// Methods
		// [XID] // 0x0000000189690CE0-0x0000000189690D00
		public int Serialize(ref byte[] bytes, int offset, double? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E7690-0x00000001856E7820
		// [XID] // 0x0000000189B84940-0x0000000189B84960
		public double? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E74D0-0x00000001856E7690
	}
}
