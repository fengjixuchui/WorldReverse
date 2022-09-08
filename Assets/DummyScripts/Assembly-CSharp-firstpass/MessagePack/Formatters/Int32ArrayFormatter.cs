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
	public class Int32ArrayFormatter : IMessagePackFormatter<int[]> // TypeDefIndex: 8230
	{
		// Fields
		public static readonly Int32ArrayFormatter Instance; // 0x00
	
		// Constructors
		private Int32ArrayFormatter() {} // 0x00000001856D0120-0x00000001856D0180
		static Int32ArrayFormatter() {} // 0x00000001856D0060-0x00000001856D0120
	
		// Methods
		// [XID] // 0x0000000189B8C8D0-0x0000000189B8C8F0
		public int Serialize(ref byte[] bytes, int offset, int[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856CFE90-0x00000001856D0060
		// [XID] // 0x0000000189B941F0-0x0000000189B94210
		public int[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856CFC80-0x00000001856CFE90
	}
}
