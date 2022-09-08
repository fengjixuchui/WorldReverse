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
	internal class DenseHashSetExBase<T> : Dictionary<T, T>, IDenseHashSetEx<T> // TypeDefIndex: 10511
	{
		// Properties
		int MoleMole.IDenseHashSet.Count { get => default; }
	
		// Constructors
		public DenseHashSetExBase() {}
		public DenseHashSetExBase(int capacity) {}
		public DenseHashSetExBase(IEqualityComparer<T> comparer) {}
	
		// Methods
		public bool Add(T value) => default;
		public bool Contains(T value) => default;
		bool MoleMole.IDenseHashSetEx.TryGetValue(T key, out T value) {
			value = default;
			return default;
		}
		void MoleMole.IDenseHashSet.Clear() {}
		bool MoleMole.IDenseHashSet.Remove(T value) => default;
	}
}
