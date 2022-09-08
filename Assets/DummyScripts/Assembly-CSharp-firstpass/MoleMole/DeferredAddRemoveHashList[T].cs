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
	public class DeferredAddRemoveHashList<T> : IReusable // TypeDefIndex: 10451
		where T : class
	{
		// Fields
		private HashList<T> _hashList;
		protected List<T> _toAddValues;
		private bool _bLockVersion;
		public Action<T> onFirstAddNode;
		public Action<DoublyList<T>> onRemoveNode;
	
		// Nested types
		public class Spawner : ISpawner<DeferredAddRemoveHashList<T>> // TypeDefIndex: 10452
		{
			// Constructors
			public Spawner() {}
	
			// Methods
			public DeferredAddRemoveHashList<T> Spawn() => default;
		}
	
		// Constructors
		public DeferredAddRemoveHashList() {}
	
		// Methods
		public bool Contains(T inElement) => default;
		public void Lock() {}
		public void Unlock() {}
		private void CheckUnlocked() {}
		public void Init() {}
		public void ClearAll() {}
		public void BeforeRecycle() {}
		public void Add(T inData) {}
		public void Remove(T inData) {}
		public DoublyList<T> Begin() => default;
		public DoublyList<T> End() => default;
		public DoublyList<T> Next(DoublyList<T> it) => default;
		public bool HasNewElementToAdd() => default;
		public void AddAllToAddElements() {}
		public int Count() => default;
		public int UpdateListCount() => default;
	}
}
