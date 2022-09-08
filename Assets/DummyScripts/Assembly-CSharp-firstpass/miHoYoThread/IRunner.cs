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
	public interface IRunner : IDestroy // TypeDefIndex: 9026
	{
		// Properties
		bool paused { get; set; }
		bool isStopping { get; }
		int numberOfRunningTasks { get; }
	
		// Methods
		void StartNode(INode node);
		void StopAllNodes();
		void Kill(Action onRunnerKilled);
	}
}
