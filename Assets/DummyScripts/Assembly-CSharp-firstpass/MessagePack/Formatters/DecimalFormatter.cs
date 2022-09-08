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
	public class DecimalFormatter : IMessagePackFormatter<decimal> // TypeDefIndex: 8267
	{
		// Fields
		public static readonly DecimalFormatter Instance; // 0x00
	
		// Constructors
		private DecimalFormatter() {} // 0x00000001856C9F80-0x00000001856C9FE0
		static DecimalFormatter() {} // 0x00000001856C9EC0-0x00000001856C9F80
	
		// Methods
		// [XID] // 0x00000001897BAA70-0x00000001897BAA90
		public int Serialize(ref byte[] bytes, int offset, decimal value, IFormatterResolver formatterResolver) => default; // 0x00000001856C9D60-0x00000001856C9EC0
		// [XID] // 0x00000001897C2700-0x00000001897C2720
		public decimal Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001856C9BA0-0x00000001856C9D60
	}
}
