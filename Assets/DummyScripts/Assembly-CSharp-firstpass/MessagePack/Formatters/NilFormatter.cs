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
	public class NilFormatter : IMessagePackFormatter<Nil> // TypeDefIndex: 8431
	{
		// Fields
		public static readonly IMessagePackFormatter<Nil> Instance; // 0x00
	
		// Constructors
		private NilFormatter() {} // 0x00000001856E5FA0-0x00000001856E6000
		static NilFormatter() {} // 0x00000001856E5EE0-0x00000001856E5FA0
	
		// Methods
		// [XID] // 0x0000000189A79370-0x0000000189A79390
		public int Serialize(ref byte[] bytes, int offset, Nil value, IFormatterResolver typeResolver) => default; // 0x00000001856E5DD0-0x00000001856E5EE0
		// [XID] // 0x00000001899ED000-0x00000001899ED020
		public Nil Deserialize(byte[] bytes, int offset, IFormatterResolver typeResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856E5CB0-0x00000001856E5DD0
	}
}
