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
	public class UriFormatter : IMessagePackFormatter<Uri> // TypeDefIndex: 8271
	{
		// Fields
		public static readonly IMessagePackFormatter<Uri> Instance; // 0x00
	
		// Constructors
		private UriFormatter() {} // 0x00000001856F64C0-0x00000001856F6520
		static UriFormatter() {} // 0x00000001856F6400-0x00000001856F64C0
	
		// Methods
		// [XID] // 0x00000001897E7870-0x00000001897E7890
		public int Serialize(ref byte[] bytes, int offset, Uri value, IFormatterResolver formatterResolver) => default; // 0x00000001856F6260-0x00000001856F6400
		// [XID] // 0x0000000189920370-0x0000000189920390
		public Uri Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F60D0-0x00000001856F6260
	}
}
