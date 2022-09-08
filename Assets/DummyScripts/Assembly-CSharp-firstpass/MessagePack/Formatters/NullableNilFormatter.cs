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
	public class NullableNilFormatter : IMessagePackFormatter<Nil?> // TypeDefIndex: 8432
	{
		// Fields
		public static readonly IMessagePackFormatter<Nil?> Instance; // 0x00
	
		// Constructors
		private NullableNilFormatter() {} // 0x00000001856E8900-0x00000001856E8960
		static NullableNilFormatter() {} // 0x00000001856E8840-0x00000001856E8900
	
		// Methods
		// [XID] // 0x0000000189A884C0-0x0000000189A884E0
		public int Serialize(ref byte[] bytes, int offset, Nil? value, IFormatterResolver typeResolver) => default; // 0x00000001856E8730-0x00000001856E8840
		// [XID] // 0x00000001899FC2E0-0x00000001899FC300
		public Nil? Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E85F0-0x00000001856E8730
	}
}
