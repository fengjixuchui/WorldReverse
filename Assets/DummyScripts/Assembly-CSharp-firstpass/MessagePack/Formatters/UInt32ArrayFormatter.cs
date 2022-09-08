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
	public class UInt32ArrayFormatter : IMessagePackFormatter<uint[]> // TypeDefIndex: 8239
	{
		// Fields
		public static readonly UInt32ArrayFormatter Instance; // 0x00
	
		// Constructors
		private UInt32ArrayFormatter() {} // 0x00000001856F3130-0x00000001856F3190
		static UInt32ArrayFormatter() {} // 0x00000001856F3070-0x00000001856F3130
	
		// Methods
		// [XID] // 0x0000000189618350-0x0000000189618370
		public int Serialize(ref byte[] bytes, int offset, uint[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856F2EA0-0x00000001856F3070
		// [XID] // 0x00000001897E9CB0-0x00000001897E9CD0
		public uint[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F2C90-0x00000001856F2EA0
	}
}
