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
	public class Int16ArrayFormatter : IMessagePackFormatter<short[]> // TypeDefIndex: 8227
	{
		// Fields
		public static readonly Int16ArrayFormatter Instance; // 0x00
	
		// Constructors
		private Int16ArrayFormatter() {} // 0x00000001856CF1C0-0x00000001856CF220
		static Int16ArrayFormatter() {} // 0x00000001856CF100-0x00000001856CF1C0
	
		// Methods
		// [XID] // 0x0000000189B60600-0x0000000189B60620
		public int Serialize(ref byte[] bytes, int offset, short[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856CEF30-0x00000001856CF100
		// [XID] // 0x000000018985ED10-0x000000018985ED30
		public short[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856CED20-0x00000001856CEF30
	}
}
