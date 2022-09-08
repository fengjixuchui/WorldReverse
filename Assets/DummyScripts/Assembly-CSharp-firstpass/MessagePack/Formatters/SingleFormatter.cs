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
	public class SingleFormatter : IMessagePackFormatter<float> // TypeDefIndex: 8243
	{
		// Fields
		public static readonly SingleFormatter Instance; // 0x00
	
		// Constructors
		private SingleFormatter() {} // 0x00000001856F0370-0x00000001856F03D0
		static SingleFormatter() {} // 0x00000001856F02B0-0x00000001856F0370
	
		// Methods
		// [XID] // 0x00000001896541B0-0x00000001896541D0
		public int Serialize(ref byte[] bytes, int offset, float value, IFormatterResolver formatterResolver) => default; // 0x00000001856F0190-0x00000001856F02B0
		// [XID] // 0x000000018965BC70-0x000000018965BC90
		public float Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856F0060-0x00000001856F0190
	}
}
