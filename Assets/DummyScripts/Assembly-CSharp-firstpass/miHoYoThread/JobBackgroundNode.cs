/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class JobBackgroundNode : INode // TypeDefIndex: 9013
	{
		// Fields
		private ITask _task; // 0x10
		private JobPriority _jobPriority; // 0x18
		private int _jobHandler; // 0x1C
		private IGraph _graph; // 0x20
		private bool _isToBeRemove; // 0x28
		private bool _isSpawned; // 0x29
		private bool _isExecuted; // 0x2A
	
		// Properties
		public ITask task { /* [XID] */ /* 0x00000001897842F0-0x0000000189784310 */ get => default; } // 0x0000000187623430-0x00000001876234D0 
		public int jobHandler { /* [XID] */ /* 0x00000001899A0630-0x00000001899A0650 */ get => default; } // 0x0000000187622ED0-0x0000000187622F70 
		public IGraph graph { /* [XID] */ /* 0x0000000189792D60-0x0000000189792D80 */ get => default; } // 0x0000000187622D40-0x0000000187622DE0 
		public int nodeId { /* [XID] */ /* 0x00000001897A24A0-0x00000001897A24C0 */ get => default; } // 0x0000000187623030-0x00000001876230F0 
		public int nodeGroupId { /* [XID] */ /* 0x00000001897A9B10-0x00000001897A9B30 */ get => default; } // 0x0000000187622F70-0x0000000187623030 
		public int nodeType { /* [XID] */ /* 0x0000000189B17100-0x0000000189B17120 */ get => default; } // 0x00000001876230F0-0x0000000187623190 
		public bool isValid { /* [XID] */ /* 0x00000001897B8F40-0x00000001897B8F60 */ get => default; } // 0x0000000187622DE0-0x0000000187622ED0 
		public bool forceMainThread { /* [XID] */ /* 0x00000001897D7950-0x00000001897D7970 */ get => default; } // 0x0000000187622CA0-0x0000000187622D40 
		public int numSuccessors { /* [XID] */ /* 0x00000001897DEE10-0x00000001897DEE30 */ get => default; } // 0x00000001876232D0-0x0000000187623370 
		public int numDependents { /* [XID] */ /* 0x00000001897E68C0-0x00000001897E68E0 */ get => default; } // 0x0000000187623190-0x0000000187623230 
		public int numRunningDependents { /* [XID] */ /* 0x00000001897EE270-0x00000001897EE290 */ get => default; } // 0x0000000187623230-0x00000001876232D0 
		public string profilerName { /* [XID] */ /* 0x000000018988F780-0x000000018988F7A0 */ get => default; } // 0x0000000187623370-0x0000000187623430 
	
		// Constructors
		public JobBackgroundNode() {} // Dummy constructor
		public JobBackgroundNode(ITask task, IGraph graph) {} // 0x0000000187622BE0-0x0000000187622CA0
	
		// Methods
		// [XID] // 0x00000001898538E0-0x0000000189853900
		public void SetNodeGeneration(INodeGeneration nodeGen) {} // 0x00000001876225F0-0x00000001876226A0
		// [XID] // 0x0000000189B263B0-0x0000000189B263D0
		public bool CheckValid() => default; // 0x0000000187621C50-0x0000000187621D00
		// [XID] // 0x00000001897C8980-0x00000001897C89A0
		public void SetToBeRemove() {} // 0x00000001876226A0-0x0000000187622740
		// [XID] // 0x00000001897D0050-0x00000001897D0070
		public bool isToBeRemove() => default; // 0x00000001876234D0-0x0000000187623570
		// [XID] // 0x00000001897F5A10-0x00000001897F5A30
		public void BatchDependents() {} // 0x0000000187621B10-0x0000000187621BB0
		// [XID] // 0x00000001897FD240-0x00000001897FD260
		public bool IsSpawned() => default; // 0x0000000187622110-0x00000001876221B0
		// [XID] // 0x00000001898048D0-0x00000001898048F0
		public void Spawn() {} // 0x00000001876227E0-0x00000001876229F0
		// [XID] // 0x000000018987C660-0x000000018987C680
		public void SpawnBatch() {} // 0x0000000187622740-0x00000001876227E0
		// [XID] // 0x00000001898135E0-0x0000000189813600
		public bool IsExecuted() => default; // 0x0000000187622020-0x0000000187622110
		// [XID] // 0x0000000189A52FC0-0x0000000189A52FE0
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x0000000187622B30-0x0000000187622BE0
		// [XID] // 0x00000001898A5930-0x00000001898A5950
		public bool OnDecrementRunningDependent(int jobHandler) => default; // 0x00000001876221B0-0x0000000187622260
		// [XID] // 0x0000000189829D90-0x0000000189829DB0
		public void AddDependents(INode node) {} // 0x0000000187621A60-0x0000000187621B10
		// [IDTag] // 0x00000001898312D0-0x0000000189831310
		// [XID] // 0x00000001898312D0-0x0000000189831310
		public void Precede(INode node) {} // 0x0000000187622490-0x0000000187622540
		// [IDTag] // 0x000000018983B870-0x000000018983B8B0
		// [XID] // 0x000000018983B870-0x000000018983B8B0
		public void Precede(IGroup group) {} // 0x00000001876223E0-0x0000000187622490
		// [XID] // 0x0000000189845FE0-0x0000000189846000
		public void Execute() {} // 0x0000000187621E80-0x0000000187621F60
		// [XID] // 0x000000018984D6F0-0x000000018984D710
		public void CheckRunnableSuccessors() {} // 0x0000000187621BB0-0x0000000187621C50
		// [XID] // 0x0000000189854690-0x00000001898546B0
		public void Reset() {} // 0x0000000187622540-0x00000001876225F0
		// [XID] // 0x00000001896763C0-0x00000001896763E0
		public void StartNodeOnFreeRunner() {} // 0x00000001876229F0-0x0000000187622A90
		// [XID] // 0x0000000189863950-0x0000000189863970
		public void StartNodeOnMainThreadRunner() {} // 0x0000000187622A90-0x0000000187622B30
		// [XID] // 0x00000001899CB0B0-0x00000001899CB0D0
		public void Collect() {} // 0x0000000187621D00-0x0000000187621DC0
		// [XID] // 0x0000000189B55F80-0x0000000189B55FA0
		public void Flush() {} // 0x0000000187621F60-0x0000000187622020
		// [XID] // 0x0000000189B43A60-0x0000000189B43A80
		public void OnPause() {} // 0x0000000187622260-0x0000000187622320
		// [XID] // 0x000000018973D8D0-0x000000018973D8F0
		public void OnResume() {} // 0x0000000187622320-0x00000001876223E0
		// [XID] // 0x00000001898881D0-0x00000001898881F0
		public void Destroy() {} // 0x0000000187621DC0-0x0000000187621E80
	}
}
