/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
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
	public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 5486
	{
		// Fields
		private DateTimeStyles _dateTimeStyles; // 0x10
		private string _dateTimeFormat; // 0x18
		private CultureInfo _culture; // 0x20
	
		// Properties
		public CultureInfo Culture { get => default; } // 0x0000000185CC0760-0x0000000185CC07F0 
	
		// Constructors
		public IsoDateTimeConverter() {} // 0x0000000185CC06F0-0x0000000185CC0760
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CC0460-0x0000000185CC06F0
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CBFD20-0x0000000185CC0460
	}
}
