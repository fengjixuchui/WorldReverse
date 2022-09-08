/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 53: ChnCharInfo.dll - Assembly: ChnCharInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=18f031bd02e5e291 - Types 6608-6619

namespace Microsoft.International.Converters.PinYinConverter
{
	internal class PinyinDictionary // TypeDefIndex: 6615
	{
		// Fields
		internal short Length; // 0x10
		internal short Count; // 0x12
		internal short Offset; // 0x14
		internal readonly byte[] Reserved; // 0x18
		internal List<PinyinUnit> PinyinUnitTable; // 0x20
		internal readonly short EndMark; // 0x28
	
		// Constructors
		public PinyinDictionary() {} // 0x0000000189545C00-0x0000000189545CA0
	
		// Methods
		internal static PinyinDictionary Deserialize(BinaryReader binaryReader) => default; // 0x0000000189545990-0x0000000189545B20
		internal PinyinUnit GetPinYinUnitByIndex(int index) => default; // 0x0000000189545B20-0x0000000189545C00
	}
}
