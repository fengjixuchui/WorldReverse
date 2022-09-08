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
	public class NullableSingleFormatter : IMessagePackFormatter<float?> // TypeDefIndex: 8244
	{
		// Fields
		public static readonly NullableSingleFormatter Instance; // 0x00
	
		// Constructors
		private NullableSingleFormatter() {} // 0x00000001856E9160-0x00000001856E91C0
		static NullableSingleFormatter() {} // 0x00000001856E90A0-0x00000001856E9160
	
		// Methods
		// [XID] // 0x0000000189707AD0-0x0000000189707AF0
		public int Serialize(ref byte[] bytes, int offset, float? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E8F20-0x00000001856E90A0
		// [XID] // 0x000000018966AAE0-0x000000018966AB00
		public float? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E8D90-0x00000001856E8F20
	}
}
