/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal struct JsonPosition // TypeDefIndex: 5251
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type) {
			Type = default;
			Position = default;
			PropertyName = default;
			HasIndex = default;
		} // 0x0000000185CC3AF0-0x0000000185CC3B00
		static JsonPosition() {
			SpecialCharacters = default;
		} // 0x0000000185CC3960-0x0000000185CC3AF0
	
		// Methods
		internal int CalculateLength() => default; // 0x0000000185CC3470-0x0000000185CC3480
		internal void WriteTo(StringBuilder sb) {} // 0x0000000185CC3950-0x0000000185CC3960
		internal static bool TypeHasIndex(JsonContainerType type) => default; // 0x0000000185CC3770-0x0000000185CC3950
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition) => default; // 0x0000000185CC3010-0x0000000185CC3470
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) => default; // 0x0000000185CC3480-0x0000000185CC3770
	}
}
