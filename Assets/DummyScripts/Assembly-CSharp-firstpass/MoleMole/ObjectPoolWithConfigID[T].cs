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
	public class ObjectPoolWithConfigID<T> // TypeDefIndex: 7473
		where T : class, new()
	{
		// Fields
		private ObjectPoolInstance<T> _cache;
		private Dictionary<uint, ObjectPoolInstance<T>> _cacheDict;
	
		// Constructors
		public ObjectPoolWithConfigID() {}
		public ObjectPoolWithConfigID(int capacity) {}
	
		// Methods
		private ObjectPoolInstance<T> GetCache(uint? key) => default;
		public T Allocate(uint? key = default) => default;
		public T Allocate(ref bool isNew, uint? key = default) => default;
		public void Deallocate(T instance, uint? key = default) {}
		public void ReleaseAllCache() {}
		public void ForEach(Action<T> callback) {}
	}
}
