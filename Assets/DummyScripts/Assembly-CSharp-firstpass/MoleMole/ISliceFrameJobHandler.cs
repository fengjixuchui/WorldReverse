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
	public interface ISliceFrameJobHandler // TypeDefIndex: 10629
	{
		// Properties
		int currentHandleIdx { get; }
		bool bFinished { get; }
		int totalCount { get; }
	
		// Methods
		void IncreaseHandledCount();
		void Handle(int i);
		void Dispose();
	}
}
