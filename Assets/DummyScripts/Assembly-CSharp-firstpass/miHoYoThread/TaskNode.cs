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
	public class TaskNode : INode // TypeDefIndex: 9016
	{
		// Fields
		private ThreadSafeList<INode> _successors; // 0x10
		private ThreadList<INode> _dependentsUnsafe; // 0x20
		private ThreadSafeList<INode> _dependents; // 0x28
		private int _numDependents; // 0x38
		private bool _isToBeRemove; // 0x3C
		private bool _isSpawned; // 0x3D
		private bool _isExecuted; // 0x3E
		private ITask _task; // 0x40
		private IGraph _graph; // 0x48
		private IRunnerPool _runnerPool; // 0x50
	
		// Properties
		public int nodeId { /* [XID] */ /* 0x0000000189889040-0x0000000189889060 */ get => default; } // 0x0000000187641D20-0x0000000187641DE0 
		public int nodeGroupId { /* [XID] */ /* 0x0000000189ACE7F0-0x0000000189ACE810 */ get => default; } // 0x0000000187641C60-0x0000000187641D20 
		public int nodeType { /* [XID] */ /* 0x00000001897C9200-0x00000001897C9220 */ get => default; } // 0x0000000187641DE0-0x0000000187641E80 
		public bool isValid { /* [XID] */ /* 0x00000001899526C0-0x00000001899526E0 */ get => default; } // 0x0000000187641B20-0x0000000187641BC0 
		public int jobHandler { /* [XID] */ /* 0x0000000189970260-0x0000000189970280 */ get => default; } // 0x0000000187641BC0-0x0000000187641C60 
		public bool forceMainThread { /* [XID] */ /* 0x0000000189B624D0-0x0000000189B624F0 */ get => default; } // 0x00000001876419C0-0x0000000187641A80 
		public int numSuccessors { /* [XID] */ /* 0x000000018985CA90-0x000000018985CAB0 */ get => default; } // 0x0000000187641FE0-0x0000000187642090 
		public int numDependents { /* [XID] */ /* 0x0000000189986B60-0x0000000189986B80 */ get => default; } // 0x0000000187641E80-0x0000000187641F40 
		public int numRunningDependents { /* [XID] */ /* 0x000000018998E650-0x000000018998E670 */ get => default; } // 0x0000000187641F40-0x0000000187641FE0 
		public ITask task { /* [XID] */ /* 0x00000001899B4700-0x00000001899B4720 */ get => default; } // 0x0000000187642150-0x00000001876421F0 
		public IGraph graph { /* [XID] */ /* 0x00000001899BBC00-0x00000001899BBC20 */ get => default; } // 0x0000000187641A80-0x0000000187641B20 
		public string profilerName { /* [XID] */ /* 0x0000000189A402C0-0x0000000189A402E0 */ get => default; } // 0x0000000187642090-0x0000000187642150 
	
		// Constructors
		public TaskNode() {} // Dummy constructor
		public TaskNode(ITask task, IGraph graph, IRunnerPool runnerPool) {} // 0x0000000187641860-0x00000001876419C0
	
		// Methods
		// [XID] // 0x000000018981ED00-0x000000018981ED20
		public bool CheckValid() => default; // 0x00000001876408E0-0x0000000187640990
		// [XID] // 0x0000000189B53800-0x0000000189B53820
		public void SetToBeRemove() {} // 0x0000000187641410-0x00000001876414B0
		// [XID] // 0x0000000189968B70-0x0000000189968B90
		public bool isToBeRemove() => default; // 0x00000001876421F0-0x0000000187642290
		// [XID] // 0x00000001899961C0-0x00000001899961E0
		public bool IsSpawned() => default; // 0x0000000187640DB0-0x0000000187640E60
		// [XID] // 0x000000018999DB60-0x000000018999DB80
		public void Spawn() {} // 0x0000000187641550-0x00000001876415F0
		// [XID] // 0x00000001899A5570-0x00000001899A5590
		public void SpawnBatch() {} // 0x00000001876414B0-0x0000000187641550
		// [XID] // 0x00000001899ACF30-0x00000001899ACF50
		public bool IsExecuted() => default; // 0x0000000187640D10-0x0000000187640DB0
		// [XID] // 0x00000001899C3840-0x00000001899C3860
		public void SetNodeGeneration(INodeGeneration nodeGen) {} // 0x0000000187641360-0x0000000187641410
		// [XID] // 0x0000000189BA3C70-0x0000000189BA3C90
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x00000001876417B0-0x0000000187641860
		// [XID] // 0x00000001899D2360-0x00000001899D2380
		public bool OnDecrementRunningDependent(int depends) => default; // 0x0000000187640E60-0x0000000187640F20
		// [XID] // 0x00000001899D9AC0-0x00000001899D9AE0
		public void BatchDependents() {} // 0x0000000187640650-0x00000001876406F0
		// [XID] // 0x00000001899E10C0-0x00000001899E10E0
		public void AddDependents(INode node) {} // 0x0000000187640580-0x0000000187640650
		// [IDTag] // 0x00000001899E8B90-0x00000001899E8BD0
		// [XID] // 0x00000001899E8B90-0x00000001899E8BD0
		public void Precede(INode node) {} // 0x00000001876411D0-0x00000001876412B0
		// [IDTag] // 0x00000001899F32C0-0x00000001899F3300
		// [XID] // 0x00000001899F32C0-0x00000001899F3300
		public void Precede(IGroup group) {} // 0x00000001876410A0-0x00000001876411D0
		// [XID] // 0x00000001899013D0-0x00000001899013F0
		public void Execute() {} // 0x0000000187640B60-0x0000000187640C50
		// [XID] // 0x0000000189A04E00-0x0000000189A04E20
		public void CheckRunnableSuccessors() {} // 0x00000001876406F0-0x00000001876408E0
		// [XID] // 0x0000000189A0C490-0x0000000189A0C4B0
		public void Reset() {} // 0x00000001876412B0-0x0000000187641360
		// [XID] // 0x0000000189A13E70-0x0000000189A13E90
		public void StartNodeOnFreeRunner() {} // 0x00000001876415F0-0x00000001876416D0
		// [XID] // 0x0000000189A1B060-0x0000000189A1B080
		public void StartNodeOnMainThreadRunner() {} // 0x00000001876416D0-0x00000001876417B0
		// [XID] // 0x0000000189A22A20-0x0000000189A22A40
		public void Collect() {} // 0x0000000187640990-0x0000000187640A50
		// [XID] // 0x00000001895F1CF0-0x00000001895F1D10
		public void Flush() {} // 0x0000000187640C50-0x0000000187640D10
		// [XID] // 0x0000000189A310C0-0x0000000189A310E0
		public void OnPause() {} // 0x0000000187640F20-0x0000000187640FE0
		// [XID] // 0x00000001896CB2B0-0x00000001896CB2D0
		public void OnResume() {} // 0x0000000187640FE0-0x00000001876410A0
		// [XID] // 0x0000000189A479F0-0x0000000189A47A10
		public void Destroy() {} // 0x0000000187640A50-0x0000000187640B60
	}
}
