/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class PrimitiveObjectFormatter : IMessagePackFormatter<object> // TypeDefIndex: 8263
	{
		// Fields
		public static readonly IMessagePackFormatter<object> Instance; // 0x00
		private static readonly Dictionary<System.Type, int> typeToJumpCode; // 0x08
	
		// Constructors
		private PrimitiveObjectFormatter() {} // 0x00000001856EC360-0x00000001856EC3C0
		static PrimitiveObjectFormatter() {} // 0x00000001856EBFD0-0x00000001856EC360
	
		// Methods
		// [XID] // 0x00000001895EE9C0-0x00000001895EE9E0
		public int Serialize(ref byte[] bytes, int offset, object value, IFormatterResolver formatterResolver) => default; // 0x00000001856EB0D0-0x00000001856EBFD0
		// [XID] // 0x0000000189692E90-0x0000000189692EB0
		public object Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856EA6F0-0x00000001856EB0D0
	}
}
