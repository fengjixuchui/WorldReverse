/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCMonsterAIController : VCBaseInputController // TypeDefIndex: 11899
{
	// Fields
	public MonoDebugStick_H4 joyStick; // 0x118
	private LCBaseCombat _combatComponent; // 0x120
	private Dictionary<int, bool> _animatorParamCache; // 0x128

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001897A9940-0x00000001897A9960 */ get => default; } // 0x00000001851AAC90-0x00000001851AAD30 

	// Constructors
	public VCMonsterAIController() {} // 0x00000001851AAC10-0x00000001851AAC90

	// Methods
	// [XID] // 0x00000001899BA280-0x00000001899BA2A0
	public override void Init() {} // 0x00000001851A97F0-0x00000001851A98D0
	// [XID] // 0x00000001899C9180-0x00000001899C91A0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001851AAB50-0x00000001851AAC10
	// [XID] // 0x00000001899C1D20-0x00000001899C1D40
	private void RegisterInput() {} // 0x00000001851AA7C0-0x00000001851AA860
	// [XID] // 0x00000001897C87B0-0x00000001897C87D0
	private void UnRegisterInput() {} // 0x00000001851A9E60-0x00000001851A9F00
	// [XID] // 0x00000001899D8090-0x00000001899D80B0
	public override void Destroy() {} // 0x00000001851A9310-0x00000001851A93B0
	// [XID] // 0x00000001899E8B70-0x00000001899E8B90
	public bool IsUnderInputControl() => default; // 0x00000001851A9680-0x00000001851A9720
	// [XID] // 0x00000001899DF6A0-0x00000001899DF6C0
	public override void TrySteer(Vector3 targetDir) {} // 0x00000001851AA9C0-0x00000001851AAB50
	// [IDTag] // 0x00000001897E6510-0x00000001897E6550
	// [XID] // 0x00000001897E6510-0x00000001897E6550
	public override void TrySteerAir(Vector3 targetDir) {} // 0x00000001851AA460-0x00000001851AA5F0
	// [IDTag] // 0x00000001897F1120-0x00000001897F1160
	// [XID] // 0x00000001897F1120-0x00000001897F1160
	public override void TrySteerAir(Vector3 targetDir, Vector3 targetPointForTilt) {} // 0x00000001851AA5F0-0x00000001851AA7C0
	// [XID] // 0x00000001897FBC60-0x00000001897FBC80
	public override void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x00000001851A9430-0x00000001851A95A0
	// [XID] // 0x0000000189803170-0x0000000189803190
	public override void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPosition) {} // 0x00000001851A90D0-0x00000001851A92A0
	// [XID] // 0x0000000189A0C350-0x0000000189A0C370
	public override void TryStop() {} // 0x00000001851A8880-0x00000001851A8970
	// [XID] // 0x0000000189811D20-0x0000000189811D40
	public override void TryJump() {} // 0x00000001851AA860-0x00000001851AA950
	// [XID] // 0x00000001898199D0-0x00000001898199F0
	public override void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x00000001851A8EB0-0x00000001851A8FB0
	// [XID] // 0x00000001898210F0-0x0000000189821110
	public override void SetYawSpeedOverride(float yawSpeed) {} // 0x00000001851AA350-0x00000001851AA460
	// [XID] // 0x00000001898286C0-0x00000001898286E0
	public override float? GetYawSpeedOrigin() => default; // 0x00000001851A9B80-0x00000001851A9CB0
	// [XID] // 0x000000018982F950-0x000000018982F970
	public void SetLodLevel(uint level) {} // 0x00000001851A9720-0x00000001851A97F0
	// [XID] // 0x0000000189837230-0x0000000189837250
	public override void SetFollowAnimationTransform(bool enabled) {} // 0x00000001851A8FB0-0x00000001851A90D0
	// [XID] // 0x000000018983E7B0-0x000000018983E7D0
	public override void SetGroundFollowAnimationRotation(bool enabled) {} // 0x00000001851A9D40-0x00000001851A9E60
	// [XID] // 0x0000000189845DF0-0x0000000189845E10
	public void SteerAIInState() {} // 0x00000001851A8B60-0x00000001851A8EB0
	// [XID] // 0x000000018984D3E0-0x000000018984D400
	private bool HasAnimatorParam(int name) => default; // 0x00000001851AA150-0x00000001851AA2E0
	// [XID] // 0x00000001898544D0-0x00000001898544F0
	public override void TryDoSkill(uint skillID) {} // 0x00000001851AA030-0x00000001851AA150
	// [XID] // 0x000000018985BE40-0x000000018985BE60
	private void TryTriggerAbility(ConfigKeyInput cfg) {} // 0x00000001851A9AD0-0x00000001851A9B80
}

