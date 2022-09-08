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
	internal class HomophoneDictionary // TypeDefIndex: 6618
	{
		// Fields
		internal int Length; // 0x10
		internal short Offset; // 0x14
		internal short Count; // 0x16
		internal readonly byte[] Reserved; // 0x18
		internal List<HomophoneUnit> HomophoneUnitTable; // 0x20
		internal readonly short EndMark; // 0x28
	
		// Constructors
		public HomophoneDictionary() {} // 0x0000000189545720-0x00000001895457C0
	
		// Methods
		internal static HomophoneDictionary Deserialize(BinaryReader binaryReader) => default; // 0x0000000189545590-0x0000000189545720
	}
}
