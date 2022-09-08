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
	public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 5478
	{
		// Properties
		public override bool CanWrite { get; }
	
		// Constructors
		protected CustomCreationConverter() {}
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {}
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default;
		public abstract T Create(System.Type objectType);
		public override bool CanConvert(System.Type objectType) => default;
	}
}
