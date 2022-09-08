/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public abstract class SerializableDictionary<TK, TV> : ISerializationCallbackReceiver // TypeDefIndex: 8516
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<TK> _keys;
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<TV> _values;
		private Dictionary<TK, TV> _dictionary;
	
		// Properties
		public int Count { get; }
		public Dictionary<TK, TV> Keys { get; }
		public Dictionary<TK, TV> Values { get; }
		public TV this[TK k] { get => default; set {} }
	
		// Constructors
		public SerializableDictionary() {}
	
		// Methods
		public void Add(TK key, TV val) {}
		public bool Remove(TK key) => default;
		public void Clear() {}
		public Dictionary<TK, TV> GetEnumerator() => default;
		public void OnAfterDeserialize() {}
		public void OnBeforeSerialize() {}
	}
}
