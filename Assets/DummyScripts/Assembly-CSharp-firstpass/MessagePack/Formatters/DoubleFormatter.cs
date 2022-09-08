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
	public class DoubleFormatter : IMessagePackFormatter<double> // TypeDefIndex: 8246
	{
		// Fields
		public static readonly DoubleFormatter Instance; // 0x00
	
		// Constructors
		private DoubleFormatter() {} // 0x00000001856CA800-0x00000001856CA860
		static DoubleFormatter() {} // 0x00000001856CA740-0x00000001856CA800
	
		// Methods
		// [XID] // 0x00000001899CFC00-0x00000001899CFC20
		public int Serialize(ref byte[] bytes, int offset, double value, IFormatterResolver formatterResolver) => default; // 0x00000001856CA620-0x00000001856CA740
		// [XID] // 0x00000001899BDA60-0x00000001899BDA80
		public double Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856CA4F0-0x00000001856CA620
	}
}
