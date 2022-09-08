/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Interfaces
{
	public interface IRegistrar<T> // TypeDefIndex: 3526
		where T : class
	{
		// Methods
		void Register(T registrant);
		void Deregister(T registrant);
	}
}
