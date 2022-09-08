/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000189ABCFB0-0x0000000189ABD000
	public class JObject : JContainer, IDictionary<string, JToken>, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 5438
	{
		// Fields
		private readonly JPropertyKeyedCollection _properties; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000186C6F0D0-0x0000000186C6F130 
		public override JTokenType Type { get => default; } // 0x0000000186C6F300-0x0000000186C6F350 
		public override JToken this[object key] { get => default; } // 0x0000000186C6F1D0-0x0000000186C6F300 
		public JToken this[string propertyName] { get => default; set {} } // 0x0000000186C6F130-0x0000000186C6F1D0 0x0000000186C6F350-0x0000000186C6F450
		ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get => default; } // 0x0000000186C6E6B0-0x0000000186C6E730 
		ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get => default; } // 0x0000000186C6E730-0x0000000186C6E7A0 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get => default; } // 0x0000000186C6E5D0-0x0000000186C6E620 
	
		// Constructors
		public JObject() {} // 0x0000000186C6EFA0-0x0000000186C6F030
		public JObject(JObject other) {} // 0x0000000186C6F030-0x0000000186C6F0D0
	
		// Methods
		internal override bool DeepEquals(JToken node) => default; // 0x0000000186C6D2C0-0x0000000186C6D390
		internal override int IndexOfItem(JToken item) => default; // 0x0000000186C6D4D0-0x0000000186C6D560
		internal override void InsertItem(int index, JToken item, bool skipParentCheck) {} // 0x0000000186C6D560-0x0000000186C6D620
		internal override void ValidateToken(JToken o, JToken existing) {} // 0x0000000186C6EAF0-0x0000000186C6EE70
		internal void InternalPropertyChanged(JProperty childProperty) {} // 0x0000000186C6D620-0x0000000186C6D750
		internal void InternalPropertyChanging(JProperty childProperty) {} // 0x0000000186C6D750-0x0000000186C6D820
		internal override JToken CloneToken() => default; // 0x0000000186C6D240-0x0000000186C6D2C0
		public JProperty Property(string name) => default; // 0x0000000186C6DDE0-0x0000000186C6DEF0
		public static JObject Load(JsonReader reader) => default; // 0x0000000186C6DA20-0x0000000186C6DA90
		public static JObject Load(JsonReader reader, JsonLoadSettings settings) => default; // 0x0000000186C6D820-0x0000000186C6DA20
		public static JObject Parse(string json) => default; // 0x0000000186C6DBF0-0x0000000186C6DC60
		public static JObject Parse(string json, JsonLoadSettings settings) => default; // 0x0000000186C6DC60-0x0000000186C6DDE0
		public override void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) {} // 0x0000000186C6EE70-0x0000000186C6EFA0
		public void Add(string propertyName, JToken value) {} // 0x0000000186C6D190-0x0000000186C6D240
		bool IDictionary<string, JToken>.ContainsKey(string key) => default; // 0x0000000186C6E620-0x0000000186C6E6B0
		public bool Remove(string propertyName) => default; // 0x0000000186C6DEF0-0x0000000186C6DF80
		public bool TryGetValue(string propertyName, out JToken value) {
			value = default;
			return default;
		} // 0x0000000186C6EA50-0x0000000186C6EAF0
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item) {} // 0x0000000186C6DF80-0x0000000186C6E050
		void ICollection<KeyValuePair<string, JToken>>.Clear() {} // 0x0000000186C6E050-0x0000000186C6E100
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item) => default; // 0x0000000186C6E100-0x0000000186C6E1B0
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) {} // 0x0000000186C6E1B0-0x0000000186C6E4B0
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item) => default; // 0x0000000186C6E4B0-0x0000000186C6E5D0
		internal override int GetDeepHashCode() => default; // 0x0000000186C6D390-0x0000000186C6D400
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() => default; // 0x0000000186C6D400-0x0000000186C6D4D0
		protected virtual void OnPropertyChanged(string propertyName) {} // 0x0000000186C6DA90-0x0000000186C6DB40
		protected virtual void OnPropertyChanging(string propertyName) {} // 0x0000000186C6DB40-0x0000000186C6DBF0
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes) => default; // 0x0000000186C6E7A0-0x0000000186C6EA50
	}
}
