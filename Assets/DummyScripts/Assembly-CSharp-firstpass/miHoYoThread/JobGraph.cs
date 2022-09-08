/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.Scripting;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public class JobGraph : IGraph // TypeDefIndex: 9009
	{
		// Fields
		private static bool bJobBatch; // 0x00
		private List<IGroup> _groups; // 0x10
		private List<INode> _nodes; // 0x18
		private List<INode> _startMainThreadNodes; // 0x20
		private int _jobPriority; // 0x28
		private int _schedulerType; // 0x2C
		private bool _dirty; // 0x30
		private bool _isMultiThread; // 0x31
		private List<JobGroup> _jobGroups; // 0x38
		private JobGroup[] _jobGroupsDic; // 0x40
		private const int DEFAULT_CAPCITY = 10; // Metadata: 0x00AE5079
		private List<INode> _waitNodes; // 0x48
		private List<INode> _tempSetupNodes; // 0x50
		private List<int> _tempDeleteIndex; // 0x58
	
		// Properties
		public int priority { /* [XID] */ /* 0x0000000189ADE6A0-0x0000000189ADE6C0 */ get => default; } // 0x0000000187628230-0x00000001876282D0 
		public int schedulerType { /* [XID] */ /* 0x0000000189AED5B0-0x0000000189AED5D0 */ get => default; } // 0x00000001876282D0-0x0000000187628370 
		private bool dirty { /* [XID] */ /* 0x0000000189AFC4B0-0x0000000189AFC4D0 */ get => default; } // 0x0000000187628190-0x0000000187628230 
	
		// Constructors
		public JobGraph() {} // 0x0000000187627FE0-0x0000000187628190
		static JobGraph() {} // 0x0000000187627F80-0x0000000187627FE0
	
		// Methods
		// [XID] // 0x00000001896AE090-0x00000001896AE0B0
		public void SetPriority(int priority) {} // 0x0000000187627480-0x0000000187627530
		// [XID] // 0x0000000189AF4F80-0x0000000189AF4FA0
		public void SetSchedulerType(int stype) {} // 0x0000000187627530-0x00000001876275E0
		// [XID] // 0x0000000189B03D50-0x0000000189B03D70
		public void SetDirty() {} // 0x00000001876273E0-0x0000000187627480
		// [XID] // 0x0000000189697010-0x0000000189697030
		public void AddNode(INode node) {} // 0x00000001876249D0-0x0000000187624AD0
		// [XID] // 0x00000001896C3F20-0x00000001896C3F40
		public void RemoveNode(INode node) {} // 0x0000000187627240-0x00000001876273E0
		// [XID] // 0x00000001899A2FD0-0x00000001899A2FF0
		public void AddGroup(IGroup group) {} // 0x0000000187624900-0x00000001876249D0
		// [XID] // 0x0000000189B21560-0x0000000189B21580
		public void RemoveGroup(IGroup group) {} // 0x00000001876270C0-0x0000000187627240
		// [XID] // 0x00000001896DA420-0x00000001896DA440
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x0000000187627CD0-0x0000000187627F80
		// [XID] // 0x0000000189B301F0-0x0000000189B30210
		public void SwitchMultiThread(bool isMultiThread) {} // 0x0000000187627C20-0x0000000187627CD0
		// [XID] // 0x0000000189B379E0-0x0000000189B37A00
		public void Collect() {} // 0x0000000187625250-0x0000000187625340
		// [XID] // 0x0000000189795BE0-0x0000000189795C00
		private bool GetJobGroup(int jobGroupId, out JobGroup jobGroup) {
			jobGroup = default;
			return default;
		} // 0x0000000187626830-0x00000001876269D0
		// [XID] // 0x0000000189B46D00-0x0000000189B46D20
		private void ClearJobGroup() {} // 0x0000000187624AD0-0x0000000187624C50
		// [XID] // 0x0000000189B4E4B0-0x0000000189B4E4D0
		private void CollectSingle() {} // 0x0000000187624F10-0x0000000187625250
		// [XID] // 0x00000001896CCD40-0x00000001896CCD60
		private void CollectBatch() {} // 0x0000000187624C50-0x0000000187624F10
		// [XID] // 0x0000000189B5D540-0x0000000189B5D560
		public void Start() {} // 0x0000000187627B30-0x0000000187627C20
		// [XID] // 0x0000000189B64CE0-0x0000000189B64D00
		public void StartMainThreadTask() {} // 0x0000000187627A90-0x0000000187627B30
		// [XID] // 0x0000000189BC7D00-0x0000000189BC7D20
		public void Flush() {} // 0x00000001876266A0-0x0000000187626830
		// [XID] // 0x0000000189B738F0-0x0000000189B73910
		public bool IsFinished() => default; // 0x0000000187626C50-0x0000000187626D40
		// [XID] // 0x0000000189B7AE40-0x0000000189B7AE60
		private bool IsFinishedSingle() => default; // 0x0000000187626B00-0x0000000187626C50
		// [XID] // 0x0000000189B82800-0x0000000189B82820
		private bool IsFinishedBatch() => default; // 0x00000001876269D0-0x0000000187626B00
		// [XID] // 0x00000001899B4490-0x00000001899B44B0
		private void SpawnGenerationNodes() {} // 0x0000000187627710-0x0000000187627A90
		// [XID] // 0x00000001899A51E0-0x00000001899A5200
		private void SpawnGenerationNodeBatch() {} // 0x00000001876275E0-0x0000000187627710
		// [XID] // 0x0000000189B98870-0x0000000189B98890
		public void OnPause() {} // 0x0000000187626D40-0x0000000187626F00
		// [XID] // 0x0000000189B9FD00-0x0000000189B9FD20
		public void OnResume() {} // 0x0000000187626F00-0x00000001876270C0
		// [XID] // 0x00000001898F5450-0x00000001898F5470
		public void Destroy() {} // 0x0000000187625BC0-0x0000000187625EC0
		// [XID] // 0x0000000189BAE6B0-0x0000000189BAE6D0
		public void DebugLogAllWaitNodes() {} // 0x0000000187625340-0x0000000187625BC0
		[Preserve] // 0x0000000189BB5ED0-0x0000000189BB5F10
		// [XID] // 0x0000000189BB5ED0-0x0000000189BB5F10
		public string Dump() => default; // 0x0000000187625EC0-0x00000001876266A0
	}
}
