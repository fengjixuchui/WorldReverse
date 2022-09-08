/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Common
{
	public sealed class CharacterSetECI : ECI // TypeDefIndex: 4576
	{
		// Fields
		internal static readonly IDictionary<int, CharacterSetECI> VALUE_TO_ECI; // 0x00
		internal static readonly IDictionary<string, CharacterSetECI> NAME_TO_ECI; // 0x08
		private readonly string encodingName; // 0x18
	
		// Constructors
		public CharacterSetECI() {} // Dummy constructor
		static CharacterSetECI() {} // 0x0000000186AE3E30-0x0000000186AE56E0
		private CharacterSetECI(int value, string encodingName) {} // 0x0000000186AE56E0-0x0000000186AE57A0
	
		// Methods
		private static void addCharacterSet(int value, string encodingName) {} // 0x0000000186AE5940-0x0000000186AE5A60
		private static void addCharacterSet(int value, string[] encodingNames) {} // 0x0000000186AE57A0-0x0000000186AE5940
		public static CharacterSetECI getCharacterSetECIByName(string name) => default; // 0x0000000186AE5A60-0x0000000186AE5B40
	}
}
