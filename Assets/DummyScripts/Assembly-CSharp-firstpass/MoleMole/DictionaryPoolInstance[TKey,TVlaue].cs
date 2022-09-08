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
	public class DictionaryPoolInstance<TKey, TVlaue> : ObjectPoolProxy // TypeDefIndex: 7441
	{
		// Fields
		protected ConcurrentHashSet<Dictionary<TKey, TVlaue>> _set;
		private Dictionary<IEqualityComparer<TKey>, Stack<Dictionary<TKey, TVlaue>>> dict;
	
		// Properties
		protected ICollection _debugCache { get => default; }
		public int debugRecycleSetElementCount { get => default; }
		public int cacheCount { get => default; }
		public ObjectPoolDebugStat debugger { get; protected set; }
	
		// Constructors
		public DictionaryPoolInstance() {}
	
		// Methods
		protected void InitializeDebugInfo(System.Type type, bool bGeneric) {}
		protected void OnAllocateElement(Dictionary<TKey, TVlaue> element) {}
		protected void PreDeallocate() {}
		protected void OnDeallocateElement(Dictionary<TKey, TVlaue> instance) {}
		protected void OnClearAll() {}
		public override string ToString() => default;
		private Stack<Dictionary<TKey, TVlaue>> GetStackByComparer(IEqualityComparer<TKey> comparer) => default;
		public Dictionary<TKey, TVlaue> Allocate(IEqualityComparer<TKey> comparer) => default;
		public void Deallocate(Dictionary<TKey, TVlaue> instance) {}
		public void Deallocate(ref Dictionary<TKey, TVlaue> instance) {}
		public void ReleaseAllCache() {}
	}
}
