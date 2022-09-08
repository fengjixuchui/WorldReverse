/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public class fsSerializer // TypeDefIndex: 4732
	{
		// Fields
		private static HashSet<string> _reservedKeywords; // 0x00
		private const string Key_ObjectReference = "$ref"; // Metadata: 0x00ADA6B1
		private const string Key_ObjectDefinition = "$id"; // Metadata: 0x00ADA6B9
		private const string Key_InstanceType = "$type"; // Metadata: 0x00ADA6C0
		private const string Key_Version = "$version"; // Metadata: 0x00ADA6C9
		private const string Key_Content = "$content"; // Metadata: 0x00ADA6D5
		private Dictionary<System.Type, fsBaseConverter> _cachedConverterTypeInstances; // 0x10
		private Dictionary<System.Type, fsBaseConverter> _cachedConverters; // 0x18
		private Dictionary<System.Type, List<fsObjectProcessor>> _cachedProcessors; // 0x20
		private readonly List<fsConverter> _availableConverters; // 0x28
		private readonly Dictionary<System.Type, fsDirectConverter> _availableDirectConverters; // 0x30
		private readonly List<fsObjectProcessor> _processors; // 0x38
		private readonly fsCyclicReferenceManager _references; // 0x40
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x48
		public fsContext Context; // 0x50
		public fsConfig Config; // 0x58
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 4733
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x0000000188DD5BE0-0x0000000188DD5C90
	
			// Methods
			public void WriteDefinition(int id, fsData data) {} // 0x0000000188DD5880-0x0000000188DD59E0
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x0000000188DD59E0-0x0000000188DD5BE0
			public void Clear() {} // 0x0000000188DD57F0-0x0000000188DD5880
		}
	
		// Constructors
		static fsSerializer() {} // 0x0000000188DE0160-0x0000000188DE0260
		public fsSerializer() {} // 0x0000000188DE0260-0x0000000188DE0C20
	
		// Methods
		public static bool IsReservedKeyword(string key) => default; // 0x0000000188DDF670-0x0000000188DDF720
		private static bool IsObjectReference(fsData data) => default; // 0x0000000188DDF5C0-0x0000000188DDF670
		private static bool IsObjectDefinition(fsData data) => default; // 0x0000000188DDF510-0x0000000188DDF5C0
		private static bool IsVersioned(fsData data) => default; // 0x0000000188DDF7D0-0x0000000188DDF880
		private static bool IsTypeSpecified(fsData data) => default; // 0x0000000188DDF720-0x0000000188DDF7D0
		private static bool IsWrappedData(fsData data) => default; // 0x0000000188DDF880-0x0000000188DDF930
		public static void StripDeserializationMetadata(ref fsData data) {} // 0x0000000188DDF930-0x0000000188DDFAC0
		private static void ConvertLegacyData(ref fsData data) {} // 0x0000000188DDCAB0-0x0000000188DDCE30
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000188DDF430-0x0000000188DDF510
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DDF160-0x0000000188DDF250
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x0000000188DDF350-0x0000000188DDF430
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000188DDF250-0x0000000188DDF350
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000188DDF080-0x0000000188DDF160
		private static void EnsureDictionary(fsData data) {} // 0x0000000188DDCE30-0x0000000188DDCF00
		public void AddProcessor(fsObjectProcessor processor) {} // 0x0000000188DDCA00-0x0000000188DDCAB0
		public void RemoveProcessor<TProcessor>() {}
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default; // 0x0000000188DDD380-0x0000000188DDD5B0
		public void AddConverter(fsBaseConverter converter) {} // 0x0000000188DDC750-0x0000000188DDCA00
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) => default; // 0x0000000188DDCF00-0x0000000188DDD380
		public fsResult TrySerialize<T>(T instance, out fsData data) {
			data = default;
			return default;
		}
		public fsResult TryDeserialize<T>(fsData data, ref T instance) => default;
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DE00A0-0x0000000188DE0160
		public fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DDFE80-0x0000000188DE00A0
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DDE6E0-0x0000000188DDEAF0
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DDEAF0-0x0000000188DDED30
		private fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DDED30-0x0000000188DDEF90
		private fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000188DDEF90-0x0000000188DDF080
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x0000000188DDFAC0-0x0000000188DDFB70
		public fsResult TryDeserialize(fsData data, System.Type storageType, System.Type overrideConverterType, ref object result) => default; // 0x0000000188DDFB70-0x0000000188DDFE80
		private fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000188DDD5B0-0x0000000188DDD7B0
		private fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000188DDD7B0-0x0000000188DDDE60
		private fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000188DDDE60-0x0000000188DDE430
		private fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x0000000188DDE430-0x0000000188DDE5A0
		private fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x0000000188DDE5A0-0x0000000188DDE6E0
	}
}
