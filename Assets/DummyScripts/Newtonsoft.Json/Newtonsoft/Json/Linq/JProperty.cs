/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JProperty : JContainer // TypeDefIndex: 5451
	{
		// Fields
		private readonly JPropertyList _content; // 0x50
		private readonly string _name; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000186C71F20-0x0000000186C71F80 
		public string Name { [DebuggerStepThrough] /* 0x0000000189658AA0-0x0000000189658AB0 */ get => default; } // 0x0000000186C71F80-0x0000000186C71FE0 
		public JToken Value { [DebuggerStepThrough] /* 0x0000000189658AA0-0x0000000189658AB0 */ get => default; set {} } // 0x0000000186C72030-0x0000000186C720A0 0x0000000186C720A0-0x0000000186C72170
		public override JTokenType Type { [DebuggerStepThrough] /* 0x0000000189658AA0-0x0000000189658AB0 */ get => default; } // 0x0000000186C71FE0-0x0000000186C72030 
	
		// Nested types
		private class JPropertyList : IList<JToken> // TypeDefIndex: 5452
		{
			// Fields
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get => default; } // 0x0000000186C70B50-0x0000000186C70BC0 
			public bool IsReadOnly { get => default; } // 0x0000000186C70BC0-0x0000000186C70C10 
			public JToken this[int index] { get => default; set {} } // 0x0000000186C70C10-0x0000000186C70C80 0x0000000186C70C80-0x0000000186C70CF0
	
			// Constructors
			public JPropertyList() {} // 0x0000000186C70AF0-0x0000000186C70B50
	
			// Methods
			public IEnumerator<JToken> GetEnumerator() => default; // 0x0000000186C707E0-0x0000000186C708B0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000186C70A80-0x0000000186C70AF0
			public void Add(JToken item) {} // 0x0000000186C705E0-0x0000000186C70640
			public void Clear() {} // 0x0000000186C70640-0x0000000186C706A0
			public bool Contains(JToken item) => default; // 0x0000000186C706A0-0x0000000186C70710
			public void CopyTo(JToken[] array, int arrayIndex) {} // 0x0000000186C70710-0x0000000186C707E0
			public bool Remove(JToken item) => default; // 0x0000000186C70A00-0x0000000186C70A80
			public int IndexOf(JToken item) => default; // 0x0000000186C708B0-0x0000000186C70920
			public void Insert(int index, JToken item) {} // 0x0000000186C70920-0x0000000186C70990
			public void RemoveAt(int index) {} // 0x0000000186C70990-0x0000000186C70A00
		}
	
		// Constructors
		public JProperty() {} // Dummy constructor
		public JProperty(JProperty other) {} // 0x0000000186C71BE0-0x0000000186C71D00
		internal JProperty(string name) {} // 0x0000000186C71E40-0x0000000186C71F20
		public JProperty(string name, object content) {} // 0x0000000186C71D00-0x0000000186C71E40
	
		// Methods
		internal override JToken GetItem(int index) => default; // 0x0000000186C71180-0x0000000186C71220
		internal override void SetItem(int index, JToken item) {} // 0x0000000186C718D0-0x0000000186C71AC0
		internal override bool RemoveItem(JToken item) => default; // 0x0000000186C717D0-0x0000000186C718D0
		internal override void RemoveItemAt(int index) {} // 0x0000000186C716D0-0x0000000186C717D0
		internal override int IndexOfItem(JToken item) => default; // 0x0000000186C71220-0x0000000186C712E0
		internal override void InsertItem(int index, JToken item, bool skipParentCheck) {} // 0x0000000186C712E0-0x0000000186C714A0
		internal override bool ContainsItem(JToken item) => default; // 0x0000000186C70E70-0x0000000186C70F30
		internal override void ClearItems() {} // 0x0000000186C70CF0-0x0000000186C70DF0
		internal override bool DeepEquals(JToken node) => default; // 0x0000000186C70F30-0x0000000186C71070
		internal override JToken CloneToken() => default; // 0x0000000186C70DF0-0x0000000186C70E70
		public override void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) {} // 0x0000000186C71AC0-0x0000000186C71BE0
		internal override int GetDeepHashCode() => default; // 0x0000000186C71070-0x0000000186C71180
		public static JProperty Load(JsonReader reader, JsonLoadSettings settings) => default; // 0x0000000186C714A0-0x0000000186C716D0
	}
}
