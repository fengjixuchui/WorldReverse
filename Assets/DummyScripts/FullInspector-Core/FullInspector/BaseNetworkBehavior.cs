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
	public abstract class BaseNetworkBehavior : CommonBaseNetworkBehavior, ISerializedObject, ISerializationCallbackReceiver // TypeDefIndex: 4795
	{
		// Fields
		[HideInInspector] // 0x0000000189844BF0-0x0000000189844C30
		[NotSerialized] // 0x0000000189844BF0-0x0000000189844C30
		[SerializeField] // 0x0000000189844BF0-0x0000000189844C30
		private List<UnityEngine.Object> _objectReferences; // 0x30
		[HideInInspector] // 0x0000000189851BC0-0x0000000189851C00
		[NotSerialized] // 0x0000000189851BC0-0x0000000189851C00
		[SerializeField] // 0x0000000189851BC0-0x0000000189851C00
		private List<string> _serializedStateKeys; // 0x38
		[HideInInspector] // 0x0000000189BCE500-0x0000000189BCE540
		[NotSerialized] // 0x0000000189BCE500-0x0000000189BCE540
		[SerializeField] // 0x0000000189BCE500-0x0000000189BCE540
		private List<string> _serializedStateValues; // 0x40
	
		// Properties
		List<UnityEngine.Object> ISerializedObject.SerializedObjectReferences { get; set; } // 0x0000000185CE83A0-0x0000000185CE8400 0x0000000185CE8520-0x0000000185CE8580
		List<string> ISerializedObject.SerializedStateKeys { get; set; } // 0x0000000185CE8400-0x0000000185CE8460 0x0000000185CE8580-0x0000000185CE85E0
		List<string> ISerializedObject.SerializedStateValues { get; set; } // 0x0000000185CE8460-0x0000000185CE84C0 0x0000000185CE85E0-0x0000000185CE8640
		bool ISerializedObject.IsRestored { get; set; } // 0x0000000185CE8340-0x0000000185CE83A0 0x0000000185CE84C0-0x0000000185CE8520
	
		// Constructors
		static BaseNetworkBehavior() {} // 0x0000000185CE8940-0x0000000185CE8A20
		protected BaseNetworkBehavior() {} // 0x0000000185CE8A20-0x0000000185CE8A80
	
		// Methods
		protected virtual void Awake() {} // 0x0000000185CE82B0-0x0000000185CE8340
		protected virtual void OnValidate() {} // 0x0000000185CE8640-0x0000000185CE86D0
		// [ContextMenu] // 0x00000001895E86A0-0x00000001895E86D0
		public void SaveState() {} // 0x0000000185CE8740-0x0000000185CE87B0
		// [ContextMenu] // 0x00000001895EFF60-0x00000001895EFF90
		public void RestoreState() {} // 0x0000000185CE86D0-0x0000000185CE8740
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000185CE87B0-0x0000000185CE88B0
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185CE88B0-0x0000000185CE8940
	}
}
