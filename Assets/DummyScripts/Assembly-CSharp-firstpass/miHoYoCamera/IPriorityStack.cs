/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public interface IPriorityStack // TypeDefIndex: 8961
	{
		// Properties
		int Count { get; }
	
		// Methods
		void Push(IPriorityStackItem item);
		IPriorityStackItem Pop(int index);
		IPriorityStackItem Peek(int index);
	}
}
