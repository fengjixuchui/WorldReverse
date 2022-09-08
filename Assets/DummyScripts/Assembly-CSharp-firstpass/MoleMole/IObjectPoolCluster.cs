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
	public interface IObjectPoolCluster // TypeDefIndex: 7455
	{
		// Methods
		T Allocate<T>()
			where T : class, new();
		void Deallocate(object objInstance);
		void ReplaceAllocator(System.Type t, Func<object> inAllocator);
		object Allocate(System.Type t);
		void Deallocate(System.Type t, object obj);
	}
}
