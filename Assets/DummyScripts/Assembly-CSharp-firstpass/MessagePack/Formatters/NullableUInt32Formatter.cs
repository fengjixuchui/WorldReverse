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
	public class NullableUInt32Formatter : IMessagePackFormatter<uint?> // TypeDefIndex: 8238
	{
		// Fields
		public static readonly NullableUInt32Formatter Instance; // 0x00
	
		// Constructors
		private NullableUInt32Formatter() {} // 0x00000001856EA230-0x00000001856EA290
		static NullableUInt32Formatter() {} // 0x00000001856EA170-0x00000001856EA230
	
		// Methods
		// [XID] // 0x0000000189609620-0x0000000189609640
		public int Serialize(ref byte[] bytes, int offset, uint? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E9FF0-0x00000001856EA170
		// [XID] // 0x0000000189610E40-0x0000000189610E60
		public uint? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E9E60-0x00000001856E9FF0
	}
}
