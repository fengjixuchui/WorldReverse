/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class ThreadTaskMgr : ITaskMgr // TypeDefIndex: 9104
	{
		// Fields
		private string[] longTaskNames0; // 0x10
		private PoolType _poolType; // 0x18
		private IRunnerPool _runnerPool; // 0x20
		private TaskGraph _updateGraph; // 0x28
		private TaskGraph _lateUpdateGraph; // 0x30
		private float _timeOut; // 0x38
	
		// Properties
		public IRunnerPool runnerPool { /* [XID] */ /* 0x000000018997C170-0x000000018997C190 */ get => default; } // 0x0000000185409290-0x0000000185409330 
		public TaskGraph updateGraph { /* [XID] */ /* 0x0000000189983DD0-0x0000000189983DF0 */ get => default; } // 0x0000000185409330-0x00000001854093D0 
		public TaskGraph lateUpdateGraph { /* [XID] */ /* 0x000000018998B7E0-0x000000018998B800 */ get => default; } // 0x00000001854091F0-0x0000000185409290 
	
		// Nested types
		public enum PoolType // TypeDefIndex: 9105
		{
			INVALID = -1,
			MAIN_THREAD = 0,
			MULTI_THREAD = 1
		}
	
		// Constructors
		public ThreadTaskMgr() {} // 0x0000000185408FA0-0x00000001854091F0
	
		// Methods
		// [XID] // 0x00000001899524D0-0x00000001899524F0
		public void CreateDebugTask() {} // 0x0000000185407C60-0x0000000185408110
		// [XID] // 0x0000000189965D50-0x0000000189965D70
		public void CreateDataDebugTask() {} // 0x00000001854078B0-0x0000000185407C60
		// [XID] // 0x000000018996D370-0x000000018996D390
		public void CreatePhysicsExampleTask() {} // 0x0000000185408110-0x0000000185408490
		// [XID] // 0x0000000189866AF0-0x0000000189866B10
		public void CreateSimpleMoveExampleTask() {} // 0x0000000185408490-0x00000001854086F0
		// [XID] // 0x0000000189609440-0x0000000189609460
		public void Init(int threadNum) {} // 0x00000001854087D0-0x00000001854088D0
		// [XID] // 0x0000000189B60ED0-0x0000000189B60EF0
		public void SwitchRunner(PoolType poolType, int threadNum) {} // 0x0000000185408A60-0x0000000185408BC0
		// [XID] // 0x00000001899A2530-0x00000001899A2550
		public void UpdateEntry() {} // 0x0000000185408BC0-0x0000000185408CD0
		// [XID] // 0x0000000189BA68E0-0x0000000189BA6900
		public void WaitUpdateAllFinished() {} // 0x0000000185408E90-0x0000000185408FA0
		// [XID] // 0x00000001899B1740-0x00000001899B1760
		public void UpdateFlush() {} // 0x0000000185408CD0-0x0000000185408D80
		// [XID] // 0x0000000189717FD0-0x0000000189717FF0
		public void LateUpdateEntry() {} // 0x00000001854088D0-0x00000001854089A0
		// [XID] // 0x0000000189892260-0x0000000189892280
		public void WaitLateUpdateAllFinished() {} // 0x0000000185408D80-0x0000000185408E90
		// [XID] // 0x00000001899C7D70-0x00000001899C7D90
		public void LateUpdateFlush() {} // 0x00000001854089A0-0x0000000185408A60
		// [XID] // 0x00000001899CF640-0x00000001899CF660
		public void Destroy() {} // 0x00000001854086F0-0x00000001854087D0
	}
}
