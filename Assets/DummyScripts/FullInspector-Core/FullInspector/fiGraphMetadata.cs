/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public class fiGraphMetadata // TypeDefIndex: 4801
	{
		// Fields
		private Dictionary<string, List<object>> _precomputedData; // 0x10
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private CullableDictionary<int, fiGraphMetadata, IntDictionary<fiGraphMetadata>> _childrenInt; // 0x18
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private CullableDictionary<string, fiGraphMetadata, Dictionary<string, fiGraphMetadata>> _childrenString; // 0x20
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		private CullableDictionary<System.Type, object, Dictionary<System.Type, object>> _metadata; // 0x28
		private fiGraphMetadata _parentMetadata; // 0x30
		private fiUnityObjectReference _targetObject; // 0x38
		private string _accessPath; // 0x40
	
		// Properties
		private UnityEngine.Object TargetObject { get => default; } // 0x0000000185CFDD20-0x0000000185CFDDC0 
		public string Path { get => default; } // 0x0000000185CFDCC0-0x0000000185CFDD20 
	
		// Nested types
		public struct MetadataMigration // TypeDefIndex: 4802
		{
			// Fields
			public int NewIndex; // 0x00
			public int OldIndex; // 0x04
		}
	
		// Constructors
		public fiGraphMetadata() {} // 0x0000000185CFD9D0-0x0000000185CFDA40
		public fiGraphMetadata(fiUnityObjectReference targetObject) {} // 0x0000000185CFD920-0x0000000185CFD9D0
		private fiGraphMetadata(fiGraphMetadata parentMetadata, string accessKey) {} // 0x0000000185CFDA40-0x0000000185CFDCC0
	
		// Methods
		public bool ShouldSerialize() => default; // 0x0000000185CFD880-0x0000000185CFD920
		public void Serialize<TPersistentData>(out string[] keys_, out TPersistentData[] values_)
			where TPersistentData : IGraphMetadataItemPersistent {
			keys_ = default;
			values_ = default;
		}
		private void AddSerializeData<TPersistentData>(List<string> keys, List<TPersistentData> values)
			where TPersistentData : IGraphMetadataItemPersistent {}
		public void Deserialize<TPersistentData>(string[] keys, TPersistentData[] values) {}
		public void BeginCullZone() {} // 0x0000000185CFD2A0-0x0000000185CFD350
		public void EndCullZone() {} // 0x0000000185CFD350-0x0000000185CFD400
		private void RebuildAccessPath(string accessKey) {} // 0x0000000185CFD5E0-0x0000000185CFD720
		public void SetChild(int identifier, fiGraphMetadata metadata) {} // 0x0000000185CFD7D0-0x0000000185CFD880
		public void SetChild(string identifier, fiGraphMetadata metadata) {} // 0x0000000185CFD720-0x0000000185CFD7D0
		public static void MigrateMetadata<T>(fiGraphMetadata metadata, T[] previous, T[] updated) {}
		private static List<MetadataMigration> ComputeNeededMigrations<T>(fiGraphMetadata metadata, T[] previous, T[] updated) => default;
		public fiGraphMetadataChild Enter(int childIdentifier) => default; // 0x0000000185CFD4E0-0x0000000185CFD5E0
		public fiGraphMetadataChild Enter(string childIdentifier) => default; // 0x0000000185CFD400-0x0000000185CFD4E0
		public T GetPersistentMetadata<T>()
			where T : IGraphMetadataItemPersistent, new() => default;
		public T GetPersistentMetadata<T>(out bool wasCreated)
			where T : IGraphMetadataItemPersistent, new() {
			wasCreated = default;
			return default;
		}
		public T GetMetadata<T>()
			where T : IGraphMetadataItemNotPersistent, new() => default;
		public T GetMetadata<T>(out bool wasCreated)
			where T : IGraphMetadataItemNotPersistent, new() {
			wasCreated = default;
			return default;
		}
		private T GetCommonMetadata<T>(out bool wasCreated)
			where T : new() {
			wasCreated = default;
			return default;
		}
		public T GetInheritedMetadata<T>()
			where T : IGraphMetadataItemNotPersistent, new() => default;
		public bool TryGetMetadata<T>(out T metadata)
			where T : IGraphMetadataItemNotPersistent, new() {
			metadata = default;
			return default;
		}
		public bool TryGetInheritedMetadata<T>(out T metadata)
			where T : IGraphMetadataItemNotPersistent, new() {
			metadata = default;
			return default;
		}
	}
}
