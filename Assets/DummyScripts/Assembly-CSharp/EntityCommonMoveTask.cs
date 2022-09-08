/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityCommonMoveTask : ThreadGroupTask<EntityCommonMoveData> // TypeDefIndex: 26601
{
	// Fields
	private int monsterDieHash; // 0x38
	private int dropHash; // 0x3C
	private int struggleHash; // 0x40
	private const int MAX_RETURN_DIRECTLY_COUNT = 30; // Metadata: 0x00B0C610
	private const float KEEP_LAST_GROUND_HEIGHT_MAX_DIST = 0.4f; // Metadata: 0x00B0C614
	private const float ALMOST_IN_OUT_WATER_RATIO = 0.2f; // Metadata: 0x00B0C618
	private const float AIR_TILT_DISTANCE_THRESHOLD = 1f; // Metadata: 0x00B0C61C
	private const float MAX_TILT = 25f; // Metadata: 0x00B0C620
	private const float TILT_COEF = 20f; // Metadata: 0x00B0C624
	private const float TILT_SPEED_COEFF = 70f; // Metadata: 0x00B0C628
	private float _deltaTime; // 0x44
	private Vector3 _worldShift; // 0x48
	private const float _fixedDeltaTime = 0.033f; // Metadata: 0x00B0C62C
	private const float _needAccelerateDelayTime = 10f; // Metadata: 0x00B0C630
	private float _accelerateRatio; // 0x54
	private float _maxAccelerateRatio; // 0x58
	private float _jamTime; // 0x5C
	private float _startCalcAvgTime; // 0x60
	private Vector3 _PosDiff; // 0x64
	private Vector3 _lastPos; // 0x70
	private Vector3 _lastlastPos; // 0x7C
	private const float JAM_RESET_TIME = 5f; // Metadata: 0x00B0C634
	private const float JAM_AVERAGE_RESET_TIME = 10f; // Metadata: 0x00B0C638
	private const float JAM_AVERAGE_START_TIME = 5f; // Metadata: 0x00B0C63C
	private const float CD = 0.06666667f; // Metadata: 0x00B0C640
	private int runHash; // 0x88
	private int walkHash; // 0x8C
	private int standbyHash; // 0x90
	private const string _taskName = "EntityCommonMoveTask"; // Metadata: 0x00B0C644
	private RaycastHit _groundHitResult; // 0x98
	private Ray _ray; // 0xD8

	// Properties
	public override string taskName { /* [XID] */ /* 0x0000000189AC1F00-0x0000000189AC1F20 */ get => default; } // 0x0000000182431430-0x00000001824314E0 

	// Constructors
	public EntityCommonMoveTask() {} // 0x0000000182431310-0x0000000182431430

	// Methods
	// [XID] // 0x0000000189961DB0-0x0000000189961DD0
	private void CollectAnimatorMoveInfo(ref EntityCommonMoveData data) {} // 0x000000018242BAD0-0x000000018242CEE0
	// [XID] // 0x00000001899693F0-0x0000000189969410
	private void ExecuteAnimatorMove(ref EntityCommonMoveData data) {} // 0x0000000182426880-0x0000000182428790
	// [XID] // 0x0000000189970F70-0x0000000189970F90
	private void UpdateAnimatorDeltaMove(ref EntityCommonMoveData data) {} // 0x0000000182424310-0x00000001824246B0
	// [XID] // 0x00000001899788A0-0x00000001899788C0
	private bool needRotateThisFrame(ref EntityCommonMoveData data) => default; // 0x000000018242D740-0x000000018242DA60
	// [XID] // 0x000000018997F910-0x000000018997F930
	private void CheckJamProtection(ref EntityCommonMoveData data) {} // 0x0000000182425E80-0x00000001824266F0
	// [XID] // 0x0000000189987300-0x0000000189987320
	private void MoveUpdateTilt(ref EntityCommonMoveData data) {} // 0x0000000182430BA0-0x0000000182430FC0
	// [XID] // 0x000000018998EDD0-0x000000018998EDF0
	private float CalcTiltByYawDelta(ref EntityCommonMoveData data, float toDesiredYaw, float tiltCoeff) => default; // 0x000000018242D040-0x000000018242D250
	// [XID] // 0x0000000189996990-0x00000001899969B0
	private void CheckIsFallOnGround(ref EntityCommonMoveData data) {} // 0x000000018242A520-0x000000018242AC10
	// [XID] // 0x000000018999E410-0x000000018999E430
	private void CheckIsInAir(ref EntityCommonMoveData data) {} // 0x000000018242A3E0-0x000000018242A520
	// [XID] // 0x00000001899A5E30-0x00000001899A5E50
	private void CheckInSlip(ref EntityCommonMoveData data) {} // 0x0000000182428870-0x00000001824289E0
	// [XID] // 0x00000001899AD450-0x00000001899AD470
	private float GetSlope(Vector3 normal) => default; // 0x000000018242AE90-0x000000018242AFD0
	// [XID] // 0x00000001899B4D10-0x00000001899B4D30
	private bool IsCliffDistance(ref EntityCommonMoveData data, float distance) => default; // 0x0000000182425940-0x0000000182425A20
	// [XID] // 0x00000001899BC450-0x00000001899BC470
	private bool IsRemoteSafePosValid(ref EntityCommonMoveData data, float closetogroundDist) => default; // 0x0000000182425760-0x0000000182425940
	// [XID] // 0x00000001899C3DF0-0x00000001899C3E10
	private bool IsAuthorityFixedRushMoveSafePosValid(ref EntityCommonMoveData data, float closetogroundDist) => default; // 0x000000018242AFD0-0x000000018242B1D0
	// [XID] // 0x00000001899CB570-0x00000001899CB590
	private Vector3 ApplyGravity(ref EntityCommonMoveData data, Vector3 velocity) => default; // 0x00000001824289E0-0x0000000182428ED0
	// [XID] // 0x00000001899D29C0-0x00000001899D29E0
	private bool CheckWallAndCliff(ref EntityCommonMoveData data, Vector3 vel, out bool isCliffDist) {
		isCliffDist = default;
		return default;
	} // 0x000000018242FB10-0x0000000182430840
	// [XID] // 0x00000001899DA0B0-0x00000001899DA0D0
	private WaterResult CheckAlmostInOutWater(ref EntityCommonMoveData data, Vector3 velocity) => default; // 0x000000018242AC10-0x000000018242AE90
	// [XID] // 0x00000001899E1A90-0x00000001899E1AB0
	private void DrownWater(ref EntityCommonMoveData data) {} // 0x0000000182425D80-0x0000000182425E80
	// [XID] // 0x00000001899E8F20-0x00000001899E8F40
	private void UpdateExtraCloseToGroundVelocity(ref EntityCommonMoveData data) {} // 0x000000018242B370-0x000000018242BAD0
	// [XID] // 0x00000001899F08A0-0x00000001899F08C0
	private void UpdateExtraCloseToGroundVelocitySync(ref EntityCommonMoveData data) {} // 0x0000000182424720-0x0000000182424930
	// [XID] // 0x00000001899F7F00-0x00000001899F7F20
	private void CheckCanSyncMoveFirstEnter(ref EntityCommonMoveData data) {} // 0x0000000182430FC0-0x00000001824310C0
	// [XID] // 0x00000001899FF5B0-0x00000001899FF5D0
	private void CalcAnimatorMoveCurrentGroundHeight(ref EntityCommonMoveData data) {} // 0x00000001824238D0-0x0000000182424310
	// [XID] // 0x0000000189A06E30-0x0000000189A06E50
	private void AnimatorMoveCloseToGround(ref EntityCommonMoveData data) {} // 0x000000018242B1D0-0x000000018242B370
	// [XID] // 0x0000000189A0E500-0x0000000189A0E520
	private void SyncAnimatorMoveCloseToGround(ref EntityCommonMoveData data) {} // 0x000000018242DA60-0x000000018242DC60
	// [XID] // 0x0000000189A15AE0-0x0000000189A15B00
	public void DetectRigidbodyVelocity(Vector3 v, int tagHash, ref EntityCommonMoveData data) {} // 0x0000000182420B30-0x0000000182421640
	// [XID] // 0x0000000189A1CF60-0x0000000189A1CF80
	private void ExecuteAnimatorMoveSync(ref EntityCommonMoveData data) {} // 0x0000000182429450-0x000000018242A1A0
	// [XID] // 0x0000000189A24580-0x0000000189A245A0
	private void ProcessCurrentMoveTask(ref EntityCommonMoveData data) {} // 0x000000018242E8B0-0x000000018242FB10
	// [XID] // 0x0000000189A2B980-0x0000000189A2B9A0
	private bool GetNextSyncOrder(ref EntityCommonMoveData data) => default; // 0x0000000182421BB0-0x0000000182422090
	// [XID] // 0x0000000189A32FC0-0x0000000189A32FE0
	private void SetAnimSync(ref EntityCommonMoveData data, MotionState motionState) {} // 0x0000000182420730-0x00000001824208A0
	// [XID] // 0x0000000189A3A8D0-0x0000000189A3A8F0
	private void SetFaceWithSteerDir(ref EntityCommonMoveData data, Vector3 steerDir) {} // 0x00000001824201C0-0x0000000182420730
	// [XID] // 0x0000000189A42200-0x0000000189A42220
	private void CalcCurrentGroundHeight(ref EntityCommonMoveData data) {} // 0x000000018242A1A0-0x000000018242A270
	// [XID] // 0x0000000189A497B0-0x0000000189A497D0
	private Vector3 MoveFollowReferenceSystem(ref EntityCommonMoveData data) => default; // 0x0000000182428ED0-0x0000000182429150
	// [XID] // 0x0000000189A51140-0x0000000189A51160
	private void CheckGroundReferenceSystem(ref EntityCommonMoveData data) {} // 0x000000018242E4E0-0x000000018242E760
	// [XID] // 0x0000000189A586C0-0x0000000189A586E0
	private void FlushAnimatorMove(ref EntityCommonMoveData data) {} // 0x0000000182422090-0x0000000182423860
	// [XID] // 0x0000000189A60290-0x0000000189A602B0
	private void StayInPlace(ref EntityCommonMoveData data) {} // 0x000000018241F870-0x000000018241FD80
	// [XID] // 0x0000000189A67DC0-0x0000000189A67DE0
	private void MoveUpdateRotationBase(ref EntityCommonMoveData data) {} // 0x000000018242D250-0x000000018242D6D0
	// [XID] // 0x0000000189A6F1D0-0x0000000189A6F1F0
	private void MoveUpdateRotation(ref EntityCommonMoveData data) {} // 0x0000000182421640-0x00000001824219A0
	// [XID] // 0x0000000189A769F0-0x0000000189A76A10
	private void PreUpdateGroundCount(ref EntityCommonMoveData data) {} // 0x000000018242CEE0-0x000000018242D040
	// [XID] // 0x0000000189A7E300-0x0000000189A7E320
	private void PostUpdateGroundCount(ref EntityCommonMoveData data) {} // 0x0000000182428790-0x0000000182428870
	// [XID] // 0x0000000189A85C80-0x0000000189A85CA0
	private void FlushMove(ref EntityCommonMoveData data) {} // 0x000000018242E760-0x000000018242E8B0
	// [XID] // 0x0000000189A8D560-0x0000000189A8D580
	private void FlushRigidbodyMove(ref EntityCommonMoveData data, EntityCommonMoveCache cache) {} // 0x00000001824310C0-0x0000000182431310
	// [XID] // 0x0000000189A94AE0-0x0000000189A94B00
	private void FlushTransformMove(ref EntityCommonMoveData data, EntityCommonMoveCache cache) {} // 0x0000000182429150-0x00000001824292F0
	// [XID] // 0x0000000189A9C360-0x0000000189A9C380
	private void CollectNpcMoveInfo(ref EntityCommonMoveData data) {} // 0x000000018242DC60-0x000000018242E4E0
	// [XID] // 0x0000000189AA3A90-0x0000000189AA3AB0
	private void ExecuteNpcMove(ref EntityCommonMoveData data) {} // 0x0000000182424930-0x0000000182425760
	// [XID] // 0x0000000189AAB0B0-0x0000000189AAB0D0
	private void CalcNpcCurrentGroundHeight(ref EntityCommonMoveData data) {} // 0x000000018241FD80-0x00000001824201C0
	// [XID] // 0x0000000189AB2A00-0x0000000189AB2A20
	private void NPCCloseToGround(ref EntityCommonMoveData data) {} // 0x0000000182425A20-0x0000000182425BA0
	// [XID] // 0x0000000189ABA570-0x0000000189ABA590
	private void FlushNpcMove(ref EntityCommonMoveData data) {} // 0x000000018242A270-0x000000018242A3E0
	// [XID] // 0x0000000189AC94D0-0x0000000189AC94F0
	private bool ShouldTick(EntityCommonMoveData data) => default; // 0x00000001824292F0-0x00000001824293E0
	// [XID] // 0x0000000189AD0EE0-0x0000000189AD0F00
	protected override void CollectInternal(int index) {} // 0x00000001824219A0-0x0000000182421BB0
	// [XID] // 0x0000000189AD8C10-0x0000000189AD8C30
	private void GetCacheFromTransform(ref EntityCommonMoveData data, EntityCommonMoveCache cache) {} // 0x0000000182420910-0x0000000182420B30
	// [XID] // 0x0000000189AE0700-0x0000000189AE0720
	protected override void ExecuteInternal(int index) {} // 0x0000000182425BA0-0x0000000182425D80
	// [XID] // 0x0000000189AE7CB0-0x0000000189AE7CD0
	protected override void FlushInternal(int index) {} // 0x00000001824266F0-0x0000000182426880
	// [XID] // 0x0000000189AEF990-0x0000000189AEF9B0
	protected override void OnPauseInternal(int index) {} // 0x00000001824308B0-0x0000000182430A90
	// [XID] // 0x0000000189AF6EF0-0x0000000189AF6F10
	protected override void OnResumeInternal(int index) {} // 0x0000000182430A90-0x0000000182430BA0
}

