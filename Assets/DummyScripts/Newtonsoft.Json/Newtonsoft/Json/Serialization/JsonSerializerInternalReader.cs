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
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 5399
	{
		// Nested types
		internal enum PropertyPresence // TypeDefIndex: 5400
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		internal class CreatorPropertyContext // TypeDefIndex: 5401
		{
			// Fields
			public string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			public CreatorPropertyContext() {} // 0x0000000185E4D250-0x0000000185E4D3B0
		}
	
		// Constructors
		public JsonSerializerInternalReader() {} // Dummy constructor
		public JsonSerializerInternalReader(JsonSerializer serializer) {} // 0x0000000186364E60-0x0000000186364EE0
	
		// Methods
		public void Populate(JsonReader reader, object target) {} // 0x00000001863619B0-0x0000000186361F00
		private JsonContract GetContractSafe(System.Type type) => default; // 0x000000018635E520-0x000000018635E5C0
		public object Deserialize(JsonReader reader, System.Type objectType, bool checkAdditionalContent) => default; // 0x000000018635D660-0x000000018635DA50
		private JsonSerializerProxy GetInternalSerializer() => default; // 0x000000018635E860-0x000000018635E8F0
		private JToken CreateJToken(JsonReader reader, JsonContract contract) => default; // 0x00000001863594A0-0x0000000186359780
		private JToken CreateJObject(JsonReader reader) => default; // 0x0000000186359210-0x00000001863594A0
		private object CreateValueInternal(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) => default; // 0x000000018635CD30-0x000000018635D340
		private static bool CoerceEmptyStringToNull(System.Type objectType, JsonContract contract, string s) => default; // 0x00000001863587F0-0x0000000186358920
		internal string GetExpectedDescription(JsonContract contract) => default; // 0x000000018635E750-0x000000018635E860
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x000000018635E5C0-0x000000018635E750
		private object CreateObject(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) => default; // 0x000000018635C160-0x000000018635CD30
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) {
			newValue = default;
			id = default;
			return default;
		} // 0x0000000186362270-0x0000000186362940
		private bool ReadMetadataProperties(JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) {
			newValue = default;
			id = default;
			return default;
		} // 0x0000000186362940-0x0000000186363060
		private void ResolveTypeName(JsonReader reader, ref System.Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) {} // 0x0000000186363A30-0x0000000186363FB0
		private JsonArrayContract EnsureArrayContract(JsonReader reader, System.Type objectType, JsonContract contract) => default; // 0x000000018635DFB0-0x000000018635E1D0
		private object CreateList(JsonReader reader, System.Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) => default; // 0x0000000186359780-0x0000000186359E70
		private bool HasNoDefinedType(JsonContract contract) => default; // 0x000000018635EA40-0x000000018635EB30
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, System.Type targetType) => default; // 0x000000018635E1D0-0x000000018635E520
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) => default; // 0x0000000186364320-0x0000000186364790
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) {
			useExistingValue = default;
			currentValue = default;
			propertyContract = default;
			gottenCurrentValue = default;
			return default;
		} // 0x00000001863580A0-0x0000000186358650
		private void AddReference(JsonReader reader, string id, object value) {} // 0x0000000186357E40-0x00000001863580A0
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) => default; // 0x000000018635E9D0-0x000000018635EA40
		private bool ShouldSetPropertyValue(JsonProperty property, object value) => default; // 0x0000000186364A20-0x0000000186364CF0
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x000000018635A280-0x000000018635A700
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x0000000186359E70-0x000000018635A280
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value) {} // 0x000000018635ED50-0x000000018635EF70
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value) {} // 0x000000018635EB30-0x000000018635ED50
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) => default; // 0x000000018635EF70-0x000000018635FD80
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) => default; // 0x0000000186360490-0x0000000186360CE0
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) {} // 0x0000000186364CF0-0x0000000186364E60
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) => default; // 0x000000018635FD80-0x0000000186360490
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) => default; // 0x0000000186358A90-0x0000000186359210
		internal object CreateISerializableItem(JToken token, System.Type type, JsonISerializableContract contract, JsonProperty member) => default; // 0x0000000186358920-0x0000000186358A90
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) => default; // 0x000000018635ABA0-0x000000018635C160
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, System.Type objectType, object existingValue) => default; // 0x000000018635D340-0x000000018635D660
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, System.Type objectType) => default; // 0x0000000186363060-0x0000000186363A30
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) => default; // 0x0000000186361FF0-0x0000000186362270
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) {
			createdFromNonDefaultCreator = default;
			return default;
		} // 0x000000018635A700-0x000000018635ABA0
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) => default; // 0x0000000186360CE0-0x00000001863619B0
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) => default; // 0x0000000186364790-0x0000000186364A20
		private bool CheckPropertyName(JsonReader reader, string memberName) => default; // 0x0000000186358650-0x00000001863587F0
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) {} // 0x0000000186363FB0-0x00000001863641C0
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) => default; // 0x0000000186361F00-0x0000000186361FF0
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) {} // 0x000000018635DA50-0x000000018635DFB0
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties) {} // 0x00000001863641C0-0x0000000186364320
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth) {} // 0x000000018635E8F0-0x000000018635E9D0
	}
}
