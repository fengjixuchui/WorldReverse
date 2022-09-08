/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_ObjectPool<T> // TypeDefIndex: 3416
		where T : UnityEngine.Object, new()
	{
		// Fields
		public int desiredSize;
		public Func<T> constructor;
		public Action<T> destructor;
		private Queue pool;
	
		// Constructors
		public pb_ObjectPool() {} // Dummy constructor
		public pb_ObjectPool(int initialSize, int desiredSize, Func<T> constructor, Action<T> destructor) {}
	
		// Methods
		public T Get() => default;
		public void Put(T obj) {}
		public void Empty() {}
		private static void DestroyObject(T obj) {}
		private void OnDestroy() {}
	}
}
