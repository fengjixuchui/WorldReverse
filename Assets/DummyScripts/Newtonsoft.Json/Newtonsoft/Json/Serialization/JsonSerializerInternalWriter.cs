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
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 5404
	{
		// Fields
		private System.Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter() {} // Dummy constructor
		public JsonSerializerInternalWriter(JsonSerializer serializer) {} // 0x0000000185E5C1A0-0x0000000185E5C240
	
		// Methods
		public void Serialize(JsonWriter jsonWriter, object value, System.Type objectType) {} // 0x0000000185E5A950-0x0000000185E5AB70
		private JsonSerializerProxy GetInternalSerializer() => default; // 0x0000000185E570B0-0x0000000185E57140
		private JsonContract GetContractSafe(object value) => default; // 0x0000000185E57000-0x0000000185E570B0
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) {} // 0x0000000185E5A1B0-0x0000000185E5A390
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) {} // 0x0000000185E5A490-0x0000000185E5A950
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) => default; // 0x0000000185E57EE0-0x0000000185E58000
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) => default; // 0x0000000185E5AF00-0x0000000185E5B0B0
		private bool ShouldWriteProperty(object memberValue, JsonProperty property) => default; // 0x0000000185E5AD90-0x0000000185E5AF00
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x0000000185E56AD0-0x0000000185E57000
		private void WriteReference(JsonWriter writer, object value) {} // 0x0000000185E5BA60-0x0000000185E5BC70
		private string GetReference(JsonWriter writer, object value) => default; // 0x0000000185E57580-0x0000000185E576F0
		internal static bool TryConvertToString(object value, System.Type type, out string s) {
			s = default;
			return default;
		} // 0x0000000185E5B420-0x0000000185E5B670
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) {} // 0x0000000185E5A390-0x0000000185E5A490
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value) {} // 0x0000000185E57D10-0x0000000185E57EE0
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value) {} // 0x0000000185E57B40-0x0000000185E57D10
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E59B00-0x0000000185E5A1B0
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) {
			memberContract = default;
			memberValue = default;
			return default;
		} // 0x0000000185E56660-0x0000000185E56AD0
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E5B670-0x0000000185E5B890
		private void WriteReferenceIdProperty(JsonWriter writer, System.Type type, object value) {} // 0x0000000185E5B890-0x0000000185E5BA60
		private void WriteTypeProperty(JsonWriter writer, System.Type type) {} // 0x0000000185E5BF90-0x0000000185E5C1A0
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) => default; // 0x0000000185E577D0-0x0000000185E57840
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) => default; // 0x0000000185E578B0-0x0000000185E57920
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) => default; // 0x0000000185E57840-0x0000000185E578B0
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E58000-0x0000000185E583F0
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E59030-0x0000000185E594F0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E594F0-0x0000000185E596D0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) {} // 0x0000000185E596D0-0x0000000185E59B00
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x0000000185E5BC70-0x0000000185E5BF90
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E58AC0-0x0000000185E59030
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) => default; // 0x0000000185E5B0B0-0x0000000185E5B420
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) {} // 0x0000000185E583F0-0x0000000185E58AC0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) {
			escape = default;
			return default;
		} // 0x0000000185E57140-0x0000000185E57580
		private void HandleError(JsonWriter writer, int initialDepth) {} // 0x0000000185E576F0-0x0000000185E577D0
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) => default; // 0x0000000185E5AB70-0x0000000185E5AD90
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) => default; // 0x0000000185E57920-0x0000000185E57B40
	}
}
