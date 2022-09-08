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

public sealed class VCAvatarAIController : VCBaseInputController // TypeDefIndex: 11788
{
	// Fields
	private LCBaseCombat _combatComponent; // 0x118
	public bool inPlayerControl; // 0x120

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896A81D0-0x00000001896A81F0 */ get => default; } // 0x000000018463F9A0-0x000000018463FA40 

	// Constructors
	public VCAvatarAIController() {} // 0x000000018463F920-0x000000018463F9A0

	// Methods
	// [XID] // 0x00000001896AF580-0x00000001896AF5A0
	public override void Init() {} // 0x000000018463ED10-0x000000018463EDE0
	// [XID] // 0x00000001896B6C60-0x00000001896B6C80
	protected override void LateTick(float inDeltaTime) {} // 0x000000018463F1E0-0x000000018463F2A0
	// [XID] // 0x00000001896BDE60-0x00000001896BDE80
	public override void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x000000018463E880-0x000000018463E980
	// [IDTag] // 0x00000001896C5770-0x00000001896C57B0
	// [XID] // 0x00000001896C5770-0x00000001896C57B0
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x000000018463F7A0-0x000000018463F920
	// [IDTag] // 0x00000001896CFED0-0x00000001896CFF10
	// [XID] // 0x00000001896CFED0-0x00000001896CFF10
	public override void TrySteer(Vector3 targetDir) {} // 0x000000018463F610-0x000000018463F7A0
	// [XID] // 0x00000001898619D0-0x00000001898619F0
	public override void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x000000018463EAD0-0x000000018463EBD0
	// [XID] // 0x00000001898692D0-0x00000001898692F0
	public override void TrySprint() {} // 0x000000018463EBD0-0x000000018463ECB0
	// [XID] // 0x00000001896E8F70-0x00000001896E8F90
	public override void TryStopSprint() {} // 0x000000018463F3F0-0x000000018463F4D0
	// [XID] // 0x00000001896F0190-0x00000001896F01B0
	public override void TryStop() {} // 0x000000018463E690-0x000000018463E780
	// [XID] // 0x00000001896F7A50-0x00000001896F7A70
	public override void TryJump() {} // 0x000000018463F4D0-0x000000018463F610
	// [XID] // 0x000000018963DC30-0x000000018963DC50
	public override void TryDoSkill(uint skillID) {} // 0x000000018463F2A0-0x000000018463F380
	// [XID] // 0x0000000189645180-0x00000001896451A0
	public override void TryReleaseSkill(uint skillID) {} // 0x000000018463EEB0-0x000000018463EFF0
}

