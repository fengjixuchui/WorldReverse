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
	[Preserve] // 0x0000000189B45780-0x0000000189B457C0
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 5441
	{
		// Fields
		private readonly List<JToken> _values; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000186C68190-0x0000000186C681F0 
		public override JTokenType Type { get => default; } // 0x0000000186C68410-0x0000000186C68460 
		public override JToken this[object key] { get => default; } // 0x0000000186C68240-0x0000000186C68390 
		public JToken this[int index] { get => default; set {} } // 0x0000000186C68390-0x0000000186C68410 0x0000000186C68460-0x0000000186C684F0
		public bool IsReadOnly { get => default; } // 0x0000000186C681F0-0x0000000186C68240 
	
		// Constructors
		public JArray() {} // 0x0000000186C67FB0-0x0000000186C68040
		public JArray(JArray other) {} // 0x0000000186C680F0-0x0000000186C68190
		public JArray(object content) {} // 0x0000000186C68040-0x0000000186C680F0
	
		// Methods
		internal override bool DeepEquals(JToken node) => default; // 0x0000000186C67850-0x0000000186C67910
		internal override JToken CloneToken() => default; // 0x0000000186C676C0-0x0000000186C67740
		public static JArray Load(JsonReader reader, JsonLoadSettings settings) => default; // 0x0000000186C67BA0-0x0000000186C67D80
		public override void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) {} // 0x0000000186C67E80-0x0000000186C67FB0
		internal override int IndexOfItem(JToken item) => default; // 0x0000000186C67A10-0x0000000186C67A90
		public int IndexOf(JToken item) => default; // 0x0000000186C67A90-0x0000000186C67B10
		public void Insert(int index, JToken item) {} // 0x0000000186C67B10-0x0000000186C67BA0
		public void RemoveAt(int index) {} // 0x0000000186C67D80-0x0000000186C67E00
		public IEnumerator<JToken> GetEnumerator() => default; // 0x0000000186C67980-0x0000000186C67A10
		public void Add(JToken item) {} // 0x0000000186C675D0-0x0000000186C67650
		public void Clear() {} // 0x0000000186C67650-0x0000000186C676C0
		public bool Contains(JToken item) => default; // 0x0000000186C67740-0x0000000186C677C0
		public void CopyTo(JToken[] array, int arrayIndex) {} // 0x0000000186C677C0-0x0000000186C67850
		public bool Remove(JToken item) => default; // 0x0000000186C67E00-0x0000000186C67E80
		internal override int GetDeepHashCode() => default; // 0x0000000186C67910-0x0000000186C67980
	}
}
