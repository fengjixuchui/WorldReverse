/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public interface IRunnerPool : IDestroy // TypeDefIndex: 9027
	{
		// Methods
		void Init(int threadNum);
		IRunner GetRunner(int handler);
		IRunner GetFreeRunner();
		IRunner GetMainThreadRunner();
		void StartNodeOnFreeRunner(INode node);
		void StartNodeOnMainThreadRunner(INode node);
	}
}
