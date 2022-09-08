/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface ILoadedResourceReceiver<T> // TypeDefIndex: 7392
		where T : UnityEngine.Object
	{
		// Properties
		bool dropEarly { get; }
	
		// Methods
		void Receive(ulong PathHash, uint handle, T obj);
		void Fail(ulong pathHash, ResourceLoadFailureReason reason);
		void Recycle();
	}
}
