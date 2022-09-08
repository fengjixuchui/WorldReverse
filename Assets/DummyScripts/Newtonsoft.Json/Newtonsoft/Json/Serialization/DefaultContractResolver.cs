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
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5369
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly JsonConverter[] BuiltInConverters; // 0x08
		private static readonly object TypeContractCacheLock; // 0x10
		private static readonly DefaultContractResolverState _sharedState; // 0x18
		private readonly DefaultContractResolverState _instanceState; // 0x10
		private readonly bool _sharedCache; // 0x18
	
		// Properties
		internal static IContractResolver Instance { get => default; } // 0x00000001863479B0-0x0000000186347A40 
		public bool DynamicCodeGeneration { get => default; } // 0x0000000186347870-0x00000001863478F0 
		[Obsolete] // 0x000000018988F880-0x000000018988F8B0
		public BindingFlags DefaultMembersSearchFlags { get; set; } // 0x0000000186347810-0x0000000186347870 0x0000000186347AA0-0x0000000186347B00
		public bool SerializeCompilerGeneratedMembers { get; } // 0x0000000186347A40-0x0000000186347AA0 
		public bool IgnoreSerializableInterface { get; } // 0x0000000186347950-0x00000001863479B0 
		public bool IgnoreSerializableAttribute { get; set; } // 0x00000001863478F0-0x0000000186347950 0x0000000186347B00-0x0000000186347B60
	
		// Nested types
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>> // TypeDefIndex: 5370
		{
			// Fields
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Constructors
			public EnumerableDictionaryWrapper() {} // Dummy constructor
	
			// Methods
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public DefaultContractResolver() {} // 0x00000001863476A0-0x00000001863477A0
		[Obsolete] // 0x0000000189886DE0-0x0000000189886E10
		public DefaultContractResolver(bool shareCache) {} // 0x00000001863477A0-0x0000000186347810
		static DefaultContractResolver() {} // 0x00000001863473D0-0x00000001863476A0
	
		// Methods
		internal DefaultContractResolverState GetState() => default; // 0x0000000186344670-0x0000000186344710
		public virtual JsonContract ResolveContract(System.Type type) => default; // 0x0000000186345850-0x0000000186345AB0
		protected virtual List<MemberInfo> GetSerializableMembers(System.Type objectType) => default; // 0x0000000186343E60-0x0000000186344670
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo) => default; // 0x00000001863471C0-0x0000000186347330
		protected virtual JsonObjectContract CreateObjectContract(System.Type objectType) => default; // 0x00000001863410F0-0x0000000186341570
		private MemberInfo GetExtensionDataMemberForType(System.Type type) => default; // 0x0000000186343B20-0x0000000186343D10
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) {} // 0x0000000186345B90-0x0000000186346450
		private ConstructorInfo GetAttributeConstructor(System.Type objectType) => default; // 0x0000000186342BE0-0x0000000186342FE0
		private ConstructorInfo GetParameterizedConstructor(System.Type objectType) => default; // 0x0000000186343D10-0x0000000186343DE0
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) => default; // 0x0000000186340130-0x0000000186340350
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) => default; // 0x00000001863419A0-0x0000000186342410
		protected virtual JsonConverter ResolveContractConverter(System.Type objectType) => default; // 0x00000001863457C0-0x0000000186345850
		private Func<object> GetDefaultCreator(System.Type createdType) => default; // 0x0000000186343A50-0x0000000186343B20
		private void InitializeContract(JsonContract contract) {} // 0x0000000186344710-0x0000000186344B90
		private void ResolveCallbackMethods(JsonContract contract, System.Type t) {} // 0x00000001863455E0-0x00000001863457C0
		private void GetCallbackMethodsForType(System.Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) {
			onSerializing = default;
			onSerialized = default;
			onDeserializing = default;
			onDeserialized = default;
			onError = default;
		} // 0x0000000186342FE0-0x0000000186343710
		private static bool ShouldSkipDeserialized(System.Type t) => default; // 0x0000000186347330-0x0000000186347380
		private static bool ShouldSkipSerializing(System.Type t) => default; // 0x0000000186347380-0x00000001863473D0
		private List<System.Type> GetClassHierarchyForType(System.Type type) => default; // 0x0000000186343710-0x0000000186343840
		protected virtual JsonDictionaryContract CreateDictionaryContract(System.Type objectType) => default; // 0x0000000186340740-0x0000000186340D30
		protected virtual JsonArrayContract CreateArrayContract(System.Type objectType) => default; // 0x000000018633FCF0-0x0000000186340130
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) => default; // 0x0000000186341570-0x0000000186341610
		protected virtual JsonLinqContract CreateLinqContract(System.Type objectType) => default; // 0x0000000186340FA0-0x0000000186341040
		protected virtual JsonISerializableContract CreateISerializableContract(System.Type objectType) => default; // 0x0000000186340D30-0x0000000186340FA0
		protected virtual JsonStringContract CreateStringContract(System.Type objectType) => default; // 0x0000000186342B40-0x0000000186342BE0
		protected virtual JsonContract CreateContract(System.Type objectType) => default; // 0x0000000186340350-0x0000000186340740
		internal static bool IsJsonPrimitiveType(System.Type t) => default; // 0x0000000186344D50-0x0000000186344DF0
		internal static bool IsIConvertible(System.Type t) => default; // 0x0000000186344B90-0x0000000186344D50
		internal static bool CanConvertToString(System.Type type) => default; // 0x000000018633FAA0-0x000000018633FCF0
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, System.Type attributeType, MethodInfo currentCallback, ref System.Type prevAttributeType) => default; // 0x0000000186344DF0-0x00000001863455E0
		internal static string GetClrTypeFullName(System.Type type) => default; // 0x0000000186343840-0x0000000186343A50
		protected virtual IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization) => default; // 0x0000000186341610-0x00000001863419A0
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) => default; // 0x0000000186341040-0x00000001863410F0
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) => default; // 0x0000000186342410-0x00000001863428C0
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, System.Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) {
			allowNonPublicAccess = default;
		} // 0x00000001863467F0-0x00000001863471C0
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member) => default; // 0x00000001863428C0-0x0000000186342B40
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) {} // 0x0000000186346450-0x00000001863467F0
		protected virtual string ResolvePropertyName(string propertyName) => default; // 0x0000000186345B30-0x0000000186345B90
		protected virtual string ResolveDictionaryKey(string dictionaryKey) => default; // 0x0000000186345AB0-0x0000000186345B30
		public string GetResolvedPropertyName(string propertyName) => default; // 0x0000000186343DE0-0x0000000186343E60
	}
}
