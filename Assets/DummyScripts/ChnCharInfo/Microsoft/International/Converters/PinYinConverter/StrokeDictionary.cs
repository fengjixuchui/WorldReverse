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
	internal class StrokeDictionary // TypeDefIndex: 6613
	{
		// Fields
		internal int Length; // 0x10
		internal int Count; // 0x14
		internal short Offset; // 0x18
		internal readonly byte[] Reserved; // 0x20
		internal List<StrokeUnit> StrokeUnitTable; // 0x28
		internal readonly short EndMark; // 0x30
	
		// Constructors
		public StrokeDictionary() {} // 0x0000000189546010-0x00000001895460B0
	
		// Methods
		internal static StrokeDictionary Deserialize(BinaryReader binaryReader) => default; // 0x0000000189545E90-0x0000000189546010
	}
}
