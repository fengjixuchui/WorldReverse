/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class HashSetPoolInstance<TKey> : ObjectPoolProxy // TypeDefIndex: 7442
	{
		// Fields
		protected HashSet<HashSet<TKey>> _set;
		protected ObjectPoolDebugStat debugger;
		private Dictionary<IEqualityComparer<TKey>, Stack<HashSet<TKey>>> dict;
	
		// Properties
		protected ICollection _debugCache { get => default; }
		public int debugRecycleSetElementCount { get => default; }
		public int cacheCount { get => default; }
	
		// Constructors
		public HashSetPoolInstance() {}
	
		// Methods
		protected void InitializeDebugInfo(System.Type type, bool bGeneric) {}
		protected void OnAllocateElement(HashSet<TKey> element) {}
		protected void PreDeallocate() {}
		protected void OnDeallocateElement(HashSet<TKey> instance) {}
		protected void OnClearAll() {}
		public override string ToString() => default;
		private Stack<HashSet<TKey>> GetStackByComparer(IEqualityComparer<TKey> comparer) => default;
		public HashSet<TKey> Allocate(IEqualityComparer<TKey> comparer) => default;
		public void Deallocate(HashSet<TKey> instance) {}
		public void Deallocate(ref HashSet<TKey> instance) {}
		public void ReleaseAllCache() {}
	}
}
