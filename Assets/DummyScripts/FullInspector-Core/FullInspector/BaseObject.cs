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
	public abstract class BaseObject : fiValueProxyEditor, fiIValueProxyAPI, ISerializedObject, ISerializationCallbackReceiver // TypeDefIndex: 4858
	{
		// Fields
		[HideInInspector] // 0x0000000189B7DDC0-0x0000000189B7DE00
		[NotSerialized] // 0x0000000189B7DDC0-0x0000000189B7DE00
		[SerializeField] // 0x0000000189B7DDC0-0x0000000189B7DE00
		private List<UnityEngine.Object> _objectReferences; // 0x10
		[HideInInspector] // 0x0000000189844BF0-0x0000000189844C30
		[NotSerialized] // 0x0000000189844BF0-0x0000000189844C30
		[SerializeField] // 0x0000000189844BF0-0x0000000189844C30
		private List<string> _serializedStateKeys; // 0x18
		[HideInInspector] // 0x0000000189851BC0-0x0000000189851C00
		[NotSerialized] // 0x0000000189851BC0-0x0000000189851C00
		[SerializeField] // 0x0000000189851BC0-0x0000000189851C00
		private List<string> _serializedStateValues; // 0x20
	
		// Properties
		List<UnityEngine.Object> ISerializedObject.SerializedObjectReferences { get; set; } // 0x0000000185CE8BC0-0x0000000185CE8C20 0x0000000185CE8D40-0x0000000185CE8DA0
		List<string> ISerializedObject.SerializedStateKeys { get; set; } // 0x0000000185CE8C20-0x0000000185CE8C80 0x0000000185CE8DA0-0x0000000185CE8E00
		List<string> ISerializedObject.SerializedStateValues { get; set; } // 0x0000000185CE8C80-0x0000000185CE8CE0 0x0000000185CE8E00-0x0000000185CE8E60
		bool ISerializedObject.IsRestored { get; set; } // 0x0000000185CE8B60-0x0000000185CE8BC0 0x0000000185CE8CE0-0x0000000185CE8D40
		object fiIValueProxyAPI.Value { get; set; } // 0x0000000185CE8F00-0x0000000185CE8F60 0x0000000185CE8F60-0x0000000185CE8FB0
	
		// Constructors
		protected BaseObject() {} // 0x0000000185CE9090-0x0000000185CE9130
	
		// Methods
		void ISerializedObject.RestoreState() {} // 0x0000000185CE8A80-0x0000000185CE8AF0
		void ISerializedObject.SaveState() {} // 0x0000000185CE8AF0-0x0000000185CE8B60
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000185CE8FB0-0x0000000185CE9020
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185CE9020-0x0000000185CE9090
		void fiIValueProxyAPI.SaveState() {} // 0x0000000185CE8EB0-0x0000000185CE8F00
		void fiIValueProxyAPI.LoadState() {} // 0x0000000185CE8E60-0x0000000185CE8EB0
	}
}
