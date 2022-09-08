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
	public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 5396
	{
		// Fields
		internal bool ExtensionDataIsJToken; // 0xE8
		private bool? _hasRequiredOrDefaultValueProperties; // 0xE9
		private ConstructorInfo _parametrizedConstructor; // 0xF0
		private ConstructorInfo _overrideConstructor; // 0xF8
		private ObjectConstructor<object> _overrideCreator; // 0x100
		private ObjectConstructor<object> _parameterizedCreator; // 0x108
		private JsonPropertyCollection _creatorParameters; // 0x110
		private System.Type _extensionDataValueType; // 0x118
	
		// Properties
		public MemberSerialization MemberSerialization { get; set; } // 0x00000001863548F0-0x0000000186354950 0x0000000186354C90-0x0000000186354D00
		public Required? ItemRequired { get; set; } // 0x0000000186354890-0x00000001863548F0 0x0000000186354C30-0x0000000186354C90
		public JsonPropertyCollection Properties { get; private set; } // 0x0000000186354A10-0x0000000186354A70 0x0000000186354EA0-0x0000000186354F10
		public JsonPropertyCollection CreatorParameters { get => default; } // 0x0000000186354380-0x0000000186354450 
		[Obsolete] // 0x0000000189823D80-0x0000000189823DB0
		public ConstructorInfo OverrideConstructor { set {} } // 0x0000000186354D00-0x0000000186354DD0
		[Obsolete] // 0x000000018982CE10-0x000000018982CE40
		public ConstructorInfo ParametrizedConstructor { set {} } // 0x0000000186354DD0-0x0000000186354EA0
		public ObjectConstructor<object> OverrideCreator { get => default; } // 0x0000000186354950-0x00000001863549B0 
		internal ObjectConstructor<object> ParameterizedCreator { get => default; } // 0x00000001863549B0-0x0000000186354A10 
		public ExtensionDataSetter ExtensionDataSetter { get; set; } // 0x00000001863544B0-0x0000000186354510 0x0000000186354AE0-0x0000000186354B50
		public ExtensionDataGetter ExtensionDataGetter { get; set; } // 0x0000000186354450-0x00000001863544B0 0x0000000186354A70-0x0000000186354AE0
		public System.Type ExtensionDataValueType { set {} } // 0x0000000186354B50-0x0000000186354C30
		internal bool HasRequiredOrDefaultValueProperties { get => default; } // 0x0000000186354510-0x0000000186354890 
	
		// Constructors
		public JsonObjectContract() {} // Dummy constructor
		public JsonObjectContract(System.Type underlyingType) {} // 0x0000000186354270-0x0000000186354380
	
		// Methods
		internal object GetUninitializedObject() => default; // 0x0000000186354150-0x0000000186354270
	}
}
