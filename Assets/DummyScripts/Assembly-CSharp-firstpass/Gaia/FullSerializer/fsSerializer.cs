/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public class fsSerializer // TypeDefIndex: 9261
	{
		// Fields
		private static HashSet<string> _reservedKeywords; // 0x00
		private const string Key_ObjectReference = "$ref"; // Metadata: 0x00AE56E2
		private const string Key_ObjectDefinition = "$id"; // Metadata: 0x00AE56EA
		private const string Key_InstanceType = "$type"; // Metadata: 0x00AE56F1
		private const string Key_Version = "$version"; // Metadata: 0x00AE56FA
		private const string Key_Content = "$content"; // Metadata: 0x00AE5706
		private Dictionary<System.Type, fsBaseConverter> _cachedConverters; // 0x10
		private Dictionary<System.Type, List<fsObjectProcessor>> _cachedProcessors; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<System.Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private readonly fsCyclicReferenceManager _references; // 0x38
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x40
		public fsContext Context; // 0x48
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 9262
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x0000000186B55DC0-0x0000000186B55E70
	
			// Methods
			// [XID] // 0x00000001899BE090-0x00000001899BE0B0
			public void WriteDefinition(int id, fsData data) {} // 0x0000000186B559C0-0x0000000186B55B70
			// [XID] // 0x0000000189A86310-0x0000000189A86330
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x0000000186B55B70-0x0000000186B55DC0
			// [XID] // 0x0000000189756BE0-0x0000000189756C00
			public void Clear() {} // 0x0000000186B55910-0x0000000186B559C0
		}
	
		// Constructors
		static fsSerializer() {} // 0x0000000186B5D190-0x0000000186B5D290
		public fsSerializer() {} // 0x0000000186B5D290-0x0000000186B5D9A0
	
		// Methods
		// [XID] // 0x0000000189A303F0-0x0000000189A30410
		public static bool IsReservedKeyword(string key) => default; // 0x0000000186B5C5D0-0x0000000186B5C6C0
		// [XID] // 0x000000018980D640-0x000000018980D660
		private static bool IsObjectReference(fsData data) => default; // 0x0000000186B5C4E0-0x0000000186B5C5D0
		// [XID] // 0x00000001898CB910-0x00000001898CB930
		private static bool IsObjectDefinition(fsData data) => default; // 0x0000000186B5C3F0-0x0000000186B5C4E0
		// [XID] // 0x0000000189ACE230-0x0000000189ACE250
		private static bool IsVersioned(fsData data) => default; // 0x0000000186B5C7B0-0x0000000186B5C8A0
		// [XID] // 0x0000000189823CA0-0x0000000189823CC0
		private static bool IsTypeSpecified(fsData data) => default; // 0x0000000186B5C6C0-0x0000000186B5C7B0
		// [XID] // 0x000000018982B760-0x000000018982B780
		private static bool IsWrappedData(fsData data) => default; // 0x0000000186B5C8A0-0x0000000186B5C990
		// [XID] // 0x0000000189832C20-0x0000000189832C40
		public static void StripDeserializationMetadata(ref fsData data) {} // 0x0000000186B5C990-0x0000000186B5CB60
		// [XID] // 0x000000018983A1C0-0x000000018983A1E0
		private static void ConvertLegacyData(ref fsData data) {} // 0x0000000186B59610-0x0000000186B599F0
		// [XID] // 0x0000000189841620-0x0000000189841640
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000186B5C2C0-0x0000000186B5C3F0
		// [XID] // 0x0000000189848B20-0x0000000189848B40
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000186B5BEE0-0x0000000186B5C030
		// [XID] // 0x0000000189AA42A0-0x0000000189AA42C0
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x0000000186B5C190-0x0000000186B5C2C0
		// [XID] // 0x0000000189B0BE10-0x0000000189B0BE30
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000186B5C030-0x0000000186B5C190
		// [XID] // 0x000000018985E830-0x000000018985E850
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000186B5BDB0-0x0000000186B5BEE0
		// [XID] // 0x0000000189720D90-0x0000000189720DB0
		private static void EnsureDictionary(fsData data) {} // 0x0000000186B599F0-0x0000000186B59AF0
		// [XID] // 0x000000018986D860-0x000000018986D880
		public void AddProcessor(fsObjectProcessor processor) {} // 0x0000000186B59520-0x0000000186B59610
		// [XID] // 0x0000000189874C90-0x0000000189874CB0
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default; // 0x0000000186B59ED0-0x0000000186B5A160
		// [XID] // 0x00000001899DAFE0-0x00000001899DB000
		public void AddConverter(fsBaseConverter converter) {} // 0x0000000186B59240-0x0000000186B59520
		// [XID] // 0x0000000189A368B0-0x0000000189A368D0
		private fsBaseConverter GetConverter(System.Type type) => default; // 0x0000000186B59AF0-0x0000000186B59ED0
		public fsResult TrySerialize<T>(T instance, out fsData data) {
			data = default;
			return default;
		}
		public fsResult TryDeserialize<T>(fsData data, ref T instance) => default;
		// [XID] // 0x000000018968CB60-0x000000018968CB80
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B5CF20-0x0000000186B5D190
		// [XID] // 0x0000000189892400-0x0000000189892420
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B5B2E0-0x0000000186B5B6E0
		// [XID] // 0x0000000189899E90-0x0000000189899EB0
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B5B6E0-0x0000000186B5B9E0
		// [XID] // 0x00000001896B90F0-0x00000001896B9110
		private fsResult InternalSerialize_3_ProcessVersioning(object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B5B9E0-0x0000000186B5BC60
		// [XID] // 0x0000000189712190-0x00000001897121B0
		private fsResult InternalSerialize_4_Converter(object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000186B5BC60-0x0000000186B5BDB0
		// [XID] // 0x000000018974C720-0x000000018974C740
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x0000000186B5CB60-0x0000000186B5CF20
		// [XID] // 0x000000018975B0E0-0x000000018975B100
		private fsResult InternalDeserialize_1_CycleReference(fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000186B5A160-0x0000000186B5A3D0
		// [XID] // 0x00000001898BEE40-0x00000001898BEE60
		private fsResult InternalDeserialize_2_Version(fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000186B5A3D0-0x0000000186B5A960
		// [XID] // 0x00000001896F7070-0x00000001896F7090
		private fsResult InternalDeserialize_3_Inheritance(fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000186B5A960-0x0000000186B5AF40
		// [XID] // 0x00000001898CDE60-0x00000001898CDE80
		private fsResult InternalDeserialize_4_Cycles(fsData data, System.Type resultType, ref object result) => default; // 0x0000000186B5AF40-0x0000000186B5B120
		// [XID] // 0x00000001899940B0-0x00000001899940D0
		private fsResult InternalDeserialize_5_Converter(fsData data, System.Type resultType, ref object result) => default; // 0x0000000186B5B120-0x0000000186B5B2E0
	}
}
