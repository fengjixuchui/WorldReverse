/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;
using MessagePack;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Formatters
{
	public class StringBuilderFormatter : IMessagePackFormatter<StringBuilder> // TypeDefIndex: 8274
	{
		// Fields
		public static readonly IMessagePackFormatter<StringBuilder> Instance; // 0x00
	
		// Constructors
		private StringBuilderFormatter() {} // 0x00000001856F0FF0-0x00000001856F1050
		static StringBuilderFormatter() {} // 0x00000001856F0F30-0x00000001856F0FF0
	
		// Methods
		// [XID] // 0x0000000189814DD0-0x0000000189814DF0
		public int Serialize(ref byte[] bytes, int offset, StringBuilder value, IFormatterResolver formatterResolver) => default; // 0x00000001856F0DC0-0x00000001856F0F30
		// [XID] // 0x000000018981C880-0x000000018981C8A0
		public StringBuilder Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F0C30-0x00000001856F0DC0
	}
}
