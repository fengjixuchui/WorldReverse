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
	internal class DenseHashTableComparer<TKey> : IDenseHashTableComparer<TKey> // TypeDefIndex: 10516
	{
		// Fields
		private static readonly DenseHashTableComparer<TKey> _default;
		private IEqualityComparer<TKey> _comparer;
	
		// Properties
		public static DenseHashTableComparer<TKey> Default { get => default; }
	
		// Constructors
		public DenseHashTableComparer() {}
		public DenseHashTableComparer(IEqualityComparer<TKey> comparer) {}
		static DenseHashTableComparer() {}
	
		// Methods
		public bool Equals(ref TKey key1, ref TKey key2) => default;
	}
}
