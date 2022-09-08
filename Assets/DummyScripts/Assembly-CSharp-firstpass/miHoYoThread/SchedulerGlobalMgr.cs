/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Scripting;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class SchedulerGlobalMgr : SchedulerMgr // TypeDefIndex: 9051
	{
		// Fields
		private static SchedulerGlobalMgr _inst; // 0x00
		private Scheduler _backgroundScheduler; // 0x48
	
		// Properties
		public static new SchedulerGlobalMgr Inst { /* [XID] */ /* 0x00000001896E5F90-0x00000001896E5FB0 */ get => default; } // 0x0000000187636B50-0x0000000187636C00 
	
		// Constructors
		public SchedulerGlobalMgr() {} // 0x0000000187636AC0-0x0000000187636B50
	
		// Methods
		// [XID] // 0x00000001896DEDE0-0x00000001896DEE00
		public static new void Create() {} // 0x0000000187635980-0x0000000187635A90
		// [XID] // 0x00000001896ED690-0x00000001896ED6B0
		public static new void SwitchThread(bool value) {} // 0x0000000187636780-0x0000000187636850
		// [XID] // 0x0000000189749740-0x0000000189749760
		public static new void PreDispose() {} // 0x0000000187636140-0x0000000187636200
		// [XID] // 0x0000000189757FF0-0x0000000189758010
		public static new void Dispose() {} // 0x0000000187635B50-0x0000000187635C80
		// [XID] // 0x0000000189703BE0-0x0000000189703C00
		public new IGraph GetBackgroundGraph() => default; // 0x0000000187635EA0-0x0000000187635F50
		// [XID] // 0x000000018970B430-0x000000018970B450
		public override void Init() {} // 0x0000000187635F50-0x0000000187636140
		// [XID] // 0x0000000189785000-0x0000000189785020
		public override void SwitchRunner(PoolType poolType, int threadNum) {} // 0x0000000187636500-0x0000000187636780
		// [XID] // 0x00000001897939A0-0x00000001897939C0
		public new void ScheduleBackground() {} // 0x0000000187636360-0x0000000187636440
		// [XID] // 0x00000001897217C0-0x00000001897217E0
		public new void ScheduleWaitAllBackgroundFinished() {} // 0x0000000187636440-0x0000000187636500
		// [XID] // 0x0000000189B400E0-0x0000000189B40100
		public override void ScheduleBackgroundPause() {} // 0x0000000187636200-0x00000001876362B0
		// [XID] // 0x0000000189730850-0x0000000189730870
		public override void ScheduleBackgroundResume() {} // 0x00000001876362B0-0x0000000187636360
		// [XID] // 0x0000000189738080-0x00000001897380A0
		public override void Destroy() {} // 0x0000000187635A90-0x0000000187635B50
		[Preserve] // 0x000000018973FCA0-0x000000018973FCE0
		// [XID] // 0x000000018973FCA0-0x000000018973FCE0
		public override string Dump() => default; // 0x0000000187635C80-0x0000000187635EA0
	}
}
