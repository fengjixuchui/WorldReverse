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
	public abstract class fiValue<T> : fiValueProxyEditor, fiIValueProxyAPI, ISerializationCallbackReceiver // TypeDefIndex: 4860
	{
		// Fields
		public T Value;
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		private string SerializedState;
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		private List<UnityEngine.Object> SerializedObjectReferences;
	
		// Properties
		object fiIValueProxyAPI.Value { get; set; }
	
		// Constructors
		protected fiValue() {}
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {}
		void ISerializationCallbackReceiver.OnAfterDeserialize() {}
		void fiIValueProxyAPI.SaveState() {}
		void fiIValueProxyAPI.LoadState() {}
		private void Serialize() {}
		private void Deserialize() {}
	}
}
