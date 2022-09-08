/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 53: ChnCharInfo.dll - Assembly: ChnCharInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=18f031bd02e5e291 - Types 6608-6619

namespace Microsoft.International.Converters.PinYinConverter
{
	public class ChineseChar // TypeDefIndex: 6616
	{
		// Fields
		private static CharDictionary charDictionary; // 0x00
		private static PinyinDictionary pinyinDictionary; // 0x08
		private static StrokeDictionary strokeDictionary; // 0x10
		private static HomophoneDictionary homophoneDictionary; // 0x18
		private char chineseCharacter; // 0x10
		private short strokeNumber; // 0x12
		private bool isPolyphone; // 0x14
		private short pinyinCount; // 0x16
		private string[] pinyinList; // 0x18
	
		// Properties
		public short PinyinCount { get => default; } // 0x00000001895454A0-0x0000000189545500 
		public ReadOnlyCollection<string> Pinyins { get => default; } // 0x0000000189545500-0x0000000189545590 
	
		// Constructors
		public ChineseChar() {} // Dummy constructor
		static ChineseChar() {} // 0x00000001895449B0-0x0000000189545230
		public ChineseChar(char ch) {} // 0x0000000189545230-0x00000001895454A0
	
		// Methods
		public static bool IsValidChar(char ch) => default; // 0x0000000189544900-0x00000001895449B0
	}
}
