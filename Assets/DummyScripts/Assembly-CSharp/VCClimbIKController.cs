/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCClimbIKController : VCBase // TypeDefIndex: 11845
{
	// Fields
	private Animator _animator; // 0x110
	private VCHumanoidMove _humanoidMove; // 0x118
	private IKBodyState _ikState; // 0x120
	private bool _isCutsceneCtrl; // 0x2E8
	public float handNormalSmooth; // 0x2EC
	private Transform _lUpperArmTran; // 0x2F0
	private Transform _rUpperArmTran; // 0x2F8
	private Transform _lLowerArmTran; // 0x300
	private Transform _rLowerArmTran; // 0x308
	private Transform _lFingerTran; // 0x310
	private Transform _rFingerTran; // 0x318
	private Transform _lHandTran; // 0x320
	private Transform _rHandTran; // 0x328
	private Transform _lUpperLegTran; // 0x330
	private Transform _rUpperLegTran; // 0x338
	private Transform _lLowerLegTran; // 0x340
	private Transform _rLowerLegTran; // 0x348
	private Transform _lFootTran; // 0x350
	private Transform _rFootTran; // 0x358
	private float _climbFootOffset; // 0x360
	public float hitNormalLerp; // 0x364
	public bool logInfo; // 0x368
	private string CLIMB_HOR_PARAM_NAME; // 0x370
	private string CLIMB_VER_PARAM_NAME; // 0x378
	private RaycastHitResult _handHit; // 0x380
	private RaycastHitResult _horizonFingerScanHit; // 0x3A0
	private RaycastHitResult _verticalFingerScanHit; // 0x3C0
	private RaycastHitResult _legHit; // 0x3E0
	private RaycastHitResult _footHit; // 0x400
	private RaycastHitResult _horizonFootScanHit; // 0x420
	private RaycastHitResult _verticalFootScanHit; // 0x440
	public bool useLeftHandIKPos; // 0x460
	public bool useRightHandIKPos; // 0x461
	public bool useLeftFootIKPos; // 0x462
	public bool useRightFootIKPos; // 0x463
	public bool useLeftHandIKRot; // 0x464
	public bool useRightHandIKRot; // 0x465
	private static Color raycastLightGreenColor; // 0x00
	private static Color raycastGreenColor; // 0x10
	private static Color raycastLightPurpleColor; // 0x20
	private static Color raycastPurpleColor; // 0x30
	private RaycastHitResult _halfCycleRaycastHit; // 0x468
	private RaycastHit _hitInfo; // 0x488
	private const float STABLE_HAND_OFFSET = 0.0004f; // Metadata: 0x00AEACF2
	private const float STABLE_FOOT_OFFSET = 0.0004f; // Metadata: 0x00AEACF6

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899D2150-0x00000001899D2170 */ get => default; } // 0x0000000182F5DA30-0x0000000182F5DAD0 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public MonoAnimationIKEventHelper animationIKHelper { /* [XID] */ /* 0x00000001899D9840-0x00000001899D9880 */ get; /* [XID] */ /* 0x00000001899E3EE0-0x00000001899E3F20 */ private set; } // 0x0000000182F57000-0x0000000182F57060 0x0000000182F57060-0x0000000182F570D0

	// Nested types
	[Flags] // 0x000000018990A800-0x000000018990A810
	private enum IKMoveDirection // TypeDefIndex: 11846
	{
		Idle = 0,
		Horizon = 1,
		Vertical = 2
	}

	private struct IKLimbState // TypeDefIndex: 11847
	{
		// Fields
		public float posIKLerp; // 0x00
		public Vector3 lastTranPos; // 0x04
		public Vector3 tranPos; // 0x10
		public Vector3 ikPos; // 0x1C
		public Vector3 fingerPos; // 0x28
		public Vector3 lowerLimbPos; // 0x34
		public Vector3 upperLimbPos; // 0x40
		public float rotIKLerp; // 0x4C
		public Quaternion tranRot; // 0x50
		public Quaternion ikRot; // 0x60

		// Methods
		// [XID] // 0x0000000189AF4D80-0x0000000189AF4DA0
		public void ShiftWorld(Vector3 delta) {} // 0x0000000182F686C0-0x0000000182F687D0
		// [XID] // 0x0000000189AFC2E0-0x0000000189AFC300
		public void Clear() {} // 0x0000000182F68400-0x0000000182F686C0
	}

	private struct IKBodyState // TypeDefIndex: 11848
	{
		// Fields
		public bool isInClimbCondition; // 0x00
		public bool isStableStandby; // 0x01
		public IKMoveDirection moveDirection; // 0x04
		public IKLimbState lHandState; // 0x08
		public IKLimbState rHandState; // 0x78
		public IKLimbState lFootState; // 0xE8
		public IKLimbState rFootState; // 0x158

		// Methods
		// [XID] // 0x0000000189B03C10-0x0000000189B03C30
		public void Clear() {} // 0x0000000182F687D0-0x0000000182F68AD0
	}

	private struct RaycastHitResult // TypeDefIndex: 11849
	{
		// Fields
		public bool hasHitted; // 0x00
		public Vector3 hitPoint; // 0x04
		public float hitDistance; // 0x10
		public Vector3 hitNormal; // 0x14
	}

	// Constructors
	public VCClimbIKController() {} // 0x0000000182F5D8C0-0x0000000182F5DA30
	static VCClimbIKController() {} // 0x0000000182F5D730-0x0000000182F5D8C0

	// Methods
	// [XID] // 0x00000001899EE530-0x00000001899EE550
	public void SetCutsceneCtrl(bool value) {} // 0x0000000182F59360-0x0000000182F59410
	// [XID] // 0x00000001896C85C0-0x00000001896C85E0
	private Vector3 GetUpperArmTranPos(IKBodySide bodySide) => default; // 0x0000000182F57910-0x0000000182F57A40
	// [XID] // 0x00000001896CFFB0-0x00000001896CFFD0
	private Vector3 GetLowerArmTranPos(IKBodySide bodySide) => default; // 0x0000000182F58C10-0x0000000182F58D40
	// [XID] // 0x00000001896D73E0-0x00000001896D7400
	private Vector3 GetFingerTranPos(IKBodySide bodySide) => default; // 0x0000000182F5BA90-0x0000000182F5BBC0
	// [XID] // 0x00000001896DED30-0x00000001896DED50
	private Vector3 GetHandTranPos(IKBodySide bodySide) => default; // 0x0000000182F5D410-0x0000000182F5D540
	// [XID] // 0x00000001898DD0B0-0x00000001898DD0D0
	private Quaternion GetHandTranRot(IKBodySide bodySide) => default; // 0x0000000182F5B910-0x0000000182F5BA90
	// [XID] // 0x0000000189A1AE30-0x0000000189A1AE50
	private Vector3 GetUpperLegTranPos(IKBodySide bodySide) => default; // 0x0000000182F575D0-0x0000000182F57700
	// [XID] // 0x0000000189A22750-0x0000000189A22770
	private Vector3 GetLowerLegTranPos(IKBodySide bodySide) => default; // 0x0000000182F58A00-0x0000000182F58B30
	// [XID] // 0x00000001896F4E40-0x00000001896F4E60
	private Vector3 GetFootTranPos(IKBodySide bodySide) => default; // 0x0000000182F57A40-0x0000000182F57B70
	// [XID] // 0x0000000189A30EE0-0x0000000189A30F00
	public override void Init() {} // 0x0000000182F59EA0-0x0000000182F5A780
	// [XID] // 0x0000000189A38B70-0x0000000189A38B90
	public override void Destroy() {} // 0x0000000182F57760-0x0000000182F57910
	// [XID] // 0x0000000189A40120-0x0000000189A40140
	public override void OnEnable() {} // 0x0000000182F5D350-0x0000000182F5D410
	// [XID] // 0x0000000189A477C0-0x0000000189A477E0
	private void OnAnimatorIK(int layerIndex) {} // 0x0000000182F58230-0x0000000182F58A00
	// [XID] // 0x0000000189A4EFB0-0x0000000189A4EFD0
	private void CalcClimbState() {} // 0x0000000182F58B30-0x0000000182F58C10
	// [XID] // 0x0000000189A56620-0x0000000189A56640
	private bool IsInClimbState() => default; // 0x0000000182F58D40-0x0000000182F58E30
	// [XID] // 0x0000000189A5E210-0x0000000189A5E230
	private bool IsStableStandby() => default; // 0x0000000182F59410-0x0000000182F594E0
	// [XID] // 0x0000000189A659C0-0x0000000189A659E0
	private IKMoveDirection GetMoveDirection() => default; // 0x0000000182F56E80-0x0000000182F57000
	// [XID] // 0x00000001897365F0-0x0000000189736610
	private void CalcHandIKState(IKBodySide bodySide, ref IKLimbState ikHandState) {} // 0x0000000182F58E30-0x0000000182F59360
	// [XID] // 0x0000000189A747A0-0x0000000189A747C0
	private bool CheckHandAcrossWall(IKLimbState ikHandState, ref Vector3 handPos, ref Quaternion handRot) => default; // 0x0000000182F57B70-0x0000000182F58230
	// [XID] // 0x0000000189A7C2E0-0x0000000189A7C300
	private bool CheckHandCloseToWall(IKLimbState ikHandState, ref Vector3 handPos, ref Quaternion handRot) => default; // 0x0000000182F56730-0x0000000182F56E20
	// [XID] // 0x0000000189A83CC0-0x0000000189A83CE0
	private Quaternion GetHandRotFromNormal(IKLimbState ikHandState, Vector3 wallNorm) => default; // 0x0000000182F594E0-0x0000000182F59730
	// [XID] // 0x0000000189A8B630-0x0000000189A8B650
	private Vector3 GetHandPosFromHandHit(IKLimbState ikHandState, Vector3 wallNorm, Vector3 handHit, Quaternion handRot) => default; // 0x0000000182F59730-0x0000000182F59D30
	// [XID] // 0x0000000189A92C20-0x0000000189A92C40
	private Vector3 GetHandPosFromFingerHit(IKLimbState ikHandState, Vector3 fingerHit, Quaternion handRot) => default; // 0x0000000182F570D0-0x0000000182F57520
	// [XID] // 0x0000000189A9A6E0-0x0000000189A9A700
	private void CalcFootIKState(IKBodySide bodySide, ref IKLimbState ikFootState) {} // 0x0000000182F5AE60-0x0000000182F5B250
	// [XID] // 0x0000000189AA1700-0x0000000189AA1720
	private bool CheckFootAcrossWall(IKLimbState ikFootState, ref Vector3 hitPos) => default; // 0x0000000182F5BC30-0x0000000182F5C960
	// [XID] // 0x0000000189AA8DD0-0x0000000189AA8DF0
	private bool CheckFootCloseToWall(IKLimbState ikFootState, ref Vector3 footPos) => default; // 0x0000000182F5CD60-0x0000000182F5D350
	// [XID] // 0x0000000189AB0A50-0x0000000189AB0A70
	private void UpdateIKAnim() {} // 0x0000000182F5C960-0x0000000182F5CB70
	// [XID] // 0x0000000189AB8040-0x0000000189AB8060
	private bool IKHalfCycleRaycast(Vector3 point, Vector3 forward, Vector3 axis, float length, bool inverse, out RaycastHitResult hitResult) {
		hitResult = default;
		return default;
	} // 0x0000000182F5B250-0x0000000182F5B910
	// [XID] // 0x0000000189ABFAC0-0x0000000189ABFAE0
	private bool IKRaycast(Vector3 startPoint, Vector3 endPoint, out RaycastHitResult hitResult, Color color) {
		hitResult = default;
		return default;
	} // 0x0000000182F5A960-0x0000000182F5AE60
	// [XID] // 0x0000000189AC76D0-0x0000000189AC76F0
	private Vector3 GetStableTranPos(Vector3 newTranPos, Vector3 oldTranPos, float offset) => default; // 0x0000000182F5CB70-0x0000000182F5CD60
	// [XID] // 0x0000000189AE8B30-0x0000000189AE8B50
	private void OnAnimatorIKPos(AvatarIKGoal ikGoal, float lerp, Vector3 pos) {} // 0x0000000182F5A7E0-0x0000000182F5A960
	// [XID] // 0x0000000189AD6BF0-0x0000000189AD6C10
	private void OnAnimatorIKRot(AvatarIKGoal ikGoal, float lerp, Quaternion rot) {} // 0x0000000182F59D30-0x0000000182F59EA0
	// [XID] // 0x0000000189ADE440-0x0000000189ADE460
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000182F5D540-0x0000000182F5D730
}

