/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public struct JobHandler // TypeDefIndex: 9036
	{
		// Fields
		private static Dictionary<int, int[]> _jhsPool; // 0x00
		private static int[] _jhs2; // 0x08
		private static JobHandler _combineJh2; // 0x10
		private static int[] _jhs3; // 0x18
		private static JobHandler _combineJh3; // 0x20
		private static int[] _jhs4; // 0x28
		private static JobHandler _combineJh4; // 0x30
		private static int[] _jhs5; // 0x38
		private static int[] _jhs6; // 0x40
		private static int[] _jhs7; // 0x48
		private static JobHandler _combineJhFree; // 0x50
		public int id; // 0x00
	
		// Constructors
		static JobHandler() {
			_jhsPool = default;
			_jhs2 = default;
			_combineJh2 = default;
			_jhs3 = default;
			_combineJh3 = default;
			_jhs4 = default;
			_combineJh4 = default;
			_jhs5 = default;
			_jhs6 = default;
			_jhs7 = default;
			_combineJhFree = default;
		} // 0x000000018762B540-0x000000018762B730
	
		// Methods
		// [XID] // 0x0000000189982820-0x0000000189982840
		private static int[] GetJhs(int length) => default; // 0x000000018762A690-0x000000018762A820
		// [IDTag] // 0x0000000189989FD0-0x000000018998A010
		// [XID] // 0x0000000189989FD0-0x000000018998A010
		public static JobHandler Combine(JobHandler jh0, JobHandler jh1) => default; // 0x0000000187629DA0-0x0000000187629F20
		// [IDTag] // 0x0000000189994AA0-0x0000000189994AE0
		// [XID] // 0x0000000189994AA0-0x0000000189994AE0
		public static JobHandler Combine(JobHandler jh0, JobHandler jh1, JobHandler jh2) => default; // 0x0000000187629F20-0x000000018762A0F0
		// [IDTag] // 0x000000018999F2F0-0x000000018999F330
		// [XID] // 0x000000018999F2F0-0x000000018999F330
		public static JobHandler Combine(JobHandler jh0, JobHandler jh1, JobHandler jh2, JobHandler jh3) => default; // 0x000000018762A0F0-0x000000018762A310
		// [XID] // 0x00000001898F35E0-0x00000001898F3600
		public static JobHandler CombineList(List<int> depends) => default; // 0x0000000187629BD0-0x0000000187629CD0
		// [XID] // 0x00000001899CD830-0x00000001899CD850
		private static int[] GetDependsArray(List<int> depends) => default; // 0x000000018762A3B0-0x000000018762A690
		// [IDTag] // 0x00000001899B8BF0-0x00000001899B8C30
		// [XID] // 0x00000001899B8BF0-0x00000001899B8C30
		public static int Combine(List<int> depends) => default; // 0x0000000187629CD0-0x0000000187629DA0
		// [IDTag] // 0x00000001899C3800-0x00000001899C3840
		// [XID] // 0x00000001899C3800-0x00000001899C3840
		public static int Schedule(IntPtr executeHandler, int nodeIndex, int depend, JobPriority jobPriority, string profileName) => default; // 0x000000018762B340-0x000000018762B440
		// [IDTag] // 0x00000001899CDCB0-0x00000001899CDCF0
		// [XID] // 0x00000001899CDCB0-0x00000001899CDCF0
		public static int Schedule(IntPtr executeHandler, int nodeIndex, int depend, JobPriority jobPriority) => default; // 0x000000018762B060-0x000000018762B150
		// [IDTag] // 0x00000001899D8210-0x00000001899D8250
		// [XID] // 0x00000001899D8210-0x00000001899D8250
		public static int ScheduleJob(IntPtr executeHandler, int nodeIndex, int depend, JobPriority jobPriority, string profileName) => default; // 0x000000018762A8C0-0x000000018762A9F0
		// [IDTag] // 0x00000001899E2930-0x00000001899E2970
		// [XID] // 0x00000001899E2930-0x00000001899E2970
		public static int Schedule(IntPtr[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority, string[] profileNames) => default; // 0x000000018762B440-0x000000018762B540
		// [IDTag] // 0x00000001899ECF40-0x00000001899ECF80
		// [XID] // 0x00000001899ECF40-0x00000001899ECF80
		public static int Schedule(IntPtr[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority) => default; // 0x000000018762AD80-0x000000018762AE70
		// [IDTag] // 0x00000001899F7930-0x00000001899F7970
		// [XID] // 0x00000001899F7930-0x00000001899F7970
		public static int ScheduleJobs(IntPtr[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority, string[] profileNames) => default; // 0x000000018762AB20-0x000000018762AC50
		// [IDTag] // 0x0000000189A01BC0-0x0000000189A01C00
		// [XID] // 0x0000000189A01BC0-0x0000000189A01C00
		private static int Schedule(Physics.DelegateCallback executeHandler, int nodeIndex, int depend, JobPriority jobPriority, string profileName) => default; // 0x000000018762AE70-0x000000018762AF70
		// [IDTag] // 0x0000000189A0C450-0x0000000189A0C490
		// [XID] // 0x0000000189A0C450-0x0000000189A0C490
		private static int Schedule(Physics.DelegateCallback executeHandler, int nodeIndex, int depend, JobPriority jobPriority) => default; // 0x000000018762B250-0x000000018762B340
		// [IDTag] // 0x0000000189A16940-0x0000000189A16980
		// [XID] // 0x0000000189A16940-0x0000000189A16980
		public static int ScheduleJob(Physics.DelegateCallback executeHandler, int nodeIndex, int depend, JobPriority jobPriority, string profileName) => default; // 0x000000018762A9F0-0x000000018762AB20
		// [IDTag] // 0x0000000189A20FC0-0x0000000189A21000
		// [XID] // 0x0000000189A20FC0-0x0000000189A21000
		private static int Schedule(Physics.DelegateCallback[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority, string[] profileNames) => default; // 0x000000018762B150-0x000000018762B250
		// [IDTag] // 0x0000000189A2B2D0-0x0000000189A2B310
		// [XID] // 0x0000000189A2B2D0-0x0000000189A2B310
		private static int Schedule(Physics.DelegateCallback[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority) => default; // 0x000000018762AF70-0x000000018762B060
		// [IDTag] // 0x0000000189A35B80-0x0000000189A35BC0
		// [XID] // 0x0000000189A35B80-0x0000000189A35BC0
		public static int ScheduleJobs(Physics.DelegateCallback[] executeHandlers, int[] nodeIndexs, int depend, JobPriority jobPriority, string[] profileNames) => default; // 0x000000018762AC50-0x000000018762AD80
		// [XID] // 0x0000000189A402A0-0x0000000189A402C0
		public static void Complete(int jobHandler) {} // 0x000000018762A310-0x000000018762A3B0
		// [XID] // 0x0000000189A479D0-0x0000000189A479F0
		public static bool IsComplete(int jobHandler) => default; // 0x000000018762A820-0x000000018762A8C0
		// [XID] // 0x0000000189A4F1D0-0x0000000189A4F1F0
		public static void ClearJobs() {} // 0x0000000187629B30-0x0000000187629BD0
	}
}
