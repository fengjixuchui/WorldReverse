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
	public class NullableBooleanFormatter : IMessagePackFormatter<bool?> // TypeDefIndex: 8250
	{
		// Fields
		public static readonly NullableBooleanFormatter Instance; // 0x00
	
		// Constructors
		private NullableBooleanFormatter() {} // 0x00000001856E65E0-0x00000001856E6640
		static NullableBooleanFormatter() {} // 0x00000001856E6520-0x00000001856E65E0
	
		// Methods
		// [XID] // 0x0000000189BBF120-0x0000000189BBF140
		public int Serialize(ref byte[] bytes, int offset, bool? value, IFormatterResolver formatterResolver) => default; // 0x00000001856E63A0-0x00000001856E6520
		// [XID] // 0x00000001896C4180-0x00000001896C41A0
		public bool? Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E6210-0x00000001856E63A0
	}
}
