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
	public class BinaryConverter : JsonConverter // TypeDefIndex: 5477
	{
		// Fields
		private ReflectionObject _reflectionObject; // 0x10
	
		// Constructors
		public BinaryConverter() {} // 0x0000000185CB80E0-0x0000000185CB8180
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CB8010-0x0000000185CB80E0
		private byte[] GetByteArray(object value) => default; // 0x0000000185CB7830-0x0000000185CB79C0
		private void EnsureReflectionObject(System.Type t) {} // 0x0000000185CB7660-0x0000000185CB7830
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CB7C10-0x0000000185CB8010
		private byte[] ReadByteArray(JsonReader reader) => default; // 0x0000000185CB79C0-0x0000000185CB7C10
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000185CB75E0-0x0000000185CB7660
	}
}
