/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public sealed class LuaThreatTask : LuaTask // TypeDefIndex: 21168
	{
		// Fields
		private LuaThreatInfo _threatInfo; // 0x98
		private LCAIBeta _ai; // 0xA0
	
		// Events
		public event Action<ILuaActor, LuaTask> ThreatAlert;
		public event Action<ILuaActor, LuaTask> ThreatAware;
		public event Action<ILuaActor, LuaTask> ThreatUnaware;
		public event Action<ILuaActor, LuaTask, LuaThreatInfo> ThreatInfo;
	
		// Constructors
		public LuaThreatTask() {} // 0x0000000184F19C90-0x0000000184F19D80
	
		// Methods
		// [XID] // 0x0000000189AF89F0-0x0000000189AF8A10
		public void CallThreatAlert() {} // 0x0000000184F18EF0-0x0000000184F18FD0
		// [XID] // 0x0000000189B0ED10-0x0000000189B0ED30
		public void CallThreatAware() {} // 0x0000000184F18FD0-0x0000000184F190C0
		// [XID] // 0x0000000189B250E0-0x0000000189B25100
		public void CallThreatUnaware() {} // 0x0000000184F191F0-0x0000000184F192E0
		// [XID] // 0x0000000189B3B3F0-0x0000000189B3B410
		public void CallThreatInfo() {} // 0x0000000184F190C0-0x0000000184F191F0
		[BlackList] // 0x0000000189B42C30-0x0000000189B42C70
		// [XID] // 0x0000000189B42C30-0x0000000189B42C70
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F194C0-0x0000000184F19750
		// [XID] // 0x0000000189B4D3B0-0x0000000189B4D3D0
		private void OnThreatLevelChanged(ThreatLevel old, ThreatLevel level) {} // 0x0000000184F19850-0x0000000184F19940
		// [XID] // 0x0000000189B54C70-0x0000000189B54C90
		private void OnAISoundInfo(AISoundInfo soundInfo) {} // 0x0000000184F19750-0x0000000184F19850
		// [XID] // 0x0000000189B5C650-0x0000000189B5C670
		public override void Tick() {} // 0x0000000184F19A10-0x0000000184F19AD0
		// [XID] // 0x0000000189B63D10-0x0000000189B63D30
		protected override void DestroyInternal() {} // 0x0000000184F192E0-0x0000000184F194C0
		// [XID] // 0x0000000189B6B4A0-0x0000000189B6B4C0
		protected override void ReleaseTask() {} // 0x0000000184F19940-0x0000000184F19A10
	}
}
