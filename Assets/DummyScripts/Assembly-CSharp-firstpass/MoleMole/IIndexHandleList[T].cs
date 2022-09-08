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
	public interface IIndexHandleList<T> : IList<T>, IIndexHandleListWithCapacity // TypeDefIndex: 10568
	{
		// Properties
		int RealCount { get; }
	
		// Methods
		T GetFirstValid();
		bool IndexRangeValid(int index);
		bool IndexValid(int index);
		int IndexAdd(T item);
		int IndexAdd(T item, bool newArray);
		int SwapAt(int index, T item);
		int IndexRemoveAt(int index);
		string ToString();
	}
}
