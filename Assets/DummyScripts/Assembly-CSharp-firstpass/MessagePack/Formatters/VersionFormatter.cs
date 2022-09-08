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
	public class VersionFormatter : IMessagePackFormatter<Version> // TypeDefIndex: 8272
	{
		// Fields
		public static readonly IMessagePackFormatter<Version> Instance; // 0x00
	
		// Constructors
		private VersionFormatter() {} // 0x00000001856F68F0-0x00000001856F6950
		static VersionFormatter() {} // 0x00000001856F6830-0x00000001856F68F0
	
		// Methods
		// [XID] // 0x0000000189805F00-0x0000000189805F20
		public int Serialize(ref byte[] bytes, int offset, Version value, IFormatterResolver formatterResolver) => default; // 0x00000001856F66B0-0x00000001856F6830
		// [XID] // 0x00000001896206C0-0x00000001896206E0
		public Version Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F6520-0x00000001856F66B0
	}
}
