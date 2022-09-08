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
	public abstract class BaseBehavior<TSerializer> : CommonBaseBehavior, ISerializedObject, ISerializationCallbackReceiver // TypeDefIndex: 4794
		where TSerializer : BaseSerializer
	{
		// Fields
		[HideInInspector] // 0x0000000189B634D0-0x0000000189B63510
		[NotSerialized] // 0x0000000189B634D0-0x0000000189B63510
		[SerializeField] // 0x0000000189B634D0-0x0000000189B63510
		private List<UnityEngine.Object> _objectReferences;
		[HideInInspector] // 0x0000000189B70B60-0x0000000189B70BA0
		[NotSerialized] // 0x0000000189B70B60-0x0000000189B70BA0
		[SerializeField] // 0x0000000189B70B60-0x0000000189B70BA0
		private List<string> _serializedStateKeys;
		[HideInInspector] // 0x0000000189B7DDC0-0x0000000189B7DE00
		[NotSerialized] // 0x0000000189B7DDC0-0x0000000189B7DE00
		[SerializeField] // 0x0000000189B7DDC0-0x0000000189B7DE00
		private List<string> _serializedStateValues;
	
		// Properties
		List<UnityEngine.Object> ISerializedObject.SerializedObjectReferences { get; set; }
		List<string> ISerializedObject.SerializedStateKeys { get; set; }
		List<string> ISerializedObject.SerializedStateValues { get; set; }
		bool ISerializedObject.IsRestored { get; set; }
	
		// Constructors
		static BaseBehavior() {}
		protected BaseBehavior() {}
	
		// Methods
		protected virtual void Awake() {}
		protected virtual void OnValidate() {}
		// [ContextMenu] // 0x00000001895E86A0-0x00000001895E86D0
		public void SaveState() {}
		// [ContextMenu] // 0x00000001895EFF60-0x00000001895EFF90
		public void RestoreState() {}
		void ISerializationCallbackReceiver.OnAfterDeserialize() {}
		void ISerializationCallbackReceiver.OnBeforeSerialize() {}
	}
}
