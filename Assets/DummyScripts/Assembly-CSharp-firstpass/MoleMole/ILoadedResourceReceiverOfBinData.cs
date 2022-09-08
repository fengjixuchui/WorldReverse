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
	public interface ILoadedResourceReceiverOfBinData // TypeDefIndex: 7391
	{
		// Properties
		bool dropEarly { get; }
	
		// Methods
		void Receive(ulong PathHash, byte[] bytes);
		void Fail(ulong pathHash, ResourceLoadFailureReason reason);
		void Recycle();
	}
}
