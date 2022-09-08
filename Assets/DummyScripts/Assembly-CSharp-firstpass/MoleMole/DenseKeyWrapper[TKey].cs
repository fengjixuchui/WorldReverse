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
	internal struct DenseKeyWrapper<TKey> // TypeDefIndex: 10520
	{
		// Fields
		private byte _tag;
		public TKey Key;
	
		// Properties
		public bool Empty { get => default; }
		public bool Deleted { get => default; }
	
		// Nested types
		public class Comparer : IDenseHashTableComparer<DenseKeyWrapper<TKey>> // TypeDefIndex: 10521
		{
			// Fields
			private static readonly Comparer<TKey> _default;
			private IEqualityComparer<TKey> _comparer;
	
			// Properties
			public static Comparer<TKey> Default { get => default; }
	
			// Constructors
			public Comparer() {}
			public Comparer(IEqualityComparer<TKey> comparer) {}
			static Comparer() {}
	
			// Methods
			public bool Equals(ref DenseKeyWrapper<TKey> x, ref DenseKeyWrapper<TKey> y) => default;
		}
	
		// Constructors
		public DenseKeyWrapper(byte tag) : this() {
			_tag = default;
			Key = default;
		}
		public DenseKeyWrapper(TKey key, byte tag) : this() {
			_tag = default;
			Key = default;
		}
	}
}
