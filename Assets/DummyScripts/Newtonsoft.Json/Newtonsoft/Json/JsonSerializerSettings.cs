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
	public class JsonSerializerSettings // TypeDefIndex: 5263
	{
		// Fields
		internal static readonly StreamingContext DefaultContext; // 0x00
		internal static readonly CultureInfo DefaultCulture; // 0x10
		internal Formatting? _formatting; // 0x10
		internal DateFormatHandling? _dateFormatHandling; // 0x18
		internal DateTimeZoneHandling? _dateTimeZoneHandling; // 0x20
		internal DateParseHandling? _dateParseHandling; // 0x28
		internal FloatFormatHandling? _floatFormatHandling; // 0x30
		internal FloatParseHandling? _floatParseHandling; // 0x38
		internal StringEscapeHandling? _stringEscapeHandling; // 0x40
		internal CultureInfo _culture; // 0x48
		internal bool? _checkAdditionalContent; // 0x50
		internal int? _maxDepth; // 0x54
		internal bool _maxDepthSet; // 0x5C
		internal string _dateFormatString; // 0x60
		internal bool _dateFormatStringSet; // 0x68
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat; // 0x6C
		internal DefaultValueHandling? _defaultValueHandling; // 0x74
		internal PreserveReferencesHandling? _preserveReferencesHandling; // 0x7C
		internal NullValueHandling? _nullValueHandling; // 0x84
		internal ObjectCreationHandling? _objectCreationHandling; // 0x8C
		internal MissingMemberHandling? _missingMemberHandling; // 0x94
		internal ReferenceLoopHandling? _referenceLoopHandling; // 0x9C
		internal StreamingContext? _context; // 0xA8
		internal ConstructorHandling? _constructorHandling; // 0xC0
		internal TypeNameHandling? _typeNameHandling; // 0xC8
		internal MetadataPropertyHandling? _metadataPropertyHandling; // 0xD0
	
		// Properties
		public ReferenceLoopHandling ReferenceLoopHandling { get => default; } // 0x0000000185CCA660-0x0000000185CCA6F0 
		public MissingMemberHandling MissingMemberHandling { get => default; } // 0x0000000185CCA420-0x0000000185CCA4B0 
		public ObjectCreationHandling ObjectCreationHandling { get => default; } // 0x0000000185CCA540-0x0000000185CCA5D0 
		public NullValueHandling NullValueHandling { get => default; } // 0x0000000185CCA4B0-0x0000000185CCA540 
		public DefaultValueHandling DefaultValueHandling { get => default; } // 0x0000000185CCA240-0x0000000185CCA2D0 
		public IList<JsonConverter> Converters { get; set; } // 0x0000000185CCA1E0-0x0000000185CCA240 0x0000000185CCA8D0-0x0000000185CCA940
		public PreserveReferencesHandling PreserveReferencesHandling { get => default; } // 0x0000000185CCA5D0-0x0000000185CCA660 
		public TypeNameHandling TypeNameHandling { get => default; set {} } // 0x0000000185CCA840-0x0000000185CCA8D0 0x0000000185CCA9D0-0x0000000185CCAA60
		public MetadataPropertyHandling MetadataPropertyHandling { get => default; } // 0x0000000185CCA390-0x0000000185CCA420 
		public FormatterAssemblyStyle TypeNameAssemblyFormat { get => default; } // 0x0000000185CCA7B0-0x0000000185CCA840 
		public ConstructorHandling ConstructorHandling { get => default; } // 0x0000000185CC9FF0-0x0000000185CCA080 
		public IContractResolver ContractResolver { get; } // 0x0000000185CCA180-0x0000000185CCA1E0 
		public IEqualityComparer EqualityComparer { get; } // 0x0000000185CCA2D0-0x0000000185CCA330 
		public Func<IReferenceResolver> ReferenceResolverProvider { get; } // 0x0000000185CCA6F0-0x0000000185CCA750 
		public ITraceWriter TraceWriter { get; } // 0x0000000185CCA750-0x0000000185CCA7B0 
		public SerializationBinder Binder { get; } // 0x0000000185CC9F90-0x0000000185CC9FF0 
		public EventHandler<ErrorEventArgs> Error { get; } // 0x0000000185CCA330-0x0000000185CCA390 
		public StreamingContext Context { get => default; } // 0x0000000185CCA080-0x0000000185CCA180 
		public Formatting Formatting { set {} } // 0x0000000185CCA940-0x0000000185CCA9D0
	
		// Constructors
		static JsonSerializerSettings() {} // 0x0000000185CC9DE0-0x0000000185CC9E80
		public JsonSerializerSettings() {} // 0x0000000185CC9E80-0x0000000185CC9F90
	}
}
