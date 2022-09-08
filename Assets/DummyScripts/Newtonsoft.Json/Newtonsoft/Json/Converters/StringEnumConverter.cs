/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class StringEnumConverter : JsonConverter // TypeDefIndex: 5483
	{
		// Properties
		public bool CamelCaseText { get; } // 0x0000000185CD9190-0x0000000185CD91F0 
		public bool AllowIntegerValues { get; set; } // 0x0000000185CD9130-0x0000000185CD9190 0x0000000185CD91F0-0x0000000185CD9250
	
		// Constructors
		public StringEnumConverter() {} // 0x0000000185CD9050-0x0000000185CD9130
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CD8E60-0x0000000185CD9050
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CD8A00-0x0000000185CD8E60
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000185CD8950-0x0000000185CD8A00
	}
}
