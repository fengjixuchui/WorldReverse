/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class AsyncOperationPool<T> // TypeDefIndex: 7404
		where T : AsyncOperation
	{
		// Fields
		private Queue<T> _requestPool;
		private Queue<T> _waitPool;
	
		// Constructors
		public AsyncOperationPool() {}
	
		// Methods
		public T Get() => default;
		public void Release(T t) {}
		public void Clear() {}
	}
}
