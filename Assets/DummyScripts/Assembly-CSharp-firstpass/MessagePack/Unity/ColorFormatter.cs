/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MessagePack;
using MessagePack.Formatters;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MessagePack.Unity
{
	public sealed class ColorFormatter : IMessagePackFormatter<Color> // TypeDefIndex: 8447
	{
		// Constructors
		public ColorFormatter() {} // 0x00000001859D7650-0x00000001859D76B0
	
		// Methods
		// [XID] // 0x000000018966BD30-0x000000018966BD50
		public int Serialize(ref byte[] bytes, int offset, Color value, IFormatterResolver formatterResolver) => default; // 0x00000001859D74B0-0x00000001859D7650
		// [XID] // 0x0000000189673AE0-0x0000000189673B00
		public Color Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize) {
			readSize = default;
			return default;
		} // 0x00000001859D7140-0x00000001859D74B0
	}
}
