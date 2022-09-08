/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	[CreateAssetMenu] // 0x0000000189BCEF20-0x0000000189BCEF70
	public sealed class VCHumanoidMoveScriptAssetData : ScriptableObjectUseFiEdit // TypeDefIndex: 19408
	{
		// Fields
		public BodyType bodyType; // 0x18
		public float climbCloseToGroundDist; // 0x1C
		public float avatarModelHeight; // 0x20
		public float avatarModelClimbHeight; // 0x24
		public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyHard; // 0x28
		public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyMiddle; // 0x54
		public HumanoidMoveFSMGoUpstairsState.PoseParameter climbToStandbyLight; // 0x80
		public HumanoidMoveFSMGoUpstairsState.PoseParameter jumpUpstairs; // 0xAC
		public HumanoidMoveFSMGoUpstairsState.PoseParameter climbtoStandbyGentle; // 0xD8
		public AnimationCurve jumpUpstairsHighCurve; // 0x108
		public AnimationCurve jumpUpstairsLowCurve; // 0x110
		public AnimationCurve jumpUpstairsHighZCurve; // 0x118
		public AnimationCurve jumpUpstairsLowZCurve; // 0x120
		public VCHumanoidMove.StandbyIKParams[] standbyIKParams; // 0x128
		private static Dictionary<BodyType, VCHumanoidMoveScriptAssetData> _humanoidMoveScriptAssetData; // 0x00
		private static uint[] _humanoidMoveScriptAssetDataHandle; // 0x08
	
		// Constructors
		public VCHumanoidMoveScriptAssetData() {} // 0x0000000183BEAA30-0x0000000183BEAA90
		static VCHumanoidMoveScriptAssetData() {} // 0x0000000183BEA980-0x0000000183BEAA30
	
		// Methods
		// [XID] // 0x0000000189BD7A10-0x0000000189BD7A30
		public static void ReloadFromFile() {} // 0x0000000183BEA5A0-0x0000000183BEA660
		[DebuggerHidden] // 0x0000000189BDF600-0x0000000189BDF640
		// [XID] // 0x0000000189BDF600-0x0000000189BDF640
		public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC86E */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183BEA660-0x0000000183BEA7A0
		// [XID] // 0x00000001895EEF20-0x00000001895EEF40
		public static void LoadVCHumanoidMoveScriptAssetData() {} // 0x0000000183BEA240-0x0000000183BEA5A0
		// [XID] // 0x0000000189A5FB10-0x0000000189A5FB30
		public static VCHumanoidMoveScriptAssetData GetVCHumanoidMoveScriptAssetData(BodyType bodyType) => default; // 0x0000000183BEA7A0-0x0000000183BEA980
	}
}
