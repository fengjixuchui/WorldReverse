/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCManekinHeadController : VCHumanoidHeadController // TypeDefIndex: 11897
{
	// Fields
	private Camera _camera; // 0x280
	private HeadControllerStyle _style; // 0x288
	private int STANDBY_STATE_HASH; // 0x328
	private ManekinHeadControllerStatus _status; // 0x32C
	private float _angleSpeed; // 0x330
	private Vector3 _cameraForward; // 0x334
	private Vector3 _entityForward; // 0x340
	private Vector3 _headForward; // 0x34C
	private Vector3 _randomForward; // 0x358
	private Vector3 _expectedForward; // 0x364
	private MotionType _motion; // 0x370
	private Vector3 _lastCameraPosition; // 0x374
	private float _timeLeft; // 0x380

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898F0E40-0x00000001898F0E60 */ get => default; } // 0x0000000181C2B0A0-0x0000000181C2B140 

	// Nested types
	private enum MotionType // TypeDefIndex: 11898
	{
		Wait = 0,
		FirstRandomPos = 1,
		SecondRandomPos = 2,
		LookCamera = 3
	}

	// Constructors
	public VCManekinHeadController() {} // Dummy constructor
	public VCManekinHeadController(ConfigHeadControl config) {} // 0x0000000181C2B000-0x0000000181C2B0A0

	// Methods
	// [XID] // 0x0000000189748810-0x0000000189748830
	protected override void Tick(float inDeltaTime) {} // 0x0000000181C2AF40-0x0000000181C2B000
	// [XID] // 0x000000018974FDB0-0x000000018974FDD0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181C2A830-0x0000000181C2A900
	// [XID] // 0x0000000189757480-0x00000001897574A0
	private void ResetHeadControllerParameter() {} // 0x0000000181C297C0-0x0000000181C29970
	// [XID] // 0x000000018975EC50-0x000000018975EC70
	protected override void UpdateTarget() {} // 0x0000000181C29720-0x0000000181C297C0
	// [XID] // 0x000000018991E170-0x000000018991E190
	protected override void UpdateTargetDir(float deltaTime) {} // 0x0000000181C29970-0x0000000181C2A830
	// [XID] // 0x0000000189925A80-0x0000000189925AA0
	private void UpdateInNoneStatus() {} // 0x0000000181C28C20-0x0000000181C28CE0
	// [XID] // 0x0000000189774D20-0x0000000189774D40
	private void UpdateInAvatarStatus(float deltaTime, float horizonAngle, float verticalAngle) {} // 0x0000000181C2AAA0-0x0000000181C2AF40
	// [XID] // 0x0000000189934540-0x0000000189934560
	private void EnterMotionType(MotionType motion) {} // 0x0000000181C28E80-0x0000000181C29160
	// [XID] // 0x00000001899A3C00-0x00000001899A3C20
	private void UpdateInWeaponStatus(float deltaTime, float horizonAngle, float verticalAngle) {} // 0x0000000181C28CE0-0x0000000181C28E80
	// [XID] // 0x0000000189A1AEF0-0x0000000189A1AF10
	private void UpdateInRelicStatus(float deltaTime, float horizonAngle, float verticalAngle) {} // 0x0000000181C29500-0x0000000181C296A0
	// [XID] // 0x0000000189A04CE0-0x0000000189A04D00
	public void InitManekinStatus(Camera camera, HeadControllerStyle style) {} // 0x0000000181C29160-0x0000000181C29320
	// [XID] // 0x00000001899AB6B0-0x00000001899AB6D0
	public void SetManekinStatus(ManekinHeadControllerStatus status) {} // 0x0000000181C29400-0x0000000181C29500
	// [XID] // 0x00000001897A22C0-0x00000001897A22E0
	public bool IsHeadControllerWaiting() => default; // 0x0000000181C2A900-0x0000000181C2A9B0
}

