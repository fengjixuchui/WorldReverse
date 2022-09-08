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

public sealed class VCRigidbodyMove : VCSimpleMove // TypeDefIndex: 11939
{
	// Fields
	private const float ENABLE_RIGIDBODY_DIST = 25f; // Metadata: 0x00AEAF7E
	private bool _enableRigibody; // 0x368
	private bool _followReferenceSys; // 0x369
	private bool _enableCloseToGroundWhenTick; // 0x36A

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896408D0-0x00000001896408F0 */ get => default; } // 0x0000000183483210-0x00000001834832B0 

	// Constructors
	public VCRigidbodyMove() {} // 0x00000001834831A0-0x0000000183483210

	// Methods
	// [XID] // 0x0000000189685B10-0x0000000189685B30
	public override void Init() {} // 0x0000000183481B30-0x0000000183481D70
	// [XID] // 0x0000000189ABCCE0-0x0000000189ABCD00
	protected override void InitMoveComponent() {} // 0x0000000183481E70-0x00000001834820A0
	// [XID] // 0x00000001896B2260-0x00000001896B2280
	protected override void LateTick(float inDeltaTime) {} // 0x00000001834820A0-0x00000001834828D0
	// [XID] // 0x00000001897B2C50-0x00000001897B2C70
	public override bool IsInAirState() => default; // 0x0000000183480EA0-0x0000000183480F60
	// [XID] // 0x0000000189AD3670-0x0000000189AD3690
	protected override void CheckIsFallOnGround(float deltaTime) {} // 0x0000000183481990-0x0000000183481B30
	// [XID] // 0x0000000189ADB110-0x0000000189ADB130
	protected override void CalcCurrentGroundHeight() {} // 0x00000001834813B0-0x0000000183481870
	// [XID] // 0x0000000189AE2820-0x0000000189AE2840
	private void CheckIsInAir(Vector3 velocity) {} // 0x0000000183481870-0x0000000183481990
	// [XID] // 0x0000000189AEA310-0x0000000189AEA330
	private Vector3 ApplyGravity(float deltaTime, Vector3 vel) => default; // 0x0000000183481020-0x00000001834813B0
	// [XID] // 0x0000000189AF1E70-0x0000000189AF1E90
	protected override void CloseToGround(float deltaTime) {} // 0x0000000183482D10-0x00000001834831A0
	// [XID] // 0x0000000189AF9800-0x0000000189AF9820
	private void CheckEnableRigidbody() {} // 0x0000000183482940-0x0000000183482BC0
	// [XID] // 0x00000001896C85A0-0x00000001896C85C0
	private void EnableRigidbody() {} // 0x0000000183480D80-0x0000000183480EA0
	// [XID] // 0x0000000189B08230-0x0000000189B08250
	private void DisableRigidbody() {} // 0x0000000183482BC0-0x0000000183482D10
	// [XID] // 0x0000000189B0FA90-0x0000000189B0FAB0
	protected override void StayInPlace() {} // 0x0000000183480AD0-0x0000000183480C30
}

