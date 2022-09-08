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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarEnterFocus : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20063
{
	// Fields
	public Vector3 cameraFollowLowerPos; // 0x30
	public Vector3 cameraFollowUpperPos; // 0x3C
	public float cameraFollowMaxDegree; // 0x48
	public float cameraFollowMinDegree; // 0x4C
	public bool cameraFastFocusMode; // 0x50
	public bool faceToTarget; // 0x51
	public float faceToTargetAngleThreshold; // 0x54
	public bool changeMainSkillID; // 0x58
	public bool useFocusSticky; // 0x59
	public bool useAutoFocus; // 0x5A
	public bool useGyro; // 0x5B
	public string dragBtnName; // 0x60
	public bool canMove; // 0x68
	public bool showCrosshair; // 0x69
	public float vcamFov; // 0x6C
	public float focusAnchorHorAngle; // 0x70
	public float focusAnchorVerAngle; // 0x74
	public bool disableAnim; // 0x78

	// Constructors
	public EvtAvatarEnterFocus() {} // 0x0000000182C0F840-0x0000000182C0F8A0

	// Methods
	[BlackList] // 0x0000000189688420-0x0000000189688460
	// [XID] // 0x0000000189688420-0x0000000189688460
	public override void AutoAllocTypeFields() {} // 0x0000000182C0F0C0-0x0000000182C0F160
	[BlackList] // 0x0000000189692FD0-0x0000000189693010
	// [XID] // 0x0000000189692FD0-0x0000000189693010
	public override void AutoRecycleTypeFields() {} // 0x0000000182C0F160-0x0000000182C0F250
	[BlackList] // 0x000000018969D460-0x000000018969D4A0
	// [XID] // 0x000000018969D460-0x000000018969D4A0
	public override void ReturnToObjectPool() {} // 0x0000000182C0F6C0-0x0000000182C0F760
	// [XID] // 0x00000001896A75C0-0x00000001896A75E0
	public void Init(uint targetID, AvatarEnterFocus config) {} // 0x0000000182C0F320-0x0000000182C0F600
	// [XID] // 0x00000001896AEAC0-0x00000001896AEAE0
	public override string ToString() => default; // 0x0000000182C0F760-0x0000000182C0F840
}

