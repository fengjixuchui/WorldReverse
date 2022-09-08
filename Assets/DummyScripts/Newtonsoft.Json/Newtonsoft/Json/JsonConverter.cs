/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public abstract class JsonConverter // TypeDefIndex: 5274
	{
		// Properties
		public virtual bool CanRead { get; } // 0x0000000185CC2910-0x0000000185CC2960 
		public virtual bool CanWrite { get; } // 0x0000000185CC2960-0x0000000185CC29B0 
	
		// Constructors
		protected JsonConverter() {} // 0x0000000185CC28B0-0x0000000185CC2910
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(System.Type objectType);
	}
}
