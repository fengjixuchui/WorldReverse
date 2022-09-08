/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public struct ScopeDictionary<K, V> : IDisposable // TypeDefIndex: 7464
	{
		// Fields
		private Dictionary<K, V> _dict;
	
		// Properties
		public int Count { get => default; }
		public V this[K key] { get => default; }
	
		// Constructors
		public ScopeDictionary(bool doesntMatter = false /* Metadata: 0x00ADE9FA */) : this() {
			_dict = default;
		}
	
		// Methods
		public void Dispose() {}
		public void Set(K key, V value) {}
		public bool ContainsKey(K key) => default;
		public bool TryGetValue(K key, out V value) {
			value = default;
			return default;
		}
	}
}
