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
	public class TaskGraph : IGraph // TypeDefIndex: 9014
	{
		// Fields
		private int _schedulerType; // 0x10
		private List<IGroup> _groups; // 0x18
		private List<INode> _nodes; // 0x20
		private bool _dirty; // 0x28
		private List<INode> _startNodes; // 0x30
		private List<INode> _startMainThreadNodes; // 0x38
		private List<INode> _genTempList; // 0x40
	
		// Properties
		public int priority { /* [XID] */ /* 0x0000000189B3F680-0x0000000189B3F6A0 */ get => default; } // 0x0000000187640440-0x00000001876404E0 
		public int schedulerType { /* [XID] */ /* 0x00000001898A5BC0-0x00000001898A5BE0 */ get => default; } // 0x00000001876404E0-0x0000000187640580 
	
		// Constructors
		public TaskGraph() {} // 0x0000000187640320-0x0000000187640440
	
		// Methods
		// [XID] // 0x0000000189BA8150-0x0000000189BA8170
		public void SetPriority(int priority) {} // 0x000000018763FB50-0x000000018763FC00
		// [XID] // 0x0000000189B6C440-0x0000000189B6C460
		public void SetSchedulerType(int stype) {} // 0x000000018763FC00-0x000000018763FCB0
		// [XID] // 0x00000001898B4580-0x00000001898B45A0
		public void SetDirty() {} // 0x000000018763FAB0-0x000000018763FB50
		// [XID] // 0x000000018982DFC0-0x000000018982DFE0
		public void AddNode(INode node) {} // 0x000000018763E5F0-0x000000018763E6C0
		// [XID] // 0x00000001898C3770-0x00000001898C3790
		public void RemoveNode(INode node) {} // 0x000000018763F7A0-0x000000018763F920
		// [XID] // 0x00000001898CB0A0-0x00000001898CB0C0
		public void AddGroup(IGroup group) {} // 0x000000018763E520-0x000000018763E5F0
		// [XID] // 0x0000000189634290-0x00000001896342B0
		public void RemoveGroup(IGroup group) {} // 0x000000018763F620-0x000000018763F7A0
		// [XID] // 0x0000000189B73B30-0x0000000189B73B50
		public void SwitchRunnerPool(IRunnerPool runnerPool) {} // 0x0000000187640070-0x0000000187640320
		// [XID] // 0x00000001896B7DF0-0x00000001896B7E10
		public void SwitchMultiThread(bool isMultiThread) {} // 0x000000018763FFC0-0x0000000187640070
		// [XID] // 0x00000001899849D0-0x00000001899849F0
		private void GenStartNodes() {} // 0x000000018763ECD0-0x000000018763ED80
		// [XID] // 0x0000000189994230-0x0000000189994250
		private void ResetAllNodes() {} // 0x000000018763F920-0x000000018763FAB0
		// [XID] // 0x00000001898F8950-0x00000001898F8970
		private void GenerateStartNodes() {} // 0x000000018763ED80-0x000000018763F140
		// [XID] // 0x00000001899001F0-0x0000000189900210
		public void Collect() {} // 0x000000018763E6C0-0x000000018763E850
		// [XID] // 0x00000001899078A0-0x00000001899078C0
		public void Start() {} // 0x000000018763FE20-0x000000018763FFC0
		// [XID] // 0x000000018990F260-0x000000018990F280
		public void StartMainThreadTask() {} // 0x000000018763FCB0-0x000000018763FE20
		// [XID] // 0x0000000189916AB0-0x0000000189916AD0
		public void Flush() {} // 0x000000018763EB40-0x000000018763ECD0
		// [XID] // 0x000000018987A890-0x000000018987A8B0
		public bool IsFinished() => default; // 0x000000018763F140-0x000000018763F2A0
		// [XID] // 0x0000000189AB05E0-0x0000000189AB0600
		public void OnPause() {} // 0x000000018763F2A0-0x000000018763F460
		// [XID] // 0x000000018992CFC0-0x000000018992CFE0
		public void OnResume() {} // 0x000000018763F460-0x000000018763F620
		// [XID] // 0x0000000189ABF730-0x0000000189ABF750
		public void Destroy() {} // 0x000000018763E850-0x000000018763EB40
	}
}
