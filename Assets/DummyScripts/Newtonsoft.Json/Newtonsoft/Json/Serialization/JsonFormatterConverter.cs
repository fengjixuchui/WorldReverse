/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5359
	{
		// Fields
		private readonly JsonSerializerInternalReader _reader; // 0x10
		private readonly JsonISerializableContract _contract; // 0x18
		private readonly JsonProperty _member; // 0x20
	
		// Constructors
		public JsonFormatterConverter() {} // Dummy constructor
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) {} // 0x0000000186353ED0-0x0000000186353F80
	
		// Methods
		private T GetTokenValue<T>(object value) => default;
		public object Convert(object value, System.Type type) => default; // 0x0000000186353A90-0x0000000186353BD0
		public bool ToBoolean(object value) => default; // 0x0000000186353BD0-0x0000000186353C50
		public short ToInt16(object value) => default; // 0x0000000186353C50-0x0000000186353CD0
		public int ToInt32(object value) => default; // 0x0000000186353CD0-0x0000000186353D50
		public long ToInt64(object value) => default; // 0x0000000186353D50-0x0000000186353DD0
		public string ToString(object value) => default; // 0x0000000186353DD0-0x0000000186353E50
		public uint ToUInt32(object value) => default; // 0x0000000186353E50-0x0000000186353ED0
	}
}
