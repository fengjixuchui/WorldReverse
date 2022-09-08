/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal static class EnumUtils // TypeDefIndex: 5331
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType; // 0x00
	
		// Constructors
		static EnumUtils() {} // 0x0000000185E54BD0-0x0000000185E54C90
	
		// Methods
		private static BidirectionalDictionary<string, string> InitializeEnumType(System.Type type) => default; // 0x0000000185E54240-0x0000000185E545D0
		public static IList<object> GetValues(System.Type enumType) => default; // 0x0000000185E53EB0-0x0000000185E54240
		public static object ParseEnumName(string enumText, bool isNullable, System.Type t) => default; // 0x0000000185E545D0-0x0000000185E548D0
		public static string ToEnumName(System.Type enumType, string enumText, bool camelCaseText) => default; // 0x0000000185E54980-0x0000000185E54BD0
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText) => default; // 0x0000000185E548D0-0x0000000185E54980
	}
}
