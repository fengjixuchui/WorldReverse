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
	public class NullableStringArrayFormatter : IMessagePackFormatter<string[]> // TypeDefIndex: 8266
	{
		// Fields
		public static readonly NullableStringArrayFormatter Instance; // 0x00
	
		// Constructors
		private NullableStringArrayFormatter() {} // 0x00000001856E9680-0x00000001856E96E0
		static NullableStringArrayFormatter() {} // 0x00000001856E95C0-0x00000001856E9680
	
		// Methods
		// [XID] // 0x00000001897AB040-0x00000001897AB060
		public int Serialize(ref byte[] bytes, int offset, string[] value, IFormatterResolver typeResolver) => default; // 0x00000001856E93F0-0x00000001856E95C0
		// [XID] // 0x0000000189A144C0-0x0000000189A144E0
		public string[] Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E91C0-0x00000001856E93F0
	}
}
