/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public class AIAutotestBase : TestCaseBase // TypeDefIndex: 28020
	{
		// Fields
		protected static uint CONFIGID_HILI_MELEE; // 0x00
	
		// Nested types
		public delegate bool TimeoutSuccessCondition(); // TypeDefIndex: 28021; 0x0000000182B1D540-0x0000000182B1D6B0
	
		// Constructors
		public AIAutotestBase() {} // 0x0000000182B033E0-0x0000000182B03460
		static AIAutotestBase() {} // 0x0000000182B03380-0x0000000182B033E0
	
		// Methods
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CleanPlayground() => default; // 0x0000000182B02B20-0x0000000182B02BD0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator TimeoutCheck(float timeout, float interval, TimeoutSuccessCondition successCondition, string failMessage = "[AI] Timeout, failed" /* Metadata: 0x00B0D2BE */) => default; // 0x0000000182B03280-0x0000000182B03380
		public AvatarEntity GetLocalAvatar() => default; // 0x0000000182B02BD0-0x0000000182B02CA0
		public void SetLocalPlayerTransform(Vector3 position, Vector3? forward = default) {} // 0x0000000182B02DA0-0x0000000182B02EE0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CameraLookAt(Vector3 targetPos) => default; // 0x0000000182B02A30-0x0000000182B02B20
		public void SetEntityTransform(BaseEntity entity, Vector3 position, Vector3? forward = default) {} // 0x0000000182B02CA0-0x0000000182B02DA0
		public BaseEntity SpawnMonster(uint configID, uint level, Vector3 pos, Vector3 dir) => default; // 0x0000000182B02EE0-0x0000000182B030F0
		public BaseEntity SpawnNpc(uint configID, Vector3 pos) => default; // 0x0000000182B030F0-0x0000000182B03280
	}
}
