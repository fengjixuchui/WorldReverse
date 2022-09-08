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
	public class JobNode : INode // TypeDefIndex: 9012
	{
		// Fields
		private List<INode> _successors; // 0x10
		private List<INode> _dependents; // 0x18
		private int _numDependents; // 0x20
		private int _batchDependents; // 0x24
		private List<int> _dependHandlerIds; // 0x28
		private ITask _task; // 0x30
		private JobPriority _jobPriority; // 0x38
		private int _jobHandler; // 0x3C
		private IGraph _graph; // 0x40
		private IRunnerPool _runnerPool; // 0x48
		private INodeGeneration _nodeGen; // 0x50
		private bool _isPreValid; // 0x58
		private bool _isToBeRemove; // 0x59
		private bool _isSpawned; // 0x5A
		private bool _isExecuted; // 0x5B
	
		// Properties
		public List<INode> dependentsForDebug { /* [XID] */ /* 0x000000018965BC30-0x000000018965BC50 */ get => default; } // 0x000000018762D110-0x000000018762D1B0 
		public ITask task { /* [XID] */ /* 0x00000001896B3D30-0x00000001896B3D50 */ get => default; } // 0x000000018762DA50-0x000000018762DAF0 
		public int jobHandler { /* [XID] */ /* 0x00000001897221C0-0x00000001897221E0 */ get => default; } // 0x000000018762D410-0x000000018762D4B0 
		public IGraph graph { /* [XID] */ /* 0x0000000189672760-0x0000000189672780 */ get => default; } // 0x000000018762D270-0x000000018762D310 
		private IRunnerPool runnerPool { /* [XID] */ /* 0x000000018998E350-0x000000018998E370 */ get => default; } // 0x000000018762D9B0-0x000000018762DA50 
		public int nodeId { /* [XID] */ /* 0x0000000189689120-0x0000000189689140 */ get => default; } // 0x000000018762D570-0x000000018762D630 
		public int nodeGroupId { /* [XID] */ /* 0x00000001898E0280-0x00000001898E02A0 */ get => default; } // 0x000000018762D4B0-0x000000018762D570 
		public int nodeType { /* [XID] */ /* 0x00000001896985B0-0x00000001896985D0 */ get => default; } // 0x000000018762D630-0x000000018762D6D0 
		public bool isValid { /* [XID] */ /* 0x000000018969F950-0x000000018969F970 */ get => default; } // 0x000000018762D310-0x000000018762D410 
		public bool forceMainThread { /* [XID] */ /* 0x00000001896BCBA0-0x00000001896BCBC0 */ get => default; } // 0x000000018762D1B0-0x000000018762D270 
		public int numSuccessors { /* [XID] */ /* 0x0000000189B8DD10-0x0000000189B8DD30 */ get => default; } // 0x000000018762D830-0x000000018762D8F0 
		public int numDependents { /* [XID] */ /* 0x00000001896CB580-0x00000001896CB5A0 */ get => default; } // 0x000000018762D6D0-0x000000018762D790 
		public int numRunningDependents { /* [XID] */ /* 0x00000001896D2B10-0x00000001896D2B30 */ get => default; } // 0x000000018762D790-0x000000018762D830 
		public string profilerName { /* [XID] */ /* 0x0000000189775050-0x0000000189775070 */ get => default; } // 0x000000018762D8F0-0x000000018762D9B0 
	
		// Constructors
		public JobNode() {} // Dummy constructor
		public JobNode(ITask task, IGraph graph, IRunnerPool runnerPool) {} // 0x000000018762CFC0-0x000000018762D110
	
		// Methods
		// [XID] // 0x0000000189681700-0x0000000189681720
		public void SetNodeGeneration(INodeGeneration nodeGen) {} // 0x000000018762C530-0x000000018762C5E0
		// [XID] // 0x00000001896A6B50-0x00000001896A6B70
		public bool CheckValid() => default; // 0x000000018762B9E0-0x000000018762BB00
		// [XID] // 0x00000001896AE1D0-0x00000001896AE1F0
		public void SetToBeRemove() {} // 0x000000018762C5E0-0x000000018762C680
		// [XID] // 0x00000001896B5900-0x00000001896B5920
		public bool isToBeRemove() => default; // 0x000000018762DAF0-0x000000018762DB90
		// [XID] // 0x00000001897E32A0-0x00000001897E32C0
		public void BatchDependents() {} // 0x000000018762B800-0x000000018762B8A0
		// [XID] // 0x00000001896E1D10-0x00000001896E1D30
		public bool IsSpawned() => default; // 0x000000018762BF40-0x000000018762BFE0
		// [XID] // 0x0000000189B29040-0x0000000189B29060
		public void Spawn() {} // 0x000000018762C720-0x000000018762C9E0
		// [XID] // 0x00000001896F0380-0x00000001896F03A0
		public void SpawnBatch() {} // 0x000000018762C680-0x000000018762C720
		// [XID] // 0x00000001896F7D50-0x00000001896F7D70
		public bool IsExecuted() => default; // 0x000000018762BE60-0x000000018762BF40
		// [XID] // 0x0000000189A09490-0x0000000189A094B0
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x000000018762CB20-0x000000018762CBD0
		// [XID] // 0x0000000189706A80-0x0000000189706AA0
		public bool OnDecrementRunningDependent(int jobHandler) => default; // 0x000000018762BFE0-0x000000018762C0C0
		// [XID] // 0x000000018970E410-0x000000018970E430
		public void AddDependents(INode node) {} // 0x000000018762B730-0x000000018762B800
		// [IDTag] // 0x0000000189715830-0x0000000189715870
		// [XID] // 0x0000000189715830-0x0000000189715870
		public void Precede(INode node) {} // 0x000000018762C370-0x000000018762C460
		// [IDTag] // 0x0000000189720280-0x00000001897202C0
		// [XID] // 0x0000000189720280-0x00000001897202C0
		public void Precede(IGroup group) {} // 0x000000018762C240-0x000000018762C370
		// [XID] // 0x000000018972A700-0x000000018972A720
		public void Execute() {} // 0x000000018762BCC0-0x000000018762BDA0
		// [XID] // 0x0000000189731EA0-0x0000000189731EC0
		public void CheckRunnableSuccessors() {} // 0x000000018762B8A0-0x000000018762B9E0
		// [XID] // 0x00000001897395E0-0x0000000189739600
		public void Reset() {} // 0x000000018762C460-0x000000018762C530
		// [XID] // 0x0000000189741160-0x0000000189741180
		public void StartNodeOnFreeRunner() {} // 0x000000018762C9E0-0x000000018762CA80
		// [XID] // 0x0000000189748A20-0x0000000189748A40
		public void StartNodeOnMainThreadRunner() {} // 0x000000018762CA80-0x000000018762CB20
		// [XID] // 0x0000000189AD7880-0x0000000189AD78A0
		public void Collect() {} // 0x000000018762BB00-0x000000018762BBC0
		// [XID] // 0x00000001896F4D20-0x00000001896F4D40
		public void Flush() {} // 0x000000018762BDA0-0x000000018762BE60
		// [XID] // 0x000000018975EE70-0x000000018975EE90
		public void OnPause() {} // 0x000000018762C0C0-0x000000018762C180
		// [XID] // 0x00000001899DE2C0-0x00000001899DE2E0
		public void OnResume() {} // 0x000000018762C180-0x000000018762C240
		// [XID] // 0x00000001899DC410-0x00000001899DC430
		public void Destroy() {} // 0x000000018762BBC0-0x000000018762BCC0
		// [XID] // 0x000000018977C900-0x000000018977C920
		public override string ToString() => default; // 0x000000018762CBD0-0x000000018762CF50
	}
}
