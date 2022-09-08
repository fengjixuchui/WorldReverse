/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public static class fiSerializationManager // TypeDefIndex: 5008
	{
		// Fields
		private static DeferredSerialization s_inspectedObjectSerialization; // 0x00
		[NonSerialized]
		public static bool DisableAutomaticSerialization; // 0x08
		private static readonly List<ISerializedObject> s_pendingDeserializations; // 0x10
		private static readonly List<ISerializedObject> s_pendingSerializations; // 0x18
		private static readonly Dictionary<ISerializedObject, fiSerializedObjectSnapshot> s_snapshots; // 0x20
		public static HashSet<UnityEngine.Object> DirtyForceSerialize; // 0x28
		private static ISerializedObject[] s_cachedSelection; // 0x30
		private static HashSet<ISerializedObject> s_seen; // 0x38
	
		// Nested types
		private class DeferredSerialization // TypeDefIndex: 5009
		{
			// Fields
			private static TimeSpan DELAY; // 0x00
			private UnityEngine.Object _tracking; // 0x10
			private DateTime _startTime; // 0x18
	
			// Constructors
			public DeferredSerialization() {} // 0x0000000185CEA470-0x0000000185CEA4D0
			static DeferredSerialization() {} // 0x0000000185CEA3E0-0x0000000185CEA470
	
			// Methods
			public void RequestSerialization(UnityEngine.Object tracking) {} // 0x0000000185CEA000-0x0000000185CEA1F0
			private void Update() {} // 0x0000000185CEA1F0-0x0000000185CEA3E0
		}
	
		// Constructors
		static fiSerializationManager() {} // 0x0000000185D03FD0-0x0000000185D04210
	
		// Methods
		private static bool SupportsMultithreading<TSerializer>()
			where TSerializer : BaseSerializer => default;
		public static void OnUnityObjectAwake<TSerializer>(ISerializedObject obj)
			where TSerializer : BaseSerializer {}
		public static void OnUnityObjectDeserialize<TSerializer>(ISerializedObject obj)
			where TSerializer : BaseSerializer {}
		public static void OnUnityObjectSerialize<TSerializer>(ISerializedObject obj)
			where TSerializer : BaseSerializer {}
		private static void OnEditorUpdate() {} // 0x0000000185D03450-0x0000000185D03CA0
		private static void DoDeserialize(ISerializedObject obj) {} // 0x0000000185D02BE0-0x0000000185D02C60
		private static void DoSerialize(ISerializedObject obj) {} // 0x0000000185D02C60-0x0000000185D030E0
		private static void HandleReset(ISerializedObject obj) {} // 0x0000000185D030E0-0x0000000185D03450
		private static bool IsNullOrEmpty<T>(IList<T> list) => default;
		public static void SerializeObject(System.Type logContext, object obj) {} // 0x0000000185D03CA0-0x0000000185D03E20
		private static void Serialize(System.Type logContext, object obj) {} // 0x0000000185D03E20-0x0000000185D03FD0
	}
}
