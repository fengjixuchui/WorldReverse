/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	[Preserve] // 0x0000000189ABCFB0-0x0000000189ABD000
	public class JConstructor : JContainer // TypeDefIndex: 5434
	{
		// Fields
		private string _name; // 0x50
		private readonly List<JToken> _values; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get => default; } // 0x0000000186C68F00-0x0000000186C68F60 
		public string Name { get => default; } // 0x0000000186C690B0-0x0000000186C69110 
		public override JTokenType Type { get => default; } // 0x0000000186C69110-0x0000000186C69160 
		public override JToken this[object key] { get => default; } // 0x0000000186C68F60-0x0000000186C690B0 
	
		// Constructors
		public JConstructor() {} // 0x0000000186C68C70-0x0000000186C68D00
		public JConstructor(JConstructor other) {} // 0x0000000186C68E20-0x0000000186C68F00
		public JConstructor(string name) {} // 0x0000000186C68D00-0x0000000186C68E20
	
		// Methods
		internal override int IndexOfItem(JToken item) => default; // 0x0000000186C68750-0x0000000186C687D0
		internal override bool DeepEquals(JToken node) => default; // 0x0000000186C68570-0x0000000186C686B0
		internal override JToken CloneToken() => default; // 0x0000000186C684F0-0x0000000186C68570
		public override void WriteTo(JsonWriter writer, params /* 0x000000018989F6F0-0x000000018989F700 */ JsonConverter[] converters) {} // 0x0000000186C68A00-0x0000000186C68C70
		internal override int GetDeepHashCode() => default; // 0x0000000186C686B0-0x0000000186C68750
		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) => default; // 0x0000000186C687D0-0x0000000186C68A00
	}
}
