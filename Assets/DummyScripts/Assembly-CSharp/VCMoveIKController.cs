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
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCMoveIKController : VCBase // TypeDefIndex: 11910
{
	// Fields
	private Animator _animator; // 0x110
	private AnimatorController _animatorController; // 0x118
	private VCHumanoidMove _humanoidMove; // 0x120
	private IKBodyState _ikState; // 0x128
	private const float IK_LERP_SPD = 5f; // Metadata: 0x00AEAE79
	public float normalSmooth; // 0x388
	public float posSmooth; // 0x38C
	public float footLengthBias; // 0x390
	private bool _isCutsceneCtrl; // 0x394
	private float _footLiftUpLength; // 0x398
	private float _defaultFootHeightL; // 0x39C
	private float _defaultFootHeightR; // 0x3A0
	private Transform _lFootTran; // 0x3A8
	private Transform _rFootTran; // 0x3B0
	private Transform _lToeTran; // 0x3B8
	private Transform _rToeTran; // 0x3C0
	private Transform _lToeNubTran; // 0x3C8
	private Transform _rToeNubTran; // 0x3D0
	private float _lFootThickness; // 0x3D8
	private float _rFootThickness; // 0x3DC
	private float _lLegLength; // 0x3E0
	private float _rLegLength; // 0x3E4
	private float _lLegMaxLength; // 0x3E8
	private float _rLegMaxLength; // 0x3EC
	private Transform _lUpperLegTran; // 0x3F0
	private Transform _rUpperLegTran; // 0x3F8
	private float _shoeThickness; // 0x400
	private float _prevHipAdjust; // 0x404
	public bool logInfo; // 0x408
	public Vector3 lKneeAnimPos; // 0x40C
	public Vector3 rKneeAnimPos; // 0x418
	private Transform lKnee; // 0x428
	private Transform rKnee; // 0x430
	private static float _maxYStretchRatio; // 0x00
	private float _horizonGroundThreshold; // 0x438
	public bool useLeftFootIKPos; // 0x43C
	public bool useRightFootIKPos; // 0x43D
	public bool useLeftFootIKRot; // 0x43E
	public bool useRightFootIKRot; // 0x43F
	private static Vector3 _footDetectStartOffset; // 0x04
	private static float _footDetectLength; // 0x10
	private const float STABLE_IK_OFFSET = 0.0002f; // Metadata: 0x00AEAE7D
	private static readonly string[] IKStateList; // 0x18
	private static int[] IKStateHashList; // 0x20
	private const string LEFT_FOOT_ZONE_NAME = "LeftFootStandIK"; // Metadata: 0x00AEAE81
	private const string RIGHT_FOOT_ZONE_NAME = "RightFootStandIK"; // Metadata: 0x00AEAE94
	private const string LEFT_FOOT_HILL_ZONE_NAME = "LeftFootHillIK"; // Metadata: 0x00AEAEA8
	private const string RIGHT_FOOT_HILL_ZONE_NAME = "RightFootHillIK"; // Metadata: 0x00AEAEBA
	private const string STABLE_STANDBY_ZONE_NAME = "StableStandby"; // Metadata: 0x00AEAECD
	private const string LEFT_FOOT_ZONE_R_NAME = "LeftFootStandIK_R"; // Metadata: 0x00AEAEDE
	private const string RIGHT_FOOT_ZONE_R_NAME = "RightFootStandIK_R"; // Metadata: 0x00AEAEF3
	private const float STABLE_IK_OFFSETV2 = 0.05f; // Metadata: 0x00AEAF09
	private const float IK_LERP_ROTATION_SPD = 5f; // Metadata: 0x00AEAF0D
	private const float IK_LERP_POSITION_SPD = 4f; // Metadata: 0x00AEAF11
	private const float IK_HIP_ADJUST_SPD = 5f; // Metadata: 0x00AEAF15
	private static Vector3Pair[] soleIKPoints; // 0x28
	private static float[] castDown; // 0x30
	private const float IK_LERP_ROTATION_SPD_V3 = 6f; // Metadata: 0x00AEAF19
	private const float IK_LERP_POSITION_SPD_V3 = 8f; // Metadata: 0x00AEAF1D
	private const float IK_HIP_ADJUST_SPD_V3 = 5f; // Metadata: 0x00AEAF21
	private const float IK_HIP_ADJUST_SPD_UP_V3 = 10f; // Metadata: 0x00AEAF25

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A659A0-0x0000000189A659C0 */ get => default; } // 0x0000000184421D70-0x0000000184421E50 
	[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
	public MonoAnimationIKEventHelper animationIKHelper { /* [XID] */ /* 0x0000000189A6D090-0x0000000189A6D0D0 */ get; /* [XID] */ /* 0x0000000189A77940-0x0000000189A77980 */ private set; } // 0x000000018440BD70-0x000000018440BDD0 0x000000018440BE80-0x000000018440BEF0
	public float lFootIKWeight { /* [XID] */ /* 0x0000000189A823C0-0x0000000189A823E0 */ get => default; } // 0x000000018440BDD0-0x000000018440BE80 
	public float rFootIKWeight { /* [XID] */ /* 0x0000000189A89D00-0x0000000189A89D20 */ get => default; } // 0x000000018440CF60-0x000000018440D010 

	// Nested types
	private struct Vector3Pair // TypeDefIndex: 11911
	{
		// Fields
		public Vector3 tran; // 0x00
		public Vector3 ik; // 0x0C

		// Methods
		// [XID] // 0x0000000189617E90-0x0000000189617EB0
		public void ShiftWorld(Vector3 delta) {} // 0x0000000183BDBF40-0x0000000183BDBF70
	}

	private struct QuaternionPair // TypeDefIndex: 11912
	{
		// Fields
		public Quaternion tran; // 0x00
		public Quaternion ik; // 0x10
	}

	private struct IKFootState // TypeDefIndex: 11913
	{
		// Fields
		public bool isStableStandby; // 0x00
		public bool isAnimIKValid; // 0x01
		public bool isInMoveIKZone; // 0x02
		public bool isFirstFrameIK; // 0x03
		public bool isFootPosPlant; // 0x04
		public Vector3Pair toeNubPos; // 0x08
		public Vector3Pair toePos; // 0x20
		public Vector3Pair heelPos; // 0x38
		public Vector3Pair? refIKPos; // 0x50
		public Vector3? refIKPosFromFrontFoot; // 0x6C
		public Vector3Pair soleDir; // 0x7C
		public Vector3? refIKDir; // 0x94
		public Vector3? refIKDirFromFrontFoot; // 0xA4
		public Quaternion soleRotFromTranToIK; // 0xB4
		public float rotIKBaseLerp; // 0xC4
		public float rotIKWeightedLerp; // 0xC8
		public QuaternionPair footRot; // 0xCC
		public float castDist; // 0xEC
		public int validPoints; // 0xF0
		public float posIKBaseLerp; // 0xF4
		public float posIKHorizonGroundWeight; // 0xF8
		public float posIKWeightedLerp; // 0xFC
		public float animFootHeight; // 0x100
		public Vector3Pair footPos; // 0x104
		public Vector3 lastFootPos; // 0x11C
		public float hipAdjustWeight; // 0x128
		public float hipAdjustDistTarget; // 0x12C

		// Methods
		// [XID] // 0x000000018961FB70-0x000000018961FB90
		public void ShiftWorld(Vector3 delta) {} // 0x0000000183BDC680-0x0000000183BDC6D0
		// [XID] // 0x000000018978B950-0x000000018978B970
		public void Clear() {} // 0x0000000183BDC330-0x0000000183BDC680
	}

	private struct IKBodyState // TypeDefIndex: 11914
	{
		// Fields
		public IKFootState lFootState; // 0x00
		public IKFootState rFootState; // 0x130

		// Methods
		// [XID] // 0x000000018962E7E0-0x000000018962E800
		public void Clear() {} // 0x0000000183BDC240-0x0000000183BDC330
	}

	// Constructors
	public VCMoveIKController() {} // 0x0000000184421BE0-0x0000000184421D70
	static VCMoveIKController() {} // 0x0000000184421700-0x0000000184421BE0

	// Methods
	// [XID] // 0x0000000189A91400-0x0000000189A91420
	public void SetCutsceneCtrl(bool value) {} // 0x00000001844187F0-0x00000001844188A0
	// [XID] // 0x0000000189A98FB0-0x0000000189A98FD0
	private Vector3 GetFootTranPos(IKBodySide bodySide) => default; // 0x000000018440FBE0-0x000000018440FD10
	// [XID] // 0x000000018971BB50-0x000000018971BB70
	private Quaternion GetFootTranRot(IKBodySide bodySide) => default; // 0x00000001844148B0-0x0000000184414A30
	// [XID] // 0x0000000189AA7930-0x0000000189AA7950
	private Transform GetFootTran(IKBodySide bodySide) => default; // 0x000000018441D5A0-0x000000018441D660
	// [XID] // 0x0000000189AAF170-0x0000000189AAF190
	private Vector3 GetToeTranPos(IKBodySide bodySide) => default; // 0x000000018441D660-0x000000018441D790
	// [XID] // 0x00000001899DC760-0x00000001899DC780
	private Vector3 GetToeNubTranPos(IKBodySide bodySide) => default; // 0x000000018440C340-0x000000018440C470
	// [XID] // 0x0000000189ABE520-0x0000000189ABE540
	private Vector3 GetHeelTranPos(IKBodySide bodySide) => default; // 0x00000001844171D0-0x0000000184417470
	// [XID] // 0x00000001899D51C0-0x00000001899D51E0
	private float GetIdleLegLength(IKBodySide bodySide) => default; // 0x000000018440FB10-0x000000018440FBE0
	// [XID] // 0x0000000189ACD600-0x0000000189ACD620
	private float GetAnimationLegLength(IKBodySide bodySide) => default; // 0x0000000184414650-0x00000001844148B0
	// [XID] // 0x0000000189AD53A0-0x0000000189AD53C0
	private float GetLegMaxLength(IKBodySide bodySide) => default; // 0x000000018440C270-0x000000018440C340
	// [XID] // 0x000000018974FE10-0x000000018974FE30
	private Vector3 GetUpperLegPosition(IKBodySide bodySide) => default; // 0x0000000184420A70-0x0000000184420BA0
	// [XID] // 0x0000000189757500-0x0000000189757520
	public override void Init() {} // 0x0000000184418F10-0x0000000184419E20
	// [XID] // 0x0000000189AEBD10-0x0000000189AEBD30
	public override void Destroy() {} // 0x000000018440F950-0x000000018440FB10
	// [XID] // 0x0000000189AF3740-0x0000000189AF3760
	public override void OnEnable() {} // 0x0000000184420BA0-0x0000000184420C60
	// [XID] // 0x000000018977C7A0-0x000000018977C7C0
	private void OnAnimatorIK(int layerIndex) {} // 0x000000018440FD10-0x0000000184410EA0
	// [XID] // 0x0000000189864BD0-0x0000000189864BF0
	private void CalcFootRefIKState(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x00000001844175D0-0x00000001844187F0
	// [XID] // 0x0000000189B09B60-0x0000000189B09B80
	private void CalcFootIKState(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x000000018441BE00-0x000000018441D5A0
	// [XID] // 0x0000000189B115C0-0x0000000189B115E0
	private void CalcFootIKLerp(ref IKBodyState ikState) {} // 0x0000000184420F80-0x0000000184421550
	// [XID] // 0x000000018980BC60-0x000000018980BC80
	private void UpdateIKAnim() {} // 0x00000001844203F0-0x0000000184420680
	// [XID] // 0x0000000189B1FE90-0x0000000189B1FEB0
	private bool IsStableStandby() => default; // 0x00000001844188A0-0x0000000184418A20
	// [XID] // 0x000000018986C0F0-0x000000018986C110
	private bool IsFootIKValid(IKBodySide bodySide) => default; // 0x000000018440ED60-0x000000018440EE60
	// [IDTag] // 0x0000000189B2E7C0-0x0000000189B2E800
	// [XID] // 0x0000000189B2E7C0-0x0000000189B2E800
	private bool IKRaycast(Vector3 point, out Vector3 hitPoint) {
		hitPoint = default;
		return default;
	} // 0x000000018441AA30-0x000000018441ACB0
	// [XID] // 0x0000000189813460-0x0000000189813480
	private void OnAnimatorIKPos(AvatarIKGoal ikGoal, float lerp, Vector3 pos) {} // 0x000000018441A8B0-0x000000018441AA30
	// [XID] // 0x0000000189B40910-0x0000000189B40930
	private void OnAnimatorIKRot(AvatarIKGoal ikGoal, float lerp, Quaternion rot) {} // 0x0000000184418AF0-0x0000000184418C60
	// [XID] // 0x00000001897DEC80-0x00000001897DECA0
	private Vector3 ProjectPointOnLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd) => default; // 0x000000018441B730-0x000000018441BBD0
	// [IDTag] // 0x0000000189B4FAD0-0x0000000189B4FB10
	// [XID] // 0x0000000189B4FAD0-0x0000000189B4FB10
	private Vector3 GetStableTranPos(Vector3 newTranPos, Vector3 oldTranPos, bool alwaysRefresh) => default; // 0x0000000184420890-0x0000000184420A70
	// [XID] // 0x0000000189B5A2E0-0x0000000189B5A300
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000184421550-0x0000000184421700
	// [XID] // 0x0000000189B61760-0x0000000189B61780
	private void CalcFootRefIKStateV2(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x0000000184414A30-0x00000001844171D0
	// [XID] // 0x0000000189B69330-0x0000000189B69350
	private void CalcFootIKStateV2(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x000000018441D800-0x00000001844203F0
	// [XID] // 0x0000000189B707F0-0x0000000189B70810
	private void UpdateHipAdjust(IKFootState lIkFootState, IKFootState rIkFootState) {} // 0x0000000184413D10-0x0000000184414650
	// [XID] // 0x0000000189B77CA0-0x0000000189B77CC0
	private bool InMoveIKZone(IKBodySide bodySide) => default; // 0x000000018440BEF0-0x000000018440C270
	// [XID] // 0x0000000189B7F2E0-0x0000000189B7F300
	private bool InFootIKState(int stateHash) => default; // 0x0000000184417470-0x00000001844175D0
	// [IDTag] // 0x0000000189B86E50-0x0000000189B86E90
	// [XID] // 0x0000000189B86E50-0x0000000189B86E90
	private bool IKRaycast(Vector3 point, float detectLength, out Vector3 hitPoint, out Vector3 hitNormal) {
		hitPoint = default;
		hitNormal = default;
		return default;
	} // 0x000000018441ACB0-0x000000018441B730
	// [XID] // 0x0000000189B912A0-0x0000000189B912C0
	private float GetHeelHeight(IKBodySide bodySide) => default; // 0x0000000184418A20-0x0000000184418AF0
	// [XID] // 0x00000001897D76F0-0x00000001897D7710
	private static bool IsStablePos(Vector3 delta, float eps) => default; // 0x000000018440D010-0x000000018440D110
	// [XID] // 0x0000000189B9FA40-0x0000000189B9FA60
	private static bool IsInPerform(Animator animator) => default; // 0x0000000184420D90-0x0000000184420F80
	// [IDTag] // 0x0000000189BA72D0-0x0000000189BA7310
	// [XID] // 0x0000000189BA72D0-0x0000000189BA7310
	private Vector3 GetStableTranPos(Vector3 newTranPos, Vector3 oldTranPos, bool plantWithOldPos, float offset = 0.05f /* Metadata: 0x00AEAE74 */, bool logErrors = true /* Metadata: 0x00AEAE78 */) => default; // 0x0000000184420680-0x0000000184420890
	// [XID] // 0x0000000189822670-0x0000000189822690
	private void UpdateV3() {} // 0x0000000184410EA0-0x0000000184411140
	// [XID] // 0x0000000189829C90-0x0000000189829CB0
	private void CalcFootRefIKStateV3(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x000000018440D110-0x000000018440ED60
	// [XID] // 0x00000001898311C0-0x00000001898311E0
	private void CalcFootIKStateV3(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x0000000184411140-0x0000000184413D10
	// [XID] // 0x000000018985D0E0-0x000000018985D100
	private float ClampHipAdjustPos(IKBodySide bodySide, Vector3 ikPos, Vector3 footToLeg, float clampLength) => default; // 0x0000000184419E80-0x000000018441A0D0
	// [XID] // 0x0000000189BCF890-0x0000000189BCF8B0
	private float CalculateHipAdjust(IKBodySide bodySide, Vector3 ikPos, Vector3 footToLeg) => default; // 0x000000018440C470-0x000000018440CAF0
	// [XID] // 0x0000000189BD6D00-0x0000000189BD6D20
	private void UpdateHipAdjustV3(IKFootState lIkFootState, IKFootState rIkFootState) {} // 0x000000018440AFE0-0x000000018440BD70
	// [XID] // 0x0000000189855E30-0x0000000189855E50
	private float ClampAdjustSize(IKFootState ikFootState, IKBodySide bodyside) => default; // 0x0000000184418C60-0x0000000184418F10
	// [XID] // 0x00000001895EB4B0-0x00000001895EB4D0
	private void HandleTargetFootPosTooLong(IKBodySide bodySide, ref IKFootState ikFootState) {} // 0x000000018441A0D0-0x000000018441A8B0
	// [XID] // 0x00000001895F2920-0x00000001895F2940
	private void CalcFootIKLerpV3(ref IKBodyState ikState) {} // 0x000000018440CAF0-0x000000018440CEB0
	// [XID] // 0x00000001895FA280-0x00000001895FA2A0
	private float IKRaycastV3(Vector3 point, float detectLength, out Vector3 hitPoint, out Vector3 hitNormal) {
		hitPoint = default;
		hitNormal = default;
		return default;
	} // 0x000000018440EE60-0x000000018440F8F0
	// [XID] // 0x0000000189601C10-0x0000000189601C30
	private static Vector3 GetLerpedIKFootPos(IKFootState footState, float hipAdjustHeight) => default; // 0x000000018441BBD0-0x000000018441BE00
	// [XID] // 0x0000000189838A00-0x0000000189838A20
	private static float ReRange(float target1, float target2, float f1, float f2, float a) => default; // 0x0000000184420C60-0x0000000184420D90
}

