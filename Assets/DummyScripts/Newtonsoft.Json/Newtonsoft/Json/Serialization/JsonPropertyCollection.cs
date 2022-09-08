/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonPropertyCollection : KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty> // TypeDefIndex: 5394
	{
		// Fields
		private readonly System.Type _type; // 0x38
		private readonly List<JsonProperty> _list; // 0x40
	
		// Constructors
		public JsonPropertyCollection() {} // Dummy constructor
		public JsonPropertyCollection(System.Type type) {} // 0x0000000186355BB0-0x0000000186355CD0
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item) => default; // 0x0000000186355890-0x0000000186355930
		public void AddProperty(JsonProperty property) {} // 0x00000001863553B0-0x0000000186355790
		public JsonProperty GetClosestMatchProperty(string propertyName) => default; // 0x0000000186355790-0x0000000186355890
		private bool TryGetValue(string key, out JsonProperty item) {
			item = default;
			return default;
		} // 0x0000000186355AE0-0x0000000186355BB0
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) => default; // 0x0000000186355930-0x0000000186355AE0
	}
}
