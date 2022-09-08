/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class RegexConverter : JsonConverter // TypeDefIndex: 5482
	{
		// Constructors
		public RegexConverter() {} // 0x0000000185CD88B0-0x0000000185CD8950
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CD8760-0x0000000185CD88B0
		private bool HasFlag(RegexOptions options, RegexOptions flag) => default; // 0x0000000185CD7C80-0x0000000185CD7CF0
		private void WriteBson(BsonWriter writer, Regex regex) {} // 0x0000000185CD8290-0x0000000185CD8580
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) {} // 0x0000000185CD8580-0x0000000185CD8760
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CD7CF0-0x0000000185CD7DF0
		private object ReadRegexString(JsonReader reader) => default; // 0x0000000185CD8100-0x0000000185CD8290
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) => default; // 0x0000000185CD7DF0-0x0000000185CD8100
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000185CD7BE0-0x0000000185CD7C80
	}
}
