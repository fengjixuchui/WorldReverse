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
	public class SingleArrayFormatter : IMessagePackFormatter<float[]> // TypeDefIndex: 8245
	{
		// Fields
		public static readonly SingleArrayFormatter Instance; // 0x00
	
		// Constructors
		private SingleArrayFormatter() {} // 0x00000001856F0000-0x00000001856F0060
		static SingleArrayFormatter() {} // 0x00000001856EFF40-0x00000001856F0000
	
		// Methods
		// [XID] // 0x00000001896727A0-0x00000001896727C0
		public int Serialize(ref byte[] bytes, int offset, float[] value, IFormatterResolver formatterResolver) => default; // 0x00000001856EFD70-0x00000001856EFF40
		// [XID] // 0x0000000189B1A510-0x0000000189B1A530
		public float[] Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856EFB50-0x00000001856EFD70
	}
}
