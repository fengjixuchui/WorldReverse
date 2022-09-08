/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal static class JsonTypeReflector // TypeDefIndex: 5407
	{
		// Fields
		private static bool? _dynamicCodeGeneration; // 0x00
		private static bool? _fullyTrusted; // 0x02
		private static readonly ThreadSafeStore<System.Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x08
		private static readonly ThreadSafeStore<System.Type, System.Type> AssociatedMetadataTypesCache; // 0x10
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool DynamicCodeGeneration { get; } // 0x0000000185E5E420-0x0000000185E5E6A0 
		public static bool FullyTrusted { get; } // 0x0000000185E5E6A0-0x0000000185E5E850 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000185E5E850-0x0000000185E5E930 
	
		// Constructors
		static JsonTypeReflector() {} // 0x0000000185E5E300-0x0000000185E5E420
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute => default;
		public static DataContractAttribute GetDataContractAttribute(System.Type type) => default; // 0x0000000185E5DB80-0x0000000185E5DC50
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) => default; // 0x0000000185E5DC50-0x0000000185E5DE70
		public static MemberSerialization GetObjectMemberSerialization(System.Type objectType, bool ignoreSerializableAttribute) => default; // 0x0000000185E5E150-0x0000000185E5E270
		public static JsonConverter GetJsonConverter(object attributeProvider) => default; // 0x0000000185E5E020-0x0000000185E5E150
		public static JsonConverter CreateJsonConverterInstance(System.Type converterType, object[] converterArgs) => default; // 0x0000000185E5D740-0x0000000185E5D820
		private static Func<object[], JsonConverter> GetJsonConverterCreator(System.Type converterType) => default; // 0x0000000185E5DE70-0x0000000185E5E020
		public static TypeConverter GetTypeConverter(System.Type type) => default; // 0x0000000185E5E270-0x0000000185E5E300
		private static System.Type GetAssociatedMetadataType(System.Type type) => default; // 0x0000000185E5DAD0-0x0000000185E5DB80
		private static System.Type GetAssociateMetadataTypeFromAttribute(System.Type type) => default; // 0x0000000185E5D820-0x0000000185E5DAD0
		private static T GetAttribute<T>(System.Type type)
			where T : Attribute => default;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute => default;
		public static T GetAttribute<T>(object provider)
			where T : Attribute => default;
	}
}
