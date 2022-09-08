/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public class CullableDictionary<TKey, TValue, TDictionary> : ICullableDictionary<TKey, TValue> // TypeDefIndex: 4976
		where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TDictionary _primary;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private TDictionary _culled;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _isCulling;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
		public IEnumerable<KeyValuePair<TKey, TValue>> Items { get => default; }
		public bool IsEmpty { get => default; }
	
		// Constructors
		public CullableDictionary() {}
	
		// Methods
		public bool TryGetValue(TKey key, out TValue value) {
			value = default;
			return default;
		}
		public void BeginCullZone() {}
		public void EndCullZone() {}
	}
}
