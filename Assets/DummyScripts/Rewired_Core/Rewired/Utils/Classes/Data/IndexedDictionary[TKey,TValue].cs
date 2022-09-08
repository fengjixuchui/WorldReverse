/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001895F2C60-0x00000001895F2CD0
	[CustomObfuscation] // 0x00000001895F2C60-0x00000001895F2CD0
	internal class IndexedDictionary<TKey, TValue> : IDictionary, IDictionary<TKey, TValue>, IReadOnlyList<TValue> // TypeDefIndex: 4320
	{
		// Fields
		private static readonly bool WGehdtGoYKIGKvRKnNsuQzYujsL;
		private static readonly bool qSISkWksASjVDSkFDsXeoPPGop;
		private IEqualityComparer<TKey> CxlUnKAGjhpBDnbYFDLUbNJKPkw;
		private IEqualityComparer<TValue> ooabukyrafXryRkJUhQNqvEtESQ;
		private readonly AList<McxTweaVquCebucWDaQJMtfANgY> WHeApkgLGAZTtUIEfvfXHvQYCck;
		private readonly ADictionary<TKey, int> uzoCjuXoZVchOYeMrSOjQzqivJq;
		private bool RFPmXuvhneQjezsggqClUZiTGte;
	
		// Properties
		public int Count { get => default; }
		public bool ContainsDuplicateKeys { get => default; }
		public bool AllowDuplicateKeys { set {} }
		public TValue this[int index] { get => default; }
		public ICollection<TKey> Keys { get => default; }
		public ICollection<TValue> Values { get => default; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get => default; }
		TValue IDictionary<TKey,TValue>.this[TKey key] { get => default; set {} }
		bool IDictionary.IsFixedSize { get => default; }
		bool IDictionary.IsReadOnly { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		int IReadOnlyList.Count { get => default; }
		object IReadOnlyList.this[int param_00009010] { get => default; }
	
		// Nested types
		private struct McxTweaVquCebucWDaQJMtfANgY // TypeDefIndex: 4321
		{
			// Fields
			public TKey VoQbUhcEgfKVubpnlLEXkujSnBHc;
			public TValue JHgsNLxiAQVnmyfVeWejfTJocIu;
	
			// Constructors
			public McxTweaVquCebucWDaQJMtfANgY(TKey key, TValue value) {
				VoQbUhcEgfKVubpnlLEXkujSnBHc = default;
				JHgsNLxiAQVnmyfVeWejfTJocIu = default;
			}
	
			// Methods
			public KeyValuePair<TKey, TValue> RHkKAifgUfCmCOaYXqRPqnplHOn() => default;
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		public struct Enumerator : IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4322
		{
			// Fields
			private IndexedDictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
			private int jKkfIpbjIavykANnmWTcMYiQOxz;
			private int mFfLSVvRgZulYzYIyEkqCMoEiNXj;
			private KeyValuePair<TKey, TValue> xbRrcEKKIAKiQkVzQCekOswVHrJ;
			private int IkrEhreRxVGUYNrGUTlbSFukAGFk;
	
			// Properties
			public KeyValuePair<TKey, TValue> Current { get => default; }
			object IEnumerator.Current { get => default; }
			DictionaryEntry IDictionaryEnumerator.Entry { get => default; }
			object IDictionaryEnumerator.Key { get => default; }
			object IDictionaryEnumerator.Value { get => default; }
	
			// Constructors
			internal Enumerator(IndexedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) : this() {
				LbwQyRfKuLNxSjFIaAsDJTuLixL = default;
				jKkfIpbjIavykANnmWTcMYiQOxz = default;
				mFfLSVvRgZulYzYIyEkqCMoEiNXj = default;
				xbRrcEKKIAKiQkVzQCekOswVHrJ = default;
				IkrEhreRxVGUYNrGUTlbSFukAGFk = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Dispose() {}
			void IEnumerator.Reset() {}
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		public sealed class KeyCollection : ICollection, ICollection<TKey> // TypeDefIndex: 4323
		{
			// Fields
			private IndexedDictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TKey>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
			[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
			public struct Enumerator : IEnumerator<TKey> // TypeDefIndex: 4324
			{
				// Fields
				private IndexedDictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
				private int mFfLSVvRgZulYzYIyEkqCMoEiNXj;
				private int jKkfIpbjIavykANnmWTcMYiQOxz;
				private TKey xMQAEwybFxHWGsoeWBzXGKqkIuk;
	
				// Properties
				public TKey Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary) : this() {
					LbwQyRfKuLNxSjFIaAsDJTuLixL = default;
					mFfLSVvRgZulYzYIyEkqCMoEiNXj = default;
					jKkfIpbjIavykANnmWTcMYiQOxz = default;
					xMQAEwybFxHWGsoeWBzXGKqkIuk = default;
				}
	
				// Methods
				public void Dispose() {}
				public bool MoveNext() => default;
				void IEnumerator.Reset() {}
			}
	
			// Constructors
			public KeyCollection() {} // Dummy constructor
			public KeyCollection(IndexedDictionary<TKey, TValue> dictionary) {}
	
			// Methods
			public void CopyTo(TKey[] array, int index) {}
			void ICollection<TKey>.Add(TKey item) {}
			void ICollection<TKey>.Clear() {}
			bool ICollection<TKey>.Contains(TKey item) => default;
			bool ICollection<TKey>.Remove(TKey item) => default;
			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			void ICollection.CopyTo(Array array, int index) {}
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
		[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
		public sealed class ValueCollection : ICollection, ICollection<TValue> // TypeDefIndex: 4325
		{
			// Fields
			private IndexedDictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TValue>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
			[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
			public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 4326
			{
				// Fields
				private IndexedDictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
				private int mFfLSVvRgZulYzYIyEkqCMoEiNXj;
				private int jKkfIpbjIavykANnmWTcMYiQOxz;
				private TValue gQYbKVkDGlhhqclRHXVPDoznkXpu;
	
				// Properties
				public TValue Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary) : this() {
					LbwQyRfKuLNxSjFIaAsDJTuLixL = default;
					mFfLSVvRgZulYzYIyEkqCMoEiNXj = default;
					jKkfIpbjIavykANnmWTcMYiQOxz = default;
					gQYbKVkDGlhhqclRHXVPDoznkXpu = default;
				}
	
				// Methods
				public void Dispose() {}
				public bool MoveNext() => default;
				void IEnumerator.Reset() {}
			}
	
			// Constructors
			public ValueCollection() {} // Dummy constructor
			public ValueCollection(IndexedDictionary<TKey, TValue> dictionary) {}
	
			// Methods
			public void CopyTo(TValue[] array, int index) {}
			void ICollection<TValue>.Add(TValue item) {}
			bool ICollection<TValue>.Remove(TValue item) => default;
			void ICollection<TValue>.Clear() {}
			bool ICollection<TValue>.Contains(TValue item) => default;
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			void ICollection.CopyTo(Array array, int index) {}
		}
	
		// Constructors
		public IndexedDictionary() {}
		public IndexedDictionary(int capacity, bool allowDuplicateKeys) {}
		static IndexedDictionary() {}
	
		// Methods
		public TValue GetValue(TKey key) => default;
		public bool TryGetValue(TKey key, out TValue value) {
			value = default;
			return default;
		}
		public TKey GetKeyAt(int index) => default;
		public KeyValuePair<TKey, TValue> GetEntryAt(int index) => default;
		public void Add(TKey key, TValue value) {}
		public void SetValue(TKey key, TValue value) {}
		public bool Remove(TKey key) => default;
		public void RemoveAt(int index) {}
		public int IndexOfKey(TKey key) => default;
		public int IndexOfValue(TValue value) => default;
		public bool ContainsKey(TKey key) => default;
		public bool ContainsValue(TValue value) => default;
		public void Clear() {}
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => default;
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		void IDictionary.Add(object key, object value) {}
		bool IDictionary.Contains(object key) => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		void IDictionary.Remove(object key) {}
		void ICollection.CopyTo(Array array, int index) {}
	}
}
