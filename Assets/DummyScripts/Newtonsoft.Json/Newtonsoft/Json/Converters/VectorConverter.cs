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
using UnityEngine;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class VectorConverter : JsonConverter // TypeDefIndex: 5484
	{
		// Fields
		private static readonly System.Type V2; // 0x00
		private static readonly System.Type V3; // 0x08
		private static readonly System.Type V4; // 0x10
	
		// Properties
		public bool EnableVector2 { get; set; } // 0x0000000185CDA3B0-0x0000000185CDA410 0x0000000185CDA4D0-0x0000000185CDA530
		public bool EnableVector3 { get; set; } // 0x0000000185CDA410-0x0000000185CDA470 0x0000000185CDA530-0x0000000185CDA590
		public bool EnableVector4 { get; set; } // 0x0000000185CDA470-0x0000000185CDA4D0 0x0000000185CDA590-0x0000000185CDA5F0
	
		// Constructors
		public VectorConverter() {} // 0x0000000185CDA260-0x0000000185CDA3B0
		static VectorConverter() {} // 0x0000000185CDA180-0x0000000185CDA260
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CD9C80-0x0000000185CD9FB0
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w) {} // 0x0000000185CD9FB0-0x0000000185CDA180
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CD9890-0x0000000185CD9C80
		public override bool CanConvert(System.Type objectType) => default; // 0x0000000185CD92B0-0x0000000185CD9480
		private static Vector2 PopulateVector2(JsonReader reader) => default; // 0x0000000185CD9480-0x0000000185CD9580
		private static Vector3 PopulateVector3(JsonReader reader) => default; // 0x0000000185CD9580-0x0000000185CD96D0
		private static Vector4 PopulateVector4(JsonReader reader) => default; // 0x0000000185CD96D0-0x0000000185CD9890
	}
}
