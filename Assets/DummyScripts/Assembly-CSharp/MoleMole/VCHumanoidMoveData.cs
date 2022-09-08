/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public sealed class VCHumanoidMoveData : VCMoveData // TypeDefIndex: 32188
	{
		// Fields
		private List<PropValue> values; // 0x1B0
		public float MIN_CROUCH_ROLL_STAMINA; // 0x1B8
		public Vector3 nextHitAirVelocityForce; // 0x1BC
		public bool tryDoJump; // 0x1C8
		public bool tryDoSlip; // 0x1C9
		public bool tryDoBlink; // 0x1CA
		public bool trySprintBS; // 0x1CB
		public bool tryStopSprint; // 0x1CC
		public bool tryDoCrouch; // 0x1CD
		public bool tryTurnDir; // 0x1CE
		public bool trySitOnChair; // 0x1CF
		public float rawJoystickAngle; // 0x1D0
		public Vector3 blinkDir; // 0x1D4
		public bool blinkPreferInput; // 0x1E0
		public float blinkDist; // 0x1E4
		public float jumpFallSavedTryDoJumpTime; // 0x1E8
		public const float TRY_DO_JUMP_SAVE_TIME = 0.1f; // Metadata: 0x00B1426D
		public bool forceAirStateFly; // 0x1EC
		public float jumpXZVelocityScale; // 0x1F0
		public bool inSprint; // 0x1F4
		public float lastCline; // 0x1F8
		public float curCeilHeight; // 0x1FC
		public AnimatorStateInfo currentAnimatorStateInfo; // 0x200
		public AnimatorStateInfo nextAnimatorStateInfo; // 0x224
		public int lastGetStateInfoFrame; // 0x248
		public uint lastEvtAvatarDownRayTriggerEntityId; // 0x24C
		public bool longDelayMode; // 0x250
		public const float LONG_DELAY_VELOCITY_SCALE = 1.2f; // Metadata: 0x00B14271
		public const int INTO_LONG_DELAY_MODE_PAC_NUM = 4; // Metadata: 0x00B14275
		public const int OUT_LONG_DELAY_MODE_PAC_NUM = 1; // Metadata: 0x00B14279
		public Vector3 sitOnChairPosition; // 0x254
		public Vector3 sitOnChairRotationEular; // 0x260
		public Vector3 lastClimbCheckNormalLeft; // 0x26C
		public Vector3 lastClimbCheckNormalRight; // 0x278
		public MoveType curAnimConfigMoveType; // 0x284
		public Transform lastHitWaterTrans; // 0x288
		public Vector3 lastSafePosition; // 0x290
		public int checkSafePositionCount; // 0x29C
		public const int CHECK_SAFE_POSITION_INTERVAL = 10; // Metadata: 0x00B1427D
		public const float CHECK_SAFE_POSITION_BACK_CHECK_DIST = 0.25f; // Metadata: 0x00B14281
		public MoveSlope currentSlopeBeneath; // 0x2A0
		public HumanoidMoveFSMBaseMoveState.BeneathResult currentBeneathResult; // 0x2D4
		public int lastUpdateSlopeFrame; // 0x2D8
		public bool airGroundNoStandAndHorizontal; // 0x2DC
		public bool combatExitClimbSetDir; // 0x2DD
		public Vector3 combatExitClimbDir; // 0x2E0
		public int lastEvtAvatarDownRayTriggerCheckFrame; // 0x2EC
		public Vector3 lastPos; // 0x2F0
		public Quaternion lastRotation; // 0x2FC
		[NonSerialized]
		public VCHumanoidMove vcHumanoidMove; // 0x310
	
		// Constructors
		public VCHumanoidMoveData() {} // 0x0000000183BEA110-0x0000000183BEA240
	
		// Methods
		// [XID] // 0x0000000189655D20-0x0000000189655D40
		public override void Reset() {} // 0x0000000183BE9F70-0x0000000183BEA110
	}
}
