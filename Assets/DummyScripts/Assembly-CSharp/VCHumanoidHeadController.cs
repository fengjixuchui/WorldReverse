/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class VCHumanoidHeadController : VCHeadController // TypeDefIndex: 11882
{
	// Fields
	private const string HEAD_CONTROLLER_LAYER_NAME = "HeadControllerLayer"; // Metadata: 0x00AEADB9
	protected Animator _animator; // 0x230
	private int _headControllerLayerIndex; // 0x238
	private const float MAX_HORIZON_HALF_ANGLE = 60f; // Metadata: 0x00AEADD0
	private const float MAX_VERTICAL_HALF_ANGLE = 30f; // Metadata: 0x00AEADD4
	private float _compensateAngleForBodyTilt; // 0x23C
	private float _tarHeadHor; // 0x240
	private float _curHeadHor; // 0x244
	private float _tarHeadVer; // 0x248
	private float _curHeadVer; // 0x24C
	protected bool _forceSetlookAt; // 0x250
	private bool _ctrlBody; // 0x251
	private float _ctrlBodyWeight; // 0x254
	private float _ctrlBodySpeed; // 0x258
	private Quaternion _curBodyRot; // 0x25C
	private float _bodyYaw; // 0x26C
	private float bodySpring; // 0x270
	private LCAbilityState _abilityState; // 0x278

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189902E40-0x0000000189902E60 */ get; } // 0x0000000183534140-0x00000001835341E0 
	public bool isForceSetlookAt { /* [XID] */ /* 0x0000000189B694D0-0x0000000189B694F0 */ get; } // 0x0000000183532DD0-0x0000000183532E80 

	// Constructors
	protected VCHumanoidHeadController() {} // Dummy constructor
	protected VCHumanoidHeadController(ConfigHeadControl config) {} // 0x00000001835340B0-0x0000000183534140

	// Methods
	// [XID] // 0x0000000189911EB0-0x0000000189911ED0
	public override void PreInit() {} // 0x0000000183533CE0-0x0000000183533DD0
	// [XID] // 0x0000000189919940-0x0000000189919960
	public override void Init() {} // 0x0000000183532AB0-0x0000000183532CB0
	// [XID] // 0x0000000189A88540-0x0000000189A88560
	public override void OnEnable() {} // 0x0000000183533B50-0x0000000183533C00
	// [XID] // 0x00000001899288D0-0x00000001899288F0
	protected override void Tick(float inDeltaTime) {} // 0x0000000183533DD0-0x00000001835340B0
	// [XID] // 0x000000018992FD50-0x000000018992FD70
	protected override void LateTick(float inDeltaTime) {} // 0x0000000183533570-0x0000000183533910
	// [XID] // 0x0000000189937250-0x0000000189937270
	private void UpdateHeadControllerByTransformRotation(float deltaTime) {} // 0x0000000183532E80-0x00000001835334C0
	// [XID] // 0x0000000189A2B220-0x0000000189A2B240
	protected virtual void CheckRotDegree() {} // 0x00000001835316E0-0x0000000183531C50
	// [XID] // 0x0000000189B52A70-0x0000000189B52A90
	public virtual void StartForceSetLookAt() {} // 0x0000000183533C00-0x0000000183533CE0
	// [XID] // 0x000000018994DB60-0x000000018994DB80
	public virtual void SetLookAt(Vector3? pos) {} // 0x0000000183531550-0x0000000183531600
	// [XID] // 0x0000000189955140-0x0000000189955160
	public void ForceSetLookAt(float yaw, float pitch) {} // 0x0000000183531DD0-0x0000000183532120
	// [XID] // 0x00000001898D2790-0x00000001898D27B0
	public virtual void StopForceSetLookAt() {} // 0x0000000183531CD0-0x0000000183531DD0
	// [XID] // 0x0000000189964250-0x0000000189964270
	public void EnableBodyRotate(bool enabled, float blendTime = 0.3f /* Metadata: 0x00AEADB5 */) {} // 0x0000000183533980-0x0000000183533AF0
	// [XID] // 0x000000018996B870-0x000000018996B890
	public void SetBodyRotate(float yaw) {} // 0x00000001835329D0-0x0000000183532AB0
	// [XID] // 0x0000000189A975F0-0x0000000189A97610
	protected bool UseAimOffset() => default; // 0x00000001835334C0-0x0000000183533570
	// [XID] // 0x000000018997AC80-0x000000018997ACA0
	private void UpdateHeadControllerByAimOffset(float deltaTime) {} // 0x0000000183532120-0x0000000183532810
	// [XID] // 0x0000000189A8FE90-0x0000000189A8FEB0
	protected void RefreshHeadControllerLayerIndex() {} // 0x00000001835328C0-0x00000001835329D0
	// [XID] // 0x0000000189989D90-0x0000000189989DB0
	protected override void ForceLookForward() {} // 0x0000000183532810-0x00000001835328C0
	// [XID] // 0x0000000189991690-0x00000001899916B0
	protected bool IsStateRestricted() => default; // 0x0000000183532D10-0x0000000183532DD0
}

