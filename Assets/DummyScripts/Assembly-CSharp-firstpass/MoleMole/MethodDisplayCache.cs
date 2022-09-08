/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class MethodDisplayCache // TypeDefIndex: 10085
	{
		// Fields
		private static Dictionary<StringPair, string> _displayMethodStringMaps; // 0x00
	
		// Nested types
		public struct StringPair // TypeDefIndex: 10086
		{
			// Fields
			public string targetName; // 0x00
			public string funcName; // 0x08
	
			// Constructors
			public StringPair(string inTarget, string inFunc) {
				targetName = default;
				funcName = default;
			} // 0x0000000186C426C0-0x0000000186C42740
		}
	
		public class StringPairComparer : IEqualityComparer<StringPair> // TypeDefIndex: 10087
		{
			// Constructors
			public StringPairComparer() {} // 0x0000000186C42660-0x0000000186C426C0
	
			// Methods
			// [XID] // 0x0000000189672610-0x0000000189672630
			public bool Equals(StringPair x, StringPair y) => default; // 0x0000000186C42400-0x0000000186C42560
			// [XID] // 0x000000018982F930-0x000000018982F950
			public int GetHashCode(StringPair obj) => default; // 0x0000000186C42560-0x0000000186C42660
		}
	
		// Constructors
		static MethodDisplayCache() {} // 0x0000000186C29D40-0x0000000186C29F30
	
		// Methods
		// [XID] // 0x000000018966A950-0x000000018966A970
		public static string GetMethodDisplayName(Delegate inDel) => default; // 0x0000000186C299B0-0x0000000186C29D40
	}
}
