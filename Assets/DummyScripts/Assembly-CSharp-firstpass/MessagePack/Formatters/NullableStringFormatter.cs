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
	public class NullableStringFormatter : IMessagePackFormatter<string> // TypeDefIndex: 8265
	{
		// Fields
		public static readonly NullableStringFormatter Instance; // 0x00
	
		// Constructors
		private NullableStringFormatter() {} // 0x00000001856E99E0-0x00000001856E9A40
		static NullableStringFormatter() {} // 0x00000001856E9920-0x00000001856E99E0
	
		// Methods
		// [XID] // 0x00000001898CE320-0x00000001898CE340
		public int Serialize(ref byte[] bytes, int offset, string value, IFormatterResolver typeResolver) => default; // 0x00000001856E9800-0x00000001856E9920
		// [XID] // 0x00000001896BE970-0x00000001896BE990
		public string Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E96E0-0x00000001856E9800
	}
}
