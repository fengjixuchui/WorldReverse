/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class JsonSerializer // TypeDefIndex: 5280
	{
		// Fields
		internal TypeNameHandling _typeNameHandling; // 0x10
		internal FormatterAssemblyStyle _typeNameAssemblyFormat; // 0x14
		internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
		internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
		internal MissingMemberHandling _missingMemberHandling; // 0x20
		internal ObjectCreationHandling _objectCreationHandling; // 0x24
		internal NullValueHandling _nullValueHandling; // 0x28
		internal DefaultValueHandling _defaultValueHandling; // 0x2C
		internal ConstructorHandling _constructorHandling; // 0x30
		internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
		internal JsonConverterCollection _converters; // 0x38
		internal IContractResolver _contractResolver; // 0x40
		internal ITraceWriter _traceWriter; // 0x48
		internal IEqualityComparer _equalityComparer; // 0x50
		internal SerializationBinder _binder; // 0x58
		internal StreamingContext _context; // 0x60
		private IReferenceResolver _referenceResolver; // 0x70
		private Formatting? _formatting; // 0x78
		private DateFormatHandling? _dateFormatHandling; // 0x80
		private DateTimeZoneHandling? _dateTimeZoneHandling; // 0x88
		private DateParseHandling? _dateParseHandling; // 0x90
		private FloatFormatHandling? _floatFormatHandling; // 0x98
		private FloatParseHandling? _floatParseHandling; // 0xA0
		private StringEscapeHandling? _stringEscapeHandling; // 0xA8
		private CultureInfo _culture; // 0xB0
		private int? _maxDepth; // 0xB8
		private bool _maxDepthSet; // 0xC0
		private bool? _checkAdditionalContent; // 0xC1
		private string _dateFormatString; // 0xC8
		private bool _dateFormatStringSet; // 0xD0
	
		// Properties
		public virtual IReferenceResolver ReferenceResolver { set {} } // 0x0000000185CCE220-0x0000000185CCE2D0
		public virtual SerializationBinder Binder { set {} } // 0x0000000185CCD9D0-0x0000000185CCDA80
		public virtual ITraceWriter TraceWriter { get => default; set {} } // 0x0000000185CCD8A0-0x0000000185CCD900 0x0000000185CCE2D0-0x0000000185CCE330
		public virtual IEqualityComparer EqualityComparer { set {} } // 0x0000000185CCDD70-0x0000000185CCDDD0
		public virtual TypeNameHandling TypeNameHandling { set {} } // 0x0000000185CCE3D0-0x0000000185CCE470
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set {} } // 0x0000000185CCE330-0x0000000185CCE3D0
		public virtual PreserveReferencesHandling PreserveReferencesHandling { set {} } // 0x0000000185CCE0E0-0x0000000185CCE180
		public virtual ReferenceLoopHandling ReferenceLoopHandling { set {} } // 0x0000000185CCE180-0x0000000185CCE220
		public virtual MissingMemberHandling MissingMemberHandling { set {} } // 0x0000000185CCDF00-0x0000000185CCDFA0
		public virtual NullValueHandling NullValueHandling { set {} } // 0x0000000185CCDFA0-0x0000000185CCE040
		public virtual DefaultValueHandling DefaultValueHandling { set {} } // 0x0000000185CCDCD0-0x0000000185CCDD70
		public virtual ObjectCreationHandling ObjectCreationHandling { set {} } // 0x0000000185CCE040-0x0000000185CCE0E0
		public virtual ConstructorHandling ConstructorHandling { set {} } // 0x0000000185CCDB10-0x0000000185CCDBB0
		public virtual MetadataPropertyHandling MetadataPropertyHandling { get => default; set {} } // 0x0000000185CCD840-0x0000000185CCD8A0 0x0000000185CCDE60-0x0000000185CCDF00
		public virtual JsonConverterCollection Converters { get => default; } // 0x0000000185CCD6E0-0x0000000185CCD7B0 
		public virtual IContractResolver ContractResolver { get => default; set {} } // 0x0000000185CCD680-0x0000000185CCD6E0 0x0000000185CCDC20-0x0000000185CCDCD0
		public virtual StreamingContext Context { get => default; set {} } // 0x0000000185CCD610-0x0000000185CCD680 0x0000000185CCDBB0-0x0000000185CCDC20
		public virtual Formatting Formatting { get => default; set {} } // 0x0000000185CCD7B0-0x0000000185CCD840 0x0000000185CCDDD0-0x0000000185CCDE60
		public virtual bool CheckAdditionalContent { get => default; set {} } // 0x0000000185CCD570-0x0000000185CCD610 0x0000000185CCDA80-0x0000000185CCDB10
	
		// Events
		public virtual event EventHandler<ErrorEventArgs> Error;
	
		// Constructors
		public JsonSerializer() {} // 0x0000000185CCD370-0x0000000185CCD4A0
	
		// Methods
		internal bool IsCheckAdditionalContentSet() => default; // 0x0000000185CCBCE0-0x0000000185CCBD50
		public static JsonSerializer Create() => default; // 0x0000000185CCB690-0x0000000185CCB700
		public static JsonSerializer Create(JsonSerializerSettings settings) => default; // 0x0000000185CCB700-0x0000000185CCB7D0
		public static JsonSerializer CreateDefault() => default; // 0x0000000185CCB560-0x0000000185CCB600
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings) => default; // 0x0000000185CCB600-0x0000000185CCB690
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) {} // 0x0000000185CCAA60-0x0000000185CCB560
		public void Populate(JsonReader reader, object target) {} // 0x0000000185CCC060-0x0000000185CCC0F0
		internal virtual void PopulateInternal(JsonReader reader, object target) {} // 0x0000000185CCBDE0-0x0000000185CCC060
		public T Deserialize<T>(JsonReader reader) => default;
		public object Deserialize(JsonReader reader, System.Type objectType) => default; // 0x0000000185CCBA60-0x0000000185CCBAF0
		internal virtual object DeserializeInternal(JsonReader reader, System.Type objectType) => default; // 0x0000000185CCB7D0-0x0000000185CCBA60
		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString) {
			previousCulture = default;
			previousDateTimeZoneHandling = default;
			previousDateParseHandling = default;
			previousFloatParseHandling = default;
			previousMaxDepth = default;
			previousDateFormatString = default;
		} // 0x0000000185CCCC40-0x0000000185CCD370
		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString) {} // 0x0000000185CCC0F0-0x0000000185CCC350
		public void Serialize(JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x0000000185CCCBB0-0x0000000185CCCC40
		public void Serialize(JsonWriter jsonWriter, object value) {} // 0x0000000185CCCB10-0x0000000185CCCBB0
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x0000000185CCC350-0x0000000185CCCB10
		internal IReferenceResolver GetReferenceResolver() => default; // 0x0000000185CCBC50-0x0000000185CCBCE0
		internal JsonConverter GetMatchingConverter(System.Type type) => default; // 0x0000000185CCBAF0-0x0000000185CCBB70
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, System.Type objectType) => default; // 0x0000000185CCBB70-0x0000000185CCBC50
		internal void OnError(ErrorEventArgs e) {} // 0x0000000185CCBD50-0x0000000185CCBDE0
	}
}
