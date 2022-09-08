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
	public interface ISchedulerMgr : IDestroy // TypeDefIndex: 9039
	{
		// Methods
		void Init();
		void SwitchMultiThread(bool value);
		void SwitchRunner(PoolType poolType, int threadNum);
		void SpawnScheduleTask(ISchedulerTask task);
		void UnSpawnScheduleTask(ISchedulerTask task);
		void ScheduleEntry(int schedulerType, bool lockScene);
		void ScheduleMainThreadEntry(int schedulerType);
		void ScheduleWaitAllFinished(int schedulerType);
		void ScheduleWaitAllTypeFinished();
		void ScheduleFlush(int schedulerType, bool lockScene);
		void ScheduleBackground();
		void ScheduleWaitAllBackgroundFinished();
		IRunnerPool GetRunnerPool();
		IGraph GetGraph(int schedulerType);
		IGraph GetBackgroundGraph();
	}
}
