/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 5405
	{
		// Fields
		private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
		private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
		private readonly JsonSerializer _serializer; // 0xF0
	
		// Properties
		public override IReferenceResolver ReferenceResolver { set {} } // 0x0000000185E5D2E0-0x0000000185E5D370
		public override ITraceWriter TraceWriter { get => default; set {} } // 0x0000000185E5C9E0-0x0000000185E5CA60 0x0000000185E5D370-0x0000000185E5D400
		public override IEqualityComparer EqualityComparer { set {} } // 0x0000000185E5CE60-0x0000000185E5CEF0
		public override JsonConverterCollection Converters { get => default; } // 0x0000000185E5C860-0x0000000185E5C8E0 
		public override DefaultValueHandling DefaultValueHandling { set {} } // 0x0000000185E5CDD0-0x0000000185E5CE60
		public override IContractResolver ContractResolver { get => default; set {} } // 0x0000000185E5C7E0-0x0000000185E5C860 0x0000000185E5CD40-0x0000000185E5CDD0
		public override MissingMemberHandling MissingMemberHandling { set {} } // 0x0000000185E5D010-0x0000000185E5D0A0
		public override NullValueHandling NullValueHandling { set {} } // 0x0000000185E5D0A0-0x0000000185E5D130
		public override ObjectCreationHandling ObjectCreationHandling { set {} } // 0x0000000185E5D130-0x0000000185E5D1C0
		public override ReferenceLoopHandling ReferenceLoopHandling { set {} } // 0x0000000185E5D250-0x0000000185E5D2E0
		public override PreserveReferencesHandling PreserveReferencesHandling { set {} } // 0x0000000185E5D1C0-0x0000000185E5D250
		public override TypeNameHandling TypeNameHandling { set {} } // 0x0000000185E5D490-0x0000000185E5D520
		public override MetadataPropertyHandling MetadataPropertyHandling { get => default; set {} } // 0x0000000185E5C960-0x0000000185E5C9E0 0x0000000185E5CF80-0x0000000185E5D010
		public override FormatterAssemblyStyle TypeNameAssemblyFormat { set {} } // 0x0000000185E5D400-0x0000000185E5D490
		public override ConstructorHandling ConstructorHandling { set {} } // 0x0000000185E5CC10-0x0000000185E5CCA0
		public override SerializationBinder Binder { set {} } // 0x0000000185E5CAF0-0x0000000185E5CB80
		public override StreamingContext Context { get => default; set {} } // 0x0000000185E5C740-0x0000000185E5C7E0 0x0000000185E5CCA0-0x0000000185E5CD40
		public override Formatting Formatting { get => default; set {} } // 0x0000000185E5C8E0-0x0000000185E5C960 0x0000000185E5CEF0-0x0000000185E5CF80
		public override bool CheckAdditionalContent { get => default; set {} } // 0x0000000185E5C6C0-0x0000000185E5C740 0x0000000185E5CB80-0x0000000185E5CC10
	
		// Events
		public override event EventHandler<ErrorEventArgs> Error;
	
		// Constructors
		public JsonSerializerProxy() {} // Dummy constructor
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) {} // 0x0000000185E5C4F0-0x0000000185E5C590
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) {} // 0x0000000185E5C590-0x0000000185E5C630
	
		// Methods
		internal JsonSerializerInternalBase GetInternalSerializer() => default; // 0x0000000185E5C300-0x0000000185E5C370
		internal override object DeserializeInternal(JsonReader reader, System.Type objectType) => default; // 0x0000000185E5C240-0x0000000185E5C300
		internal override void PopulateInternal(JsonReader reader, object target) {} // 0x0000000185E5C370-0x0000000185E5C420
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, System.Type rootType) {} // 0x0000000185E5C420-0x0000000185E5C4F0
	}
}
