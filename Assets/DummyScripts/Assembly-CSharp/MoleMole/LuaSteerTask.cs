/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaSteerTask : LuaTask // TypeDefIndex: 21164
	{
		// Fields
		private BaseEntity _entity; // 0x78
		private VCBaseMove _moveComponent; // 0x80
		private bool _isStartSteer; // 0x88
		private float _duration; // 0x8C
		private float _curTime; // 0x90
		private Vector3 _targetDir; // 0x94
		private Vector3 _startDir; // 0xA0
		private static int TURN_LEFT_FREESTYLE_ID; // 0x00
		private static int TURN_RIGHT_FREESTYLE_ID; // 0x04
	
		// Constructors
		public LuaSteerTask() {} // 0x0000000184F155D0-0x0000000184F15650
		static LuaSteerTask() {} // 0x0000000184F15550-0x0000000184F155D0
	
		// Methods
		[BlackList] // 0x000000018984C680-0x000000018984C6C0
		// [XID] // 0x000000018984C680-0x000000018984C6C0
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F14910-0x0000000184F14A50
		// [XID] // 0x0000000189856720-0x0000000189856740
		protected override void TickInternal() {} // 0x0000000184F15090-0x0000000184F15140
		// [XID] // 0x000000018985D9D0-0x000000018985D9F0
		public void StartSteer(Vector3 targetDir, float duration, bool useAnim, bool interruptFreestyle) {} // 0x0000000184F14DB0-0x0000000184F14F70
		// [XID] // 0x0000000189865430-0x0000000189865450
		private void TickSteer() {} // 0x0000000184F15140-0x0000000184F15390
		// [XID] // 0x000000018986C8D0-0x000000018986C8F0
		private void Steer(BaseEntity entity, Vector3 steerTarget) {} // 0x0000000184F14F70-0x0000000184F15090
		// [XID] // 0x0000000189873D80-0x0000000189873DA0
		private void PlaySteerAnimation(BaseEntity entity, Vector3 dir, bool interrupt) {} // 0x0000000184F14A50-0x0000000184F14CE0
		// [XID] // 0x000000018987B820-0x000000018987B840
		public override void FinishTask() {} // 0x0000000184F14860-0x0000000184F14910
		// [XID] // 0x00000001898829D0-0x00000001898829F0
		protected override void ReleaseTask() {} // 0x0000000184F14CE0-0x0000000184F14DB0
	}
}
