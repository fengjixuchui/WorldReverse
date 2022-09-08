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
	public sealed class LuaMoveTask : LuaTask, IRequestOwnerEntityNoPauseTask // TypeDefIndex: 21155
	{
		// Fields
		private EntityActor _entityActor; // 0x78
		private LCAIBeta _ai; // 0x80
		public int curWayPointIndex; // 0x88
	
		// Properties
		public IPausableEntity ownerPausableEntity { /* [XID] */ /* 0x0000000189614270-0x0000000189614290 */ get => default; } // 0x0000000184F10FB0-0x0000000184F11070 
	
		// Constructors
		public LuaMoveTask() {} // 0x0000000184F10F30-0x0000000184F10FB0
	
		// Methods
		// [XID] // 0x000000018961BC90-0x000000018961BCB0
		public void RequestOwnerEntityNoPause() {} // 0x0000000184F10C00-0x0000000184F10CC0
		// [XID] // 0x0000000189623200-0x0000000189623220
		public void CancelOwnerEntityNoPause() {} // 0x0000000184F10480-0x0000000184F10540
		[BlackList] // 0x000000018962AA00-0x000000018962AA40
		// [XID] // 0x000000018962AA00-0x000000018962AA40
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F106A0-0x0000000184F108B0
		// [XID] // 0x0000000189635810-0x0000000189635830
		private void OnMoveEnd(ScriptedMoveToInfo.ReachPointState state, int middlePointIndex) {} // 0x0000000184F108B0-0x0000000184F109A0
		// [XID] // 0x000000018963CED0-0x000000018963CEF0
		private void OnMoveReachMiddlePoint() {} // 0x0000000184F10A70-0x0000000184F10B30
		// [XID] // 0x0000000189644490-0x00000001896444B0
		private void OnMoveReachFinalPoint() {} // 0x0000000184F109A0-0x0000000184F10A70
		// [XID] // 0x000000018964BD10-0x000000018964BD30
		public override void StartTask() {} // 0x0000000184F10CC0-0x0000000184F10D70
		// [XID] // 0x0000000189653320-0x0000000189653340
		protected override void DestroyInternal() {} // 0x0000000184F10540-0x0000000184F106A0
		// [XID] // 0x000000018965ABB0-0x000000018965ABD0
		protected override void ReleaseTask() {} // 0x0000000184F10B30-0x0000000184F10C00
	}
}
