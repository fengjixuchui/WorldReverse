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

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonProperty // TypeDefIndex: 5393
	{
		// Fields
		internal Required? _required; // 0x10
		internal bool _hasExplicitDefaultValue; // 0x18
		private object _defaultValue; // 0x20
		private bool _hasGeneratedDefaultValue; // 0x28
		private string _propertyName; // 0x30
		internal bool _skipPropertyNameEscape; // 0x38
		private System.Type _propertyType; // 0x40
	
		// Properties
		internal JsonContract PropertyContract { get; set; } // 0x00000001863565C0-0x0000000186356620 0x0000000186357190-0x00000001863571F0
		public string PropertyName { get => default; set {} } // 0x0000000186356620-0x0000000186356680 0x00000001863571F0-0x00000001863572A0
		public System.Type DeclaringType { get; set; } // 0x0000000186356020-0x0000000186356080 0x0000000186356B90-0x0000000186356BF0
		public int? Order { get; set; } // 0x0000000186356560-0x00000001863565C0 0x0000000186357130-0x0000000186357190
		public string UnderlyingName { get; set; } // 0x00000001863569B0-0x0000000186356A10 0x0000000186357520-0x0000000186357580
		public IValueProvider ValueProvider { get; set; } // 0x0000000186356A10-0x0000000186356A70 0x0000000186357580-0x00000001863575E0
		public IAttributeProvider AttributeProvider { get; set; } // 0x0000000186356AD0-0x0000000186356B30
		public System.Type PropertyType { get => default; set {} } // 0x0000000186356680-0x00000001863566E0 0x00000001863572A0-0x0000000186357310
		public JsonConverter Converter { get; set; } // 0x0000000186355FC0-0x0000000186356020 0x0000000186356B30-0x0000000186356B90
		public JsonConverter MemberConverter { get; set; } // 0x0000000186356440-0x00000001863564A0 0x0000000186357000-0x0000000186357070
		public bool Ignored { get; set; } // 0x0000000186356200-0x0000000186356260 0x0000000186356DA0-0x0000000186356E10
		public bool Readable { get; set; } // 0x00000001863566E0-0x0000000186356740 0x0000000186357310-0x0000000186357380
		public bool Writable { get; set; } // 0x0000000186356A70-0x0000000186356AD0 0x00000001863575E0-0x0000000186357650
		public bool HasMemberAttribute { get; set; } // 0x00000001863561A0-0x0000000186356200 0x0000000186356D30-0x0000000186356DA0
		public object DefaultValue { get => default; set {} } // 0x00000001863560E0-0x0000000186356140 0x0000000186356C50-0x0000000186356CC0
		public Required Required { get => default; } // 0x00000001863567A0-0x0000000186356830 
		public bool? IsReference { get; set; } // 0x0000000186356260-0x00000001863562C0 0x0000000186356E10-0x0000000186356E70
		public NullValueHandling? NullValueHandling { get; set; } // 0x00000001863564A0-0x0000000186356500 0x0000000186357070-0x00000001863570D0
		public DefaultValueHandling? DefaultValueHandling { get; set; } // 0x0000000186356080-0x00000001863560E0 0x0000000186356BF0-0x0000000186356C50
		public ReferenceLoopHandling? ReferenceLoopHandling { get; set; } // 0x0000000186356740-0x00000001863567A0 0x0000000186357380-0x00000001863573E0
		public ObjectCreationHandling? ObjectCreationHandling { get; set; } // 0x0000000186356500-0x0000000186356560 0x00000001863570D0-0x0000000186357130
		public TypeNameHandling? TypeNameHandling { get; set; } // 0x0000000186356950-0x00000001863569B0 0x00000001863574C0-0x0000000186357520
		public Predicate<object> ShouldSerialize { get; set; } // 0x00000001863568F0-0x0000000186356950 0x0000000186357450-0x00000001863574C0
		public Predicate<object> ShouldDeserialize { get; } // 0x0000000186356890-0x00000001863568F0 
		public Predicate<object> GetIsSpecified { get; set; } // 0x0000000186356140-0x00000001863561A0 0x0000000186356CC0-0x0000000186356D30
		public Action<object, object> SetIsSpecified { get; set; } // 0x0000000186356830-0x0000000186356890 0x00000001863573E0-0x0000000186357450
		public JsonConverter ItemConverter { get; set; } // 0x00000001863562C0-0x0000000186356320 0x0000000186356E70-0x0000000186356EE0
		public bool? ItemIsReference { get; set; } // 0x0000000186356320-0x0000000186356380 0x0000000186356EE0-0x0000000186356F40
		public TypeNameHandling? ItemTypeNameHandling { get; set; } // 0x00000001863563E0-0x0000000186356440 0x0000000186356FA0-0x0000000186357000
		public ReferenceLoopHandling? ItemReferenceLoopHandling { get; set; } // 0x0000000186356380-0x00000001863563E0 0x0000000186356F40-0x0000000186356FA0
	
		// Constructors
		public JsonProperty() {} // 0x0000000186355F60-0x0000000186355FC0
	
		// Methods
		internal object GetResolvedDefaultValue() => default; // 0x0000000186355CD0-0x0000000186355D90
		public override string ToString() => default; // 0x0000000186355D90-0x0000000186355E30
		internal void WritePropertyName(JsonWriter writer) {} // 0x0000000186355E30-0x0000000186355F60
	}
}
