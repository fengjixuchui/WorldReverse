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

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x000000018966ABA0-0x000000018966AC10
	[CustomObfuscation] // 0x000000018966ABA0-0x000000018966AC10
	internal class ADictionary<TKey, TValue> : IDictionary, IDictionary<TKey, TValue> // TypeDefIndex: 4313
	{
		// Fields
		private const string kwfuRjsZDUXrelJeCGQpYdraGKR = "Version"; // Metadata: 0x00AC4EAE
		private const string cZkJDgAgRAMCaCazgzUrgASUnVG = "HashSize"; // Metadata: 0x00AC4EB9
		private const string sVfintwfYdBqVKzMnDycsLznkyja = "KeyValuePairs"; // Metadata: 0x00AC4EC5
		private const string svkguqveuhynZWfnfAdyfgiKcIiK = "Comparer"; // Metadata: 0x00AC4ED6
		private int[] qGaMYlHsqJBlIcPeaIimFjKSzAXf;
		internal Entry[] _entries;
		internal int _count;
		private int wyCzBtxDiYHWdJxUIaVcrhitjEkf;
		private int sQrzaytHzEaFnInVPIRQoBDHCYN;
		private int FBDDgkGsBCdENkbsiJNLrgqPpHXC;
		private int XgIAQrGhAxqovdeEirMSGrnEIdiX;
		private IEqualityComparer<TKey> CxlUnKAGjhpBDnbYFDLUbNJKPkw;
		private IEqualityComparer<TValue> ooabukyrafXryRkJUhQNqvEtESQ;
		private KeyCollection PczZmwlKZffAWXLQaVTRvCWjchW;
		private ValueCollection qmzoTsMXQWlxxgxeInzhrPetPQC;
		private readonly object hXfFbNklCHLuuDBVVoEKlNLfPpvH;
		private static readonly bool WGehdtGoYKIGKvRKnNsuQzYujsL;
		private static readonly bool qSISkWksASjVDSkFDsXeoPPGop;
	
		// Properties
		public int Count { get => default; }
		public KeyCollection Keys { get => default; }
		public ValueCollection Values { get => default; }
		public TValue this[TKey key] { get => default; set {} }
		ICollection<TKey> IDictionary<TKey,TValue>.Keys { get => default; }
		ICollection<TValue> IDictionary<TKey,TValue>.Values { get => default; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		bool IDictionary.IsFixedSize { get => default; }
		bool IDictionary.IsReadOnly { get => default; }
		ICollection IDictionary.Keys { get => default; }
		ICollection IDictionary.Values { get => default; }
		object IDictionary.this[object key] { get => default; set {} }
	
		// Nested types
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		internal struct Entry // TypeDefIndex: 4314
		{
			// Fields
			public int hashCode;
			public int next;
			public TKey key;
			public TValue value;
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
		[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
		public struct Enumerator : IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4315
		{
			// Fields
			private ADictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
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
			internal Enumerator(ADictionary<TKey, TValue> dictionary, int getEnumeratorRetType) : this() {
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
		public sealed class KeyCollection : ICollection, ICollection<TKey> // TypeDefIndex: 4316
		{
			// Fields
			private ADictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TKey>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
			[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
			public struct Enumerator : IEnumerator<TKey> // TypeDefIndex: 4317
			{
				// Fields
				private ADictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
				private int mFfLSVvRgZulYzYIyEkqCMoEiNXj;
				private int jKkfIpbjIavykANnmWTcMYiQOxz;
				private TKey xMQAEwybFxHWGsoeWBzXGKqkIuk;
	
				// Properties
				public TKey Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(ADictionary<TKey, TValue> dictionary) : this() {
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
			public KeyCollection(ADictionary<TKey, TValue> dictionary) {}
	
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
		public sealed class ValueCollection : ICollection, ICollection<TValue> // TypeDefIndex: 4318
		{
			// Fields
			private ADictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
	
			// Properties
			public int Count { get => default; }
			bool ICollection<TValue>.IsReadOnly { get => default; }
			bool ICollection.IsSynchronized { get => default; }
			object ICollection.SyncRoot { get => default; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
			[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
			public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 4319
			{
				// Fields
				private ADictionary<TKey, TValue> LbwQyRfKuLNxSjFIaAsDJTuLixL;
				private int mFfLSVvRgZulYzYIyEkqCMoEiNXj;
				private int jKkfIpbjIavykANnmWTcMYiQOxz;
				private TValue gQYbKVkDGlhhqclRHXVPDoznkXpu;
	
				// Properties
				public TValue Current { get => default; }
				object IEnumerator.Current { get => default; }
	
				// Constructors
				internal Enumerator(ADictionary<TKey, TValue> dictionary) : this() {
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
			public ValueCollection(ADictionary<TKey, TValue> dictionary) {}
	
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
		public ADictionary() {}
		public ADictionary(int capacity) {}
		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer) {}
		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer) {}
		static ADictionary() {}
	
		// Methods
		public void Add(TKey key, TValue value) {}
		public void Clear() {}
		public bool ContainsKey(TKey key) => default;
		public bool ContainsValue(TValue value) => default;
		public Enumerator GetEnumerator() => default;
		public bool Remove(TKey key) => default;
		public bool TryGetValue(TKey key, out TValue value) {
			value = default;
			return default;
		}
		public TValue GetValueSafe(TKey key) => default;
		public int IndexOfKey(TKey key) => default;
		public int IndexOfValue(TValue value) => default;
		private void dltGwNGuOzjStdhAgzeuPOwejmfS(KeyValuePair<TKey, TValue>[] param_00008fbf, int param_00008fc0) {}
		private void YJaAHaimrHWIfKrgfWxeihnqrcza(int param_00008fc1) {}
		private void cstwlfTlxxCXbEfllWofrtFdGPqh(TKey param_00008fc2, TValue param_00008fc3, bool param_00008fc4) {}
		private void SSgoHVLKmdbMSiSYImMBoZFCtiP() {}
		private void SSgoHVLKmdbMSiSYImMBoZFCtiP(int param_00008fc5, bool param_00008fc6) {}
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => default;
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) {}
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) => default;
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) => default;
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) {}
		void ICollection.CopyTo(Array array, int index) {}
		IEnumerator IEnumerable.GetEnumerator() => default;
		void IDictionary.Add(object key, object value) {}
		bool IDictionary.Contains(object key) => default;
		IDictionaryEnumerator IDictionary.GetEnumerator() => default;
		void IDictionary.Remove(object key) {}
		private static bool ZZQBFWEnBOntoXDfEnPMEBmVtMI(object param_00008fd5) => default;
		private static void TpwEapuFMOXMTZQCXRiMjbCLtgY<T>(object param_00008fd6, string param_00008fd7) {}
	}
}
