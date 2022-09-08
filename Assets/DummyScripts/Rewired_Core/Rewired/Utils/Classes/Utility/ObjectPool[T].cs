/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class ObjectPool<T> : IObjectPool<T>, IObjectPool // TypeDefIndex: 4398
		where T : class
	{
		// Fields
		protected readonly Queue<T> _pool;
		protected readonly Func<T> _createInstanceDelegate;
		protected readonly Action<T> _processOnReturnDelegate;
		private ulong pbQDaYJgPflojVjuHQmFyxQcOKp;
	
		// Constructors
		public ObjectPool() {} // Dummy constructor
		public ObjectPool(int startingSize, Func<T> createInstanceDelegate, Action<T> processOnReturnDelegate = null) {}
		public ObjectPool(Func<T> instancerDelegate) {}
	
		// Methods
		public T Get() => default;
		public bool Return(T item) => default;
		bool IObjectPool.Return(object param_000092ce) => default;
		protected T CreateInstance() => default;
		protected ulong IncrementInstanceCount() => default;
	}
}
