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
	public interface IScheduler : IDestroy // TypeDefIndex: 9038
	{
		// Properties
		bool IsNeedFlush { get; }
	
		// Methods
		void Init(SchedulerType schedulerType, int priority);
		void SwitchRunner(IRunnerPool runnerPool);
		void SwitchMultiThread(bool isMultiThread);
		void SpawnScheduleTask(ISchedulerTask task);
		void UnSpawnScheduleTask(ISchedulerTask task);
		void ScheduleEntry(bool lockScene);
		void ScheduleMainThreadEntry();
		void ScheduleBackgroundEntry();
		void ScheduleCheckAllFinished(bool lockscene);
		void ScheduleWaitAllFinished();
		void ScheduleFlush(bool lockScene);
		IGraph GetGraph();
		void Pause();
		void Resume();
	}
}
