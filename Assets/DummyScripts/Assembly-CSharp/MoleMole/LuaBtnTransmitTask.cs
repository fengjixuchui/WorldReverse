/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaBtnTransmitTask : LuaTask // TypeDefIndex: 21143
	{
		// Fields
		private Dictionary<int, BtnTransmitSubTask> _id2TaskDic; // 0x78
		private List<BtnTransmitSubTask> _taskList; // 0x80
		private BtnTransmitSubTask _curSubTask; // 0x88
		private GlobalActor _globalActor; // 0x90
	
		// Constructors
		public LuaBtnTransmitTask() {} // 0x0000000184EFFF30-0x0000000184F00000
	
		// Methods
		// [XID] // 0x00000001899141C0-0x00000001899141E0
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184EFF740-0x0000000184EFF890
		// [XID] // 0x000000018991BC80-0x000000018991BCA0
		public void AddSubTaskWithData(IBtnTransmitData data) {} // 0x0000000184EFED50-0x0000000184EFF2F0
		// [XID] // 0x0000000189923280-0x00000001899232A0
		public void RemoveSubTaskWithData(IBtnTransmitData data) {} // 0x0000000184EFFA80-0x0000000184EFFCB0
		// [XID] // 0x000000018992AA60-0x000000018992AA80
		public void RefreshCurrent() {} // 0x0000000184EFF890-0x0000000184EFF9B0
		// [XID] // 0x00000001899320A0-0x00000001899320C0
		public bool DoBtnTransmit() => default; // 0x0000000184EFF410-0x0000000184EFF740
		// [XID] // 0x0000000189939A50-0x0000000189939A70
		protected override void TickInternal() {} // 0x0000000184EFFCB0-0x0000000184EFFD70
		// [XID] // 0x0000000189940C20-0x0000000189940C40
		protected override void DestroyInternal() {} // 0x0000000184EFF2F0-0x0000000184EFF410
		// [XID] // 0x00000001899485E0-0x0000000189948600
		protected override void ReleaseTask() {} // 0x0000000184EFF9B0-0x0000000184EFFA80
	}
}
