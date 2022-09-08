/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class TestCaseCombatBase : TestCaseBase // TypeDefIndex: 28203
	{
		// Fields
		private EventManager evtManager; // 0x198
		private HitLevel lastHitLevel; // 0x1A0
		public BaseEntity Monster; // 0x1A8
		public bool Checking; // 0x1B0
	
		// Constructors
		public TestCaseCombatBase() {} // 0x0000000184F914D0-0x0000000184F915A0
	
		// Methods
		public void InitEvtHook() {} // 0x0000000184F91060-0x0000000184F91140
		public void StopEvtHook() {} // 0x0000000184F911F0-0x0000000184F91290
		public void SetCheckMonster(uint runtimeID) {} // 0x0000000184F91140-0x0000000184F911F0
		private void HandleEvt(BaseEvent evt, int step) {} // 0x0000000184F90D60-0x0000000184F91060
		private bool isEntityEvtRalated(uint runtimeID, BaseEntity entity) => default; // 0x0000000184F91980-0x0000000184F91A80
		private bool isChanging(Vector3 pos, List<Vector3> AvatarPosCache) => default; // 0x0000000184F91810-0x0000000184F91980
		private float getMaxChangeByKey(string key, List<Vector3> AvatarPosCache) => default; // 0x0000000184F915A0-0x0000000184F91810
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitChecking() => default; // 0x0000000184F91400-0x0000000184F914D0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitCheckHitLevel(HitLevel targetLevel, bool skipLevelCheck = false /* Metadata: 0x00B0D49B */, uint monsterId = 0 /* Metadata: 0x00B0D49C */) => default; // 0x0000000184F91300-0x0000000184F91400
	}
}
