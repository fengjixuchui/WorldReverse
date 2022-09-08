/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class Scheduler : IScheduler // TypeDefIndex: 9048
	{
		// Fields
		public static bool TASK_MODE; // 0x00
		private bool _isNeedFlush; // 0x10
		private bool _isPaused; // 0x11
		private bool _isPausing; // 0x12
		private bool _isResuming; // 0x13
		private float _timeOut; // 0x14
		private SchedulerType _type; // 0x18
		private IGraph _graph; // 0x20
		private List<ISchedulerTask>[] _schedulerTaskDic; // 0x28
	
		// Properties
		public bool IsNeedFlush { /* [XID] */ /* 0x0000000189AE6080-0x0000000189AE60A0 */ get => default; } // 0x000000018763B780-0x000000018763B820 
		public bool isPaused { /* [XID] */ /* 0x0000000189AED590-0x0000000189AED5B0 */ get => default; } // 0x000000018763B820-0x000000018763B8C0 
		public SchedulerType type { /* [XID] */ /* 0x0000000189884CD0-0x0000000189884CF0 */ get => default; } // 0x000000018763B8C0-0x000000018763BA00 
	
		// Constructors
		public Scheduler() {} // 0x000000018763B6D0-0x000000018763B780
		static Scheduler() {} // 0x000000018763B670-0x000000018763B6D0
	
		// Methods
		// [XID] // 0x0000000189AD6D10-0x0000000189AD6D30
		public static Scheduler Create(SchedulerType schedulerType, int priority) => default; // 0x000000018763A160-0x000000018763A250
		// [XID] // 0x0000000189AC4000-0x0000000189AC4020
		public static Scheduler CreateBackground() => default; // 0x000000018763A090-0x000000018763A160
		// [XID] // 0x0000000189B0F2B0-0x0000000189B0F2D0
		public void Pause() {} // 0x000000018763A740-0x000000018763A7E0
		// [XID] // 0x0000000189AFC490-0x0000000189AFC4B0
		public void Resume() {} // 0x000000018763A7E0-0x000000018763A880
		// [XID] // 0x000000018990B9F0-0x000000018990BA10
		protected void CheckPause() {} // 0x0000000187639FA0-0x000000018763A090
		// [XID] // 0x0000000189B12C60-0x0000000189B12C80
		public IGraph GetGraph() => default; // 0x000000018763A380-0x000000018763A420
		// [XID] // 0x0000000189B1A0B0-0x0000000189B1A0D0
		public void Init(SchedulerType schedulerType, int priority) {} // 0x000000018763A520-0x000000018763A740
		// [XID] // 0x0000000189AD2F40-0x0000000189AD2F60
		public void InitBackground() {} // 0x000000018763A420-0x000000018763A520
		// [XID] // 0x00000001898B90A0-0x00000001898B90C0
		public void SwitchRunner(IRunnerPool runnerPool) {} // 0x000000018763B190-0x000000018763B260
		// [XID] // 0x00000001898A2730-0x00000001898A2750
		public void SwitchMultiThread(bool isMultiThread) {} // 0x000000018763B0C0-0x000000018763B190
		// [XID] // 0x0000000189B379C0-0x0000000189B379E0
		public void SpawnScheduleTask(ISchedulerTask task) {} // 0x000000018763AF90-0x000000018763B0C0
		// [XID] // 0x000000018964E8F0-0x000000018964E910
		public void UnSpawnScheduleTask(ISchedulerTask task) {} // 0x000000018763B4D0-0x000000018763B670
		// [XID] // 0x0000000189B46CE0-0x0000000189B46D00
		private void TickSchedulerTask(float deltaTime, SchedulerTaskType taskType) {} // 0x000000018763B260-0x000000018763B4D0
		// [XID] // 0x0000000189612A90-0x0000000189612AB0
		public void ScheduleEntry(bool lockScene) {} // 0x000000018763AA10-0x000000018763AC00
		// [XID] // 0x0000000189B55AC0-0x0000000189B55AE0
		public void ScheduleMainThreadEntry() {} // 0x000000018763AD40-0x000000018763AE00
		// [XID] // 0x0000000189B5D500-0x0000000189B5D520
		public void ScheduleBackgroundEntry() {} // 0x000000018763A880-0x000000018763A940
		// [XID] // 0x0000000189B64CC0-0x0000000189B64CE0
		public void ScheduleCheckAllFinished(bool lockscene) {} // 0x000000018763A940-0x000000018763AA10
		// [XID] // 0x0000000189B6C070-0x0000000189B6C090
		public void ScheduleWaitAllFinished() {} // 0x000000018763AE00-0x000000018763AF90
		// [XID] // 0x0000000189B738B0-0x0000000189B738D0
		public void ScheduleFlush(bool lockScene) {} // 0x000000018763AC00-0x000000018763AD40
		// [XID] // 0x0000000189B92F60-0x0000000189B92F80
		public void Destroy() {} // 0x000000018763A250-0x000000018763A380
	}
}
