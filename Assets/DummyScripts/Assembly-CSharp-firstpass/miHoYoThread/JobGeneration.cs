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
	public class JobGeneration : INodeGeneration // TypeDefIndex: 9007
	{
		// Fields
		private static Queue<JobGeneration> _pool; // 0x00
		private IntPtr[] intPtrs; // 0x10
		private Physics.DelegateCallback[] invokes; // 0x18
		private int[] nodeIds; // 0x20
		private string[] profileNames; // 0x28
		private List<INode> _threadNodes; // 0x30
		private List<INode> _mainNodes; // 0x38
		private JobGroup _jobGroup; // 0x40
	
		// Constructors
		public JobGeneration() {} // 0x0000000187624820-0x0000000187624900
		static JobGeneration() {} // 0x0000000187624790-0x0000000187624820
	
		// Methods
		// [XID] // 0x0000000189A29BC0-0x0000000189A29BE0
		public static JobGeneration Get(JobGroup jobGroup) => default; // 0x0000000187623EC0-0x0000000187624040
		// [XID] // 0x0000000189A310E0-0x0000000189A31100
		public static void Release(JobGeneration jobGen) {} // 0x00000001876240F0-0x00000001876241E0
		// [XID] // 0x0000000189A38D30-0x0000000189A38D50
		public void Init(JobGroup jobGroup) {} // 0x0000000187624040-0x00000001876240F0
		// [XID] // 0x0000000189A402E0-0x0000000189A40300
		public void AddThreadNode(INode node) {} // 0x0000000187623960-0x0000000187623A30
		// [XID] // 0x000000018994DB80-0x000000018994DBA0
		public void UpdateThreadNodes(List<INode> nodes) {} // 0x0000000187624610-0x0000000187624790
		// [XID] // 0x0000000189A4F1F0-0x0000000189A4F210
		public void SetDirty() {} // 0x0000000187624560-0x0000000187624610
		// [XID] // 0x0000000189A56800-0x0000000189A56820
		public void Clear() {} // 0x0000000187623A30-0x0000000187623D30
		// [XID] // 0x0000000189964270-0x0000000189964290
		public int ScheduleJobs(int depends, JobPriority jobPriority) => default; // 0x00000001876241E0-0x0000000187624560
		// [XID] // 0x0000000189A65C60-0x0000000189A65C80
		public void AddMainNode(INode node) {} // 0x0000000187623890-0x0000000187623960
		// [XID] // 0x0000000189A6D270-0x0000000189A6D290
		public void ExecuteMainJobs() {} // 0x0000000187623D30-0x0000000187623EC0
	}
}
