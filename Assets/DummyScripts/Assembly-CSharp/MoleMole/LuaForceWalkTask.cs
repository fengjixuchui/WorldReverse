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
	public sealed class LuaForceWalkTask : LuaTask // TypeDefIndex: 21144
	{
		// Fields
		private const float TICK_INTERVAL = 0.5f; // Metadata: 0x00AFEEDB
		private float _inDistSqr; // 0x78
		private float _outDistSqr; // 0x7C
		private bool _paramInit; // 0x80
		private float _lastTickTime; // 0x84
		private ForceWalkState _curState; // 0x88
		private EntityActor _entityActor; // 0x90
		private static HashSet<string> _curForceWalkStateTasks; // 0x00
	
		// Nested types
		private enum ForceWalkState // TypeDefIndex: 21145
		{
			None = 0,
			ForceWalk = 1,
			SuggestWalk = 2
		}
	
		// Constructors
		public LuaForceWalkTask() {} // 0x0000000184F011E0-0x0000000184F01250
		static LuaForceWalkTask() {} // 0x0000000184F01150-0x0000000184F011E0
	
		// Methods
		[BlackList] // 0x0000000189957300-0x0000000189957340
		// [XID] // 0x0000000189957300-0x0000000189957340
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F00A80-0x0000000184F00BE0
		// [XID] // 0x0000000189961FB0-0x0000000189961FD0
		public void InitParams(float inDist, float outDist) {} // 0x0000000184F009A0-0x0000000184F00A80
		// [XID] // 0x0000000189969560-0x0000000189969580
		public override void FinishTask() {} // 0x0000000184F00900-0x0000000184F009A0
		// [XID] // 0x0000000189971140-0x0000000189971160
		protected override void DestroyInternal() {} // 0x0000000184F00840-0x0000000184F00900
		// [XID] // 0x0000000189978B10-0x0000000189978B30
		private void ChangeCurState(ForceWalkState tarState) {} // 0x0000000184F003C0-0x0000000184F00840
		// [XID] // 0x000000018997FB90-0x000000018997FBB0
		protected override void TickInternal() {} // 0x0000000184F00CB0-0x0000000184F00F30
		// [XID] // 0x0000000189987470-0x0000000189987490
		protected override void ReleaseTask() {} // 0x0000000184F00BE0-0x0000000184F00CB0
	}
}
