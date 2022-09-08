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
	public interface ISchedulerTask : IDestroy, IComparable<miHoYoThread.ISchedulerTask> // TypeDefIndex: 9040
	{
		// Properties
		int id { get; }
		SchedulerType type { get; }
		SchedulerTaskType taskType { get; }
	
		// Methods
		void Init(int pId, SchedulerType pType, SchedulerTaskType pTaskType);
		void Execute(float deltaTime);
		void Spawn();
		void UnSpawn();
	}
}
