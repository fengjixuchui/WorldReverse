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
	public abstract class ObjectPoolInstance<T> : ObjectPoolInstanceBase // TypeDefIndex: 7445
		where T : class, new()
	{
		// Fields
		protected readonly Stack<T> _cache;
		protected readonly int _capacity;
	
		// Properties
		public Func<T> allocator { get; }
		protected override ICollection _debugCache { get; }
	
		// Constructors
		public ObjectPoolInstance(int capacity, bool staticPool = false /* Metadata: 0x00ADE9F6 */) {}
		public ObjectPoolInstance() {}
	
		// Methods
		protected override void Init(System.Type t, bool bGeneric) {}
		public override string ToString() => default;
		public T Allocate() => default;
		protected abstract T InternalAllocate();
		public T Allocate(ref bool isNew) => default;
		public void Deallocate(T instance) {}
		public override void ReleaseAllCache() {}
		public int CachePoolCount() => default;
		public void ForEach(Action<T> callback) {}
	}
}
