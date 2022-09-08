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
	public class JobGroup // TypeDefIndex: 9008
	{
		// Fields
		private static Queue<JobGroup> _pool; // 0x00
		private int _groupId; // 0x10
		private List<INode> _origThreadNodes; // 0x18
		private List<INode> _threadNodes; // 0x20
		private List<INode> _origMainNodes; // 0x28
		private List<INode> _mainNodes; // 0x30
		private bool _isDirty; // 0x38
		private List<JobGeneration> _jobGens; // 0x40
		private List<INode> _waitNodes; // 0x48
		private int _waitHandler; // 0x50
		private List<INode> _tempSetupNodes; // 0x58
		private List<int> _tempDeleteIndex; // 0x60
	
		// Properties
		public int groupId { /* [XID] */ /* 0x0000000189B86F50-0x0000000189B86F70 */ get => default; } // 0x00000001876299F0-0x0000000187629A90 
		public bool isDirty { /* [XID] */ /* 0x0000000189637D80-0x0000000189637DA0 */ get => default; } // 0x0000000187629A90-0x0000000187629B30 
	
		// Constructors
		public JobGroup() {} // 0x0000000187629830-0x00000001876299F0
		static JobGroup() {} // 0x00000001876297A0-0x0000000187629830
	
		// Methods
		// [XID] // 0x0000000189AC4670-0x0000000189AC4690
		public static JobGroup Get(int groupId) => default; // 0x0000000187629180-0x0000000187629300
		// [XID] // 0x0000000189A7C550-0x0000000189A7C570
		public static void Release(JobGroup jobGroup) {} // 0x0000000187629480-0x0000000187629570
		// [XID] // 0x0000000189B8E0E0-0x0000000189B8E100
		public void AddNode(INode node) {} // 0x0000000187628590-0x0000000187628680
		// [XID] // 0x0000000189A92E90-0x0000000189A92EB0
		public void AddMainNode(INode node) {} // 0x0000000187628370-0x0000000187628460
		// [XID] // 0x0000000189A9A960-0x0000000189A9A980
		private void AddNodeRange(List<INode> from, List<INode> to) {} // 0x0000000187628460-0x0000000187628590
		// [XID] // 0x0000000189AA19D0-0x0000000189AA19F0
		public void Init(int groupId) {} // 0x0000000187629300-0x00000001876293B0
		// [XID] // 0x0000000189AB0BE0-0x0000000189AB0C00
		public void SetDirty() {} // 0x0000000187629700-0x00000001876297A0
		// [XID] // 0x000000018963EFD0-0x000000018963EFF0
		public void CollectBatch() {} // 0x0000000187628A70-0x0000000187629180
		// [XID] // 0x0000000189655930-0x0000000189655950
		public void ScheduleBatch(JobPriority jobPriority) {} // 0x0000000187629570-0x0000000187629700
		// [XID] // 0x00000001896A69C0-0x00000001896A69E0
		public bool IsFinished() => default; // 0x00000001876293B0-0x0000000187629480
		// [XID] // 0x0000000189ACEED0-0x0000000189ACEEF0
		private void ClearOnDirty() {} // 0x0000000187628680-0x0000000187628830
		// [XID] // 0x0000000189B7F360-0x0000000189B7F380
		public void Clear() {} // 0x0000000187628830-0x0000000187628A70
	}
}
