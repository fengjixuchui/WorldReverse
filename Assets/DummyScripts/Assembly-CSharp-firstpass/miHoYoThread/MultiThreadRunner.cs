/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public sealed class MultiThreadRunner : IRunner // TypeDefIndex: 9030
	{
		// Fields
		private int _handler; // 0x14
		private RunnerData _runnerData; // 0x18
		private Thread _subThread; // 0x20
	
		// Properties
		public bool paused { get; /* [XID] */ /* 0x00000001898736D0-0x0000000189873710 */ set; } // 0x0000000187632DC0-0x0000000187632E20 0x0000000187632E20-0x0000000187632E80
		public bool isStopping { /* [XID] */ /* 0x000000018987E390-0x000000018987E3B0 */ get => default; } // 0x0000000187632C50-0x0000000187632D10 
		public int numberOfRunningTasks { /* [XID] */ /* 0x00000001898B1320-0x00000001898B1340 */ get => default; } // 0x0000000187632D10-0x0000000187632DC0 
		public int handler { /* [XID] */ /* 0x00000001897E6570-0x00000001897E6590 */ get => default; } // 0x0000000187632BB0-0x0000000187632C50 
	
		// Nested types
		public class RunnerData // TypeDefIndex: 9031
		{
			// Fields
			public readonly ThreadSafeQueue<INode> newNodes; // 0x10
			public bool waitForFlush; // 0x18
			private bool _breakThread; // 0x19
			private readonly List<INode> _runningNodes; // 0x20
			private readonly long _interval; // 0x28
			private readonly int _handler; // 0x30
			private bool _isRunningTightTasks; // 0x34
			private ManualResetEventEx _mevent; // 0x38
			private Action _onThreadKilled; // 0x40
			private Stopwatch _watch; // 0x48
			private int _interlock; // 0x50
			private readonly Action _lockingMechanism; // 0x58
	
			// Properties
			public int handler { /* [XID] */ /* 0x00000001898CDE80-0x00000001898CDEA0 */ get => default; } // 0x00000001876339B0-0x0000000187633A50 
			public bool isRunningTightTasks { /* [XID] */ /* 0x00000001898D5790-0x00000001898D57B0 */ get => default; } // 0x0000000187633A50-0x0000000187633AF0 
			public int Count { /* [XID] */ /* 0x00000001898DD1C0-0x00000001898DD1E0 */ get => default; } // 0x00000001876338F0-0x00000001876339B0 
	
			// Constructors
			public RunnerData() {} // Dummy constructor
			public RunnerData(bool relaxed, float interval, int handler, bool isRunningTightTasks) {} // 0x0000000187633780-0x00000001876338F0
	
			// Methods
			// [XID] // 0x00000001898E4BF0-0x00000001898E4C10
			private void QuickLockingMechanism() {} // 0x00000001876330A0-0x00000001876331D0
			// [XID] // 0x00000001898EC640-0x00000001898EC660
			private void RelaxedLockingMechanism() {} // 0x00000001876331D0-0x00000001876332A0
			// [XID] // 0x00000001898F4010-0x00000001898F4030
			private void WaitForInterval() {} // 0x0000000187633650-0x0000000187633780
			// [XID] // 0x00000001898FB460-0x00000001898FB480
			internal void UnlockThread() {} // 0x0000000187633590-0x0000000187633650
			// [XID] // 0x00000001897DEB40-0x00000001897DEB60
			public void Kill(Action onThreadKilled) {} // 0x0000000187632FC0-0x00000001876330A0
			// [XID] // 0x0000000189A0CEA0-0x0000000189A0CEC0
			internal void Run() {} // 0x00000001876332A0-0x0000000187633590
		}
	
		// Constructors
		public MultiThreadRunner() {} // 0x0000000187632B30-0x0000000187632BB0
	
		// Methods
		// [XID] // 0x00000001898DE8A0-0x00000001898DE8C0
		public void StartNode(INode node) {} // 0x00000001876328A0-0x0000000187632A10
		// [XID] // 0x0000000189893E40-0x0000000189893E60
		public void StopAllNodes() {} // 0x0000000187632A10-0x0000000187632B30
		// [XID] // 0x00000001897D7630-0x00000001897D7650
		public void Kill(Action onRunnerKilled) {} // 0x00000001876327D0-0x00000001876328A0
		// [XID] // 0x00000001898A2A80-0x00000001898A2AA0
		public void Destroy() {} // 0x0000000187632200-0x00000001876322A0
		~MultiThreadRunner() {} // 0x00000001876322A0-0x0000000187632350
		// [IDTag] // 0x00000001898B18F0-0x00000001898B1930
		// [XID] // 0x00000001898B18F0-0x00000001898B1930
		public void Init(int handler, bool relaxed = false /* Metadata: 0x00AE50B9 */, bool tightTasks = false /* Metadata: 0x00AE50BA */) {} // 0x0000000187632540-0x0000000187632690
		// [IDTag] // 0x00000001898BC370-0x00000001898BC3B0
		// [XID] // 0x00000001898BC370-0x00000001898BC3B0
		public void Init(int handler, float intervalInMs) {} // 0x0000000187632690-0x00000001876327D0
		// [XID] // 0x00000001898F65E0-0x00000001898F6600
		private void InitInternal() {} // 0x0000000187632350-0x0000000187632540
	}
}
