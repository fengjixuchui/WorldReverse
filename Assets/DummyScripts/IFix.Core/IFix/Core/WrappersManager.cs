/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 45: IFix.Core.dll - Assembly: IFix.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5033-5067

namespace IFix.Core
{
	public interface WrappersManager // TypeDefIndex: 5066
	{
		// Methods
		Delegate CreateDelegate(System.Type type, int id, object anon);
		AnonymousStorey CreateBridge(int fieldNum, int[] slots, VirtualMachine virtualMachine);
		object CreateWrapper(int id);
		object InitWrapperArray(int len);
	}
}
