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
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public abstract class fiBaseStorageComponent<T> : MonoBehaviour, fiIEditorOnlyTag, ISerializationCallbackReceiver // TypeDefIndex: 4862
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<UnityEngine.Object> _keys;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<T> _values;
		private IDictionary<UnityEngine.Object, T> _data;
	
		// Properties
		public IDictionary<UnityEngine.Object, T> Data { get; }
	
		// Constructors
		protected fiBaseStorageComponent() {}
	
		// Methods
		void ISerializationCallbackReceiver.OnAfterDeserialize() {}
		void ISerializationCallbackReceiver.OnBeforeSerialize() {}
	}
}
