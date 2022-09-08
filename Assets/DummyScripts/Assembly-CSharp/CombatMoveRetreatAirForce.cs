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

public sealed class CombatMoveRetreatAirForce : MoveVelocityForce // TypeDefIndex: 14687
{
	// Fields
	private float _attenuationX; // 0x48
	private float _attenuationY; // 0x4C
	private float _vOnStartX; // 0x50
	private float _vOnStartY; // 0x54
	private float _vX; // 0x58
	private float _vY; // 0x5C
	private bool firstTick; // 0x60

	// Constructors
	public CombatMoveRetreatAirForce() {} // 0x0000000181703640-0x00000001817036B0

	// Methods
	// [XID] // 0x0000000189699670-0x0000000189699690
	public override void Init(VelocityForceType forceType, int priority) {} // 0x0000000181702BC0-0x0000000181702D30
	// [XID] // 0x00000001896A0B40-0x00000001896A0B60
	public override void SetForce(Vector3 dir, float attenuation) {} // 0x0000000181702D30-0x0000000181702EF0
	// [XID] // 0x00000001896A80F0-0x00000001896A8110
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000181702F50-0x0000000181703040
	// [XID] // 0x00000001896AF460-0x00000001896AF480
	public override void OnMove(float inDeltaTime, float ownerTimeScale) {} // 0x0000000181703040-0x0000000181703360
	// [XID] // 0x00000001896B6AE0-0x00000001896B6B00
	public override bool IsInForce() => default; // 0x00000001817034E0-0x00000001817035A0
	// [XID] // 0x00000001896BDD00-0x00000001896BDD20
	public override void Stop() {} // 0x0000000181702A90-0x0000000181702B40
}

