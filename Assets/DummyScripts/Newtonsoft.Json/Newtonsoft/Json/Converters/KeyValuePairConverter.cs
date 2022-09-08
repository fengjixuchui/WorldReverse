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
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 5480
	{
		// Fields
		private static readonly ThreadSafeStore<System.Type, ReflectionObject> ReflectionObjectPerType; // 0x00
	
		// Constructors
		public KeyValuePairConverter() {} // 0x0000000185CD7B40-0x0000000185CD7BE0
		static KeyValuePairConverter() {} // 0x0000000185CD7A80-0x0000000185CD7B40
	
		// Methods
		private static ReflectionObject InitializeReflectionObject(System.Type t) => default; // 0x0000000185CD7070-0x0000000185CD73C0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CD77F0-0x0000000185CD7A80
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CD73C0-0x0000000185CD77F0
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000185CD6F50-0x0000000185CD7070
	}
}
