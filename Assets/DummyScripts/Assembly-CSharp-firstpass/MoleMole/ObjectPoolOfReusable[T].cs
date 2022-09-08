/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class ObjectPoolOfReusable<T> : ObjectPoolProxy // TypeDefIndex: 7487
		where T : class, IReusable
	{
		// Fields
		private LockFreeCollection _cache;
		private ConcurrentHashSet<T> _set;
		private ObjectPoolDebugStat debugger;
	
		// Properties
		public int debugRecycleSetElementCount { get => default; }
		public int cacheCount { get => default; }
		public int CacheCount { get => default; }
	
		// Constructors
		public ObjectPoolOfReusable() {}
	
		// Methods
		private void Init() {}
		public static T AllocatePooledObjectWithSpawner<TSpawner>()
			where TSpawner : class, ISpawner<T>, new() => default;
		public static T AllocatePooledObjectWithSpawnerAndPolisher<TSpawner, TPolisher>()
			where TSpawner : class, ISpawner<T>, new()
			where TPolisher : class, IPolisher<T>, new() => default;
		public static void DeallocatePooledObject(ref T inObject) {}
		public static void DeallocatePooledObject(T inObject) {}
		public T Allocate(ISpawner<T> spawner) => default;
		public T Allocate(ISpawner<T> spawner, IPolisher<T> polisher) => default;
		public T Allocate<T1>(T1 param1, ISpawner<T, T1> spawner, IPolisher<T, T1> polisher) => default;
		public T Allocate<T1, T2>(T1 param1, T2 param2, ISpawner<T, T1, T2> spawner, IPolisher<T, T1, T2> polisher) => default;
		public T Allocate<T1, T2, T3>(T1 param1, T2 param2, T3 param3, ISpawner<T, T1, T2, T3> spawner, IPolisher<T, T1, T2, T3> polisher) => default;
		public T Allocate<T1, T2, T3, T4>(T1 param1, T2 param2, T3 param3, T4 param4, ISpawner<T, T1, T2, T3, T4> spawner, IPolisher<T, T1, T2, T3, T4> polisher) => default;
		public T Allocate<T1, T2, T3, T4, T5>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, ISpawner<T, T1, T2, T3, T4, T5> spawner, IPolisher<T, T1, T2, T3, T4, T5> polisher) => default;
		public void Deallocate(T instance) {}
		public void ReleaseAllCache() {}
	}
}
